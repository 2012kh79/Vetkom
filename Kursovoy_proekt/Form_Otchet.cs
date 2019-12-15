using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Kursovoy_proekt
{
    public partial class Form_Otchet : Form
    {
        DataBaseTables tables = new DataBaseTables();
        DynamicObjects classDynamicObjects = new DynamicObjects();
        DBProcedures procedure = new DBProcedures();
        string patData = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d";
        string patDouble = @"^[0-9]*[,][0-9]+$";
        public Form_Otchet()
        {
            InitializeComponent();
        }

        private void Form_Ochet_Load(object sender, EventArgs e)
        {
            classDynamicObjects.Form_otchet = this;
            classDynamicObjects.Form_Otchet_Fill();
            Thread thread = new Thread(dgvJPTFill);
            thread.Start();
            Thread thread1 = new Thread(cmbID_TovarFill);
            thread1.Start();
            Thread thread2 = new Thread(dgvTTNFill);
            thread2.Start();
            Thread thread3 = new Thread(dgvJUDTNSFill);
            thread3.Start();
            Thread thread4 = new Thread(dgvSprosFill);
            thread4.Start();
            Thread thread5 = new Thread(dgvSoprFill);
            thread5.Start();
            Thread thread6 = new Thread(dgvShetFill);
            thread6.Start();
        }

        public void dgvJPTFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvJPT.Rows.Count != 0)
                    {
                        dgvJPT.Rows.Remove(dgvJPT.Rows[dgvJPT.Rows.Count - 1]);
                    }
                    tables.dtJPTFill();
                    dgvJPT.DataSource = tables.dtJournal_postupleniya_tovarov;
                    dgvJPT.Columns[0].HeaderText = "Номер записи";
                    dgvJPT.Columns[1].HeaderText = "Дата поступления";
                    dgvJPT.Columns[2].Visible = false;
                    dgvJPT.Columns[3].Visible = false;
                    dgvJPT.Columns[4].HeaderText = "Название товара";
                    dgvJPT.Columns[5].HeaderText = "Дата производства";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvTTNFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvTTN.Rows.Count != 0)
                    {
                        dgvTTN.Rows.Remove(dgvTTN.Rows[dgvTTN.Rows.Count - 1]);
                    }
                    tables.dtTTNFill();
                    dgvTTN.DataSource = tables.dtTovarno_transportnaya_nakladnaya;
                    dgvTTN.Columns[0].HeaderText = "Номер записи";
                    dgvTTN.Columns[1].HeaderText = "Фамилия грузоотправителя";
                    dgvTTN.Columns[2].HeaderText = "Имя грузоотправителя";
                    dgvTTN.Columns[3].HeaderText = "Отчество грузоотправителя";
                    dgvTTN.Columns[4].Visible = false;
                    dgvTTN.Columns[5].Visible = false;
                    dgvTTN.Columns[6].Visible = false;
                    dgvTTN.Columns[7].HeaderText = "Название товара";
                    dgvTTN.Columns[8].HeaderText = "Дата производства";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvJUDTNSFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvJUDTNS.Rows.Count != 0)
                    {
                        dgvJUDTNS.Rows.Remove(dgvJUDTNS.Rows[dgvJUDTNS.Rows.Count - 1]);
                    }
                    tables.dtJUDTNSFill();
                    dgvJUDTNS.DataSource = tables.dtJournal_ucheta_dvizheniya_tovara_na_sklade;
                    dgvJUDTNS.Columns[0].HeaderText = "Номер записи";
                    dgvJUDTNS.Columns[1].HeaderText = "Фамилия ответственного";
                    dgvJUDTNS.Columns[2].HeaderText = "Имя ответственного";
                    dgvJUDTNS.Columns[3].HeaderText = "Отчество ответственного";
                    dgvJUDTNS.Columns[4].HeaderText = "Расходы";
                    dgvJUDTNS.Columns[5].HeaderText = "Приход";
                    dgvJUDTNS.Columns[6].HeaderText = "Остаток";
                    dgvJUDTNS.Columns[7].Visible = false;
                    dgvJUDTNS.Columns[8].Visible = false;
                    dgvJUDTNS.Columns[9].Visible = false;
                    dgvJUDTNS.Columns[10].HeaderText = "Область применения";
                    dgvJUDTNS.Columns[11].HeaderText = "Место нахождения товара";
                    dgvJUDTNS.Columns[12].HeaderText = "Срок хранения от";
                    dgvJUDTNS.Columns[13].HeaderText = "Срок хранения до";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvSprosFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvSpros.Rows.Count != 0)
                    {
                        dgvSpros.Rows.Remove(dgvSpros.Rows[dgvSpros.Rows.Count - 1]);
                    }
                    tables.dtSprosFill();
                    dgvSpros.DataSource = tables.dtOtchet_o_sprose_i_fact_nalichii_tovarov;
                    dgvSpros.Columns[0].HeaderText = "Номер записи";
                    dgvSpros.Columns[1].HeaderText = "Фамилия бухгалтера";
                    dgvSpros.Columns[2].HeaderText = "Имя бухгалтера";
                    dgvSpros.Columns[3].HeaderText = "Отчество бухгалтера";
                    dgvSpros.Columns[4].HeaderText = "Дата формирования отчёта";
                    dgvSpros.Columns[5].Visible = false;
                    dgvSpros.Columns[6].Visible = false;
                    dgvSpros.Columns[7].Visible = false;
                    dgvSpros.Columns[8].Visible = false;
                    dgvSpros.Columns[9].HeaderText = "ФИО ответственного";
                    dgvSpros.Columns[10].HeaderText = "Расходы";
                    dgvSpros.Columns[11].HeaderText = "Приход";
                    dgvSpros.Columns[12].HeaderText = "Остаток";
                    dgvSpros.Columns[13].Visible = false;
                    dgvSpros.Columns[14].HeaderText = "Способ доставки";
                    dgvSpros.Columns[15].HeaderText = "Количество заказанного товара";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvSoprFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvSopr.Rows.Count != 0)
                    {
                        dgvSopr.Rows.Remove(dgvSopr.Rows[dgvSopr.Rows.Count - 1]);
                    }
                    tables.dtSoprFill();
                    dgvSopr.DataSource = tables.dtSoprovoditelny_document;
                    dgvSopr.Columns[0].HeaderText = "Номер записи";
                    dgvSopr.Columns[1].HeaderText = "Адрес поставщика";
                    dgvSopr.Columns[2].HeaderText = "Адрес заказчика";
                    dgvSopr.Columns[3].Visible = false;
                    dgvSopr.Columns[4].Visible = false;
                    dgvSopr.Columns[5].HeaderText = "Наименование поставщика";
                    dgvSopr.Columns[6].HeaderText = "ИНН поставщика";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void dgvShetFill()
        {
            Action action = () =>
            {
                try
                {
                    while (dgvShet.Rows.Count != 0)
                    {
                        dgvShet.Rows.Remove(dgvShet.Rows[dgvShet.Rows.Count - 1]);
                    }
                    tables.dtShetFill();
                    dgvShet.DataSource = tables.dtShet_facture;
                    dgvShet.Columns[0].HeaderText = "Номер записи";
                    dgvShet.Columns[1].HeaderText = "Дата формирования счёта";
                    dgvShet.Columns[2].HeaderText = "Цена за заказанный товар";
                    dgvShet.Columns[3].Visible = false;
                    dgvShet.Columns[4].Visible = false;
                    dgvShet.Columns[5].Visible = false;
                    dgvShet.Columns[8].Visible = false;
                    dgvShet.Columns[6].HeaderText = "Способ доставки";
                    dgvShet.Columns[7].HeaderText = "Количество заказанного товара";
                    dgvShet.Columns[9].HeaderText = "ФИО грузоотправителя";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void dgvJPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.mtbData_postupleniya.Text = dgvJPT.CurrentRow.Cells[1].Value.ToString();//Данные передаются TextBox при нажатии на строку
            classDynamicObjects.cmbID_Tovar.SelectedValue = dgvJPT.CurrentRow.Cells[3].Value.ToString();
        }

        public void btnInsert_JPT_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(classDynamicObjects.mtbData_postupleniya.Text, patData, RegexOptions.IgnoreCase))
            {
                try
                {
                    procedure.spJournal_postupleniya_tovarov_Insert(classDynamicObjects.mtbData_postupleniya.Text, Convert.ToInt32(classDynamicObjects.cmbID_Tovar.SelectedValue.ToString()));
                    classDynamicObjects.mtbData_postupleniya.Clear();
                    dgvJPTFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
            else
                MessageBox.Show("Введите дату поступления в соответствии с форматом даты", "Ошибка вводимых данных");
        }

        public void btnUpdate_JPT_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(classDynamicObjects.mtbData_postupleniya.Text, patData, RegexOptions.IgnoreCase))
            {
                try
                {
                    procedure.spJournal_postupleniya_tovarov_Update(Convert.ToInt32(dgvJPT.CurrentRow.Cells[0].Value.ToString()),
                     classDynamicObjects.mtbData_postupleniya.Text, Convert.ToInt32(classDynamicObjects.cmbID_Tovar.SelectedValue.ToString()));
                    dgvJPTFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения");
                }
            }
            else
                MessageBox.Show("Введите дату поступления в соответствии с форматом даты", "Ошибка вводимых данных");
        }

        public void btnDelete_JPT_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись в журнале поступления товаров?", "Удаление записи в журнале поступления товаров от " + classDynamicObjects.mtbData_postupleniya.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spJournal_postupleniya_tovarov_Delete(Convert.ToInt32(
                        dgvJPT.CurrentRow.Cells[0].Value.ToString()));
                    dgvJPTFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        public void cmbID_TovarFill()//Метод отвечает за заполнение ComboBox данными
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Tovar = new DataBaseTables();
                    tables_Tovar.dtTovarFill();//Заполнение таблицы данными с класса
                    classDynamicObjects.cmbID_Tovar.DataSource = tables_Tovar.dtTovar;
                    classDynamicObjects.cmbID_Tovar.DisplayMember = "Tovar";//Отображает свойство объекта
                    classDynamicObjects.cmbID_Tovar.ValueMember = "ID_Tovar";//Значение для ComboBox
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void dgvTTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.tbF_gruz.Text = dgvTTN.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.tbI_gruz.Text = dgvTTN.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.tbO_gruz.Text = dgvTTN.CurrentRow.Cells[3].Value.ToString();
            classDynamicObjects.cmbID_Tovar_TTN.SelectedValue = dgvTTN.CurrentRow.Cells[6].Value.ToString();
        }

        public void cmbID_Tovar_TTNFill()//Метод отвечает за заполнение ComboBox данными
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Tovar = new DataBaseTables();
                    tables_Tovar.dtTovarFill();//Заполнение таблицы данными с класса
                    classDynamicObjects.cmbID_Tovar_TTN.DataSource = tables_Tovar.dtTovar;
                    classDynamicObjects.cmbID_Tovar_TTN.DisplayMember = "Tovar";//Отображает свойство объекта
                    classDynamicObjects.cmbID_Tovar_TTN.ValueMember = "ID_Tovar";//Значение для ComboBox
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void tc_Otchet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((TabControl)sender).SelectedIndex;//Создание переменной для хранения вкладки TabControl
            switch (index)
            {
                case 0:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)//Цикл для удаления объектов со страницы
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];//Обращение к элементам
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);//Удаление 
                        classDynamicObjects.Form_Otchet_Fill();//Заполнение
                        cmbID_TovarFill();
                    }
                    break;
                case 1:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Form_TTN_Fill();
                        cmbID_Tovar_TTNFill();
                    }
                    break;
                case 2:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Form_JUDTNS_Fill();
                        cmbID_Sort_JUDTNSFill();
                    }
                    break;
                case 3:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Form_Spros_Fill();
                        cmbID_Zakaz_SprosFill();
                        cmbID_JUDTNS_SprosFill();
                    }
                    break;
                case 4:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Form_Sopr_Fill();
                        cmbID_Postavshik_SoprFill();
                    }
                    break;
                case 5:
                    for (int i = classDynamicObjects.pnlTextBox.Controls.Count - 1; i >= 0; i--)
                    {
                        Control Ctrl1 = classDynamicObjects.pnlTextBox.Controls[i];
                        classDynamicObjects.pnlTextBox.Controls.RemoveAt(i);
                        classDynamicObjects.Form_Shet_Fill();
                        cmbID_Zakaz_ShetFill();
                        cmbID_TTN_ShetFill();
                    }
                    break;
            }
        }

        private void btnInsert_TTN_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbF_gruz.Text != "" & classDynamicObjects.tbI_gruz.Text != "" & classDynamicObjects.tbO_gruz.Text != "" &
                classDynamicObjects.tbF_gruz.TextLength > 2 & classDynamicObjects.tbI_gruz.TextLength > 2 & classDynamicObjects.tbO_gruz.TextLength > 2)
            {
                try
                {
                    procedure.spTovarno_transportnaya_nakladnaya_Insert(classDynamicObjects.tbF_gruz.Text, classDynamicObjects.tbI_gruz.Text, classDynamicObjects.tbO_gruz.Text, Convert.ToInt32(classDynamicObjects.cmbID_Tovar_TTN.SelectedValue.ToString()));
                    classDynamicObjects.tbF_gruz.Clear();
                    classDynamicObjects.tbI_gruz.Clear();
                    classDynamicObjects.tbO_gruz.Clear();
                    dgvTTNFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
            else
                MessageBox.Show("Заполните корректно данные об грузоотправителе!", "Ошибка добавления");
        }

        private void btnUpdate_TTN_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbF_gruz.Text != "" & classDynamicObjects.tbI_gruz.Text != "" & classDynamicObjects.tbO_gruz.Text != "" &
                classDynamicObjects.tbF_gruz.TextLength > 2 & classDynamicObjects.tbI_gruz.TextLength > 2 & classDynamicObjects.tbO_gruz.TextLength > 2)
            {
                try
                {
                    procedure.spTovarno_transportnaya_nakladnaya_Update(Convert.ToInt32(dgvTTN.CurrentRow.Cells[0].Value.ToString()), classDynamicObjects.tbF_gruz.Text, classDynamicObjects.tbI_gruz.Text, classDynamicObjects.tbO_gruz.Text, Convert.ToInt32(classDynamicObjects.cmbID_Tovar_TTN.SelectedValue.ToString()));
                    dgvTTNFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения");
                }
            }
            else
                MessageBox.Show("Заполните корректно данные об грузоотправителе!", "Ошибка изменения");
        }

        private void btnDelete_TTN_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись в товарно-транспортной накладной?", "Удаление записи", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spTovarno_transportnaya_nakladnaya_Delete(Convert.ToInt32(dgvTTN.CurrentRow.Cells[0].Value.ToString()));
                    dgvTTNFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void dgvJUDTNS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.tbF_otv.Text = dgvJUDTNS.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.tbI_otv.Text = dgvJUDTNS.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.tbO_otv.Text = dgvJUDTNS.CurrentRow.Cells[3].Value.ToString();
            classDynamicObjects.tbRashod.Text = dgvJUDTNS.CurrentRow.Cells[4].Value.ToString();
            classDynamicObjects.tbPrihod.Text = dgvJUDTNS.CurrentRow.Cells[5].Value.ToString();
            classDynamicObjects.cmbID_Sort_JUDTNS.SelectedValue = dgvJUDTNS.CurrentRow.Cells[9].Value.ToString();
        }

        public void cmbID_Sort_JUDTNSFill()//Метод отвечает за заполнение ComboBox данными
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Sort = new DataBaseTables();
                    tables_Sort.dtSortFill();//Заполнение таблицы данными с класса
                    classDynamicObjects.cmbID_Sort_JUDTNS.DataSource = tables_Sort.dtSort_tovary;
                    classDynamicObjects.cmbID_Sort_JUDTNS.DisplayMember = "Sort_tovary";//Отображает свойство объекта
                    classDynamicObjects.cmbID_Sort_JUDTNS.ValueMember = "ID_Sort";//Значение для ComboBox
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void btnInsert_JUDTNS_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbF_otv.Text != "" & classDynamicObjects.tbI_otv.Text != "" & classDynamicObjects.tbO_otv.Text != "" &
                classDynamicObjects.tbRashod.Text != "" & classDynamicObjects.tbPrihod.Text != "")
            {
                if (Regex.IsMatch(classDynamicObjects.tbRashod.Text, patDouble, RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(classDynamicObjects.tbPrihod.Text, patDouble, RegexOptions.IgnoreCase))
                    {
                        try
                        {
                            procedure.spJournal_ucheta_dvizheniya_tovara_na_sklade_Insert(classDynamicObjects.tbF_otv.Text, classDynamicObjects.tbI_otv.Text, classDynamicObjects.tbO_otv.Text,
                        Convert.ToDouble(classDynamicObjects.tbRashod.Text), Convert.ToDouble(classDynamicObjects.tbPrihod.Text), Convert.ToInt32(classDynamicObjects.cmbID_Sort_JUDTNS.SelectedValue.ToString()));
                            classDynamicObjects.tbF_otv.Clear();
                            classDynamicObjects.tbI_otv.Clear();
                            classDynamicObjects.tbO_otv.Clear();
                            classDynamicObjects.tbPrihod.Clear();
                            classDynamicObjects.tbRashod.Clear();
                            dgvJUDTNSFill();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка добавления");
                        }
                    }
                    else
                        MessageBox.Show("Заполните корректно данные о приходах!", "Ошибка изменения");
                }
                else
                    MessageBox.Show("Заполните корректно данные о расходах!", "Ошибка изменения");
            }
            else
                MessageBox.Show("Заполните корректно данные об ответственном за журнал!", "Ошибка добавления");
        }

        private void btnUpdate_JUDTNS_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbF_otv.Text != "" & classDynamicObjects.tbI_otv.Text != "" & classDynamicObjects.tbO_otv.Text != "" &
                classDynamicObjects.tbRashod.Text != "" & classDynamicObjects.tbPrihod.Text != "")
            {
                if (Regex.IsMatch(classDynamicObjects.tbRashod.Text, patDouble, RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(classDynamicObjects.tbPrihod.Text, patDouble, RegexOptions.IgnoreCase))
                    {
                        try
                        {
                            procedure.spJournal_ucheta_dvizheniya_tovara_na_sklade_Update(Convert.ToInt32(dgvJUDTNS.CurrentRow.Cells[0].Value.ToString()), classDynamicObjects.tbF_otv.Text, classDynamicObjects.tbI_otv.Text, classDynamicObjects.tbO_otv.Text,
                                                Convert.ToDouble(classDynamicObjects.tbRashod.Text), Convert.ToDouble(classDynamicObjects.tbPrihod.Text), Convert.ToInt32(classDynamicObjects.cmbID_Sort_JUDTNS.SelectedValue.ToString()));
                            dgvJUDTNSFill();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка изменения");
                        }
                    }
                    else
                        MessageBox.Show("Заполните корректно данные о приходах!", "Ошибка изменения");
                }
                else
                    MessageBox.Show("Заполните корректно данные о расходах!", "Ошибка изменения");
            }
            else
                MessageBox.Show("Заполните корректно данные об ответственном за журнал!", "Ошибка изменения");
        }

        private void btnDelete_JUDTNS_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись в ЖУДТНС?", "Удаление записи", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spJournal_ucheta_dvizheniya_tovara_na_sklade_Delete(Convert.ToInt32(dgvJUDTNS.CurrentRow.Cells[0].Value.ToString()));
                    dgvJUDTNSFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void dgvSpros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.tbF_buh.Text = dgvSpros.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.tbI_buh.Text = dgvSpros.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.tbO_buh.Text = dgvSpros.CurrentRow.Cells[3].Value.ToString();
            classDynamicObjects.mtbData_form_otcheta.Text = dgvSpros.CurrentRow.Cells[4].Value.ToString();
            classDynamicObjects.cmbID_Zakaz_Spros.SelectedValue = dgvSpros.CurrentRow.Cells[13].Value.ToString();
            classDynamicObjects.cmbID_JUDTNS_Spros.SelectedValue = dgvSpros.CurrentRow.Cells[8].Value.ToString();
        }

        public void cmbID_Zakaz_SprosFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Zakaz = new DataBaseTables();
                    tables_Zakaz.dtZakazFill();
                    classDynamicObjects.cmbID_Zakaz_Spros.DataSource = tables_Zakaz.dtZakazany_tovary;
                    classDynamicObjects.cmbID_Zakaz_Spros.DisplayMember = "Zakazany_tovary";
                    classDynamicObjects.cmbID_Zakaz_Spros.ValueMember = "ID_Zakaz";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_JUDTNS_SprosFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_JUDTNS = new DataBaseTables();
                    tables_JUDTNS.dtJUDTNSFill();
                    classDynamicObjects.cmbID_JUDTNS_Spros.DataSource = tables_JUDTNS.dtJournal_ucheta_dvizheniya_tovara_na_sklade;
                    classDynamicObjects.cmbID_JUDTNS_Spros.DisplayMember = "Journal_ucheta_dvizheniya_tovara_na_sklade";
                    classDynamicObjects.cmbID_JUDTNS_Spros.ValueMember = "ID_JUDTNS";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Postavshik_SoprFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Postavshik = new DataBaseTables();
                    tables_Postavshik.dtPostavshikFill();
                    classDynamicObjects.cmbID_Postavshik_Sopr.DataSource = tables_Postavshik.dtPostavshik;
                    classDynamicObjects.cmbID_Postavshik_Sopr.DisplayMember = "Postavshik";
                    classDynamicObjects.cmbID_Postavshik_Sopr.ValueMember = "ID_Postavshik";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_Zakaz_ShetFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_Zakaz = new DataBaseTables();
                    tables_Zakaz.dtZakazFill();
                    classDynamicObjects.cmbID_Zakaz.DataSource = tables_Zakaz.dtZakazany_tovary;
                    classDynamicObjects.cmbID_Zakaz.DisplayMember = "Zakazany_tovary";
                    classDynamicObjects.cmbID_Zakaz.ValueMember = "ID_Zakaz";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        public void cmbID_TTN_ShetFill()
        {
            Action action = () =>
            {
                try
                {
                    DataBaseTables tables_TTN = new DataBaseTables();
                    tables_TTN.dtTTNFill();
                    classDynamicObjects.cmbID_TTN_Shet.DataSource = tables_TTN.dtTovarno_transportnaya_nakladnaya;
                    classDynamicObjects.cmbID_TTN_Shet.DisplayMember = "Tovarno_transportnaya_nakladnaya";
                    classDynamicObjects.cmbID_TTN_Shet.ValueMember = "ID_TTN";
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void btnInsert_Spros_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbF_buh.Text != "" & classDynamicObjects.tbI_buh.Text != "" & classDynamicObjects.tbO_buh.Text != "" & classDynamicObjects.mtbData_form_otcheta.Text != "" &
                classDynamicObjects.tbF_buh.TextLength > 2 & classDynamicObjects.tbI_buh.TextLength > 2 & classDynamicObjects.tbO_buh.TextLength > 2)
            {
                if (Regex.IsMatch(classDynamicObjects.mtbData_form_otcheta.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spOtchet_o_sprose_i_fact_nalichii_tovarov_Insert(classDynamicObjects.tbF_buh.Text, classDynamicObjects.tbI_buh.Text, classDynamicObjects.tbO_buh.Text,
                            classDynamicObjects.mtbData_form_otcheta.Text,
                            Convert.ToInt32(classDynamicObjects.cmbID_JUDTNS_Spros.SelectedValue.ToString()),
                            Convert.ToInt32(classDynamicObjects.cmbID_Zakaz_Spros.SelectedValue.ToString()));
                        classDynamicObjects.tbF_buh.Clear();
                        classDynamicObjects.tbI_buh.Clear();
                        classDynamicObjects.tbO_buh.Clear();
                        classDynamicObjects.mtbData_form_otcheta.Clear();
                        dgvSprosFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка добавления");
                    }
                }
                else
                    MessageBox.Show("Введите дату формирования отчёта в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные об отчёте", "Ошибка вводимых данных");

        }

        private void btnUpdate_Spros_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbF_buh.Text != "" & classDynamicObjects.tbI_buh.Text != "" & classDynamicObjects.tbO_buh.Text != "" & classDynamicObjects.mtbData_form_otcheta.Text != "" &
               classDynamicObjects.tbF_buh.TextLength > 2 & classDynamicObjects.tbI_buh.TextLength > 2 & classDynamicObjects.tbO_buh.TextLength > 2)
            {
                if (Regex.IsMatch(classDynamicObjects.mtbData_form_otcheta.Text, patData, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        procedure.spOtchet_o_sprose_i_fact_nalichii_tovarov_Update(Convert.ToInt32(dgvSpros.CurrentRow.Cells[0].Value.ToString()), classDynamicObjects.tbF_buh.Text, classDynamicObjects.tbI_buh.Text, classDynamicObjects.tbO_buh.Text,
                            classDynamicObjects.mtbData_form_otcheta.Text,
                            Convert.ToInt32(classDynamicObjects.cmbID_JUDTNS_Spros.SelectedValue.ToString()),
                            Convert.ToInt32(classDynamicObjects.cmbID_Zakaz_Spros.SelectedValue.ToString()));
                        dgvSprosFill();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения");
                    }
                }
                else
                    MessageBox.Show("Введите дату формирования отчёта в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните данные об отчёте", "Ошибка вводимых данных");
        }

        private void btnDelete_Spros_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись в отчете о спросе и фактическом наличии товаров?", "Удаление записи от " + classDynamicObjects.mtbData_form_otcheta.Text, MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spOtchet_o_sprose_i_fact_nalichii_tovarov_Delete(Convert.ToInt32(dgvSpros.CurrentRow.Cells[0].Value.ToString()));
                    dgvSprosFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void dgvSopr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.tbAdres_post.Text = dgvSopr.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.tbAdres_zakaz.Text = dgvSopr.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.cmbID_Postavshik_Sopr.SelectedValue = dgvSopr.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnInsert_Sopr_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbAdres_post.Text != "" & classDynamicObjects.tbAdres_zakaz.Text != "")
            {
                try
                {
                    procedure.spSoprovoditelny_document_Insert(classDynamicObjects.tbAdres_post.Text, classDynamicObjects.tbAdres_zakaz.Text, Convert.ToInt32(classDynamicObjects.cmbID_Postavshik_Sopr.SelectedValue.ToString()));
                    classDynamicObjects.tbAdres_post.Clear();
                    classDynamicObjects.tbAdres_zakaz.Clear();
                    dgvSoprFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
            else
                MessageBox.Show("Заполните поля данных", "Ошибка вводимых данных");
        }

        private void btnUpdate_Sopr_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbAdres_post.Text != "" & classDynamicObjects.tbAdres_zakaz.Text != "")
            {
                try
                {
                    procedure.spSoprovoditelny_document_Update(Convert.ToInt32(dgvSopr.CurrentRow.Cells[0].Value.ToString()), classDynamicObjects.tbAdres_post.Text, classDynamicObjects.tbAdres_zakaz.Text, Convert.ToInt32(classDynamicObjects.cmbID_Postavshik_Sopr.SelectedValue.ToString()));
                    dgvSoprFill();
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения");
                }
            }
            else
                MessageBox.Show("Заполните поля данных", "Ошибка вводимых данных");
        }

        private void btnDelete_Sopr_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись в сопроводительном документе?", "Удаление записи", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spSoprovoditelny_document_Delete(Convert.ToInt32(dgvSopr.CurrentRow.Cells[0].Value.ToString()));
                    dgvSoprFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void dgvShet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classDynamicObjects.mtbData_form_shet.Text = dgvShet.CurrentRow.Cells[1].Value.ToString();
            classDynamicObjects.tbTsena.Text = dgvShet.CurrentRow.Cells[2].Value.ToString();
            classDynamicObjects.cmbID_Zakaz.SelectedValue = dgvShet.CurrentRow.Cells[5].Value.ToString();
            classDynamicObjects.cmbID_TTN_Shet.SelectedValue = dgvShet.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnInsert_Shet_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbTsena.Text != "" & classDynamicObjects.mtbData_form_shet.Text != "")
            {

                if (Regex.IsMatch(classDynamicObjects.mtbData_form_shet.Text, patData, RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(classDynamicObjects.tbTsena.Text, patDouble, RegexOptions.IgnoreCase))
                    {
                        try
                        {
                            procedure.spShet_facture_Insert(Convert.ToDouble(classDynamicObjects.tbTsena.Text), classDynamicObjects.mtbData_form_shet.Text, Convert.ToInt32(classDynamicObjects.cmbID_Zakaz.SelectedValue.ToString()), Convert.ToInt32(classDynamicObjects.cmbID_TTN_Shet.SelectedValue.ToString()));
                            classDynamicObjects.mtbData_form_shet.Clear();
                            classDynamicObjects.tbTsena.Clear();
                            dgvShetFill();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка добавления");
                        }
                    }
                    else
                        MessageBox.Show("Заполните корректно данные о цене", "Ошибка вводимых данных");
                }
                else
                    MessageBox.Show("Введите дату поступления в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните поля ввода!", "Ошибка вводимых данных");
        }

        private void btnUpdate_Shet_Click(object sender, EventArgs e)
        {
            if (classDynamicObjects.tbTsena.Text != "" & classDynamicObjects.mtbData_form_shet.Text != "")
            {

                if (Regex.IsMatch(classDynamicObjects.mtbData_form_shet.Text, patData, RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(classDynamicObjects.tbTsena.Text, patDouble, RegexOptions.IgnoreCase))
                    {
                        try
                        {
                            procedure.spShet_facture_Update(Convert.ToInt32(dgvShet.CurrentRow.Cells[0].Value.ToString()), Convert.ToDouble(classDynamicObjects.tbTsena.Text), classDynamicObjects.mtbData_form_shet.Text, Convert.ToInt32(classDynamicObjects.cmbID_Zakaz.SelectedValue.ToString()), Convert.ToInt32(classDynamicObjects.cmbID_TTN_Shet.SelectedValue.ToString()));
                            classDynamicObjects.mtbData_postupleniya.Clear();
                            dgvShetFill();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка изменения");
                        }
                    }
                    else
                        MessageBox.Show("Заполните корректно данные о цене", "Ошибка вводимых данных");
                }
                else
                    MessageBox.Show("Введите дату поступления в соответствии с форматом даты", "Ошибка вводимых данных");
            }
            else
                MessageBox.Show("Заполните поля ввода!", "Ошибка вводимых данных");
        }

        private void btnDelete_Shet_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Удалить запись в счёт-фактуре?", "Удаление записи от " + classDynamicObjects.mtbData_form_shet.Text, MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    procedure.spShet_facture_Delete(Convert.ToInt32(dgvShet.CurrentRow.Cells[0].Value.ToString()));
                    dgvShetFill();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empty"
                || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    Form_Config configForm = new Form_Config();
                    configForm.ShowDialog();
                    break;
                case (false):
                    DataTable data = new DataTable();
                    DataBaseTables dt = new DataBaseTables();
                    WordDocument document = new WordDocument();
                    DataRow dr;
                    btnWord.Enabled = false;
                    data.Columns.Add("ID_Shet");
                    data.Columns.Add("Data_form_shet");
                    data.Columns.Add("Tsena_za_zakazany_tovar");
                    data.Columns.Add("Zakaz_tovary_ID");
                    data.Columns.Add("TTN_ID");

                    foreach (DataGridViewRow row in dgvShet.Rows)
                    {
                        dr = data.NewRow();
                        dr["ID_Shet"] = row.Cells[0].Value.ToString();
                        dr["Data_form_shet"] = row.Cells[1].Value.ToString();
                        dr["Tsena_za_zakazany_tovar"] = row.Cells[2].Value.ToString();
                        dr["Zakaz_tovary_ID"] = row.Cells[5].Value.ToString();
                        dr["TTN_ID"] = row.Cells[8].Value.ToString();
                        data.Rows.Add(dr);
                    }

                    dt.qrShet_facture = "select [Data_form_shet] as \"Дата формирования счёта\",[Tsena_za_zakazany_tovar] as \"Цена за заказанный товар\", [Zakaz_tovary_ID] as \"Код заказанного товара\", [TTN_ID] as \"Код ТТН\" from [dbo].[Shet_facture]";
                    document.table = data;
                    document.Shet_Facture();
                    btnWord.Enabled = true;
                    break;
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empty"
                || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    Form_Config configForm = new Form_Config();
                    configForm.ShowDialog();
                    break;
                case (false):
                    btnPDF.Enabled = false;
                    PDFDocument document = new PDFDocument();
                    document.ID_Shet = dgvShet.Rows[dgvShet.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    document.Data_form = dgvShet.Rows[dgvShet.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    document.Tsena_tovara = dgvShet.Rows[dgvShet.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    document.Zakaz_ID = dgvShet.Rows[dgvShet.CurrentCell.RowIndex].Cells[5].Value.ToString();
                    document.TTN_ID = dgvShet.Rows[dgvShet.CurrentCell.RowIndex].Cells[8].Value.ToString();
                    document.Shet_Facture_PDF();
                    btnPDF.Enabled = true;
                    break;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            switch (Registry_Class.DirPath == "Empty"
                || Registry_Class.DocBM == 0.0 || Registry_Class.DocTM == 0.0 ||
                Registry_Class.DocRM == 0.0 || Registry_Class.DocLM == 0.0)
            {
                case (true):
                    Form_Config configForm = new Form_Config();
                    configForm.ShowDialog();
                    break;
                case (false):
                    btnExcel.Enabled = false;
                    DataTable dt = new DataTable();
                    DataRow dr;
                    dt.Columns.Add("Fam_buhgalter");
                    dt.Columns.Add("Imya_buhgalter");
                    dt.Columns.Add("Otch_buhgalter");
                    dt.Columns.Add("Data_form_otchet");
                    dt.Columns.Add("JUDTNS_ID");
                    dt.Columns.Add("Zakaz_ID");
                    foreach (DataGridViewRow Row in dgvSpros.Rows)
                    {
                        dr = dt.NewRow();
                        dr["Fam_buhgalter"] = Row.Cells[1].Value.ToString();
                        dr["Imya_buhgalter"] = Row.Cells[2].Value.ToString();
                        dr["Otch_buhgalter"] = Row.Cells[3].Value.ToString();
                        dr["Data_form_otchet"] = Row.Cells[4].Value.ToString();
                        dr["JUDTNS_ID"] = Row.Cells[8].Value.ToString();
                        dr["Zakaz_ID"] = Row.Cells[13].Value.ToString();
                        dt.Rows.Add(dr);
                    }
                    ExcelDocument document = new ExcelDocument();
                    document.dtShet = dt;
                    document.SprosCreate();
                    btnExcel.Enabled = true;
                    break;
            }
        }
    }
}
