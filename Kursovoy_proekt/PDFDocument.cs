using System;
using word = Microsoft.Office.Interop.Word;
using System.Data;

namespace Kursovoy_proekt
{
    class PDFDocument
    {
        public DataTable table = new DataTable();
        Registry_Class reg = new Registry_Class();
        public string ID_Shet = "", Tsena_tovara = "", Data_form = "", Zakaz_ID = "", TTN_ID = "";
        public void Shet_Facture_PDF()
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);

            string file_name = Registry_Class.DirPath + "\\СФ_"
            + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".pdf";
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

                word.Paragraph Nomer_shet = document.Paragraphs.Add();
                Nomer_shet.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Nomer_shet.Range.Font.Name = "Times New Roman";
                Nomer_shet.Range.Font.Size = 16;
                Nomer_shet.Range.Text = "Номер cчёта - " + ID_Shet;

                document.Paragraphs.Add();

                word.Paragraph Data = document.Paragraphs.Add();
                Data.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Data.Range.Font.Name = "Times New Roman";
                Data.Range.Font.Size = 16;
                Data.Range.Text = "Дата формирования счёта - " + Data_form;

                document.Paragraphs.Add();

                word.Paragraph Tsena = document.Paragraphs.Add();
                Tsena.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                Tsena.Range.Font.Name = "Times New Roman";
                Tsena.Range.Font.Size = 16;
                Tsena.Range.Text = "Цена за заказанный товар - " + Tsena_tovara;

                document.Paragraphs.Add();

                word.Paragraph Zakaz_id = document.Paragraphs.Add();
                Zakaz_id.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                Zakaz_id.Range.Font.Name = "Times New Roman";
                Zakaz_id.Range.Font.Size = 16;
                Zakaz_id.Range.Text = "Номер заказанного товара - " + Zakaz_ID;

                document.Paragraphs.Add();

                word.Paragraph TTN_id = document.Paragraphs.Add();
                TTN_id.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
                TTN_id.Range.Font.Name = "Times New Roman";
                TTN_id.Range.Font.Size = 16;
                TTN_id.Range.Text = "Номер заказанного товара - " + TTN_ID;

                document.Paragraphs.Add();

                document.Paragraphs.Add();

            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                + DateTime.Now.ToLongDateString() + " " + ex.Message;
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatPDF);
                document.Close(false);
                application.Quit();
            }
        }
    }
}
