using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BUS
{
    public class ExportToExcel_BUS
    {
        public void ExportExcel(DataGridView Datagridview)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;
            app.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Cells.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            for (int i = 1; i < Datagridview.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Datagridview.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < Datagridview.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Datagridview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Datagridview.Rows[i].Cells[j].Value.ToString();
                }
            }
            worksheet.Columns.AutoFit();
            app.Quit();
        }
    }
}