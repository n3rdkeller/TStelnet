﻿using System;
using System.Windows.Forms;
using TelnetSocketNamespace;
using System.Threading;

namespace TStelnet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region variables declaration
        TelnetSocket tc = new TelnetSocket();
        bool connectionestablished = false;
        string[] lastcommands = new string[10];
        string lastcommand = string.Empty;
        int lastcommandscounter = -1;
        string composedstring = string.Empty;
        const string tsnewline = "\n\r";
        const string tbxnewline = "\r\n";
        const string space = "\\s";
        string[] chlist = new string[32767];
        string[] cllist = new string[32767];
        int[] chidlist = new int[32767];
        int[] chpidlist = new int[32767]; //ERKENNTNIS: PID STEHT FÜR PARENT-ID! HA!
        int[] clidlist = new int[32767];
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            connectedornot(0);
            tvwChannels.ExpandAll();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            #region get connection details from the textbox
            string ip;
            int port;
            ip = tbxIP.Text.Substring(0, tbxIP.Text.LastIndexOf(":"));
            port = Convert.ToInt32(tbxIP.Text.Substring(tbxIP.Text.LastIndexOf(":") + 1));
            addtolog("Starting to connect to " + ip + " on port " + port + ".");
            #endregion

            #region connecting trial
            try
            {
                connectedornot(1);
                //start telnetconnection
                connectionestablished = false;
                tc = new TelnetSocket();
                tc.OnDataReceived += new ScriptableCommunicatorNamespace.DataReceived(tc_DataReceived);
                tc.LineTerminator = tsnewline;
                tc.Connect(ip, port);

                //connection error
                if (!tc.Connected)
                {
                    addtolog("Error trying to connect.");
                    connectedornot(0);
                }
            }
            catch (Exception ex)
            {
                addtolog(ex);
                connectedornot(0);
            }
            #endregion
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                sendCommand("quit");
                tc.Close();
                addtolog("Disconnected.");
                connectedornot(0);
            }
            catch (Exception ex)
            {
                addtolog(ex);
            }

        }

        private void tc_DataReceived(string data)
        {
            if (!connectionestablished) addtolog("Connected.");
            if (data != string.Empty) connectionestablished = true;

            /* teamspeak does something strange at this point
             * it splits data in the middle of nowhere, so we 
             * need to compose it again before adding it to log.
             */
            if (!data.EndsWith(tsnewline))
            {
                composedstring = composedstring + data;
            }
            else
            {
                data = composedstring + data;
                composedstring = string.Empty;
                
                //manual carriage returns for lists to be displayed in a niiiiiice way
                if (lastcommand == "clientlist" || lastcommand == "channellist") data = data.Replace("|", tsnewline);                
                data = data.Replace (space, " ");
                data = data.Replace("???", "™");
                
                /*Here we split data into strings if there is a carriage return*/
                string[] decomposeddata = new string[32767];
                decomposeddata = data.Split(new string[] { tsnewline }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string dataline in decomposeddata) addtolog(dataline);
                if (lastcommand == "clientlist" && data != "error id=0 msg=ok\n\r") cllist = decomposeddata;
                if (lastcommand == "channellist") chlist = decomposeddata;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sendCommand("login " + tbxLogin.Text);
            if (nudSID.Value != 0) sendCommand("use sid=" + Convert.ToString(nudSID.Value));
            if (tbxNick.Text != "") sendCommand("clientupdate client_nickname=" + tbxNick.Text.Replace(" ", space));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            sendCommand("help");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbxCommands.Text != "")
            {
                sendCommand(tbxCommands.Text);
                tbxCommands.Text = "";
            }
        }

        private void tbxCommands_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) e.Handled = true;
            if ((e.KeyChar == Convert.ToChar(13)) && (tbxCommands.Text != ""))
            {
                if (tc.Connected)
                {
                    sendCommand(tbxCommands.Text);
                    tbxCommands.Text = "";
                    e.Handled = true;
                }
            }

        }

        private void tbxCommands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int bugfixvariable;
                if (lastcommandscounter == -1) bugfixvariable = 0;
                    else bugfixvariable = lastcommandscounter;
                
                if (lastcommands[bugfixvariable] != null)
                {
                    if (lastcommandscounter == ArrayLength(lastcommands) - 1) lastcommandscounter = 0;
                        else lastcommandscounter++;
                    tbxCommands.Text = lastcommands[lastcommandscounter];
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lastcommandscounter == -1 || lastcommandscounter == 0) lastcommandscounter = ArrayLength(lastcommands) - 1;
                    else lastcommandscounter--;
                tbxCommands.Text = lastcommands[lastcommandscounter];
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            sendCommand("clientlist");
            sendCommand("channellist");
            //System.Threading.Thread.Sleep(2000);
            if (cllist[0] == null) return;
            lbxClients.Items.Clear();
            string[] names = getClOrCh(cllist,0);
            for (int i = 0; i < names.Length; i++) lbxClients.Items.Add(names[i]);
        }

     
        #region supporting functions

        private string[] getClOrCh(string[] rawlist, byte ClOrCh)
        {
            string begin; string end;
            if (ClOrCh == 0)
            {
                begin = "client_nickname="; end = "client_type=";
            }
            else
            {
                begin = "channel_name="; end = "total_clients=";
            }
            for (int i = 0; i < rawlist.Length; i++)
                rawlist[i] = rawlist[i].Substring(rawlist[i].IndexOf(begin) + (begin).Length,
                    (rawlist[i].LastIndexOf(end) - 1) - (rawlist[i].IndexOf(begin) + (begin).Length));
            return rawlist;
        }

        private int[] getClOrChIDs(string[] rawlist, byte ClOrCh)
        {
            string begin; string end;
            if (ClOrCh == 0)
            {
                begin = "clid="; end = "cid=";
            }
            else
            {
                begin = "cid="; end = "pid=";
            }
            int[] ids = new int[rawlist.Length];
            for (int i = 0; i < rawlist.Length; i++)
                ids[i] = Convert.ToInt32(rawlist[i].Substring(rawlist[i].IndexOf(begin) + (begin).Length,
                    (rawlist[i].LastIndexOf(end) - 1) - (rawlist[i].IndexOf(begin) + (begin).Length)));
            return ids;
        }

        private void addtolog(object what)
        {
            DateTime currentDate = DateTime.Now;
            string dtHour, dtMinute, dtSecond;
            dtHour = withzero(currentDate.Hour);
            dtMinute = withzero(currentDate.Minute);
            dtSecond = withzero(currentDate.Second);


            if (this.InvokeRequired) this.Invoke(new Action<object>(this.addtolog), what);
            else
            {
                tbxLog.Text += "[" + dtHour + ":" + dtMinute + ":" + dtSecond + "] ";
                tbxLog.Text += what + tbxnewline;
                tbxLog.SelectionStart = tbxLog.Text.Length;
                tbxLog.ScrollToCaret();
            }
        }

        private string withzero(int number)
        {
            if (number < 10)
            {
                return "0" + Convert.ToString(number);
            }
            else
            {
                return Convert.ToString(number);
            }
        }

        private void connectedornot(byte yorn)
        {
            if (yorn == 1)
            {
                tbxIP.Enabled = false;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnMove.Enabled = true;
                btnRefresh.Enabled = true;
                tvwChannels.Enabled = true;
                lbxClients.Enabled = true;
                tbxCommands.Enabled = true;
                tbxLogin.Enabled = true;
                btnHelp.Enabled = true;
                btnLogin.Enabled = true;
                btnSend.Enabled = true;
                tbxNick.Enabled = true;
                nudSID.Enabled = true;
            }
            else
            {
                tbxIP.Enabled = true;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnMove.Enabled = false;
                btnRefresh.Enabled = false;
                tvwChannels.Enabled = false;
                lbxClients.Enabled = false;
                tbxCommands.Enabled = false;
                tbxLogin.Enabled = false;
                btnHelp.Enabled = false;
                btnLogin.Enabled = false;
                btnSend.Enabled = false;
                tbxNick.Enabled = false;
                nudSID.Enabled = false;
            }
        }

        void sendCommand(string command)
        {
            if (tc.Connected)
            {
                try
                {
                    
                    addtolog(command);
                    if (lastcommands[0] != command)
                    {
                        for (int i = lastcommands.Length - 1; i > 0; i--)
                        {
                            lastcommands[i] = lastcommands[i - 1];
                        }
                        lastcommands[0] = command;
                        lastcommand = command;
                    }
                    lastcommandscounter = -1;
                    tc.WriteLine(command);
                } 
                catch (Exception ex)
                {
                    addtolog(ex);
                }
            }
        }

        public int ArrayLength(object[] anarray)
        {
            int count = 0;
            for (int i = 0; i < anarray.Length; i++)
            {
                if (anarray[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

    }
}
