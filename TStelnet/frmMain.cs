using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
//using MinimalisticTelnet;
//using De.Mud.Telnet;
//using Net.Graphite.Telnet;
using TelnetSocketNamespace;

namespace TStelnet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        TelnetSocket tc = new TelnetSocket();

        private void frmMain_Load(object sender, EventArgs e)
        {
            connectedornot(0);
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
                tc.OnDataReceived += new ScriptableCommunicatorNamespace.DataReceived(tc_DataReceived);
                tc.Connect(ip,port);

                //connection established
                if (tc.Connected)
                {
                    addtolog("Connected");
                    //tmrRefresh.Start();
                }
                else
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
                  tc.Close();
                  addtolog("Disconnected.");
                  connectedornot(0);
            }
            catch (Exception ex)
            {
                addtolog(ex);
            }

        }

        private void tbxCommands_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (tc.Connected)
                {
                    tc.WriteLine(tbxCommands.Text);
                    addtolog(tbxCommands.Text);
                    e.Handled = true;
                }
            }
        }

        private void tc_DataReceived(string data)
        {
            addtolog(data);
        }



        #region supporting functions

        private void addtolog(object what)
        {
            DateTime currentDate = DateTime.Now;
            string dtHour, dtMinute, dtSecond;
            dtHour = withzero(currentDate.Hour);
            dtMinute = withzero(currentDate.Minute);
            dtSecond = withzero(currentDate.Second);

            const string newline = "\r\n";

            if (this.InvokeRequired)
            {
                this.Invoke(new Action<object>(this.addtolog), what);
            }
            else
            {
                tbxLog.Text += "[" + dtHour + ":" + dtMinute + ":" + dtSecond + "] ";
                tbxLog.Text += what.ToString() + newline;
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
                lbxChannels.Enabled = true;
                lbxClients.Enabled = true;
                tbxCommands.Enabled = true;
            }
            else
            {
                tbxIP.Enabled = true;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnMove.Enabled = false;
                btnRefresh.Enabled = false;
                lbxChannels.Enabled = false;
                lbxClients.Enabled = false;
                tbxCommands.Enabled = false;
            }
        }

        #endregion
     }
}
