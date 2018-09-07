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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpImpList = new System.Windows.Forms.GroupBox();
            this.btnListImp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbListTblSel = new System.Windows.Forms.ComboBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dgvList_cmRegAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvList_cmParamNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvList_cmParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvList_cmMult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvList_cmBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvList_cmUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTblFileOpen = new System.Windows.Forms.Button();
            this.btnListFileBrowse = new System.Windows.Forms.Button();
            this.txtListFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpUserAuth = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.chkWinAuth = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statMain = new System.Windows.Forms.StatusStrip();
            this.statMain_lblID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statMain_lblStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.statMain_prgIO = new System.Windows.Forms.ToolStripProgressBar();
            this.grpDefVals = new System.Windows.Forms.GroupBox();
            this.grpDefTools = new System.Windows.Forms.GroupBox();
            this.btnDefImp = new System.Windows.Forms.Button();
            this.btnDefColCfg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDefCol = new System.Windows.Forms.TextBox();
            this.cmbDefDrive = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDefTblList = new System.Windows.Forms.ComboBox();
            this.cmbDefDuty = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDefVal = new System.Windows.Forms.DataGridView();
            this.dgvDefVal_cmRegAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDefVal_cmParamNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDefVal_cmParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDefVal_cmDefVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDefOpen = new System.Windows.Forms.Button();
            this.btnDefBrowse = new System.Windows.Forms.Button();
            this.txtDefFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDefCmp = new System.Windows.Forms.Button();
            this.grpImpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.grpUserAuth.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statMain.SuspendLayout();
            this.grpDefVals.SuspendLayout();
            this.grpDefTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefVal)).BeginInit();
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
            // grpImpList
            // 
            this.grpImpList.Controls.Add(this.btnListImp);
            this.grpImpList.Controls.Add(this.label6);
            this.grpImpList.Controls.Add(this.cmbListTblSel);
            this.grpImpList.Controls.Add(this.dgvList);
            this.grpImpList.Controls.Add(this.btnTblFileOpen);
            this.grpImpList.Controls.Add(this.btnListFileBrowse);
            this.grpImpList.Controls.Add(this.txtListFile);
            this.grpImpList.Controls.Add(this.label5);
            this.grpImpList.Enabled = false;
            this.grpImpList.Location = new System.Drawing.Point(12, 153);
            this.grpImpList.Name = "grpImpList";
            this.grpImpList.Size = new System.Drawing.Size(725, 246);
            this.grpImpList.TabIndex = 5;
            this.grpImpList.TabStop = false;
            this.grpImpList.Text = "Drive Master Parameter List Import";
            // 
            // btnListImp
            // 
            this.btnListImp.Enabled = false;
            this.btnListImp.Location = new System.Drawing.Point(301, 210);
            this.btnListImp.Name = "btnListImp";
            this.btnListImp.Size = new System.Drawing.Size(115, 23);
            this.btnListImp.TabIndex = 15;
            this.btnListImp.Text = "Import List Data";
            this.btnListImp.UseVisualStyleBackColor = true;
            this.btnListImp.Click += new System.EventHandler(this.btnListImp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Database Table: ";
            // 
            // cmbListTblSel
            // 
            this.cmbListTblSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListTblSel.Enabled = false;
            this.cmbListTblSel.FormattingEnabled = true;
            this.cmbListTblSel.Location = new System.Drawing.Point(101, 210);
            this.cmbListTblSel.Name = "cmbListTblSel";
            this.cmbListTblSel.Size = new System.Drawing.Size(194, 21);
            this.cmbListTblSel.TabIndex = 13;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvList_cmRegAddr,
            this.dgvList_cmParamNum,
            this.dgvList_cmParamName,
            this.dgvList_cmMult,
            this.dgvList_cmBase,
            this.dgvList_cmUnits});
            this.dgvList.Location = new System.Drawing.Point(6, 53);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(709, 145);
            this.dgvList.TabIndex = 12;
            // 
            // dgvList_cmRegAddr
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList_cmRegAddr.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList_cmRegAddr.HeaderText = "Register Address";
            this.dgvList_cmRegAddr.Name = "dgvList_cmRegAddr";
            this.dgvList_cmRegAddr.ReadOnly = true;
            this.dgvList_cmRegAddr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList_cmRegAddr.Width = 60;
            // 
            // dgvList_cmParamNum
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList_cmParamNum.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList_cmParamNum.HeaderText = "Parameter Number";
            this.dgvList_cmParamNum.Name = "dgvList_cmParamNum";
            this.dgvList_cmParamNum.ReadOnly = true;
            this.dgvList_cmParamNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList_cmParamNum.Width = 60;
            // 
            // dgvList_cmParamName
            // 
            this.dgvList_cmParamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList_cmParamName.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvList_cmParamName.HeaderText = "Parameter Name";
            this.dgvList_cmParamName.Name = "dgvList_cmParamName";
            this.dgvList_cmParamName.ReadOnly = true;
            this.dgvList_cmParamName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvList_cmMult
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList_cmMult.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvList_cmMult.HeaderText = "Multiplier";
            this.dgvList_cmMult.Name = "dgvList_cmMult";
            this.dgvList_cmMult.ReadOnly = true;
            this.dgvList_cmMult.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList_cmMult.Width = 60;
            // 
            // dgvList_cmBase
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList_cmBase.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvList_cmBase.HeaderText = "Number Base";
            this.dgvList_cmBase.Name = "dgvList_cmBase";
            this.dgvList_cmBase.ReadOnly = true;
            this.dgvList_cmBase.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList_cmBase.Width = 60;
            // 
            // dgvList_cmUnits
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList_cmUnits.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvList_cmUnits.HeaderText = "Value Units";
            this.dgvList_cmUnits.Name = "dgvList_cmUnits";
            this.dgvList_cmUnits.ReadOnly = true;
            this.dgvList_cmUnits.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList_cmUnits.Width = 60;
            // 
            // btnTblFileOpen
            // 
            this.btnTblFileOpen.Location = new System.Drawing.Point(640, 24);
            this.btnTblFileOpen.Name = "btnTblFileOpen";
            this.btnTblFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnTblFileOpen.TabIndex = 8;
            this.btnTblFileOpen.Text = "Open File";
            this.btnTblFileOpen.UseVisualStyleBackColor = true;
            this.btnTblFileOpen.Click += new System.EventHandler(this.btnListFileOpen_Click);
            // 
            // btnListFileBrowse
            // 
            this.btnListFileBrowse.Location = new System.Drawing.Point(559, 24);
            this.btnListFileBrowse.Name = "btnListFileBrowse";
            this.btnListFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnListFileBrowse.TabIndex = 7;
            this.btnListFileBrowse.Text = "Browse";
            this.btnListFileBrowse.UseVisualStyleBackColor = true;
            this.btnListFileBrowse.Click += new System.EventHandler(this.btnFileBrowse_Click);
            // 
            // txtListFile
            // 
            this.txtListFile.Location = new System.Drawing.Point(70, 26);
            this.txtListFile.Name = "txtListFile";
            this.txtListFile.Size = new System.Drawing.Size(483, 20);
            this.txtListFile.TabIndex = 6;
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
            this.statMain_lblID,
            this.statMain_lblStat,
            this.statMain_prgIO});
            this.statMain.Location = new System.Drawing.Point(0, 861);
            this.statMain.Name = "statMain";
            this.statMain.Size = new System.Drawing.Size(747, 22);
            this.statMain.TabIndex = 9;
            this.statMain.Text = "statusStrip1";
            // 
            // statMain_lblID
            // 
            this.statMain_lblID.Name = "statMain_lblID";
            this.statMain_lblID.Size = new System.Drawing.Size(45, 17);
            this.statMain_lblID.Text = "Status: ";
            // 
            // statMain_lblStat
            // 
            this.statMain_lblStat.Name = "statMain_lblStat";
            this.statMain_lblStat.Size = new System.Drawing.Size(130, 17);
            this.statMain_lblStat.Text = "Database Disconnected";
            // 
            // statMain_prgIO
            // 
            this.statMain_prgIO.Name = "statMain_prgIO";
            this.statMain_prgIO.Size = new System.Drawing.Size(250, 16);
            this.statMain_prgIO.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.statMain_prgIO.Visible = false;
            // 
            // grpDefVals
            // 
            this.grpDefVals.Controls.Add(this.grpDefTools);
            this.grpDefVals.Controls.Add(this.dgvDefVal);
            this.grpDefVals.Controls.Add(this.btnDefOpen);
            this.grpDefVals.Controls.Add(this.btnDefBrowse);
            this.grpDefVals.Controls.Add(this.txtDefFile);
            this.grpDefVals.Controls.Add(this.label7);
            this.grpDefVals.Enabled = false;
            this.grpDefVals.Location = new System.Drawing.Point(12, 405);
            this.grpDefVals.Name = "grpDefVals";
            this.grpDefVals.Size = new System.Drawing.Size(725, 323);
            this.grpDefVals.TabIndex = 10;
            this.grpDefVals.TabStop = false;
            this.grpDefVals.Text = "Drive Default Parameter Value Import";
            // 
            // grpDefTools
            // 
            this.grpDefTools.Controls.Add(this.btnDefCmp);
            this.grpDefTools.Controls.Add(this.btnDefImp);
            this.grpDefTools.Controls.Add(this.btnDefColCfg);
            this.grpDefTools.Controls.Add(this.label8);
            this.grpDefTools.Controls.Add(this.txtDefCol);
            this.grpDefTools.Controls.Add(this.cmbDefDrive);
            this.grpDefTools.Controls.Add(this.label11);
            this.grpDefTools.Controls.Add(this.label9);
            this.grpDefTools.Controls.Add(this.cmbDefTblList);
            this.grpDefTools.Controls.Add(this.cmbDefDuty);
            this.grpDefTools.Controls.Add(this.label10);
            this.grpDefTools.Enabled = false;
            this.grpDefTools.Location = new System.Drawing.Point(6, 204);
            this.grpDefTools.Name = "grpDefTools";
            this.grpDefTools.Size = new System.Drawing.Size(713, 112);
            this.grpDefTools.TabIndex = 26;
            this.grpDefTools.TabStop = false;
            this.grpDefTools.Text = "Database Tools:";
            // 
            // btnDefImp
            // 
            this.btnDefImp.Location = new System.Drawing.Point(12, 83);
            this.btnDefImp.Name = "btnDefImp";
            this.btnDefImp.Size = new System.Drawing.Size(130, 23);
            this.btnDefImp.TabIndex = 27;
            this.btnDefImp.Text = "Import Default Data";
            this.btnDefImp.UseVisualStyleBackColor = true;
            this.btnDefImp.Click += new System.EventHandler(this.btnDefImp_Click);
            // 
            // btnDefColCfg
            // 
            this.btnDefColCfg.Location = new System.Drawing.Point(458, 47);
            this.btnDefColCfg.Name = "btnDefColCfg";
            this.btnDefColCfg.Size = new System.Drawing.Size(115, 23);
            this.btnDefColCfg.TabIndex = 26;
            this.btnDefColCfg.Text = "Configure Column";
            this.btnDefColCfg.UseVisualStyleBackColor = true;
            this.btnDefColCfg.Click += new System.EventHandler(this.btnDefColCfg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Drive Selection:";
            // 
            // txtDefCol
            // 
            this.txtDefCol.Location = new System.Drawing.Point(344, 49);
            this.txtDefCol.Name = "txtDefCol";
            this.txtDefCol.ReadOnly = true;
            this.txtDefCol.Size = new System.Drawing.Size(108, 20);
            this.txtDefCol.TabIndex = 25;
            // 
            // cmbDefDrive
            // 
            this.cmbDefDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefDrive.FormattingEnabled = true;
            this.cmbDefDrive.Location = new System.Drawing.Point(101, 13);
            this.cmbDefDrive.Name = "cmbDefDrive";
            this.cmbDefDrive.Size = new System.Drawing.Size(443, 21);
            this.cmbDefDrive.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Table Column:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Drive Duty:";
            // 
            // cmbDefTblList
            // 
            this.cmbDefTblList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefTblList.FormattingEnabled = true;
            this.cmbDefTblList.Location = new System.Drawing.Point(101, 49);
            this.cmbDefTblList.Name = "cmbDefTblList";
            this.cmbDefTblList.Size = new System.Drawing.Size(149, 21);
            this.cmbDefTblList.TabIndex = 23;
            // 
            // cmbDefDuty
            // 
            this.cmbDefDuty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefDuty.FormattingEnabled = true;
            this.cmbDefDuty.Items.AddRange(new object[] {
            "Heavy Duty",
            "Normal Duty"});
            this.cmbDefDuty.Location = new System.Drawing.Point(617, 13);
            this.cmbDefDuty.Name = "cmbDefDuty";
            this.cmbDefDuty.Size = new System.Drawing.Size(89, 21);
            this.cmbDefDuty.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Database Table:";
            // 
            // dgvDefVal
            // 
            this.dgvDefVal.AllowUserToAddRows = false;
            this.dgvDefVal.AllowUserToDeleteRows = false;
            this.dgvDefVal.AllowUserToResizeColumns = false;
            this.dgvDefVal.AllowUserToResizeRows = false;
            this.dgvDefVal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefVal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDefVal_cmRegAddr,
            this.dgvDefVal_cmParamNum,
            this.dgvDefVal_cmParamName,
            this.dgvDefVal_cmDefVal});
            this.dgvDefVal.Location = new System.Drawing.Point(6, 53);
            this.dgvDefVal.Name = "dgvDefVal";
            this.dgvDefVal.RowHeadersVisible = false;
            this.dgvDefVal.Size = new System.Drawing.Size(709, 145);
            this.dgvDefVal.TabIndex = 17;
            // 
            // dgvDefVal_cmRegAddr
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefVal_cmRegAddr.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDefVal_cmRegAddr.HeaderText = "Register Address";
            this.dgvDefVal_cmRegAddr.Name = "dgvDefVal_cmRegAddr";
            this.dgvDefVal_cmRegAddr.ReadOnly = true;
            this.dgvDefVal_cmRegAddr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefVal_cmRegAddr.Width = 60;
            // 
            // dgvDefVal_cmParamNum
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefVal_cmParamNum.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDefVal_cmParamNum.HeaderText = "Parameter Number";
            this.dgvDefVal_cmParamNum.Name = "dgvDefVal_cmParamNum";
            this.dgvDefVal_cmParamNum.ReadOnly = true;
            this.dgvDefVal_cmParamNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefVal_cmParamNum.Width = 60;
            // 
            // dgvDefVal_cmParamName
            // 
            this.dgvDefVal_cmParamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefVal_cmParamName.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDefVal_cmParamName.HeaderText = "Parameter Name";
            this.dgvDefVal_cmParamName.Name = "dgvDefVal_cmParamName";
            this.dgvDefVal_cmParamName.ReadOnly = true;
            this.dgvDefVal_cmParamName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvDefVal_cmDefVal
            // 
            this.dgvDefVal_cmDefVal.HeaderText = "Default Value";
            this.dgvDefVal_cmDefVal.Name = "dgvDefVal_cmDefVal";
            this.dgvDefVal_cmDefVal.ReadOnly = true;
            // 
            // btnDefOpen
            // 
            this.btnDefOpen.Location = new System.Drawing.Point(637, 24);
            this.btnDefOpen.Name = "btnDefOpen";
            this.btnDefOpen.Size = new System.Drawing.Size(75, 23);
            this.btnDefOpen.TabIndex = 16;
            this.btnDefOpen.Text = "Open File";
            this.btnDefOpen.UseVisualStyleBackColor = true;
            this.btnDefOpen.Click += new System.EventHandler(this.btnDefOpen_Click);
            // 
            // btnDefBrowse
            // 
            this.btnDefBrowse.Location = new System.Drawing.Point(556, 24);
            this.btnDefBrowse.Name = "btnDefBrowse";
            this.btnDefBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDefBrowse.TabIndex = 15;
            this.btnDefBrowse.Text = "Browse";
            this.btnDefBrowse.UseVisualStyleBackColor = true;
            this.btnDefBrowse.Click += new System.EventHandler(this.btnFileBrowse_Click);
            // 
            // txtDefFile
            // 
            this.txtDefFile.Location = new System.Drawing.Point(67, 26);
            this.txtDefFile.Name = "txtDefFile";
            this.txtDefFile.Size = new System.Drawing.Size(483, 20);
            this.txtDefFile.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Excel File:";
            // 
            // btnDefCmp
            // 
            this.btnDefCmp.Location = new System.Drawing.Point(148, 83);
            this.btnDefCmp.Name = "btnDefCmp";
            this.btnDefCmp.Size = new System.Drawing.Size(130, 23);
            this.btnDefCmp.TabIndex = 27;
            this.btnDefCmp.Text = "Compare Default Data";
            this.btnDefCmp.UseVisualStyleBackColor = true;
            this.btnDefCmp.Click += new System.EventHandler(this.btnDefCmp_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 883);
            this.Controls.Add(this.grpDefVals);
            this.Controls.Add(this.statMain);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpImpList);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrical Database Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpImpList.ResumeLayout(false);
            this.grpImpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.grpUserAuth.ResumeLayout(false);
            this.grpUserAuth.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statMain.ResumeLayout(false);
            this.statMain.PerformLayout();
            this.grpDefVals.ResumeLayout(false);
            this.grpDefVals.PerformLayout();
            this.grpDefTools.ResumeLayout(false);
            this.grpDefTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpImpList;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpUserAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox chkWinAuth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.StatusStrip statMain;
        private System.Windows.Forms.ToolStripStatusLabel statMain_lblID;
        private System.Windows.Forms.ToolStripStatusLabel statMain_lblStat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtListFile;
        private System.Windows.Forms.Button btnListFileBrowse;
        private System.Windows.Forms.Button btnTblFileOpen;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvList_cmRegAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvList_cmParamNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvList_cmParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvList_cmMult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvList_cmBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvList_cmUnits;
        private System.Windows.Forms.Button btnListImp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbListTblSel;
        private System.Windows.Forms.ToolStripProgressBar statMain_prgIO;
        private System.Windows.Forms.GroupBox grpDefVals;
        private System.Windows.Forms.TextBox txtDefCol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDefTblList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDefDuty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDefDrive;
        private System.Windows.Forms.DataGridView dgvDefVal;
        private System.Windows.Forms.Button btnDefOpen;
        private System.Windows.Forms.Button btnDefBrowse;
        private System.Windows.Forms.TextBox txtDefFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpDefTools;
        private System.Windows.Forms.Button btnDefImp;
        private System.Windows.Forms.Button btnDefColCfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDefVal_cmRegAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDefVal_cmParamNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDefVal_cmParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDefVal_cmDefVal;
        private System.Windows.Forms.Button btnDefCmp;
    }
}

