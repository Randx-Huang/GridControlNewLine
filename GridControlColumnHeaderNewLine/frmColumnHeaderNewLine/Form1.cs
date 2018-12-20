using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmColumnHeaderNewLine
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = GetDataSource();
        }

        private DataTable GetDataSource()
        {
            DataTable dtl = new DataTable();
            dtl.Columns.Add("Col1");
            dtl.Columns.Add("Col2");
            dtl.Columns.Add("Col3");
            dtl.Columns.Add("Col4");

            var dr = dtl.NewRow();
            dr["Col1"] = "A";
            dr["Col2"] = "B";
            dr["Col3"] = "C";
            dr["Col4"] = "D";

            dtl.Rows.Add(dr);

            dtl.Columns["Col1"].Caption = $"欄位1{Environment.NewLine}Col1";
            dtl.Columns["Col2"].Caption = $"欄位2{Environment.NewLine}Col2";
            dtl.Columns["Col3"].Caption = $"欄位3{Environment.NewLine}Col3";
            dtl.Columns["Col4"].Caption = $"欄位4{Environment.NewLine}Col4";

            return dtl;
        }
    }

    
}
