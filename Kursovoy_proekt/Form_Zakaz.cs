using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Kursovoy_proekt
{
    public partial class Form_Zakaz : Form
    {
        IniFiles IF = new IniFiles();
        DynamicObjects classDynamics = new DynamicObjects();
        int i;
        Image Daewoo_Stir = Properties.Resources.Daewoo_Stir;
        Image Daewoo_TV = Properties.Resources.Daewoo_TV;
        Image Daewoo_Micro = Properties.Resources.Micro_Daewoo;
        Image LG_Stir = Properties.Resources.LG_Stir;
        Image LG_TV = Properties.Resources.LG_TV;
        Image LG_Micro = Properties.Resources.LG_Micro;
        Image Samsung_Stir = Properties.Resources.Samsung_Stir;
        Image Samsung_TV = Properties.Resources.Samsung_TV;
        Image Samsung_Micro = Properties.Resources.Samsung_micro;
        public Form_Zakaz()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnZakaz.Enabled = false;
            cmbPostavshik.Enabled = false;
            btnDelete.Enabled = false;
            if (this.Width == 920 & this.Width != 1220)
            {
                timer1.Enabled = true;
                i = 0;
            }
            if (cmbPostavshik.SelectedIndex == 0)
            {
                pbStir.BackgroundImage = Samsung_Stir;
                pbMicrovolnovka.BackgroundImage = Samsung_Micro;
                pbTelevizor.BackgroundImage = Samsung_TV;
                Show();
            }
            else if (cmbPostavshik.SelectedIndex == 1)
            {
                pbStir.BackgroundImage = LG_Stir;
                pbMicrovolnovka.BackgroundImage = LG_Micro;
                pbTelevizor.BackgroundImage = LG_TV;
                Show();
            }
            else if (cmbPostavshik.SelectedIndex == 2)
            {
                pbStir.BackgroundImage = Daewoo_Stir;
                pbMicrovolnovka.BackgroundImage = Daewoo_Micro;
                pbTelevizor.BackgroundImage = Daewoo_TV;
                Show();
            }
        }

        private void Form_Zakaz_Load(object sender, EventArgs e)
        {
            pnlZaliv.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            Thread thread1 = new Thread(cmbID_Name_PostavshikFill);
            thread1.Start();
        }

        public void cmbID_Name_PostavshikFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Postavshik = new DataBaseTables();
                    tables_Postavshik.dtPostavshikFill();
                    cmbPostavshik.DataSource = tables_Postavshik.dtPostavshik;
                    cmbPostavshik.DisplayMember = "Postavshik";
                    cmbPostavshik.ValueMember = "Naimenovanie_Postavshik";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled & this.Width != 1220 & i == 0)
            {
                this.Width += 10;
                if (this.Width == 920)
                {
                    timer1.Enabled = false;
                    button1.Enabled = true;
                }
            }
            if (timer1.Enabled & this.Width != 920 & i == 1)
            {
                this.Width -= 10;
                if (this.Width == 920)
                {
                    timer1.Enabled = false;
                    button1.Enabled = true;
                }
            }
        }

        private void rbTelevizor_CheckedChanged(object sender, EventArgs e)
        {
            if (pbTelevizor.BackgroundImage == Samsung_TV)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Телевизор Samsung \"U49V870VKE\"");
            }
            else if (pbTelevizor.BackgroundImage == LG_TV)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Телевизор LG \"32LG500V\"");
            }
            else if (pbTelevizor.BackgroundImage == Daewoo_TV)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Телевизор Daewoo \"KDL-32WD756\"");
            }
            if (this.Width == 1220 & this.Width != 920)
            {
                timer1.Enabled = true;
                i = 1;
            }
            button1.Enabled = true;
            cmbPostavshik.Enabled = true;
            btnZakaz.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void rbStir_CheckedChanged(object sender, EventArgs e)
        {
            if (pbStir.BackgroundImage == Samsung_Stir)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Стиральная машина Samsung \"QuickDrive WW8800M\"");
            }
            else if (pbStir.BackgroundImage == LG_Stir)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Стиральная машина LG \"F-1096\"");
            }
            else if (pbStir.BackgroundImage == Daewoo_Stir)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Стиральная машина Daewoo \"DW-K500C\"");
            }
            if (this.Width == 1220 & this.Width != 920)
            {
                timer1.Enabled = true;
                i = 1;
            }
            button1.Enabled = true;
            cmbPostavshik.Enabled = true;
            btnZakaz.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void rbMicro_CheckedChanged(object sender, EventArgs e)
        {
            if (pbMicrovolnovka.BackgroundImage == Samsung_Micro)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Микроволновка Samsung \"MS23K3515AS\"");
            }
            else if (pbMicrovolnovka.BackgroundImage == LG_Micro)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Микроволновка LG \"MW-23R\"");
            }
            else if (pbMicrovolnovka.BackgroundImage == Daewoo_Micro)
            {
                lbSpisok.Items.Clear();
                lbSpisok.Items.Insert(0, "Микроволновка Daewoo \"KOR-5A17\"");
            }
            if (this.Width == 1220 & this.Width != 920)
            {
                timer1.Enabled = true;
                i = 1;
            }
            button1.Enabled = true;
            cmbPostavshik.Enabled = true;
            btnZakaz.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = Form_Authorize.Login;
            int rowNumber = dgvZakaz_tovar.Rows.Add();
            DBProcedures procedure = new DBProcedures();
            if (cmbPostavshik.Text != "" || lbSpisok.Items[0] != null ||
                nudKolTovara.Value != 0 || tbAdresPostavki.Text != "")
            {
                procedure.spZakazany_tovary_Insert("Отправка компанией", Convert.ToInt32(nudKolTovara.Value), Login, 2);
                procedure.spSoprovoditelny_document_Insert("ул.Мировая,д 19", tbAdresPostavki.Text, cmbPostavshik.SelectedIndex + 1);
                dgvZakaz_tovar.Rows[rowNumber].Cells[0].Value = rowNumber;
                dgvZakaz_tovar.Rows[rowNumber].Cells[1].Value = cmbPostavshik.SelectedValue.ToString();
                dgvZakaz_tovar.Rows[rowNumber].Cells[2].Value = lbSpisok.Items[0].ToString();
                dgvZakaz_tovar.Rows[rowNumber].Cells[3].Value = nudKolTovara.Value.ToString();
                dgvZakaz_tovar.Rows[rowNumber].Cells[4].Value = tbAdresPostavki.Text;
                MessageBox.Show("Заказ товара выполнен успешно", "Заказ товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Одно или несколько из полей не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbSpisok.Items.Clear();
        }
    }
}
