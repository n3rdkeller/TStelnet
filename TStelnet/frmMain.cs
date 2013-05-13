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

namespace TStelnet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //TcpClient connector = new TcpClient();

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ip;
            int port;
            ip = tbxIP.Text.Substring(0,tbxIP.Text.LastIndexOf(":"));
            port = Convert.ToInt32(tbxIP.Text.Substring(tbxIP.Text.LastIndexOf(":")+1));
            addtolog("Starting to connect to " + ip + " on port " + port + ".");

            //connector.ConnectAsync(ip, port);
        }

        #region helpingfunctions
        private void addtolog(object what)
        {
            DateTime currentDate = DateTime.Now;
            string dtHour, dtMinute, dtSecond;
            dtHour = withzero(currentDate.Hour);
            dtMinute = withzero(currentDate.Minute);
            dtSecond = withzero(currentDate.Second);

            const string newline = "\r\n";

            tbxLog.Text += "[" + dtHour + ":" + dtMinute + ":" + dtSecond + "] ";
            tbxLog.Text += what.ToString() + newline;
            tbxLog.SelectionStart = tbxLog.Text.Length;
            tbxLog.ScrollToCaret();
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
        #endregion
    }
}
