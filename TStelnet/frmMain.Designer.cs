namespace TStelnet
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbxClients = new System.Windows.Forms.ListBox();
            this.tbxCommands = new System.Windows.Forms.TextBox();
            this.lbxChannels = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tclMain = new System.Windows.Forms.TabControl();
            this.tbpConsole = new System.Windows.Forms.TabPage();
            this.tbpLists = new System.Windows.Forms.TabPage();
            this.tclMain.SuspendLayout();
            this.tbpConsole.SuspendLayout();
            this.tbpLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(135, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(8, 6);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(121, 20);
            this.tbxIP.TabIndex = 1;
            this.tbxIP.Text = "91.121.193.155:10011";
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.Color.White;
            this.tbxLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLog.Location = new System.Drawing.Point(3, 32);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxLog.Size = new System.Drawing.Size(833, 547);
            this.tbxLog.TabIndex = 3;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisconnect.Location = new System.Drawing.Point(216, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbxClients
            // 
            this.lbxClients.FormattingEnabled = true;
            this.lbxClients.Location = new System.Drawing.Point(351, 5);
            this.lbxClients.Name = "lbxClients";
            this.lbxClients.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxClients.Size = new System.Drawing.Size(220, 316);
            this.lbxClients.TabIndex = 5;
            // 
            // tbxCommands
            // 
            this.tbxCommands.AutoCompleteCustomSource.AddRange(new string[] {
            "help",
            "login",
            "logout",
            "quit",
            "use",
            "banadd",
            "banclient",
            "bandelall",
            "bandel",
            "banlist",
            "bindinglist",
            "channeladdperm",
            "channelclientaddperm",
            "channelclientdelperm",
            "channelclientpermlist",
            "channelcreate",
            "channeldelete",
            "channeldelperm",
            "channeledit",
            "channelfind",
            "channelgroupadd",
            "channelgroupaddperm",
            "channelgroupclientlist",
            "channelgroupcopy",
            "channelgroupdel",
            "channelgroupdelperm",
            "channelgrouplist",
            "channelgrouppermlist",
            "channelgrouprename",
            "channelinfo",
            "channellist",
            "channelmove",
            "channelpermlist",
            "clientaddperm",
            "clientdbdelete",
            "clientdbedit",
            "clientdbfind",
            "clientdbinfo",
            "clientdblist",
            "clientdelperm",
            "clientedit",
            "clientfind",
            "clientgetdbidfromuid",
            "clientgetids",
            "clientgetnamefromdbid",
            "clientgetnamefromuid",
            "clientgetuidfromclid",
            "clientinfo",
            "clientkick",
            "clientlist",
            "clientmove",
            "clientpermlist",
            "clientpoke",
            "clientsetserverquerylogin",
            "clientupdate",
            "complainadd",
            "complaindelall",
            "complaindel",
            "complainlist",
            "custominfo",
            "customsearch",
            "ftcreatedir",
            "ftdeletefile",
            "ftgetfileinfo",
            "ftgetfilelist",
            "ftinitdownload",
            "ftinitupload",
            "ftlist",
            "ftrenamefile",
            "ftstop",
            "gm",
            "hostinfo",
            "instanceedit",
            "instanceinfo",
            "logadd",
            "logview",
            "messageadd",
            "messagedel",
            "messagegetinbox",
            "messagelist",
            "messageupdateflag",
            "permfind",
            "permgetyourself",
            "permidgetbyname",
            "permissionlist",
            "permoverview",
            "permresetrestore default permissions",
            "privilegekeyadd",
            "privilegekeydelete",
            "privilegekeylistserver",
            "privilegekeyuse",
            "sendtextmessage",
            "servercreate",
            "serverdelete",
            "serveredit",
            "servergroupaddclient",
            "servergroupadd",
            "servergroupaddperm",
            "servergroupautoaddpermgroups",
            "servergroupbyclientid",
            "servergroupclientlist",
            "servergroupcopy",
            "servergroupdelclient",
            "servergroupdel",
            "servergroupdelperm",
            "servergroupautodelpermgroup",
            "servergrouplist",
            "servergrouppermlist",
            "servergrouprename",
            "servergroupsbyclientid",
            "serveridgetbyport",
            "serverinfo",
            "serverlist",
            "servernotifyregister",
            "servernotifyunregister",
            "serverprocessstop",
            "serverrequestconnectioninfo",
            "serversnapshotcreate",
            "serversnapshotdeploy",
            "serverstart",
            "servertemppasswordadd",
            "servertemppassworddelpassword",
            "servertemppasswordlistpasswords",
            "serverstop",
            "setclientchannelgroup",
            "tokenadd",
            "tokendelete",
            "tokenlist",
            "tokenuse",
            "version",
            "whoami"});
            this.tbxCommands.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxCommands.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbxCommands.Location = new System.Drawing.Point(8, 590);
            this.tbxCommands.Name = "tbxCommands";
            this.tbxCommands.Size = new System.Drawing.Size(575, 29);
            this.tbxCommands.TabIndex = 6;
            this.tbxCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCommands_KeyDown);
            this.tbxCommands.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCommands_KeyPress);
            // 
            // lbxChannels
            // 
            this.lbxChannels.FormattingEnabled = true;
            this.lbxChannels.Location = new System.Drawing.Point(3, 3);
            this.lbxChannels.Name = "lbxChannels";
            this.lbxChannels.Size = new System.Drawing.Size(342, 628);
            this.lbxChannels.TabIndex = 7;
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMove.Image")));
            this.btnMove.Location = new System.Drawing.Point(400, 327);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(118, 40);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Move";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(400, 373);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 40);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 500;
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(297, 6);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(120, 20);
            this.tbxLogin.TabIndex = 10;
            this.tbxLogin.Text = "admin E9LE6NVv";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(423, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(713, 585);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(118, 41);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(589, 585);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 41);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tclMain
            // 
            this.tclMain.Controls.Add(this.tbpConsole);
            this.tclMain.Controls.Add(this.tbpLists);
            this.tclMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclMain.Location = new System.Drawing.Point(0, 0);
            this.tclMain.Name = "tclMain";
            this.tclMain.SelectedIndex = 0;
            this.tclMain.Size = new System.Drawing.Size(847, 662);
            this.tclMain.TabIndex = 14;
            // 
            // tbpConsole
            // 
            this.tbpConsole.Controls.Add(this.btnHelp);
            this.tbpConsole.Controls.Add(this.btnLogin);
            this.tbpConsole.Controls.Add(this.btnSend);
            this.tbpConsole.Controls.Add(this.tbxLogin);
            this.tbpConsole.Controls.Add(this.tbxCommands);
            this.tbpConsole.Controls.Add(this.btnDisconnect);
            this.tbpConsole.Controls.Add(this.tbxIP);
            this.tbpConsole.Controls.Add(this.btnConnect);
            this.tbpConsole.Controls.Add(this.tbxLog);
            this.tbpConsole.Location = new System.Drawing.Point(4, 22);
            this.tbpConsole.Name = "tbpConsole";
            this.tbpConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsole.Size = new System.Drawing.Size(839, 636);
            this.tbpConsole.TabIndex = 0;
            this.tbpConsole.Text = "Console";
            this.tbpConsole.UseVisualStyleBackColor = true;
            // 
            // tbpLists
            // 
            this.tbpLists.Controls.Add(this.lbxClients);
            this.tbpLists.Controls.Add(this.lbxChannels);
            this.tbpLists.Controls.Add(this.btnRefresh);
            this.tbpLists.Controls.Add(this.btnMove);
            this.tbpLists.Location = new System.Drawing.Point(4, 22);
            this.tbpLists.Name = "tbpLists";
            this.tbpLists.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLists.Size = new System.Drawing.Size(839, 636);
            this.tbpLists.TabIndex = 1;
            this.tbpLists.Text = "Lists";
            this.tbpLists.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 662);
            this.Controls.Add(this.tclMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TStelnet - by r3t4rdun1c0rns";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tclMain.ResumeLayout(false);
            this.tbpConsole.ResumeLayout(false);
            this.tbpConsole.PerformLayout();
            this.tbpLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox lbxClients;
        private System.Windows.Forms.TextBox tbxCommands;
        private System.Windows.Forms.ListBox lbxChannels;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRefresh;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tclMain;
        private System.Windows.Forms.TabPage tbpLists;
        private System.Windows.Forms.TabPage tbpConsole;
    }
}

