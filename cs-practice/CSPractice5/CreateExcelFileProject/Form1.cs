using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateExcelFileProject
{
    public partial class FrmCreateExcelFile : Form
    {
        public FrmCreateExcelFile()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application WRExcel = null;
            Microsoft.Office.Interop.Excel.Workbooks WRwbs = null;

            Microsoft.Office.Interop.Excel._Workbook WRwb = null;
            Microsoft.Office.Interop.Excel.Sheets WRss = null;

            Microsoft.Office.Interop.Excel._Worksheet WRws = null;

            object objOpt = System.Reflection.Missing.Value;

            // membuat Excel spreadsheet
            WRExcel = new Microsoft.Office.Interop.Excel.Application();
            WRwbs = (Microsoft.Office.Interop.Excel.Workbooks)WRExcel.Workbooks;

            WRwb = (Microsoft.Office.Interop.Excel.Workbook)(WRwbs.Add(objOpt));

            WRss = (Microsoft.Office.Interop.Excel.Sheets)WRwb.Worksheets;

            WRws = (Microsoft.Office.Interop.Excel._Worksheet)(WRss.get_Item(1));

            WRws.Cells[1, 1] = "Excel Text 1";
            WRws.Cells[2, 1] = "Excel Text 2";
            WRws.Cells[3, 1] = "Excel Text 3";

            WRws.get_Range("A5", "A9").MergeCells = true;
            WRws.get_Range("A5", "A9").ColumnWidth = 9.7;
            WRws.get_Range("A5", "A9").Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            WRws.get_Range("A5", "A9").Interior.Color = System.Drawing.ColorTranslator.ToWin32(System.Drawing.Color.Orange);

            WRwb.SaveAs(@"C:\Database\CreateExcelFile.xls", objOpt, objOpt, objOpt, objOpt, objOpt, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, objOpt, objOpt, objOpt, objOpt, objOpt);

            WRwbs.Close();
            
        }
    }
}
