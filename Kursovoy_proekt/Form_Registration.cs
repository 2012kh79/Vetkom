using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Kursovoy_proekt
{
    public partial class Form_Registration : Form
    {
        string patLogin = @"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$";
        string patEmail = @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$";
        string patPassword = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        int Enable;
        public Form_Registration()
        {
            InitializeComponent();
            tbPass.UseSystemPasswordChar = true;
            tbRepeatPass.UseSystemPasswordChar = true;
        }

        public static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Authorize Form_authoriz = new Form_Authorize();
            Form_authoriz.Show();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            Registry_Class reg = new Registry_Class();
            reg.Registry_Get();
            DBProcedures procedure = new DBProcedures();
            procedure.spAccount_Insert(tbLogin.Text, Hash(tbPass.Text), 6);
            procedure.spKlient_Insert(tbLogin.Text,tb_Fam.Text,tbImya.Text,tbOtch.Text,tb_Pochta.Text);
            DialogResult result = MessageBox.Show("Регистрация прошла успешно","Регистрация");
            if (result == DialogResult.OK)
            {
                this.Hide();
                Form_Authorize Form_authoriz = new Form_Authorize();
                Form_authoriz.Show();
            }
        }

        private void btProv_Click(object sender, EventArgs e)
        {
            Enable = 0;
            if (tb_Fam.Text.Length >= 4)
            {
                pictureBox4.Image = Properties.Resources.gal;
                Enable++;
            }
            else
                pictureBox4.Image = Properties.Resources.krest;
            if (tbImya.Text.Length >= 4)
            {
                pictureBox5.Image = Properties.Resources.gal;
                Enable++;
            }
            else
                pictureBox5.Image = Properties.Resources.krest;
            if (tbOtch.Text.Length >= 4)
            {
                pictureBox6.Image = Properties.Resources.gal;
                Enable++;
            }
            else
                pictureBox6.Image = Properties.Resources.krest;
            if (Regex.IsMatch(tbLogin.Text, patLogin, RegexOptions.IgnoreCase) & tbLogin.Text.Length >= 4)
            {
                pictureBox2.Image = Properties.Resources.gal;
                Enable++;
            }
            else
                pictureBox2.Image = Properties.Resources.krest;
            if (Regex.IsMatch(tb_Pochta.Text, patEmail, RegexOptions.IgnoreCase))
            {
                pictureBox1.Image = Properties.Resources.gal;
                Enable++;
            }
            else
                pictureBox1.Image = Properties.Resources.krest;
            if (tbPass.Text.Equals(tbRepeatPass.Text))
            {
                if (Regex.IsMatch(tbPass.Text, patPassword, RegexOptions.IgnoreCase) & tbPass.Text.Length >= 4)
                {
                    pictureBox3.Image = Properties.Resources.gal;
                    Enable++;
                }
                else
                    pictureBox3.Image = Properties.Resources.krest;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
                pictureBox3.Image = Properties.Resources.krest;
            }
            if (Enable == 6)
                btReg.Enabled = true;
            else
                btReg.Enabled = false;
        }

        private void btGlaz_MouseDown(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = false;
            tbRepeatPass.UseSystemPasswordChar = false;
        }

        private void btGlaz_MouseUp(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
            tbRepeatPass.UseSystemPasswordChar = true;
        }

        private void tbOtch_Click(object sender, EventArgs e)
        {
            tbOtch.Text = "";
        }

        private void tbOtch_Leave(object sender, EventArgs e)
        {
            if (tbOtch.Text == "")
                tbOtch.Text = "Нет данных";
        }

        private void tb_Fam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
    }
}
