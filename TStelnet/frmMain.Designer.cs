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
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(139, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(12, 12);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(121, 20);
            this.tbxIP.TabIndex = 1;
            this.tbxIP.Text = "91.121.193.155:10011";
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(12, 39);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxLog.Size = new System.Drawing.Size(507, 187);
            this.tbxLog.TabIndex = 3;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDisconnect.Location = new System.Drawing.Point(220, 10);
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
            this.lbxClients.Location = new System.Drawing.Point(13, 232);
            this.lbxClients.Name = "lbxClients";
            this.lbxClients.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxClients.Size = new System.Drawing.Size(120, 160);
            this.lbxClients.TabIndex = 5;
            // 
            // tbxCommands
            // 
            this.tbxCommands.Location = new System.Drawing.Point(354, 13);
            this.tbxCommands.Name = "tbxCommands";
            this.tbxCommands.Size = new System.Drawing.Size(165, 20);
            this.tbxCommands.TabIndex = 6;
            this.tbxCommands.Text = "help";
            this.tbxCommands.TextChanged += new System.EventHandler(this.tbxCommands_TextChanged);
            this.tbxCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCommands_KeyDown);
            // 
            // lbxChannels
            // 
            this.lbxChannels.FormattingEnabled = true;
            this.lbxChannels.Location = new System.Drawing.Point(172, 232);
            this.lbxChannels.Name = "lbxChannels";
            this.lbxChannels.Size = new System.Drawing.Size(123, 160);
            this.lbxChannels.TabIndex = 7;
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMove.Image")));
            this.btnMove.Location = new System.Drawing.Point(313, 320);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(161, 40);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Move";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(312, 252);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(162, 40);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 500;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDisconnect;
            this.ClientSize = new System.Drawing.Size(531, 403);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lbxChannels);
            this.Controls.Add(this.tbxCommands);
            this.Controls.Add(this.lbxClients);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TStelnet - by r3t4rdun1c0rns";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

