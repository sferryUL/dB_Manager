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
        const string conn_str_start = "Server = {0};Database = {1}; Integrated Security = {2};";
        const string conn_str_usr = "User ID = {0};Password = {1};";


        XL.Application xlApp = new XL.Application();
        XL._Workbook xlWB;
        XL._Worksheet xlWS;
        XL.Range xlRng;

        SqlConnection dBConn = new SqlConnection();

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
                statMain_ConnStat.Text = "Connected";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                grpTblImp.Enabled = true;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            dBConn.Close();
            dBConn.Dispose();
            statMain_ConnStat.Text = "Disconnected";
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

        private void btnTblFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();

            opfd.Filter = ("Excel 2007 Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*");
            opfd.RestoreDirectory = true;
            opfd.InitialDirectory = "N:\\ELECTRICAL DATA\\APPLICATIONS\\VFD Programmer\\data\\";
            if(opfd.ShowDialog() == DialogResult.OK)
            {
                txtTblFile.Text = opfd.FileName;
                txtTblName.Text = opfd.SafeFileName.Substring(0, opfd.SafeFileName.IndexOf('.'));
            }

        }

        private void btnTblImport_Click(object sender, EventArgs e)
        {
            switch(cmbTblType.SelectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }

        private void grpTblImport_Disable()
        {
            grpTblImp_Clear();
            grpTblImp.Enabled = false;
        }

        private void grpTblImp_Clear()
        {
            txtTblFile.Text = "";
            cmbTblType.SelectedIndex = -1;
            txtTblName.Text = "";
        }

        private void btnTblFileOpen_Click(object sender, EventArgs e)
        {
            if(txtTblFile.Text == "")
            {
                MsgBox.Err("A filename is required!");
                return;
            }

            

            try
            {
                xlApp = new XL.Application();
                xlWB = xlApp.Workbooks.Open(txtTblFile.Text);
                xlWS = xlWB.Worksheets[0];
                xlRng = xlWS.UsedRange;
            }
            catch (Exception ex)
            {
                MsgBox.Err("Error opening file!\n" + ex.Message);
                return;
            }

            int cnt = xlRng.Rows.Count;


            xlFunc.xlClose(ref xlApp, ref xlWB, ref xlWS, ref xlRng);
        }

    } // class frmMain
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
