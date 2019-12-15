using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovoy_proekt
{
    public partial class Form_Main : Form
    {
        IniFiles IF = new IniFiles();
        Image p1 = Properties.Resources.Кнопка_1;
        Image p2 = Properties.Resources.Кнопка_2;
        Image p4 = Properties.Resources.Кнопка_4;
        Image p5 = Properties.Resources.Кнопка_6;
        Image p6 = Properties.Resources.Кнопка_Отчёты;
        Image p7 = Properties.Resources.Кнопка_Поставщик;
        Image p9 = Properties.Resources.Кнопка_о_программе;
        Image p10 = Properties.Resources.Кнопка_об_авторе;
        Image p11 = Properties.Resources.Кнопка_об_авторе;
        Image p12 = Properties.Resources.Кнопка_личный_кабинет;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void pbOtchet_MouseMove(object sender, MouseEventArgs e)
        {
            pbOtchet.BackgroundImage = p1;
        }

        private void pbOtchet_MouseLeave(object sender, EventArgs e)
        {
            pbOtchet.BackgroundImage = p6;
        }

        private void pbPostavshik_MouseMove(object sender, MouseEventArgs e)
        {
            pbSklad.BackgroundImage = p2;
        }

        private void pbPostavshik_MouseLeave(object sender, EventArgs e)
        {
            pbSklad.BackgroundImage = p7;
        }

        private void pbInf_o_program_MouseMove(object sender, MouseEventArgs e)
        {
            pbInf_o_program.BackgroundImage = p4;
        }

        private void pbInf_o_program_MouseLeave(object sender, EventArgs e)
        {
            pbInf_o_program.BackgroundImage = p9;
        }

        private void pbAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            pbAuthor.BackgroundImage = p5;
        }

        private void pbAuthor_MouseLeave(object sender, EventArgs e)
        {
            pbAuthor.BackgroundImage = p10;
        }

        private void pbKabinet_MouseMove(object sender, MouseEventArgs e)
        {
            pbKabinet.BackgroundImage = p11;
        }

        private void pbKabinet_MouseLeave(object sender, EventArgs e)
        {
            pbKabinet.BackgroundImage = p12;
        }

        private void pbInf_o_program_Click(object sender, EventArgs e)
        {
            Form_About_Program about = new Form_About_Program();
            about.Show();
        }

        private void pbOtchet_Click(object sender, EventArgs e)
        {
            Form_Otchet otchet = new Form_Otchet();
            otchet.Show();
        }

        private void pbKabinet_Click(object sender, EventArgs e)
        {
            Form_Kabinet kabinet = new Form_Kabinet();
            kabinet.Show();
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            Form_Settings settings = new Form_Settings();
            this.Hide();
            settings.Show();
        }

        private void pbPostavshik_Click(object sender, EventArgs e)
        {
            Form_Sklad sklad = new Form_Sklad();
            sklad.Show();
        }

        private void pbZakaz_Click(object sender, EventArgs e)
        {
            Form_Zakaz form_zakaz = new Form_Zakaz();
            form_zakaz.Show();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (Form_Authorize.role == Form_Authorize.Role.Admin)
            {
                pbKabinet.Enabled = false;
            }
            else if (Form_Authorize.role == Form_Authorize.Role.Klient)
            {
                pbOtchet.Enabled = false;
                pbSklad.Enabled = false;
            }
            else if (Form_Authorize.role == Form_Authorize.Role.Director)
            {
                pbKabinet.Enabled = false;
            }
            else if (Form_Authorize.role == Form_Authorize.Role.Menedjer_po_prodajam)
            {
                pbKabinet.Enabled = false;
            }
            else if (Form_Authorize.role == Form_Authorize.Role.Menedjer_po_zak)
            {
                pbKabinet.Enabled = false;
            }
            else if (Form_Authorize.role == Form_Authorize.Role.Kladovshik)
            {
                pbOtchet.Enabled = false;
                pbKabinet.Enabled = false;
            }
            else if (Form_Authorize.role == Form_Authorize.Role.Buhgalter)
            {
                pbSklad.Enabled = false;
                pbKabinet.Enabled = false;
            }
        }

        private void pbAuthor_Click(object sender, EventArgs e)
        {
            Form_Author author = new Form_Author();
            author.Show();
        }
    }
}
