namespace ExcelDBtoSS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTblImport = new System.Windows.Forms.Button();
            this.grpTblImp = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTblInfo = new System.Windows.Forms.GroupBox();
            this.grpUserAuth = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.chkWinAuth = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statMain = new System.Windows.Forms.StatusStrip();
            this.statMain_label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statMain_ConnStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTblFile = new System.Windows.Forms.TextBox();
            this.btnTblFileBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTblType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTblFileOpen = new System.Windows.Forms.Button();
            this.txtTblName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grpTblImp.SuspendLayout();
            this.grpTblInfo.SuspendLayout();
            this.grpUserAuth.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(559, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(640, 22);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.TabStop = false;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(350, 25);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(203, 20);
            this.txtDB.TabIndex = 1;
            this.txtDB.Text = "ElectricalApps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database:";
            // 
            // btnTblImport
            // 
            this.btnTblImport.Location = new System.Drawing.Point(10, 63);
            this.btnTblImport.Name = "btnTblImport";
            this.btnTblImport.Size = new System.Drawing.Size(115, 23);
            this.btnTblImport.TabIndex = 4;
            this.btnTblImport.TabStop = false;
            this.btnTblImport.Text = "Import Table";
            this.btnTblImport.UseVisualStyleBackColor = true;
            this.btnTblImport.Click += new System.EventHandler(this.btnTblImport_Click);
            // 
            // grpTblImp
            // 
            this.grpTblImp.Controls.Add(this.btnTblFileOpen);
            this.grpTblImp.Controls.Add(this.grpTblInfo);
            this.grpTblImp.Controls.Add(this.btnTblFileBrowse);
            this.grpTblImp.Controls.Add(this.txtTblFile);
            this.grpTblImp.Controls.Add(this.label5);
            this.grpTblImp.Enabled = false;
            this.grpTblImp.Location = new System.Drawing.Point(12, 153);
            this.grpTblImp.Name = "grpTblImp";
            this.grpTblImp.Size = new System.Drawing.Size(725, 381);
            this.grpTblImp.TabIndex = 5;
            this.grpTblImp.TabStop = false;
            this.grpTblImp.Text = "Table Import";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(53, 24);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(203, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "ULSQL12T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server:";
            // 
            // grpTblInfo
            // 
            this.grpTblInfo.Controls.Add(this.dataGridView1);
            this.grpTblInfo.Controls.Add(this.txtTblName);
            this.grpTblInfo.Controls.Add(this.label7);
            this.grpTblInfo.Controls.Add(this.cmbTblType);
            this.grpTblInfo.Controls.Add(this.label6);
            this.grpTblInfo.Controls.Add(this.button1);
            this.grpTblInfo.Controls.Add(this.btnTblImport);
            this.grpTblInfo.Enabled = false;
            this.grpTblInfo.Location = new System.Drawing.Point(6, 53);
            this.grpTblInfo.Name = "grpTblInfo";
            this.grpTblInfo.Size = new System.Drawing.Size(692, 322);
            this.grpTblInfo.TabIndex = 6;
            this.grpTblInfo.TabStop = false;
            this.grpTblInfo.Text = "Table Information";
            // 
            // grpUserAuth
            // 
            this.grpUserAuth.Controls.Add(this.label4);
            this.grpUserAuth.Controls.Add(this.txtPass);
            this.grpUserAuth.Controls.Add(this.label3);
            this.grpUserAuth.Controls.Add(this.txtUser);
            this.grpUserAuth.Enabled = false;
            this.grpUserAuth.Location = new System.Drawing.Point(9, 73);
            this.grpUserAuth.Name = "grpUserAuth";
            this.grpUserAuth.Size = new System.Drawing.Size(592, 52);
            this.grpUserAuth.TabIndex = 7;
            this.grpUserAuth.TabStop = false;
            this.grpUserAuth.Text = "User Authentication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(376, 19);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(203, 20);
            this.txtPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(74, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(203, 20);
            this.txtUser.TabIndex = 3;
            // 
            // chkWinAuth
            // 
            this.chkWinAuth.AutoSize = true;
            this.chkWinAuth.Checked = true;
            this.chkWinAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWinAuth.Location = new System.Drawing.Point(9, 50);
            this.chkWinAuth.Name = "chkWinAuth";
            this.chkWinAuth.Size = new System.Drawing.Size(163, 17);
            this.chkWinAuth.TabIndex = 2;
            this.chkWinAuth.Text = "Use Windows Authentication";
            this.chkWinAuth.UseVisualStyleBackColor = true;
            this.chkWinAuth.CheckedChanged += new System.EventHandler(this.chkWinAuth_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grpUserAuth);
            this.groupBox4.Controls.Add(this.chkWinAuth);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtDB);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnDisconnect);
            this.groupBox4.Controls.Add(this.txtServer);
            this.groupBox4.Controls.Add(this.btnConnect);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 135);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Connection";
            // 
            // statMain
            // 
            this.statMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statMain_label1,
            this.statMain_ConnStat});
            this.statMain.Location = new System.Drawing.Point(0, 717);
            this.statMain.Name = "statMain";
            this.statMain.Size = new System.Drawing.Size(747, 22);
            this.statMain.TabIndex = 9;
            this.statMain.Text = "statusStrip1";
            // 
            // statMain_label1
            // 
            this.statMain_label1.Name = "statMain_label1";
            this.statMain_label1.Size = new System.Drawing.Size(110, 17);
            this.statMain_label1.Text = "Connection Status: ";
            // 
            // statMain_ConnStat
            // 
            this.statMain_ConnStat.Name = "statMain_ConnStat";
            this.statMain_ConnStat.Size = new System.Drawing.Size(79, 17);
            this.statMain_ConnStat.Text = "Disconnected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Excel File:";
            // 
            // txtTblFile
            // 
            this.txtTblFile.Location = new System.Drawing.Point(70, 26);
            this.txtTblFile.Name = "txtTblFile";
            this.txtTblFile.Size = new System.Drawing.Size(466, 20);
            this.txtTblFile.TabIndex = 6;
            // 
            // btnTblFileBrowse
            // 
            this.btnTblFileBrowse.Location = new System.Drawing.Point(542, 24);
            this.btnTblFileBrowse.Name = "btnTblFileBrowse";
            this.btnTblFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnTblFileBrowse.TabIndex = 7;
            this.btnTblFileBrowse.Text = "Browse";
            this.btnTblFileBrowse.UseVisualStyleBackColor = true;
            this.btnTblFileBrowse.Click += new System.EventHandler(this.btnTblFileBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Table Type:";
            // 
            // cmbTblType
            // 
            this.cmbTblType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTblType.FormattingEnabled = true;
            this.cmbTblType.Items.AddRange(new object[] {
            "Drive Master Parameter List",
            "Drive Master Parameter Grouping",
            "Machine Data",
            "Parameter Chart"});
            this.cmbTblType.Location = new System.Drawing.Point(77, 25);
            this.cmbTblType.Name = "cmbTblType";
            this.cmbTblType.Size = new System.Drawing.Size(180, 21);
            this.cmbTblType.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Table name:";
            // 
            // btnTblFileOpen
            // 
            this.btnTblFileOpen.Location = new System.Drawing.Point(623, 24);
            this.btnTblFileOpen.Name = "btnTblFileOpen";
            this.btnTblFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnTblFileOpen.TabIndex = 8;
            this.btnTblFileOpen.Text = "Open File";
            this.btnTblFileOpen.UseVisualStyleBackColor = true;
            this.btnTblFileOpen.Click += new System.EventHandler(this.btnTblFileOpen_Click);
            // 
            // txtTblName
            // 
            this.txtTblName.Location = new System.Drawing.Point(352, 30);
            this.txtTblName.Name = "txtTblName";
            this.txtTblName.Size = new System.Drawing.Size(180, 20);
            this.txtTblName.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 224);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "View Table Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTblImport_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 739);
            this.Controls.Add(this.statMain);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpTblImp);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrical Database Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpTblImp.ResumeLayout(false);
            this.grpTblImp.PerformLayout();
            this.grpTblInfo.ResumeLayout(false);
            this.grpTblInfo.PerformLayout();
            this.grpUserAuth.ResumeLayout(false);
            this.grpUserAuth.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statMain.ResumeLayout(false);
            this.statMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTblImport;
        private System.Windows.Forms.GroupBox grpTblImp;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTblInfo;
        private System.Windows.Forms.GroupBox grpUserAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox chkWinAuth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.StatusStrip statMain;
        private System.Windows.Forms.ToolStripStatusLabel statMain_label1;
        private System.Windows.Forms.ToolStripStatusLabel statMain_ConnStat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTblFile;
        private System.Windows.Forms.ComboBox cmbTblType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTblFileBrowse;
        private System.Windows.Forms.Button btnTblFileOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTblName;
        private System.Windows.Forms.Button button1;
    }
}

