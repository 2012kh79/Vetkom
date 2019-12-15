using System;
using System.Data;
using word = Microsoft.Office.Interop.Word;

namespace Kursovoy_proekt
{
    class WordDocument
    {
        public DataTable table = new DataTable();
        public void Shet_Facture()
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Registry_Class.DirPath + "\\СФ_"
                + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocLM));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocRM));
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocTM));
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(Convert.ToSingle(Registry_Class.DocBM));
                range.ParagraphFormat.Alignment
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "СЧЁТ-ФАКТУРА";
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table tbShet = document.Tables.Add(pTable.Range, table.Rows.Count + 1,
                    table.Columns.Count);
                tbShet.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbShet.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                tbShet.Cell(1, 1).Range.Text = "Номер cчёта";
                tbShet.Cell(1, 2).Range.Text = "Дата формирования счёта";
                tbShet.Cell(1, 3).Range.Text = "Цена за заказанный товар";
                tbShet.Cell(1, 4).Range.Text = "Номер заказанного товара";
                tbShet.Cell(1, 5).Range.Text = "Номер товарно-транспортной накладной";
                tbShet.Range.Font.Size = 11;
                tbShet.Range.Font.Name = "Times New Roman";
                tbShet.Columns[1].AutoFit();
                for (int i = 2; i <= tbShet.Rows.Count; i++)
                    for (int j = 1; j <= tbShet.Columns.Count; j++)
                    {
                        tbShet.Cell(i, j).Range.Text
                            = table.Rows[i - 2][j - 1].ToString();
                    }
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
            }
        }
    }
}
