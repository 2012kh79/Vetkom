using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kursovoy_proekt
{
    public partial class Form_Kabinet : Form
    {
        IniFiles IF = new IniFiles();
        string Login = Form_Authorize.Login;
        DBProcedures procedure = new DBProcedures();
        DataBaseTables tables = new DataBaseTables();
        string patPassword = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        int Enable;
        public Form_Kabinet()
        {
            InitializeComponent();
            pbAvatar.ImageLocation = IF.Read("Аватарка");
            tbPassword.UseSystemPasswordChar = true;
            tbRepeatPass.UseSystemPasswordChar = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            tbPassword.Enabled = true;
            tbRepeatPass.Enabled = true;
            btnCheck.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            procedure.spAccount_Update(Login, Form_Registration.Hash(tbPassword.Text), 6);
            tbPassword.Text = "";
            tbRepeatPass.Text = "";
            btnUpdate.Enabled = true;
            tbPassword.Enabled = false;
            tbRepeatPass.Enabled = false;
            btnCheck.Enabled = false;
            btnSave.Enabled = false;
            DialogResult result = MessageBox.Show("Изменение пользователя" + Login + "произошло успешно. Чтобы изменения вступили в силу, необходимо перезапустить программу. Завершить?", "Уведомление",MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                Application.ExitThread();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Enable = 0;
            if (tbPassword.Text.Equals(tbRepeatPass.Text))
            {
                if (Regex.IsMatch(tbPassword.Text, patPassword, RegexOptions.IgnoreCase) & tbPassword.Text.Length >= 4)
                {
                    pictureBox1.Image = Properties.Resources.gal;
                    Enable++;
                }
                else
                    pictureBox1.Image = Properties.Resources.krest;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
                pictureBox1.Image = Properties.Resources.krest;
            }
            if (Enable == 1)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void btGlaz_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
            tbRepeatPass.UseSystemPasswordChar = false;
        }

        private void btGlaz_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            tbRepeatPass.UseSystemPasswordChar = true;
        }
    }
}
