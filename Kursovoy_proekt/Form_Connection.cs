using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Kursovoy_proekt
{
    public partial class Form_Connection : Form
    {
        private DataBaseConfiguration configuration = new DataBaseConfiguration();
        private Int32 status = 1;
        public Form_Connection()
        {
            InitializeComponent();
        }

        private void Form_Settings_Admin_Load(object sender, EventArgs e)
        {
            switch (DataBaseConfiguration.logCon)
            {
                case (true):
                    cmbAdres_server.Text = Registry_Class.DS;
                    cmbNazv_server.Text = Registry_Class.DSSN;
                    cmbIst_server.Text = Registry_Class.IC;
                    cmbAdres_server.Enabled = true;
                    cmbNazv_server.Enabled = true;
                    cmbIst_server.Enabled = true;
                    tbUser_server.Enabled = true;
                    tbPassword_server.Enabled = true;
                    btnProverka.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    tsslStatus.Visible = true;
                    tsslStatus.Text = "Поиск серверов";
                    configuration.dtServers += dtservers;
                    Thread thread = new Thread(configuration.Servers_get);
                    Thread threadMessage = new Thread(tsslMessage);
                    threadMessage.Start();
                    thread.Start();
                    break;
            }
        }

        private void dtservers(DataTable table)
        {
            status = 0;
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cmbAdres_server.Items.Add(r[0]);
                    cmbNazv_server.Items.Add(r[1]);
                }
                cmbAdres_server.Enabled = true;
                cmbNazv_server.Enabled = true;
                tbUser_server.Enabled = true;
                tbPassword_server.Enabled = true;
                btnProverka.Enabled = true;
            };
            Invoke(action);
        }

        private void tsslMessage()
        {
            for (int i = 0; i < status;)
            {
                Thread.Sleep(500);
                Action action = () =>
                {
                    switch (status)
                    {
                        case (1):
                            if (tsslStatus.Text != "Поиск серверов...")
                                tsslStatus.Text += ".";
                            else
                                tsslStatus.Text = "Поиск серверов";
                            break;
                        case (2):
                            if (tsslStatus.Text != "Поиск баз данных...")
                                tsslStatus.Text += ".";
                            else
                                tsslStatus.Text = "Поиск баз данных";
                            break;
                        case (0):
                            tsslStatus.Text = "-";
                            tsslStatus.Visible = false;
                            break;
                    }
                };
                Invoke(action);
            }
        }

        private void btnProverka_Click(object sender, EventArgs e)
        {
            configuration.cds = cmbAdres_server.Text + @"\" + cmbNazv_server.Text;
            configuration.cui = tbUser_server.Text;
            configuration.cpw = tbPassword_server.Text;
            status = 2;
            tsslStatus.Text = "Поиск баз данных";
            tsslStatus.Visible = true;
            configuration.dtDatabases += databases;
            Thread threadMessage = new Thread(tsslMessage);
            Thread thread = new Thread(configuration.Databases_get);
            threadMessage.Start();
            thread.Start();
        }

        private void databases(DataTable table)
        {
            Action action = () =>
            {
                cmbIst_server.Items.Clear();
                foreach (DataRow r in table.Rows)
                {
                    cmbIst_server.Items.Add(r[0]);
                }
                status = 0;
                cmbIst_server.Enabled = true;
                btnConnect.Enabled = true;
            };
            Invoke(action);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Registry_Class registry = new Registry_Class();
            registry.Registry_Set(cmbAdres_server.Text, cmbNazv_server.Text, cmbIst_server.Text, tbUser_server.Text, tbPassword_server.Text);
            if (cmbIst_server.SelectedItem.ToString() == "Vetkom")
            {
                MessageBox.Show("Подключение успешно установлено!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
                MessageBox.Show("Выберите другую базу данных (Initial Catalog)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Settings_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (DataBaseConfiguration.logCon)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    Application.Exit();
                    break;
            }
        }
    }
}
