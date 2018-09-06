using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;
using XL = Microsoft.Office.Interop.Excel;
using GenFunc;

namespace ExcelDBtoSS
{
    public partial class frmMain : Form
    {
        #region Globals
        const string conn_str_start = "Server = {0};Database = {1}; Integrated Security = {2};";
        const string conn_str_usr = "User ID = {0};Password = {1};";

        XL.Application xlApp;
        XL._Workbook xlWB;
        XL._Worksheet xlWS;
        XL.Range xlRng;

        List<Drv_List_Data> DrvParmData;
        List<Drv_List_Data> DrvDefData;
        List<Drv_Info>DrvInfo;

        SqlConnection dBConn = new SqlConnection();

        #endregion

        #region Form Management
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dBConn.State == ConnectionState.Open)
                dBConn.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtServer.Focus();
        }
        #endregion

        #region Database Connection
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if((txtServer.Text == "") || (txtDB.Text == ""))
            {
                MsgBox.Err("Server name and database name are required!");
                return;
            }

            string conn_str;
            if(chkWinAuth.Checked)
                conn_str = String.Format(conn_str_start, txtServer.Text, txtDB.Text, "True");
            else
            {
                if((txtUser.Text == "") || (txtPass.Text == ""))
                {
                    MsgBox.Err("Username & password required!");
                    return;
                }
                conn_str = String.Format(conn_str_start, txtServer.Text, txtDB.Text, "False") +
                            String.Format(conn_str_usr, txtUser.Text, txtPass.Text);
            }

            dBConn.ConnectionString = conn_str;

            try
            {
                dBConn.Open();
            }
            catch (Exception ex)
            {
                MsgBox.Err("Connection Failure\n" + ex.Message, "Database Error");
            }

            if(dBConn.State == ConnectionState.Open)
            {
                statMain_lblStat.Text = "Database Connected";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                grpImpList.Enabled = true;
                grpDefVals.Enabled = true;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            dBConn.Close();
            dBConn.Dispose();
            statMain_lblStat.Text = "Disconnected";
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            grpTblImport_Disable();
        }

        private void chkWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if(chkWinAuth.Checked)
                grpUserAuth.Enabled = false;
            else
            {
                txtUser.Text = "";
                txtPass.Text = "";
                grpUserAuth.Enabled = true;
            }
        }

        #endregion

        #region Parameter List Import Functions

        private void grpTblImport_Disable()
        {
            grpTblImp_Clear();
            grpImpList.Enabled = false;
        }

        private void grpTblImp_Clear()
        {
            txtListFile.Text = "";
        }

        private void btnListFileOpen_Click(object sender, EventArgs e)
        {
            if(txtListFile.Text == "")
            {
                MsgBox.Err("A filename is required!");
                return;
            }

            try
            {
                xlApp = new XL.Application();
                xlWB = xlApp.Workbooks.Open(txtListFile.Text);
                xlWS = xlWB.Worksheets[1];
                xlRng = xlWS.UsedRange;
            }
            catch (Exception ex)
            {
                MsgBox.Err("Error opening file!\n" + ex.Message, "File Error");
                return;
            }

            DrvParmData = new List<Drv_List_Data>();

            string tmpStat = statMain_lblStat.Text;
            statMain_lblStat.Text = "Reading Drive Master Parameter List";
            statMain_prgIO.Value = 0;
            statMain_prgIO.Visible = true;
            dgvList.Rows.Clear();
            for(int i=2;i<xlRng.Rows.Count;i++)
            {
                Drv_List_Data dat = new Drv_List_Data();

                dat.Index = i;

                if(xlRng.Cells[i, 2] != null && xlRng.Cells[i, 2].Value2 != null)
                    dat.RegAddress = Convert.ToInt32(xlRng.Cells[i, 2].Value2);
                else
                    dat.RegAddress = 0;

                if(xlRng.Cells[i, 3] != null && xlRng.Cells[i, 3].Value2 != null)
                    dat.ParamNum = xlRng.Cells[i, 3].Value2.ToString();
                else
                    dat.ParamNum = "0";

                if(xlRng.Cells[i, 4] != null && xlRng.Cells[i, 4].Value2 != null)
                    dat.ParamName = xlRng.Cells[i, 4].Value2.ToString();
                else
                    dat.ParamName = "0";

                if(xlRng.Cells[i, 5] != null && xlRng.Cells[i, 5].Value2 != null)
                    dat.Multiplier = Convert.ToInt32(xlRng.Cells[i, 5].Value2);
                else
                    dat.Multiplier = 1;

                if(xlRng.Cells[i, 6] != null && xlRng.Cells[i, 6].Value2 != null)
                    dat.NumBase = Convert.ToInt32(xlRng.Cells[i, 6].Value2);
                else
                    dat.NumBase = 10;

                if(xlRng.Cells[i, 7] != null && xlRng.Cells[i, 7].Value2 != null)
                    dat.Units = xlRng.Cells[i, 7].Value2.ToString();
                else
                    dat.Units = "";


                dgvList.Rows.Add(new string[]
                {
                    ("0x" + dat.RegAddress.ToString("X4")),
                    dat.ParamNum,
                    dat.ParamName,
                    dat.Multiplier.ToString(),
                    dat.NumBase.ToString(),
                    dat.Units

                });

                
                DrvParmData.Add(dat);

                Single percent = (float)i / xlRng.Rows.Count;
                percent *= 100;
                int val = (int) percent;
                statMain_prgIO.Value = val;
            }
            xlFunc.xlClose(ref xlApp, ref xlWB, ref xlWS, ref xlRng);

            
            statMain_lblStat.Text = tmpStat;
            statMain_prgIO.Visible = false;
            GetTableList(cmbListTblSel);
            cmbListTblSel.Enabled = true;
            btnListImp.Enabled = true;
        }

        private void btnListImp_Click(object sender, EventArgs e)
        {
            if(cmbListTblSel.SelectedIndex == -1)
            {
                MsgBox.Err("A valid database table selection is required!");
                return;
            }

            string tbl = cmbListTblSel.Text;
            string sql = string.Format("SELECT * FROM {0}", tbl);
            SqlCommand cmd = new SqlCommand(sql, dBConn);
            SqlDataReader dr = cmd.ExecuteReader();
            bool row_exist = dr.HasRows;
            dr.Close();
            if(row_exist)
            {
                if(MsgBox.YN("This table has existing data, do you wish to overwrite it?", "Data Overwrite") == DialogResult.Yes)
                {
                    sql = string.Format("DELETE FROM {0}", tbl);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                else
                    return;
            }
            
            for(int i=0;i<DrvParmData.Count;i++)
            {
                sql = string.Format("INSERT INTO {0} (REG_ADDR, PARAM_NUM, PARAM_NAME, MULTIPLIER, NUM_BASE, UNITS) VALUES ({1}, '{2}', '{3}', {4}, {5}, '{6}')", 
                     cmbListTblSel.Text, DrvParmData[i].RegAddress, DrvParmData[i].ParamNum, DrvParmData[i].ParamName, DrvParmData[i].Multiplier, DrvParmData[i].NumBase, DrvParmData[i].Units);

                cmd = new SqlCommand(sql, dBConn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MsgBox.Err("Error adding data to database table!\n" + ex.Message, "Database Error");
                    return;
                }
            }
        }

        #endregion

        #region Default Value Import Functions
        private void btnDefOpen_Click(object sender, EventArgs e)
        {
            if(txtDefFile.Text == "")
            {
                MsgBox.Err("A filename is required!");
                return;
            }

            try
            {
                xlApp = new XL.Application();
                xlWB = xlApp.Workbooks.Open(txtDefFile.Text);
                xlWS = xlWB.Worksheets[1];
                xlRng = xlWS.UsedRange;
            }
            catch(Exception ex)
            {
                MsgBox.Err("Error opening file!\n" + ex.Message, "File Error");
                return;
            }

            DrvDefData = new List<Drv_List_Data>();
            
            string tmpStat = statMain_lblStat.Text;
            statMain_lblStat.Text = "Reading Drive Master Parameter List";
            statMain_prgIO.Value = 0;
            statMain_prgIO.Visible = true;
            dgvDefVal.Rows.Clear();
            for(int i = 2; i < xlRng.Rows.Count; i++)
            {
                Drv_List_Data dat = new Drv_List_Data();

                dat.Index = i;

                if(xlRng.Cells[i, 2] != null && xlRng.Cells[i, 2].Value2 != null)
                    dat.RegAddress = Convert.ToInt32(xlRng.Cells[i, 2].Value2);
                else
                    dat.RegAddress = 0;

                if(xlRng.Cells[i, 3] != null && xlRng.Cells[i, 3].Value2 != null)
                    dat.ParamNum = xlRng.Cells[i, 3].Value2.ToString();
                else
                    dat.ParamNum = "0";

                if(xlRng.Cells[i, 4] != null && xlRng.Cells[i, 4].Value2 != null)
                    dat.ParamName = xlRng.Cells[i, 4].Value2.ToString();
                else
                    dat.ParamName = "0";

                if(xlRng.Cells[i, 5] != null && xlRng.Cells[i, 5].Value != null)
                    dat.DefVal = Convert.ToInt32(xlRng.Cells[i, 5].Value2);
                else
                    dat.DefVal = 0;

                if(xlRng.Cells[i, 6] != null && xlRng.Cells[i, 5].Value2 != null)
                    dat.Multiplier = Convert.ToInt32(xlRng.Cells[i, 5].Value2);
                else
                    dat.Multiplier = 1;

                if(xlRng.Cells[i, 7] != null && xlRng.Cells[i, 6].Value2 != null)
                    dat.NumBase = Convert.ToInt32(xlRng.Cells[i, 6].Value2);
                else
                    dat.NumBase = 10;

                if(xlRng.Cells[i, 8] != null && xlRng.Cells[i, 7].Value2 != null)
                    dat.Units = xlRng.Cells[i, 7].Value2.ToString();
                else
                    dat.Units = "";

                dgvDefVal.Rows.Add(new string[]
                {
                    ("0x" + dat.RegAddress.ToString("X4")),
                    dat.ParamNum,
                    dat.ParamName,
                    dat.DefVal.ToString()
                });

                DrvDefData.Add(dat);

                Single percent = (float)i / xlRng.Rows.Count;
                percent *= 100;
                int val = (int)percent;
                statMain_prgIO.Value = val;
            }

            xlFunc.xlClose(ref xlApp, ref xlWB, ref xlWS, ref xlRng);
            statMain_lblStat.Text = tmpStat;
            statMain_prgIO.Visible = false;

            GetDriveList();
            GetTableList(cmbDefTblList);
            grpDefTools.Enabled = true;
        } // btnDefOpen_Click

        private void btnDefColCfg_Click(object sender, EventArgs e)
        {
            if((cmbDefDrive.SelectedIndex == -1) || (cmbDefDuty.SelectedIndex == -1))
            {
                MsgBox.Err("A drive selection and drive duty selection is required!");
                return;
            }

            string duty = "";
            switch(cmbDefDuty.SelectedIndex)
            {
                case 0:
                    duty = "HD";
                    break;
                case 1:
                    duty = "ND";
                    break;
            }

            txtDefCol.Text = "DEF_" + DrvInfo[cmbDefDrive.SelectedIndex].PartNum + "_" + duty;
        }

        private void btnDefImp_Click(object sender, EventArgs e)
        {
            if((cmbDefTblList.Text == "") || (txtDefCol.Text == ""))
            {
                MsgBox.Err("A table selection and column configuration is required");
                return;
            }

            string tbl = cmbDefTblList.Text;
            string col = txtDefCol.Text;

            for(int i=0;i<DrvDefData.Count;i++)
            {
                string val = DrvDefData[i].DefVal.ToString();
                string param = DrvDefData[i].ParamNum;
                string sql = string.Format("UPDATE {0} SET {1} = {2} WHERE PARAM_NUM = '{3}'", tbl, col, val, param);
                SqlCommand cmd = new SqlCommand(sql, dBConn);
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Shared Event Functions
        private void btnFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();

            opfd.Filter = ("Excel 2007 Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*");
            opfd.RestoreDirectory = true;
            //opfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opfd.InitialDirectory = "N:\\ELECTRICAL DATA\\APPLICATIONS\\VFD Programmer\\data\\";
            if(opfd.ShowDialog() == DialogResult.OK)
            {
                Button btn = (Button)sender;
                switch(btn.Name)
                {
                    case "btnListFileBrowse":
                        txtListFile.Text = opfd.FileName;
                        break;
                    case "btnDefBrowse":
                        txtDefFile.Text = opfd.FileName;
                        break;
                }

            }
        }
        #endregion

        #region List Acquisition Functions
        private void GetTableList(ComboBox p_Combobox)
        {
            string sql = "SELECT TABLE_NAME FROM ElectricalApps.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            SqlCommand cmd = new SqlCommand(sql, dBConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                p_Combobox.Items.Add(dr[0].ToString());

            }
            dr.Close();
            cmd.Dispose();
        }

        private void GetDriveList()
        {
            string sql = "SELECT * FROM DRV_LIST";
            SqlCommand cmd = new SqlCommand(sql, dBConn);
            SqlDataReader dr = cmd.ExecuteReader();
            DrvInfo = new List<Drv_Info>();
            while(dr.Read())
            {
                Drv_Info inf = new Drv_Info();
                inf.PartNum = dr["DRV_NUM"].ToString();
                inf.PartDesc = dr["DRV_DESC"].ToString();
                inf.Mfr = dr["DRV_MFR"].ToString();
                inf.MfrPartNum = dr["DRV_MFR_NUM"].ToString();
                inf.ParamTbl = dr["DRV_PARAM_LIST"].ToString();
                inf.GrpDescTbl = dr["DRV_GRP_DESC"].ToString();

                DrvInfo.Add(inf);
                string str = inf.PartNum + " - " + inf.PartDesc;
                cmbDefDrive.Items.Add(str);
            }

            dr.Close();
            cmd.Dispose();
        }
        #endregion

    } // class frmMain

    public class Drv_Info
    {
        public string PartNum;
        public string PartDesc;
        public string Mfr;
        public string MfrPartNum;
        public string ParamTbl;
        public string GrpDescTbl;
    }

    public class Drv_List_Data
    {
        public int Index;
        public int RegAddress;
        public string ParamNum;
        public string ParamName;
        public int Multiplier;
        public int NumBase;
        public string Units;
        public int DefVal;
    }

    } // namespace ExcelDBtoSS

/*
    private void btnCreateTbl_Click(object sender, EventArgs e)
    {
        if(dBConn.State == ConnectionState.Open)
        {
            string sql = "CREATE TABLE " + txtDB.Text + " (IDX int);";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dBConn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void btnDelTbl_Click(object sender, EventArgs e)
    {
        if(dBConn.State == ConnectionState.Open)
        {
            string sql = "DROP TABLE " + txtDB.Text + ";";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, dBConn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
*/
