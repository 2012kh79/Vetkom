using System.Windows.Forms;
using System.Drawing;

namespace Kursovoy_proekt
{
    class DynamicObjects
    {
        IniFiles IF = new IniFiles();
        public Form Form_otchet = new Form();
        public Label lblData_postupleniya = new Label();
        public Label lblNomer_tovar = new Label();
        public Panel pnlTextBox = new Panel();
        public MaskedTextBox mtbData_postupleniya = new MaskedTextBox();
        public ComboBox cmbID_Tovar = new ComboBox();

        public void Form_Otchet_Fill()
        {
            lblData_postupleniya.Size = new Size(150, 20);
            lblData_postupleniya.Text = "Дата поступления";
            lblData_postupleniya.Location = new Point(30, 5);
            lblData_postupleniya.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblData_postupleniya);

            lblNomer_tovar.Size = new Size(150, 20);
            lblNomer_tovar.Text = "Номер товара";
            lblNomer_tovar.Location = new Point(30, 55);
            lblNomer_tovar.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomer_tovar);

            mtbData_postupleniya.Size = new Size(150, 20);
            mtbData_postupleniya.Location = new Point(30, 25);
            mtbData_postupleniya.Mask = "00/00/0000";
            pnlTextBox.Controls.Add(mtbData_postupleniya);

            cmbID_Tovar.Size = new Size(150, 20);
            cmbID_Tovar.Location = new Point(30, 75);
            pnlTextBox.Controls.Add(cmbID_Tovar);

