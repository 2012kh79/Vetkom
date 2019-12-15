using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Kursovoy_proekt
{
    public partial class Form_Sklad : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DBProcedures procedure = new DBProcedures();
        IniFiles IF = new IniFiles();
        string patData = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d";
        public Form_Sklad()
        {
            InitializeComponent();
        }

        public void dgvTovary_PostFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvTovary_Post.Rows.Count != 0)
                    {
                        dgvTovary_Post.Rows.Remove(dgvTovary_Post.Rows[dgvTovary_Post.Rows.Count - 1]);
                    }
                    tables.dtTovarFill();
                    dgvTovary_Post.DataSource = tables.dtTovar;
                    dgvTovary_Post.Columns[0].HeaderText = "Номер записи";
                    dgvTovary_Post.Columns[1].HeaderText = "Название товара";
                    dgvTovary_Post.Columns[2].HeaderText = "Дата производства";
                    dgvTovary_Post.Columns[3].Visible = false;
                    dgvTovary_Post.Columns[4].Visible = false;
                    dgvTovary_Post.Columns[5].HeaderText = "Наименование поставщика";
                    dgvTovary_Post.Columns[6].HeaderText = "ИНН";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvTovary_ProverkaFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvTPP.Rows.Count != 0)
                    {
                        dgvTPP.Rows.Remove(dgvTPP.Rows[dgvTPP.Rows.Count - 1]);
                    }
                    tables.dtTPPFill();
                    dgvTPP.DataSource = tables.dtTovary_prosh_proverku;
                    dgvTPP.Columns[0].HeaderText = "Номер записи";
                    dgvTPP.Columns[1].HeaderText = "Дата оценки";
                    dgvTPP.Columns[2].HeaderText = "Время оценки";
                    dgvTPP.Columns[3].HeaderText = "Количество товара";
                    dgvTPP.Columns[4].Visible = false;
                    dgvTPP.Columns[5].Visible = false;
                    dgvTPP.Columns[6].Visible = false;
                    dgvTPP.Columns[7].HeaderText = "Название товара";
                    dgvTPP.Columns[8].HeaderText = "Дата производства";
                    dgvTPP.Columns[9].Visible = false;
                    dgvTPP.Columns[10].HeaderText = "Подлинность";
                    dgvTPP.Columns[11].HeaderText = "ФИО проверяющего";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvTovary_SortirovanyFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvSort.Rows.Count != 0)
                    {
                        dgvSort.Rows.Remove(dgvSort.Rows[dgvSort.Rows.Count - 1]);
                    }
                    tables.dtSortFill();
                    dgvSort.DataSource = tables.dtSort_tovary;
                    dgvSort.Columns[0].HeaderText = "Номер записи";
                    dgvSort.Columns[1].HeaderText = "Область применения";
                    dgvSort.Columns[2].HeaderText = "Наименование склада";
                    dgvSort.Columns[3].HeaderText = "Срок хранения от";
                    dgvSort.Columns[4].HeaderText = "Срок хранения до";
                    dgvSort.Columns[5].Visible = false;
                    dgvSort.Columns[6].Visible = false;
                    dgvSort.Columns[7].HeaderText = "Дата оценки";
                    dgvSort.Columns[8].HeaderText = "Время оценки";
                    dgvSort.Columns[9].HeaderText = "Количество товара";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvTovary_ZakazFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvZakaz.Rows.Count != 0)
                    {
                        dgvZakaz.Rows.Remove(dgvZakaz.Rows[dgvZakaz.Rows.Count - 1]);
                    }
                    tables.dtZakazFill();
                    dgvZakaz.DataSource = tables.dtZakazany_tovary;
                    dgvZakaz.Columns[0].HeaderText = "Номер записи";
                    dgvZakaz.Columns[1].HeaderText = "Способ доставки";
                    dgvZakaz.Columns[2].HeaderText = "Количество заказанного товара";
                    dgvZakaz.Columns[3].Visible = false;
                    dgvZakaz.Columns[4].Visible = false;
                    dgvZakaz.Columns[5].Visible = false;
                    dgvZakaz.Columns[6].HeaderText = "Область применения";
                    dgvZakaz.Columns[7].HeaderText = "Наименование склада";
                    dgvZakaz.Columns[8].HeaderText = "Срок хранения от";
                    dgvZakaz.Columns[9].HeaderText = "Срок хранения до";
                    dgvZakaz.Columns[10].Visible = false;
                    dgvZakaz.Columns[11].HeaderText = "ФИО клиента";
                    dgvZakaz.Columns[12].HeaderText = "Mail";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvTovary_KomplFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgv_Kompl.Rows.Count != 0)
                    {
                        dgv_Kompl.Rows.Remove(dgv_Kompl.Rows[dgv_Kompl.Rows.Count - 1]);
                    }
                    tables.dtKomplFill();
                    dgv_Kompl.DataSource = tables.dtUkomplektovany_tovar;
                    dgv_Kompl.Columns[0].HeaderText = "Номер записи";
                    dgv_Kompl.Columns[1].HeaderText = "Дата комплектации";
                    dgv_Kompl.Columns[2].Visible = false;
                    dgv_Kompl.Columns[3].Visible = false;
                    dgv_Kompl.Columns[4].Visible = false;
                    dgv_Kompl.Columns[5].HeaderText = "Способ доставки";
                    dgv_Kompl.Columns[6].HeaderText = "Количество заказанного товара";
                    dgv_Kompl.Columns[7].Visible = false;
                    dgv_Kompl.Columns[8].HeaderText = "Адрес поставщика";
                    dgv_Kompl.Columns[9].HeaderText = "Адрес заказчика";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvTovary_PerFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvPeredan.Rows.Count != 0)
                    {
                        dgvPeredan.Rows.Remove(dgvPeredan.Rows[dgvPeredan.Rows.Count - 1]);
                    }
                    tables.dtPeredany_tovarFill();
                    dgvPeredan.DataSource = tables.dtPeredany_tovar;
                    dgvPeredan.Columns[0].HeaderText = "Номер записи";
                    dgvPeredan.Columns[1].HeaderText = "Дата передачи";
                    dgvPeredan.Columns[2].HeaderText = "Время передачи";
                    dgvPeredan.Columns[3].Visible = false;
                    dgvPeredan.Columns[4].Visible = false;
                    dgvPeredan.Columns[5].Visible = false;
                    dgvPeredan.Columns[6].HeaderText = "Дата комплектации";
                    dgvPeredan.Columns[7].Visible = false;
                    dgvPeredan.Columns[8].HeaderText = "Дата формирования счёта";
                    dgvPeredan.Columns[9].HeaderText = "Цена за заказанный товар";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void Form_Sklad_Load(object sender, EventArgs e)
        {
            tpTovary_post.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            tpTPP.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            tpSort.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            tpZakaz.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            tpKompl.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            tpPeredan.BackColor = Color.FromName(IF.Read("Цвет панелей"));
            Thread threadPost = new Thread(dgvTovary_PostFill);
            threadPost.Start();
            Thread threadProverka = new Thread(dgvTovary_ProverkaFill);
            threadProverka.Start();
            Thread threadSort = new Thread(dgvTovary_SortirovanyFill);
            threadSort.Start();
            Thread threadZakaz = new Thread(dgvTovary_ZakazFill);
            threadZakaz.Start();
            Thread threadUkompl = new Thread(dgvTovary_KomplFill);
            threadUkompl.Start();
            Thread threadPeredan = new Thread(dgvTovary_PerFill);
            threadPeredan.Start();
            Thread thread1 = new Thread(cmbID_Tovar_PostavshikFill);
            thread1.Start();
            Thread thread2 = new Thread(cmbID_Kompl_SoprFill);
            thread2.Start();
            Thread thread3 = new Thread(cmbID_Kompl_ZakazFill);
            thread3.Start();
            Thread thread4 = new Thread(cmbID_Peredan_KomplFill);
            thread4.Start();
            Thread thread5 = new Thread(cmbID_Peredan_ShetFill);
            thread5.Start();
            Thread thread6 = new Thread(cmbID_Prosh_SertificatFill);
            thread6.Start();
            Thread thread7 = new Thread(cmbID_Prosh_TovarFill);
            thread7.Start();
            Thread thread8 = new Thread(cmbID_Sort_TPPFill);
            thread8.Start();
            Thread thread9 = new Thread(cmbID_Zakaz_LoginFill);
            thread9.Start();
            Thread thread10 = new Thread(cmbID_Zakaz_SortFill);
            thread10.Start();
            Thread thread11 = new Thread(cmbSposob_dostavkiFill);
            thread11.Start();
            Thread thread12 = new Thread(cmbNaim_SkladFill);
            thread12.Start();
        }

        private void dgvTovary_Post_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNazv_tovar.Text = dgvTovary_Post.CurrentRow.Cells[1].Value.ToString();
            mtbData_proizv.Text = dgvTovary_Post.CurrentRow.Cells[2].Value.ToString();
            cmbPostavshik_ID.SelectedValue = dgvTovary_Post.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvTPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbData_otsenky.Text = dgvTPP.CurrentRow.Cells[1].Value.ToString();
            mtbVremya_otsenky.Text = dgvTPP.CurrentRow.Cells[2].Value.ToString();
            nudKol_tovar.Text = dgvTPP.CurrentRow.Cells[3].Value.ToString();
            cmbTovar_ID.SelectedValue = dgvTPP.CurrentRow.Cells[6].Value.ToString();
            cmbSertificat_ID.SelectedValue = dgvTPP.CurrentRow.Cells[9].Value.ToString();
        }

        private void dgvSort_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbOblast.Text = dgvSort.CurrentRow.Cells[1].Value.ToString();
            mtbSrok_ot.Text = dgvSort.CurrentRow.Cells[3].Value.ToString();
            mtb_Srok_do.Text = dgvSort.CurrentRow.Cells[4].Value.ToString();
            cmb_Naim_sklad.SelectedValue = dgvSort.CurrentRow.Cells[2].Value.ToString();
            cmbTPP_ID.SelectedValue = dgvSort.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvZakaz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nudKol_zakaz.Text = dgvZakaz.CurrentRow.Cells[2].Value.ToString();
            cmbKlient_Login.SelectedValue = dgvZakaz.CurrentRow.Cells[10].Value.ToString();
            cmbSposob_dostavki.SelectedValue = dgvZakaz.CurrentRow.Cells[1].Value.ToString();
            cmbSort_ID.SelectedValue = dgvZakaz.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgv_Kompl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbData_kompl.Text = dgv_Kompl.CurrentRow.Cells[1].Value.ToString();
            cmbZakaz_ID.SelectedValue = dgv_Kompl.CurrentRow.Cells[4].Value.ToString();
            cmbSopr_ID.SelectedValue = dgv_Kompl.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvPeredan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbData_peredachi.Text = dgvPeredan.CurrentRow.Cells[1].Value.ToString();
            mtbVremya_peredachi.Text = dgvPeredan.CurrentRow.Cells[2].Value.ToString();
            cmb_Kompl.SelectedValue = dgvPeredan.CurrentRow.Cells[5].Value.ToString();
            cmbShet_ID.SelectedValue = dgvPeredan.CurrentRow.Cells[7].Value.ToString();
        }

        public void cmbID_Tovar_PostavshikFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Postavshik = new DataBaseTables();
                    tables_Postavshik.dtPostavshikFill();
                    cmbPostavshik_ID.DataSource = tables_Postavshik.dtPostavshik;
                    cmbPostavshik_ID.DisplayMember = "Postavshik";
                    cmbPostavshik_ID.ValueMember = "ID_Postavshik";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Prosh_TovarFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_tovar = new DataBaseTables();
                    tables_tovar.dtTovarFill();
                    cmbTovar_ID.DataSource = tables_tovar.dtTovar;
                    cmbTovar_ID.DisplayMember = "Tovar";
                    cmbTovar_ID.ValueMember = "ID_Tovar";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Prosh_SertificatFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_sertificat = new DataBaseTables();
                    tables_sertificat.dtSertificatFill();
                    cmbSertificat_ID.DataSource = tables_sertificat.dtSertificat_sootv;
                    cmbSertificat_ID.DisplayMember = "Sertificat_sootv";
                    cmbSertificat_ID.ValueMember = "ID_Sertificat";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Sort_TPPFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_TPP = new DataBaseTables();
                    tables_TPP.dtTPPFill();
                    cmbTPP_ID.DataSource = tables_TPP.dtTovary_prosh_proverku;
                    cmbTPP_ID.DisplayMember = "Tovary_prosh_proverku";
                    cmbTPP_ID.ValueMember = "ID_TPP";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Zakaz_LoginFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Login = new DataBaseTables();
                    tables_Login.dtKlientFill();
                    cmbKlient_Login.DataSource = tables_Login.dtKlient;
                    cmbKlient_Login.DisplayMember = "Klient";
                    cmbKlient_Login.ValueMember = "Login_Klient";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Zakaz_SortFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Sort = new DataBaseTables();
                    tables_Sort.dtSortFill();
                    cmbSort_ID.DataSource = tables_Sort.dtSort_tovary;
                    cmbSort_ID.DisplayMember = "Sort_tovary";
                    cmbSort_ID.ValueMember = "ID_Sort";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Kompl_ZakazFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Zakaz = new DataBaseTables();
                    tables_Zakaz.dtZakazFill();
                    cmbZakaz_ID.DataSource = tables_Zakaz.dtZakazany_tovary;
                    cmbZakaz_ID.DisplayMember = "Zakazany_tovary";
                    cmbZakaz_ID.ValueMember = "ID_Zakaz";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Kompl_SoprFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Sopr = new DataBaseTables();
                    tables_Sopr.dtSoprFill();
                    cmbSopr_ID.DataSource = tables_Sopr.dtSoprovoditelny_document;
                    cmbSopr_ID.DisplayMember = "Soprovoditelny_document";
                    cmbSopr_ID.ValueMember = "ID_Sopr";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Peredan_KomplFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Kompl = new DataBaseTables();
                    tables_Kompl.dtKomplFill();
                    cmb_Kompl.DataSource = tables_Kompl.dtUkomplektovany_tovar;
                    cmb_Kompl.DisplayMember = "Ukomplektovany_tovar";
                    cmb_Kompl.ValueMember = "ID_Kompl";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Peredan_ShetFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Shet = new DataBaseTables();
                    tables_Shet.dtShetFill();
                    cmbShet_ID.DataSource = tables_Shet.dtShet_facture;
                    cmbShet_ID.DisplayMember = "Shet_facture";
                    cmbShet_ID.ValueMember = "ID_Shet";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbSposob_dostavkiFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Sposob = new DataBaseTables();
                    tables_Sposob.dtZakazFill();
                    cmbSposob_dostavki.DataSource = tables_Sposob.dtZakazany_tovary;
                    cmbSposob_dostavki.DisplayMember = "Zakazany_tovary";
                    cmbSposob_dostavki.ValueMember = "Sposob_dostavki";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbNaim_SkladFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Sklad = new DataBaseTables();
                    tables_Sklad.dtSortFill();
                    cmb_Naim_sklad.DataSource = tables_Sklad.dtSort_tovary;
                    cmb_Naim_sklad.DisplayMember = "Sort_tovary";
                    cmb_Naim_sklad.ValueMember = "Naim_sklada";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void btnInsert_Tovary_Post_Click(object sender, EventArgs e)
        {
            if (tbNazv_tovar.Text != "" & mtbData_proizv.Text != String.Empty)
            {
                if (Regex.IsMatch(mtbData_proizv.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spTovar_Insert(tbNazv_tovar.Text, mtbData_proizv.Text, Convert.ToInt32(cmbPostavshik_ID.SelectedValue.ToString()));
                        tbNazv_tovar.Clear();
                        mtbData_proizv.Clear();
                        dgvTovary_PostFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка добавления");
                    }
                }
                else
                    MessageBox.Show("Введите дату производства в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные о товарах от поставщиков", "Ошибка вводимых данных");
        }

        private void btnUpdate_Tovary_Post_Click(object sender, EventArgs e)
        {
            if (tbNazv_tovar.Text != "" & mtbData_proizv.Text != String.Empty)
            {
                if (Regex.IsMatch(mtbData_proizv.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spTovar_Update(Convert.ToInt32(dgvTovary_Post.CurrentRow.Cells[0].Value.ToString()), tbNazv_tovar.Text, mtbData_proizv.Text, Convert.ToInt32(cmbPostavshik_ID.SelectedValue.ToString()));
                        dgvTovary_PostFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения");
                    }
                }
                else
                    MessageBox.Show("Введите дату поступления в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные о товарах от поставщиков", "Ошибка вводимых данных");
        }

        private void btnDelete_Tovary_Post_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись о товаре от поставщика?", "Удаление записи от " + mtbData_proizv.Text, MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spTovar_Delete(Convert.ToInt32(dgvTovary_Post.CurrentRow.Cells[0].Value.ToString()));
                    dgvTovary_PostFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnInsert_TPP_Click(object sender, EventArgs e)
        {
            if (mtbData_otsenky.Text != String.Empty & mtbVremya_otsenky.Text != String.Empty & nudKol_tovar.Value != 0)
            {
                if (Regex.IsMatch(mtbData_otsenky.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spTovary_prosh_proverku_Insert(Convert.ToInt32(nudKol_tovar.Value.ToString()), mtbData_otsenky.Text, mtbVremya_otsenky.Text, Convert.ToInt32(cmbTovar_ID.SelectedValue.ToString()), Convert.ToInt32(cmbSertificat_ID.SelectedValue.ToString()));
                        nudKol_tovar.Value = 0;
                        mtbData_otsenky.Clear();
                        mtbVremya_otsenky.Clear();
                        dgvTovary_ProverkaFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка добавления");
                    }
                }
                else
                    MessageBox.Show("Введите дату оценки в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные о товарах, проешдших проверку", "Ошибка вводимых данных");
        }

        private void btnUpdate_TPP_Click(object sender, EventArgs e)
        {
            if (mtbData_otsenky.Text != String.Empty & mtbVremya_otsenky.Text != String.Empty & nudKol_tovar.Value != 0)
            {
                if (Regex.IsMatch(mtbData_otsenky.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spTovary_prosh_proverku_Update(Convert.ToInt32(dgvTPP.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(nudKol_tovar.Value.ToString()), mtbData_otsenky.Text, mtbVremya_otsenky.Text, Convert.ToInt32(cmbTovar_ID.SelectedValue.ToString()), Convert.ToInt32(cmbSertificat_ID.SelectedValue.ToString()));
                        dgvTovary_ProverkaFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения");
                    }
                }
                else
                    MessageBox.Show("Введите дату оценки в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные о товарах, проешдших проверку", "Ошибка вводимых данных");
        }

        private void btnDelete_TPP_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись о товаре,прошедший проверку?", "Удаление записи от " + mtbData_otsenky.Text, MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spTovary_prosh_proverku_Delete(Convert.ToInt32(dgvTPP.CurrentRow.Cells[0].Value.ToString()));
                    dgvTovary_ProverkaFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnInsert_Sort_Click(object sender, EventArgs e)
        {
            if (mtbSrok_ot.Text != String.Empty & mtb_Srok_do.Text != String.Empty & tbOblast.Text != "")
            {
                if (Regex.IsMatch(mtbSrok_ot.Text, patData, RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(mtb_Srok_do.Text, patData, RegexOptions.IgnoreCase))
                    {
                        try
                        {
                            procedure.spSort_tovary_Insert(tbOblast.Text, cmb_Naim_sklad.SelectedValue.ToString(), mtbSrok_ot.Text, mtb_Srok_do.Text, Convert.ToInt32(cmbTPP_ID.SelectedValue.ToString()));
                            tbOblast.Clear();
                            mtbSrok_ot.Clear();
                            mtb_Srok_do.Clear();
                            dgvTovary_SortirovanyFill();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка добавления");
                        }
                    }
                    else
                        MessageBox.Show("Введите дату срока хранения до в соответствии с форматом даты", "Ошибка вводимых данных");
                }
                else
                    MessageBox.Show("Введите дату срока хранения от в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные о сортированном товаре", "Ошибка вводимых данных");
        }

        private void btnUpdate_Sort_Click(object sender, EventArgs e)
        {
            if (mtbSrok_ot.Text != String.Empty & mtb_Srok_do.Text != String.Empty & tbOblast.Text != "")
            {
                if (Regex.IsMatch(mtbSrok_ot.Text, patData, RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(mtb_Srok_do.Text, patData, RegexOptions.IgnoreCase))
                    {
                        try
                        {
                            procedure.spSort_tovary_Update(Convert.ToInt32(dgvSort.CurrentRow.Cells[0].Value.ToString()),tbOblast.Text, cmb_Naim_sklad.SelectedValue.ToString(), mtbSrok_ot.Text, mtb_Srok_do.Text, Convert.ToInt32(cmbTPP_ID.SelectedValue.ToString()));
                            dgvTovary_SortirovanyFill();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка изменения");
                        }
                    }
                    else
                        MessageBox.Show("Введите дату срока хранения до в соответствии с форматом даты", "Ошибка вводимых данных");
                }
                else
                    MessageBox.Show("Введите дату срока хранения от в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные о сортированном товаре", "Ошибка вводимых данных");
        }

        private void btnDelete_Sort_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись о сортированном товаре?", "Удаление записи", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spSort_tovary_Delete(Convert.ToInt32(dgvSort.CurrentRow.Cells[0].Value.ToString()));
                    dgvTovary_SortirovanyFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnInsert_Zakaz_Click(object sender, EventArgs e)
        {
            if (nudKol_zakaz.Value != 0)
            {
                        try
                        {
                            procedure.spZakazany_tovary_Insert(cmbSposob_dostavki.SelectedValue.ToString(), Convert.ToInt32(nudKol_zakaz.Value.ToString()), cmbKlient_Login.SelectedValue.ToString(), Convert.ToInt32(cmbSort_ID.SelectedValue.ToString()));
                            nudKol_zakaz.Value = 0;
                            dgvTovary_ZakazFill();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка добавления");
                        }
            }
            else
                MessageBox.Show("Заполните данные об заказанном товаре", "Ошибка вводимых данных");
        }

        private void btnUpdate_Zakaz_Click(object sender, EventArgs e)
        {
            if (nudKol_zakaz.Value != 0)
            {
                try
                {
                    procedure.spZakazany_tovary_Update(Convert.ToInt32(dgvZakaz.CurrentRow.Cells[0].Value.ToString()),cmbSposob_dostavki.SelectedValue.ToString(), Convert.ToInt32(nudKol_zakaz.Value.ToString()), cmbKlient_Login.SelectedValue.ToString(), Convert.ToInt32(cmbSort_ID.SelectedValue.ToString()));
                    nudKol_zakaz.Value = 0;
                    dgvTovary_ZakazFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения");
                }
            }
            else
                MessageBox.Show("Заполните данные об заказанном товаре", "Ошибка вводимых данных");
        }

        private void btnDelete_Zakaz_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись о заказанном товаре?", "Удаление записи", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spZakazany_tovary_Delete(Convert.ToInt32(dgvZakaz.CurrentRow.Cells[0].Value.ToString()));
                    dgvTovary_ZakazFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnInsert_Kompl_Click(object sender, EventArgs e)
        {
                if (Regex.IsMatch(mtbData_kompl.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spUkomplektovany_tovar_Insert(mtbData_kompl.Text, Convert.ToInt32(cmbSopr_ID.SelectedValue.ToString()), Convert.ToInt32(cmbZakaz_ID.SelectedValue.ToString()));
                        mtbData_kompl.Text = "";
                        dgvTovary_KomplFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка добавления");
                    }
                }
                else
                    MessageBox.Show("Введите дату комплектации в соответствии с форматом даты", "Ошибка вводимых данных");
        }

        private void btnUpdate_Kompl_Click(object sender, EventArgs e)
        {
                if (Regex.IsMatch(mtbData_kompl.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spUkomplektovany_tovar_Update(Convert.ToInt32(dgv_Kompl.CurrentRow.Cells[0].Value.ToString()), mtbData_kompl.Text, Convert.ToInt32(cmbSopr_ID.SelectedValue.ToString()), Convert.ToInt32(cmbZakaz_ID.SelectedValue.ToString()));
                        dgvTovary_KomplFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения");
                    }
                }
                else
                    MessageBox.Show("Введите дату комплектации в соответствии с форматом даты", "Ошибка вводимых данных");
        }

        private void btnDelete_Kompl_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись об укомплектованном товаре?", "Удаление записи", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spUkomplektovany_tovar_Delete(Convert.ToInt32(dgv_Kompl.CurrentRow.Cells[0].Value.ToString()));
                    dgvTovary_KomplFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnInsert_Peredan_Click(object sender, EventArgs e)
        {
                if (Regex.IsMatch(mtbData_peredachi.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spPeredany_tovar_Insert(mtbData_peredachi.Text, mtbVremya_peredachi.Text, Convert.ToInt32(cmb_Kompl.SelectedValue.ToString()), Convert.ToInt32(cmbShet_ID.SelectedValue.ToString()));
                        mtbData_peredachi.Text = "";
                        mtbVremya_peredachi.Text = "";
                        dgvTovary_PerFill();
                    }
                    catch
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
                else
                    MessageBox.Show("Введите дату передачи в соответствии с форматом даты", "Ошибка вводимых данных");
        }

        private void btnUpdate_Peredan_Click(object sender, EventArgs e)
        {
                if (Regex.IsMatch(mtbData_peredachi.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spPeredany_tovar_Update(Convert.ToInt32(dgvPeredan.CurrentRow.Cells[0].Value.ToString()), mtbData_peredachi.Text, mtbVremya_peredachi.Text, Convert.ToInt32(cmb_Kompl.SelectedValue.ToString()), Convert.ToInt32(cmbShet_ID.SelectedValue.ToString()));
                        dgvTovary_PerFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения");
                    }
                }
                else
                    MessageBox.Show("Введите дату передачи в соответствии с форматом даты", "Ошибка вводимых данных");
        }

        private void btnDelete_Peredan_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись о переданном товаре?", "Удаление записи от " + mtbData_peredachi.Text, MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spPeredany_tovar_Delete(Convert.ToInt32(dgvPeredan.CurrentRow.Cells[0].Value.ToString()));
                    dgvTovary_PerFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
