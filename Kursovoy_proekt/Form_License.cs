using System;
using System.Windows.Forms;
using System.IO;

namespace Kursovoy_proekt
{
    public partial class Form_License : Form
    {
        string put;
        public Form_License()
        {
            InitializeComponent();
        }

        private void Form_License_Load(object sender, EventArgs e)
        {
        }

        private void btn_Voity_Click(object sender, EventArgs e)
        {
            put = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Keys.txt");
            try
            {
                if (mtb_License.Text != "")
                {
                    string chtenie = File.ReadAllText(put);
                    try
                    {
                        if (chtenie.IndexOf(mtb_License.Text) != -1) 
                        {
                            Registry_Class reg = new Registry_Class();
                            reg.LicenseSet(mtb_License.Text);
                            Form_Authorize Form_Authorize = new Form_Authorize();
                            Form_Authorize.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Лицензионный ключ не найден!", "Лицензия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Введите лицензионный ключ!", "Лицензия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Сообщение о выходе", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