            pnlTextBox.Size = new Size(200, 120);
            pnlTextBox.Location = new Point(10, 375);
            pnlTextBox.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            pnlTextBox.BorderStyle = BorderStyle.Fixed3D;
            Form_otchet.Controls.Add(pnlTextBox);
        }

        public Label lblF_gruz = new Label();
        public Label lblI_gruz = new Label();
        public Label lblO_gruz = new Label();
        public Label lblNomer_tovar_TTN = new Label();
        public TextBox tbF_gruz = new TextBox();
        public TextBox tbI_gruz = new TextBox();
        public TextBox tbO_gruz = new TextBox();
        public ComboBox cmbID_Tovar_TTN = new ComboBox();

        public void Form_TTN_Fill()
        {
            lblF_gruz.Size = new Size(170, 20);
            lblF_gruz.Text = "Фамилия грузоотправителя";
            lblF_gruz.Location = new Point(30, 5);
            lblF_gruz.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblF_gruz);

            lblI_gruz.Size = new Size(150, 20);
            lblI_gruz.Text = "Имя грузоотправителя";
            lblI_gruz.Location = new Point(30, 55);
            lblI_gruz.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblI_gruz);

            lblO_gruz.Size = new Size(200, 20);
            lblO_gruz.Text = "Отчество грузоотправителя";
            lblO_gruz.Location = new Point(30, 105);
            lblO_gruz.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblO_gruz);

            lblNomer_tovar_TTN.Size = new Size(150, 20);
            lblNomer_tovar_TTN.Text = "Номер товара";
            lblNomer_tovar_TTN.Location = new Point(200, 5);
            lblNomer_tovar_TTN.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblNomer_tovar_TTN);

            tbF_gruz.Size = new Size(150, 20);
            tbF_gruz.Location = new Point(30, 25);
            pnlTextBox.Controls.Add(tbF_gruz);

            tbI_gruz.Size = new Size(150, 20);
            tbI_gruz.Location = new Point(30, 75);
            pnlTextBox.Controls.Add(tbI_gruz);

            tbO_gruz.Size = new Size(150, 20);
            tbO_gruz.Location = new Point(30, 125);
            pnlTextBox.Controls.Add(tbO_gruz);

            cmbID_Tovar_TTN.Size = new Size(150, 20);
            cmbID_Tovar_TTN.Location = new Point(200, 25);
            pnlTextBox.Controls.Add(cmbID_Tovar_TTN);

            pnlTextBox.Size = new Size(380, 170);
            pnlTextBox.Location = new Point(10, 375);
            pnlTextBox.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            pnlTextBox.BorderStyle = BorderStyle.Fixed3D;
            Form_otchet.Controls.Add(pnlTextBox);
        }

        public Label lblF_otv = new Label();
        public Label lblI_otv = new Label();
        public Label lblO_otv = new Label();
        public Label lblRashod = new Label();
        public Label lblPrihod = new Label();
        public Label lblID_Sort_JUDTNS = new Label();
        public TextBox tbF_otv = new TextBox();
        public TextBox tbI_otv = new TextBox();
        public TextBox tbO_otv = new TextBox();
        public TextBox tbRashod = new TextBox();
        public TextBox tbPrihod = new TextBox();
        public ComboBox cmbID_Sort_JUDTNS = new ComboBox();

        public void Form_JUDTNS_Fill()
        {
            lblF_otv.Size = new Size(170, 20);
            lblF_otv.Text = "Фамилия ответственного";
            lblF_otv.Location = new Point(30, 5);
            lblF_otv.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblF_otv);

            lblI_otv.Size = new Size(150, 20);
            lblI_otv.Text = "Имя ответственного";
            lblI_otv.Location = new Point(30, 55);
            lblI_otv.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblI_otv);

            lblO_otv.Size = new Size(170, 20);
            lblO_otv.Text = "Отчество ответственного";
            lblO_otv.Location = new Point(30, 105);
            lblO_otv.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblO_otv);

            lblRashod.Size = new Size(150, 20);
            lblRashod.Text = "Расходы";
            lblRashod.Location = new Point(200, 5);
            lblRashod.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblRashod);

            lblPrihod.Size = new Size(150, 20);
            lblPrihod.Text = "Приход";
            lblPrihod.Location = new Point(200, 55);
            lblPrihod.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblPrihod);

            lblID_Sort_JUDTNS.Size = new Size(200, 20);
            lblID_Sort_JUDTNS.Text = "Номер сортированного товара";
            lblID_Sort_JUDTNS.Location = new Point(200, 105);
            lblID_Sort_JUDTNS.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblID_Sort_JUDTNS);

            tbF_otv.Size = new Size(150, 20);
            tbF_otv.Location = new Point(30, 25);
            pnlTextBox.Controls.Add(tbF_otv);

            tbI_otv.Size = new Size(150, 20);
            tbI_otv.Location = new Point(30, 75);
            pnlTextBox.Controls.Add(tbI_otv);

            tbO_otv.Size = new Size(150, 20);
            tbO_otv.Location = new Point(30, 125);
            pnlTextBox.Controls.Add(tbO_otv);

            tbRashod.Size = new Size(150, 20);
            tbRashod.Location = new Point(200, 25);
            pnlTextBox.Controls.Add(tbRashod);

            tbPrihod.Size = new Size(150, 20);
            tbPrihod.Location = new Point(200, 75);
            pnlTextBox.Controls.Add(tbPrihod);

            cmbID_Sort_JUDTNS.Size = new Size(150, 20);
            cmbID_Sort_JUDTNS.Location = new Point(200, 125);
            pnlTextBox.Controls.Add(cmbID_Sort_JUDTNS);

            pnlTextBox.Size = new Size(400, 170);
            pnlTextBox.Location = new Point(10, 375);
            pnlTextBox.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            pnlTextBox.BorderStyle = BorderStyle.Fixed3D;
            Form_otchet.Controls.Add(pnlTextBox);
        }

        public Label lblF_buh = new Label();
        public Label lblI_buh = new Label();
        public Label lblO_buh = new Label();
        public Label lblData_form = new Label();
        public Label lblID_JUDTNS_Spros = new Label();
        public Label lblID_Zakaz_Spros = new Label();
        public TextBox tbF_buh = new TextBox();
        public TextBox tbI_buh = new TextBox();
        public TextBox tbO_buh = new TextBox();
        public MaskedTextBox mtbData_form_otcheta = new MaskedTextBox();
        public ComboBox cmbID_JUDTNS_Spros = new ComboBox();
        public ComboBox cmbID_Zakaz_Spros = new ComboBox();

        public void Form_Spros_Fill()
        {
            lblF_buh.Size = new Size(170, 20);
            lblF_buh.Text = "Фамилия бухгалтера";
            lblF_buh.Location = new Point(30, 5);
            lblF_buh.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblF_buh);

            lblI_buh.Size = new Size(150, 20);
            lblI_buh.Text = "Имя бухгалтера";
            lblI_buh.Location = new Point(30, 55);
            lblI_buh.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblI_buh);

            lblO_buh.Size = new Size(170, 20);
            lblO_buh.Text = "Отчество бухгалтера";
            lblO_buh.Location = new Point(30, 105);
            lblO_buh.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblO_buh);

            lblData_form.Size = new Size(150, 20);
            lblData_form.Text = "Дата формирования отчёта";
            lblData_form.Location = new Point(200, 5);
            lblData_form.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblData_form);

            lblID_JUDTNS_Spros.Size = new Size(170, 20);
            lblID_JUDTNS_Spros.Text = "Номер записи в ЖУДТНС";
            lblID_JUDTNS_Spros.Location = new Point(200, 55);
            lblID_JUDTNS_Spros.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblID_JUDTNS_Spros);

            lblID_Zakaz_Spros.Size = new Size(200, 20);
            lblID_Zakaz_Spros.Text = "Номер заказанного товара";
            lblID_Zakaz_Spros.Location = new Point(200, 105);
            lblID_Zakaz_Spros.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblID_Zakaz_Spros);

            tbF_buh.Size = new Size(150, 20);
            tbF_buh.Location = new Point(30, 25);
            pnlTextBox.Controls.Add(tbF_buh);

            tbI_buh.Size = new Size(150, 20);
            tbI_buh.Location = new Point(30, 75);
            pnlTextBox.Controls.Add(tbI_buh);

            tbO_buh.Size = new Size(150, 20);
            tbO_buh.Location = new Point(30, 125);
            pnlTextBox.Controls.Add(tbO_buh);

            mtbData_form_otcheta.Size = new Size(150, 20);
            mtbData_form_otcheta.Location = new Point(200, 25);
            mtbData_form_otcheta.Mask = "00/00/0000";
            pnlTextBox.Controls.Add(mtbData_form_otcheta);

            cmbID_Zakaz_Spros.Size = new Size(150, 20);
            cmbID_Zakaz_Spros.Location = new Point(200, 125);
            pnlTextBox.Controls.Add(cmbID_Zakaz_Spros);

            cmbID_JUDTNS_Spros.Size = new Size(150, 20);
            cmbID_JUDTNS_Spros.Location = new Point(200, 75);
            pnlTextBox.Controls.Add(cmbID_JUDTNS_Spros);

            pnlTextBox.Size = new Size(400, 170);
            pnlTextBox.Location = new Point(10, 375);
            pnlTextBox.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            pnlTextBox.BorderStyle = BorderStyle.Fixed3D;
            Form_otchet.Controls.Add(pnlTextBox);
        }
        public Label lblAdres_post = new Label();
        public Label lblAdres_zakaz = new Label();
        public Label lblID_Postavshik = new Label();
        public TextBox tbAdres_post = new TextBox();
        public TextBox tbAdres_zakaz = new TextBox();
        public ComboBox cmbID_Postavshik_Sopr = new ComboBox();

        public void Form_Sopr_Fill()
        {
            lblAdres_post.Size = new Size(120, 20);
            lblAdres_post.Text = "Адрес поставщика";
            lblAdres_post.Location = new Point(30, 5);
            lblAdres_post.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblAdres_post);

            lblAdres_zakaz.Size = new Size(120, 20);
            lblAdres_zakaz.Text = "Адрес заказчика";
            lblAdres_zakaz.Location = new Point(30, 55);
            lblAdres_zakaz.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblAdres_zakaz);

            lblID_Postavshik.Size = new Size(120, 20);
            lblID_Postavshik.Text = "Номер поставщика";
            lblID_Postavshik.Location = new Point(30, 105);
            lblID_Postavshik.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblID_Postavshik);

            tbAdres_post.Size = new Size(250, 20);
            tbAdres_post.Location = new Point(30, 25);
            pnlTextBox.Controls.Add(tbAdres_post);

            tbAdres_zakaz.Size = new Size(250, 20);
            tbAdres_zakaz.Location = new Point(30, 75);
            pnlTextBox.Controls.Add(tbAdres_zakaz);

            cmbID_Postavshik_Sopr.Size = new Size(250, 20);
            cmbID_Postavshik_Sopr.Location = new Point(30, 125);
            pnlTextBox.Controls.Add(cmbID_Postavshik_Sopr);

            pnlTextBox.Size = new Size(320, 170);
            pnlTextBox.Location = new Point(10, 375);
            pnlTextBox.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            pnlTextBox.BorderStyle = BorderStyle.Fixed3D;
            Form_otchet.Controls.Add(pnlTextBox);
        }
        public Label lblTsena_za_zakaz = new Label();
        public Label lblData_form_shet = new Label();
        public Label lblID_Zakaz = new Label();
        public Label lblID_TTN_Shet = new Label();
        public TextBox tbTsena = new TextBox();
        public MaskedTextBox mtbData_form_shet = new MaskedTextBox();
        public ComboBox cmbID_Zakaz = new ComboBox();
        public ComboBox cmbID_TTN_Shet = new ComboBox();

        public void Form_Shet_Fill()
        {
            lblTsena_za_zakaz.Size = new Size(150, 20);
            lblTsena_za_zakaz.Text = "Цена за заказанный товар";
            lblTsena_za_zakaz.Location = new Point(30, 5);
            lblTsena_za_zakaz.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblTsena_za_zakaz);

            lblAdres_zakaz.Size = new Size(150, 20);
            lblAdres_zakaz.Text = "Дата формирования счёта";
            lblAdres_zakaz.Location = new Point(30, 55);
            lblAdres_zakaz.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblAdres_zakaz);

            lblID_Postavshik.Size = new Size(120, 20);
            lblID_Postavshik.Text = "Номер заказа";
            lblID_Postavshik.Location = new Point(200, 5);
            lblID_Postavshik.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblID_Postavshik);

            lblID_TTN_Shet.Size = new Size(120, 20);
            lblID_TTN_Shet.Text = "Номер ТТН";
            lblID_TTN_Shet.Location = new Point(200, 55);
            lblID_TTN_Shet.Font = new Font("Times New Roman", 10);
            pnlTextBox.Controls.Add(lblID_TTN_Shet);

            tbTsena.Size = new Size(150, 20);
            tbTsena.Location = new Point(30, 25);
            pnlTextBox.Controls.Add(tbTsena);

            mtbData_form_shet.Size = new Size(150, 20);
            mtbData_form_shet.Location = new Point(30, 75);
            mtbData_form_shet.Mask = "00/00/0000";
            pnlTextBox.Controls.Add(mtbData_form_shet);

            cmbID_Zakaz.Size = new Size(120, 20);
            cmbID_Zakaz.Location = new Point(200, 25);
            pnlTextBox.Controls.Add(cmbID_Zakaz);

            cmbID_TTN_Shet.Size = new Size(120, 20);
            cmbID_TTN_Shet.Location = new Point(200, 75);
            pnlTextBox.Controls.Add(cmbID_TTN_Shet);

            pnlTextBox.Size = new Size(350, 120);
            pnlTextBox.Location = new Point(10, 375);
            pnlTextBox.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            pnlTextBox.BorderStyle = BorderStyle.Fixed3D;
            Form_otchet.Controls.Add(pnlTextBox);
        }
    }
}
