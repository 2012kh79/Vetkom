using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Kursovoy_proekt
{
    public partial class Form_Settings : Form
    {
        DynamicObjects classDynamicObject = new DynamicObjects();
        DataBaseTables tables = new DataBaseTables();
        DBProcedures procedure = new DBProcedures();
        IniFiles IF = new IniFiles();
        Form_Kabinet kabinet = new Form_Kabinet();
        Form_Main main = new Form_Main();
        Image Man = Properties.Resources.img_377009;
        Image Woman = Properties.Resources.img_426276;
        int i;
        public Form_Settings()
        {
            InitializeComponent();
        }

        public void dgvAccountFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvAccount.Rows.Count != 0)
                    {
                        dgvAccount.Rows.Remove(dgvAccount.Rows[dgvAccount.Rows.Count - 1]);
                    }
                    tables.dtAccountFill();
                    dgvAccount.DataSource = tables.dtAccount;
                    dgvAccount.Columns[0].HeaderText = "Логин";
                    dgvAccount.Columns[1].HeaderText = "Пароль";
                    dgvAccount.Columns[2].Visible = false;
                    dgvAccount.Columns[3].Visible = false;
                    dgvAccount.Columns[4].HeaderText = "Наименование роли";
                    dgvAccount.Columns[5].HeaderText = "Отчёт";
                    dgvAccount.Columns[6].HeaderText = "Склад";
                    dgvAccount.Columns[7].HeaderText = "Заказ";
                    dgvAccount.Columns[8].HeaderText = "Кабинет";
                    dgvAccount.Columns[9].HeaderText = "Информация о программе";
                    dgvAccount.Columns[10].HeaderText = "Информация об авторе";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbRole_IDFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Role = new DataBaseTables();
                    tables_Role.dtRoleFill();
                    cmbRole_ID.DataSource = tables_Role.dtRole;
                    cmbRole_ID.DisplayMember = "Role";
                    cmbRole_ID.ValueMember = "ID_Role";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            if (Form_Authorize.role == Form_Authorize.Role.Admin)
            {
                btnNazn_Role.Enabled = true;
            }
            Thread thread1 = new Thread(dgvAccountFill);
            Thread thread2 = new Thread(cmbRole_IDFill);
            thread1.Start();
            thread2.Start();
            pictureBox1.BackgroundImage = Man;
            pictureBox2.BackgroundImage = Woman;
            btnNazn_Role.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            rbOrange.Checked = Convert.ToBoolean(IF.Read("rbOrange.Checked"));
            rbLiteGreen.Checked = Convert.ToBoolean(IF.Read("rbLiteGreen.Checked"));
            rbLiteBlue.Checked = Convert.ToBoolean(IF.Read("rbLiteBlue.Checked"));
            rbMan.Checked = Convert.ToBoolean(IF.Read("rbMan.Checked"));
            rbWoman.Checked = Convert.ToBoolean(IF.Read("rbWoman.Checked"));
        }

        private void Form_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            IF.Write("rbOrange.Checked", rbOrange.Checked.ToString());
            IF.Write("rbLiteGreen.Checked", rbLiteGreen.Checked.ToString());
            IF.Write("rbLiteBlue.Checked", rbLiteBlue.Checked.ToString());
            IF.Write("rbMan.Checked", rbMan.Checked.ToString());
            IF.Write("rbWoman.Checked", rbWoman.Checked.ToString());
            IF.Write("Цвет панелей", classDynamicObject.pnlTextBox.BackColor.Name);
            IF.Write("Аватарка", kabinet.pbAvatar.ImageLocation);
            kabinet.pbAvatar.ImageLocation = IF.Read("Аватарка");
            main.Show();
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            classDynamicObject.pnlTextBox.BackColor = Color.Orange;
        }

        private void rbLiteGreen_CheckedChanged(object sender, EventArgs e)
        {
            classDynamicObject.pnlTextBox.BackColor = Color.Lime;
        }

        private void rbLiteBlue_CheckedChanged(object sender, EventArgs e)
        {
            classDynamicObject.pnlTextBox.BackColor = Color.Aquamarine;
        }

        private void rbMan_CheckedChanged(object sender, EventArgs e)
        {
            kabinet.pbAvatar.BackgroundImage = Man;
        }

        private void rbWoman_CheckedChanged(object sender, EventArgs e)
        {
            kabinet.pbAvatar.BackgroundImage = Woman;
        }

        private void btnNazn_Role_Click(object sender, EventArgs e)
        {
            if (this.Width == 365 & this.Width != 935)
            {
                timer1.Enabled = true;
                i = 0;
            }

            if (this.Width == 935 & this.Width != 365)
            {
                timer1.Enabled = true;
                i = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled & this.Width != 935 & i == 0)
            {
                this.Width += 5;
                if (this.Width == 935)
                    timer1.Enabled = false;
            }

            if (timer1.Enabled & this.Width != 365 & i == 1)
            {
                this.Width -= 5;
                if (this.Width == 365)
                    timer1.Enabled = false;
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbRole_ID.SelectedValue = dgvAccount.CurrentRow.Cells[3].Value.ToString();
            cbOtchet.Checked = Convert.ToBoolean(dgvAccount.CurrentRow.Cells[5].Value);
            cbSklad.Checked = Convert.ToBoolean(dgvAccount.CurrentRow.Cells[6].Value);
            cbZakaz.Checked = Convert.ToBoolean(dgvAccount.CurrentRow.Cells[7].Value);
            cbKabinet.Checked = Convert.ToBoolean(dgvAccount.CurrentRow.Cells[8].Value);
            cbInf_o_programe.Checked = Convert.ToBoolean(dgvAccount.CurrentRow.Cells[9].Value);
            cbInf_ob_abtore.Checked = Convert.ToBoolean(dgvAccount.CurrentRow.Cells[10].Value);
        }

        private void btnUpdate_Role_Click(object sender, EventArgs e)
        {
            procedure.spAccount_Update(dgvAccount.CurrentRow.Cells[0].Value.ToString(), dgvAccount.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(cmbRole_ID.SelectedValue.ToString()));
            dgvAccountFill();
        }

        private void Settings_Base_Click(object sender, EventArgs e)
        {
            Form_Connection form_Connection = new Form_Connection();
            form_Connection.Show();
        }
    }
}
