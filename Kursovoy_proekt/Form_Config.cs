using System;
using System.Windows.Forms;
using System.IO;

namespace Kursovoy_proekt
{
    public partial class Form_Config : Form
    {
        decimal TM, RM, BM, LM;
        Registry_Class registry = new Registry_Class();

        private void btBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbPut.Text = folderBrowserDialog1.SelectedPath;
        }

        private void nudSleva_ValueChanged(object sender, EventArgs e)
        {
            if (nudSleva.Value > LM)
            {
                pnText.Width -= (int)nudSleva.Value;
                pnText.Left += (int)nudSleva.Value;
            }
            else
            {
                pnText.Width += (int)nudSleva.Value;
                pnText.Left -= (int)nudSleva.Value;
            }
            LM = nudSleva.Value;
        }

        private void nudVerh_ValueChanged(object sender, EventArgs e)
        {
            if (nudVerh.Value > TM)
            {
                pnText.Height -= (int)nudVerh.Value;
                pnText.Top += (int)nudVerh.Value;
            }
            else
            {
                pnText.Height += (int)nudVerh.Value;
                pnText.Top -= (int)nudVerh.Value;
            }
            TM = nudVerh.Value;
        }

        private void nudSprava_ValueChanged(object sender, EventArgs e)
        {
            if (nudSprava.Value > RM)
                pnText.Width -= (int)nudSprava.Value;
            else
                pnText.Width += (int)nudSprava.Value;
            RM = nudSprava.Value;
        }

        private void nudSnizu_ValueChanged(object sender, EventArgs e)
        {
            if (nudSnizu.Value > BM)
                pnText.Height -= (int)nudSnizu.Value;
            else
                pnText.Height += (int)nudSnizu.Value;
            BM = nudSnizu.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DocumentSave();
            Close();
        }

        private void Form_Config_Load(object sender, EventArgs e)
        {
            registry.ConfigurationGet();
            tbPut.Text = Registry_Class.DirPath;
            nudVerh.Value = (decimal)Registry_Class.DocTM;
            nudSprava.Value = (decimal)Registry_Class.DocRM;
            nudSnizu.Value = (decimal)Registry_Class.DocBM;
            nudSleva.Value = (decimal)Registry_Class.DocLM;
            TM = nudVerh.Value;
            RM = nudSprava.Value;
            BM = nudSnizu.Value;
            LM = nudSleva.Value;
            pnText.Top += (int)TM * 10;
            pnText.Height -= (int)TM * 10;
            pnText.Width -= (int)RM * 10;
            pnText.Height -= (int)BM * 10;
            pnText.Left += (int)LM * 10;
            pnText.Width -= (int)LM * 10;
        }

        private void DocumentSave()
        {
            string document_default_path = "";
            switch (tbPut.Text == "")
            {
                case (true):
                    document_default_path =
                        "C:\\Users\\" + SystemInformation.UserName
                        + "\\Documents\\Отчёты";
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
                case (false):
                    document_default_path = tbPut.Text;
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
            }
            registry.DocumentConfigurationSet(tbPut.Text, nudSleva.Value,
                nudVerh.Value,
                nudSprava.Value, nudSnizu.Value);
        }

        public Form_Config()
        {
            InitializeComponent();
        }
    }
}
