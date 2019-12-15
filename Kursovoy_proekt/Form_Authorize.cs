using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DLLConnectionString;

namespace Kursovoy_proekt
{
    public partial class Form_Authorize : Form
    {
        public static SQLCon con = new SQLCon();
        public static byte Role_ID;
        public static SqlCommand command = new SqlCommand("", Registry_Class.sql);
        public enum Role {Failed, Director, Klient, Admin, Menedjer_po_zak, Menedjer_po_prodajam, Buhgalter, Kladovshik};
        public static Role role;
        public static string Login;

        public Form_Authorize()
        {
            InitializeComponent();
            tbPass.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Registration Form_Reg = new Form_Registration();
            this.Hide();
            Form_Reg.ShowDialog();
        }

        private void btVhod_Click(object sender, EventArgs e)
        {
            Get_Authorize();
        }

        private void Form_Authorize_Load(object sender, EventArgs e)
        {
            Registry_Class reg = new Registry_Class();
            reg.Registry_Set(con.DS, con.DSSN, con.IC, con.ID, con.PSWRD);
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        public static Role Get_Role(string login, string password)
        {
            Registry_Class reg = new Registry_Class();
            Role role = Role.Failed;
            reg.Registry_Get();
            SqlCommand command = new SqlCommand("Select [Role_ID] From Account WHERE Login_Account=@Login_Account AND Parol_account=@Parol_Account", Registry_Class.sql);
            Registry_Class.sql.Open();
            command.Parameters.AddWithValue("@Login_Account", login);
            command.Parameters.AddWithValue("@Parol_Account", password);
                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        switch ((int)dataReader["Role_ID"])
                        {
                            case 1: role = Role.Director; break;
                            case 2: role = Role.Menedjer_po_zak; break;
                            case 3: role = Role.Menedjer_po_prodajam; break;
                            case 4: role = Role.Buhgalter;break;
                            case 5: role = Role.Kladovshik;break;
                            case 6: role = Role.Klient; break;
                            case 7: role = Role.Admin;break;
                        }
                    }
                }
            Registry_Class.sql.Close();
            return role;
        }

        private void Get_Authorize()
        {
            role = Get_Role(tbLogin.Text,Form_Registration.Hash(tbPass.Text));
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации");
            }
            else
            {
                if (role == Role.Director)
                {
                    MessageBox.Show("Вы авторизовались, как \"Директор\"", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Main main = new Form_Main();
                    main.Show();
                }
                else if (role == Role.Klient)
                {
                    Login = tbLogin.Text;
                    MessageBox.Show("Вы авторизовались, как \"Клиент\"", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Zakaz form_Zakaz = new Form_Zakaz();
                    form_Zakaz.Show();
                }
                else if (role == Role.Admin)
                {
                    Login = tbLogin.Text;
                    MessageBox.Show("Вы авторизовались, как \"Админ\"", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Main main = new Form_Main();
                    main.Show();
                }
                else if (role == Role.Menedjer_po_prodajam)
                {
                    MessageBox.Show("Вы авторизовались, как \"Менеджер по продажам\"", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Main main = new Form_Main();
                    main.Show();
                }
                else if (role == Role.Menedjer_po_zak)
                {
                    MessageBox.Show("Вы авторизовались, как \"Менеджер по закупкам\"", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Main main = new Form_Main();
                    main.Show();
                }
                else if (role == Role.Buhgalter)
                {
                    MessageBox.Show("Вы авторизовались, как \"Бухгалтер\"", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Main main = new Form_Main();
                    main.Show();
                }
                else if (role == Role.Kladovshik)
                {
                    MessageBox.Show("Вы авторизовались, как \"Кладовщик\"", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Main main = new Form_Main();
                    main.Show();
                }
            }
        }

        private void btGlaz_MouseUp(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }

        private void btGlaz_MouseDown(object sender, MouseEventArgs e)
        {
            tbPass.UseSystemPasswordChar = false;
        }
    }
}
