using System;
using System.Data;
using excel = Microsoft.Office.Interop.Excel;


namespace Kursovoy_proekt
{
    class ExcelDocument
    {
        public DataTable dtShet = new DataTable();
        public void SprosCreate()
        {
            excel.Application application = new excel.Application(); 
            excel.Workbook workbook = application.Workbooks.Add();
            excel.Worksheet worksheet =
            (excel.Worksheet)workbook.ActiveSheet;
            string file_name = Registry_Class.DirPath + "\\ООСИФНТ_" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".xlsx";
            try
            {
                worksheet.Name = "ООСИФНТ";
                worksheet.Cells[1, 1] = "Фамилия бухгалтера";
                worksheet.Cells[1, 2] = "Имя бухгалтера";
                worksheet.Cells[1, 3] = "Отчество бухгалтера";
                worksheet.Cells[1, 4] = "Дата формирования отчёта";
                worksheet.Cells[1, 5] = "Номер ЖУДТНС";
                worksheet.Cells[1, 6] = "Номер заказанного товара";

                for (int i = 0; i < dtShet.Rows.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = dtShet.Rows[i][0].ToString();
                    worksheet.Cells[i + 2, 2] = dtShet.Rows[i][1].ToString();
                    worksheet.Cells[i + 2, 3] = dtShet.Rows[i][2].ToString();
                    worksheet.Cells[i + 2, 4] = dtShet.Rows[i][3].ToString();
                    worksheet.Cells[i + 2, 5] = dtShet.Rows[i][4].ToString();
                    worksheet.Cells[i + 2, 6] = dtShet.Rows[i][5].ToString();
                }
                worksheet.Columns[1].ColumnWidth = 30;
                worksheet.Columns[2].ColumnWidth = 30;
                worksheet.Columns[3].ColumnWidth = 30;
                worksheet.Columns[4].ColumnWidth = 30;
                worksheet.Columns[5].ColumnWidth = 30;
                worksheet.Columns[6].ColumnWidth = 30;

                application.ActiveWindow.View = excel.XlWindowView.xlPageBreakPreview;
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                workbook.SaveAs(file_name, application.DefaultSaveFormat);
                workbook.Close();
                application.Quit();
            }
        }
    }
}
