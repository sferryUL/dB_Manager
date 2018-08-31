﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XL = Microsoft.Office.Interop.Excel;

namespace GenFunc
{
    public static class MsgBox
    {
        public static DialogResult Err(string p_Msg, string p_Caption = "Entry Error")
        {
            DialogResult result = MessageBox.Show(p_Msg, p_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
        }

        public static DialogResult YN(string p_Msg, string p_Caption = "")
        {
            DialogResult result = MessageBox.Show(p_Msg, p_Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result;
        }

        public static DialogResult Info(string p_Msg, string p_Caption = "Information")
        {
            DialogResult result = MessageBox.Show(p_Msg, p_Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }

    }

    public static class xlFunc
    {
        public static void xlClose(ref XL.Application p_App, ref XL._Workbook p_WB, ref XL._Worksheet p_WS, ref XL.Range p_Rng)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            p_WB.Close();
            p_App.Quit();

            // release COM objects
            Marshal.ReleaseComObject(p_Rng);
            Marshal.ReleaseComObject(p_WS);
            Marshal.ReleaseComObject(p_WB);
            Marshal.ReleaseComObject(p_App);
        }

    }

}
