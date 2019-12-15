namespace Kursovoy_proekt
{
    partial class Form_Otchet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Otchet));
            this.tc_Otchet = new System.Windows.Forms.TabControl();
            this.tpJPT = new System.Windows.Forms.TabPage();
            this.btnDelete_JPT = new System.Windows.Forms.Button();
            this.btnUpdate_JPT = new System.Windows.Forms.Button();
            this.btnInsert_JPT = new System.Windows.Forms.Button();
            this.dgvJPT = new System.Windows.Forms.DataGridView();
            this.tpTTN = new System.Windows.Forms.TabPage();
            this.btnDelete_TTN = new System.Windows.Forms.Button();
            this.btnUpdate_TTN = new System.Windows.Forms.Button();
            this.btnInsert_TTN = new System.Windows.Forms.Button();
            this.dgvTTN = new System.Windows.Forms.DataGridView();
            this.tpJUDTNS = new System.Windows.Forms.TabPage();
            this.btnDelete_JUDTNS = new System.Windows.Forms.Button();
            this.btnUpdate_JUDTNS = new System.Windows.Forms.Button();
            this.btnInsert_JUDTNS = new System.Windows.Forms.Button();
            this.dgvJUDTNS = new System.Windows.Forms.DataGridView();
            this.tb_Spros = new System.Windows.Forms.TabPage();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDelete_Spros = new System.Windows.Forms.Button();
            this.btnUpdate_Spros = new System.Windows.Forms.Button();
            this.btnInsert_Spros = new System.Windows.Forms.Button();
            this.dgvSpros = new System.Windows.Forms.DataGridView();
            this.tpSopr = new System.Windows.Forms.TabPage();
            this.btnDelete_Sopr = new System.Windows.Forms.Button();
            this.btnUpdate_Sopr = new System.Windows.Forms.Button();
            this.btnInsert_Sopr = new System.Windows.Forms.Button();
            this.dgvSopr = new System.Windows.Forms.DataGridView();
            this.tpShet = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnDelete_Shet = new System.Windows.Forms.Button();
            this.btnUpdate_Shet = new System.Windows.Forms.Button();
            this.btnInsert_Shet = new System.Windows.Forms.Button();
            this.dgvShet = new System.Windows.Forms.DataGridView();
            this.tc_Otchet.SuspendLayout();
            this.tpJPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJPT)).BeginInit();
            this.tpTTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTN)).BeginInit();
            this.tpJUDTNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJUDTNS)).BeginInit();
            this.tb_Spros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpros)).BeginInit();
            this.tpSopr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSopr)).BeginInit();
            this.tpShet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShet)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Otchet
            // 
            this.tc_Otchet.Controls.Add(this.tpJPT);
            this.tc_Otchet.Controls.Add(this.tpTTN);
            this.tc_Otchet.Controls.Add(this.tpJUDTNS);
            this.tc_Otchet.Controls.Add(this.tb_Spros);
            this.tc_Otchet.Controls.Add(this.tpSopr);
            this.tc_Otchet.Controls.Add(this.tpShet);
            this.tc_Otchet.Location = new System.Drawing.Point(12, 46);
            this.tc_Otchet.Name = "tc_Otchet";
            this.tc_Otchet.SelectedIndex = 0;
            this.tc_Otchet.Size = new System.Drawing.Size(860, 312);
            this.tc_Otchet.TabIndex = 0;
            this.tc_Otchet.SelectedIndexChanged += new System.EventHandler(this.tc_Otchet_SelectedIndexChanged);
            // 
            // tpJPT
            // 
            this.tpJPT.Controls.Add(this.btnDelete_JPT);
            this.tpJPT.Controls.Add(this.btnUpdate_JPT);
            this.tpJPT.Controls.Add(this.btnInsert_JPT);
            this.tpJPT.Controls.Add(this.dgvJPT);
            this.tpJPT.Location = new System.Drawing.Point(4, 22);
            this.tpJPT.Name = "tpJPT";
            this.tpJPT.Padding = new System.Windows.Forms.Padding(3);
            this.tpJPT.Size = new System.Drawing.Size(852, 286);
            this.tpJPT.TabIndex = 0;
            this.tpJPT.Text = "Журнал поступления товаров";
            this.tpJPT.UseVisualStyleBackColor = true;
            // 
            // btnDelete_JPT
            // 
            this.btnDelete_JPT.Location = new System.Drawing.Point(749, 143);
            this.btnDelete_JPT.Name = "btnDelete_JPT";
            this.btnDelete_JPT.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_JPT.TabIndex = 3;
            this.btnDelete_JPT.Text = "Удалить";
            this.btnDelete_JPT.UseVisualStyleBackColor = true;
            this.btnDelete_JPT.Click += new System.EventHandler(this.btnDelete_JPT_Click);
            // 
            // btnUpdate_JPT
            // 
            this.btnUpdate_JPT.Location = new System.Drawing.Point(749, 73);
            this.btnUpdate_JPT.Name = "btnUpdate_JPT";
            this.btnUpdate_JPT.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_JPT.TabIndex = 2;
            this.btnUpdate_JPT.Text = "Изменить";
            this.btnUpdate_JPT.UseVisualStyleBackColor = true;
            this.btnUpdate_JPT.Click += new System.EventHandler(this.btnUpdate_JPT_Click);
            // 
            // btnInsert_JPT
            // 
            this.btnInsert_JPT.Location = new System.Drawing.Point(749, 3);
            this.btnInsert_JPT.Name = "btnInsert_JPT";
            this.btnInsert_JPT.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_JPT.TabIndex = 1;
            this.btnInsert_JPT.Text = "Добавить";
            this.btnInsert_JPT.UseVisualStyleBackColor = true;
            this.btnInsert_JPT.Click += new System.EventHandler(this.btnInsert_JPT_Click);
            // 
            // dgvJPT
            // 
            this.dgvJPT.AllowUserToAddRows = false;
            this.dgvJPT.AllowUserToDeleteRows = false;
            this.dgvJPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJPT.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvJPT.Location = new System.Drawing.Point(3, 3);
            this.dgvJPT.Name = "dgvJPT";
            this.dgvJPT.Size = new System.Drawing.Size(740, 280);
            this.dgvJPT.TabIndex = 0;
            this.dgvJPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJPT_CellClick);
            // 
            // tpTTN
            // 
            this.tpTTN.Controls.Add(this.btnDelete_TTN);
            this.tpTTN.Controls.Add(this.btnUpdate_TTN);
            this.tpTTN.Controls.Add(this.btnInsert_TTN);
            this.tpTTN.Controls.Add(this.dgvTTN);
            this.tpTTN.Location = new System.Drawing.Point(4, 22);
            this.tpTTN.Name = "tpTTN";
            this.tpTTN.Padding = new System.Windows.Forms.Padding(3);
            this.tpTTN.Size = new System.Drawing.Size(852, 286);
            this.tpTTN.TabIndex = 1;
            this.tpTTN.Text = "Товарно-транспортная накладная";
            this.tpTTN.UseVisualStyleBackColor = true;
            // 
            // btnDelete_TTN
            // 
            this.btnDelete_TTN.Location = new System.Drawing.Point(749, 143);
            this.btnDelete_TTN.Name = "btnDelete_TTN";
            this.btnDelete_TTN.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_TTN.TabIndex = 6;
            this.btnDelete_TTN.Text = "Удалить";
            this.btnDelete_TTN.UseVisualStyleBackColor = true;
            this.btnDelete_TTN.Click += new System.EventHandler(this.btnDelete_TTN_Click);
            // 
            // btnUpdate_TTN
            // 
            this.btnUpdate_TTN.Location = new System.Drawing.Point(749, 73);
            this.btnUpdate_TTN.Name = "btnUpdate_TTN";
            this.btnUpdate_TTN.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_TTN.TabIndex = 5;
            this.btnUpdate_TTN.Text = "Изменить";
            this.btnUpdate_TTN.UseVisualStyleBackColor = true;
            this.btnUpdate_TTN.Click += new System.EventHandler(this.btnUpdate_TTN_Click);
            // 
            // btnInsert_TTN
            // 
            this.btnInsert_TTN.Location = new System.Drawing.Point(749, 3);
            this.btnInsert_TTN.Name = "btnInsert_TTN";
            this.btnInsert_TTN.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_TTN.TabIndex = 4;
            this.btnInsert_TTN.Text = "Добавить";
            this.btnInsert_TTN.UseVisualStyleBackColor = true;
            this.btnInsert_TTN.Click += new System.EventHandler(this.btnInsert_TTN_Click);
            // 
            // dgvTTN
            // 
            this.dgvTTN.AllowUserToAddRows = false;
            this.dgvTTN.AllowUserToDeleteRows = false;
            this.dgvTTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTTN.Location = new System.Drawing.Point(3, 3);
            this.dgvTTN.Name = "dgvTTN";
            this.dgvTTN.Size = new System.Drawing.Size(740, 280);
            this.dgvTTN.TabIndex = 0;
            this.dgvTTN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTN_CellClick);
            // 
            // tpJUDTNS
            // 
            this.tpJUDTNS.Controls.Add(this.btnDelete_JUDTNS);
            this.tpJUDTNS.Controls.Add(this.btnUpdate_JUDTNS);
            this.tpJUDTNS.Controls.Add(this.btnInsert_JUDTNS);
            this.tpJUDTNS.Controls.Add(this.dgvJUDTNS);
            this.tpJUDTNS.Location = new System.Drawing.Point(4, 22);
            this.tpJUDTNS.Name = "tpJUDTNS";
            this.tpJUDTNS.Size = new System.Drawing.Size(852, 286);
            this.tpJUDTNS.TabIndex = 2;
            this.tpJUDTNS.Text = "Журнал учёта движения товара на складе";
            this.tpJUDTNS.UseVisualStyleBackColor = true;
            // 
            // btnDelete_JUDTNS
            // 
            this.btnDelete_JUDTNS.Location = new System.Drawing.Point(749, 143);
            this.btnDelete_JUDTNS.Name = "btnDelete_JUDTNS";
            this.btnDelete_JUDTNS.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_JUDTNS.TabIndex = 9;
            this.btnDelete_JUDTNS.Text = "Удалить";
            this.btnDelete_JUDTNS.UseVisualStyleBackColor = true;
            this.btnDelete_JUDTNS.Click += new System.EventHandler(this.btnDelete_JUDTNS_Click);
            // 
            // btnUpdate_JUDTNS
            // 
            this.btnUpdate_JUDTNS.Location = new System.Drawing.Point(749, 73);
            this.btnUpdate_JUDTNS.Name = "btnUpdate_JUDTNS";
            this.btnUpdate_JUDTNS.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_JUDTNS.TabIndex = 8;
            this.btnUpdate_JUDTNS.Text = "Изменить";
            this.btnUpdate_JUDTNS.UseVisualStyleBackColor = true;
            this.btnUpdate_JUDTNS.Click += new System.EventHandler(this.btnUpdate_JUDTNS_Click);
            // 
            // btnInsert_JUDTNS
            // 
            this.btnInsert_JUDTNS.Location = new System.Drawing.Point(749, 3);
            this.btnInsert_JUDTNS.Name = "btnInsert_JUDTNS";
            this.btnInsert_JUDTNS.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_JUDTNS.TabIndex = 7;
            this.btnInsert_JUDTNS.Text = "Добавить";
            this.btnInsert_JUDTNS.UseVisualStyleBackColor = true;
            this.btnInsert_JUDTNS.Click += new System.EventHandler(this.btnInsert_JUDTNS_Click);
            // 
            // dgvJUDTNS
            // 
            this.dgvJUDTNS.AllowUserToAddRows = false;
            this.dgvJUDTNS.AllowUserToDeleteRows = false;
            this.dgvJUDTNS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJUDTNS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJUDTNS.Location = new System.Drawing.Point(3, 3);
            this.dgvJUDTNS.Name = "dgvJUDTNS";
            this.dgvJUDTNS.Size = new System.Drawing.Size(740, 280);
            this.dgvJUDTNS.TabIndex = 0;
            this.dgvJUDTNS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJUDTNS_CellClick);
            // 
            // tb_Spros
            // 
            this.tb_Spros.Controls.Add(this.btnExcel);
            this.tb_Spros.Controls.Add(this.btnDelete_Spros);
            this.tb_Spros.Controls.Add(this.btnUpdate_Spros);
            this.tb_Spros.Controls.Add(this.btnInsert_Spros);
            this.tb_Spros.Controls.Add(this.dgvSpros);
            this.tb_Spros.Location = new System.Drawing.Point(4, 22);
            this.tb_Spros.Name = "tb_Spros";
            this.tb_Spros.Size = new System.Drawing.Size(852, 286);
            this.tb_Spros.TabIndex = 3;
            this.tb_Spros.Text = "Спрос и наличие товаров";
            this.tb_Spros.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExcel.Location = new System.Drawing.Point(749, 213);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(99, 70);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnDelete_Spros
            // 
            this.btnDelete_Spros.Location = new System.Drawing.Point(749, 143);
            this.btnDelete_Spros.Name = "btnDelete_Spros";
            this.btnDelete_Spros.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Spros.TabIndex = 12;
            this.btnDelete_Spros.Text = "Удалить";
            this.btnDelete_Spros.UseVisualStyleBackColor = true;
            this.btnDelete_Spros.Click += new System.EventHandler(this.btnDelete_Spros_Click);
            // 
            // btnUpdate_Spros
            // 
            this.btnUpdate_Spros.Location = new System.Drawing.Point(749, 73);
            this.btnUpdate_Spros.Name = "btnUpdate_Spros";
            this.btnUpdate_Spros.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Spros.TabIndex = 11;
            this.btnUpdate_Spros.Text = "Изменить";
            this.btnUpdate_Spros.UseVisualStyleBackColor = true;
            this.btnUpdate_Spros.Click += new System.EventHandler(this.btnUpdate_Spros_Click);
            // 
            // btnInsert_Spros
            // 
            this.btnInsert_Spros.Location = new System.Drawing.Point(749, 3);
            this.btnInsert_Spros.Name = "btnInsert_Spros";
            this.btnInsert_Spros.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Spros.TabIndex = 10;
            this.btnInsert_Spros.Text = "Добавить";
            this.btnInsert_Spros.UseVisualStyleBackColor = true;
            this.btnInsert_Spros.Click += new System.EventHandler(this.btnInsert_Spros_Click);
            // 
            // dgvSpros
            // 
            this.dgvSpros.AllowUserToAddRows = false;
            this.dgvSpros.AllowUserToDeleteRows = false;
            this.dgvSpros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSpros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpros.Location = new System.Drawing.Point(3, 3);
            this.dgvSpros.Name = "dgvSpros";
            this.dgvSpros.Size = new System.Drawing.Size(740, 280);
            this.dgvSpros.TabIndex = 0;
            this.dgvSpros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpros_CellClick);
            // 
            // tpSopr
            // 
            this.tpSopr.Controls.Add(this.btnDelete_Sopr);
            this.tpSopr.Controls.Add(this.btnUpdate_Sopr);
            this.tpSopr.Controls.Add(this.btnInsert_Sopr);
            this.tpSopr.Controls.Add(this.dgvSopr);
            this.tpSopr.Location = new System.Drawing.Point(4, 22);
            this.tpSopr.Name = "tpSopr";
            this.tpSopr.Size = new System.Drawing.Size(852, 286);
            this.tpSopr.TabIndex = 4;
            this.tpSopr.Text = "Сопроводительный документ";
            this.tpSopr.UseVisualStyleBackColor = true;
            // 
            // btnDelete_Sopr
            // 
            this.btnDelete_Sopr.Location = new System.Drawing.Point(749, 143);
            this.btnDelete_Sopr.Name = "btnDelete_Sopr";
            this.btnDelete_Sopr.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Sopr.TabIndex = 15;
            this.btnDelete_Sopr.Text = "Удалить";
            this.btnDelete_Sopr.UseVisualStyleBackColor = true;
            this.btnDelete_Sopr.Click += new System.EventHandler(this.btnDelete_Sopr_Click);
            // 
            // btnUpdate_Sopr
            // 
            this.btnUpdate_Sopr.Location = new System.Drawing.Point(749, 73);
            this.btnUpdate_Sopr.Name = "btnUpdate_Sopr";
            this.btnUpdate_Sopr.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Sopr.TabIndex = 14;
            this.btnUpdate_Sopr.Text = "Изменить";
            this.btnUpdate_Sopr.UseVisualStyleBackColor = true;
            this.btnUpdate_Sopr.Click += new System.EventHandler(this.btnUpdate_Sopr_Click);
            // 
            // btnInsert_Sopr
            // 
            this.btnInsert_Sopr.Location = new System.Drawing.Point(749, 3);
            this.btnInsert_Sopr.Name = "btnInsert_Sopr";
            this.btnInsert_Sopr.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Sopr.TabIndex = 13;
            this.btnInsert_Sopr.Text = "Добавить";
            this.btnInsert_Sopr.UseVisualStyleBackColor = true;
            this.btnInsert_Sopr.Click += new System.EventHandler(this.btnInsert_Sopr_Click);
            // 
            // dgvSopr
            // 
            this.dgvSopr.AllowUserToAddRows = false;
            this.dgvSopr.AllowUserToDeleteRows = false;
            this.dgvSopr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSopr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSopr.Location = new System.Drawing.Point(3, 3);
            this.dgvSopr.Name = "dgvSopr";
            this.dgvSopr.Size = new System.Drawing.Size(740, 280);
            this.dgvSopr.TabIndex = 0;
            this.dgvSopr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSopr_CellClick);
            // 
            // tpShet
            // 
            this.tpShet.Controls.Add(this.groupBox1);
            this.tpShet.Controls.Add(this.btnDelete_Shet);
            this.tpShet.Controls.Add(this.btnUpdate_Shet);
            this.tpShet.Controls.Add(this.btnInsert_Shet);
            this.tpShet.Controls.Add(this.dgvShet);
            this.tpShet.Location = new System.Drawing.Point(4, 22);
            this.tpShet.Name = "tpShet";
            this.tpShet.Size = new System.Drawing.Size(852, 286);
            this.tpShet.TabIndex = 5;
            this.tpShet.Text = "Счёт-фактура";
            this.tpShet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPDF);
            this.groupBox1.Controls.Add(this.btnWord);
            this.groupBox1.Location = new System.Drawing.Point(749, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 70);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод в эл.вид";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Red;
            this.btnPDF.Location = new System.Drawing.Point(6, 41);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(87, 23);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWord.Location = new System.Drawing.Point(6, 15);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(87, 23);
            this.btnWord.TabIndex = 0;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnDelete_Shet
            // 
            this.btnDelete_Shet.Location = new System.Drawing.Point(749, 143);
            this.btnDelete_Shet.Name = "btnDelete_Shet";
            this.btnDelete_Shet.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Shet.TabIndex = 18;
            this.btnDelete_Shet.Text = "Удалить";
            this.btnDelete_Shet.UseVisualStyleBackColor = true;
            this.btnDelete_Shet.Click += new System.EventHandler(this.btnDelete_Shet_Click);
            // 
            // btnUpdate_Shet
            // 
            this.btnUpdate_Shet.Location = new System.Drawing.Point(749, 73);
            this.btnUpdate_Shet.Name = "btnUpdate_Shet";
            this.btnUpdate_Shet.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Shet.TabIndex = 17;
            this.btnUpdate_Shet.Text = "Изменить";
            this.btnUpdate_Shet.UseVisualStyleBackColor = true;
            this.btnUpdate_Shet.Click += new System.EventHandler(this.btnUpdate_Shet_Click);
            // 
            // btnInsert_Shet
            // 
            this.btnInsert_Shet.Location = new System.Drawing.Point(749, 3);
            this.btnInsert_Shet.Name = "btnInsert_Shet";
            this.btnInsert_Shet.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Shet.TabIndex = 16;
            this.btnInsert_Shet.Text = "Добавить";
            this.btnInsert_Shet.UseVisualStyleBackColor = true;
            this.btnInsert_Shet.Click += new System.EventHandler(this.btnInsert_Shet_Click);
            // 
            // dgvShet
            // 
            this.dgvShet.AllowUserToAddRows = false;
            this.dgvShet.AllowUserToDeleteRows = false;
            this.dgvShet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShet.Location = new System.Drawing.Point(3, 3);
            this.dgvShet.Name = "dgvShet";
            this.dgvShet.Size = new System.Drawing.Size(740, 280);
            this.dgvShet.TabIndex = 0;
            this.dgvShet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShet_CellClick);
            // 
            // Form_Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tc_Otchet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Otchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты";
            this.Load += new System.EventHandler(this.Form_Ochet_Load);
            this.tc_Otchet.ResumeLayout(false);
            this.tpJPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJPT)).EndInit();
            this.tpTTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTN)).EndInit();
            this.tpJUDTNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJUDTNS)).EndInit();
            this.tb_Spros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpros)).EndInit();
            this.tpSopr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSopr)).EndInit();
            this.tpShet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Otchet;
        private System.Windows.Forms.TabPage tpJPT;
        private System.Windows.Forms.TabPage tpTTN;
        private System.Windows.Forms.DataGridView dgvTTN;
        private System.Windows.Forms.TabPage tpJUDTNS;
        private System.Windows.Forms.DataGridView dgvJUDTNS;
        private System.Windows.Forms.TabPage tb_Spros;
        private System.Windows.Forms.DataGridView dgvSpros;
        private System.Windows.Forms.TabPage tpSopr;
        private System.Windows.Forms.DataGridView dgvSopr;
        private System.Windows.Forms.TabPage tpShet;
        private System.Windows.Forms.DataGridView dgvShet;
        public System.Windows.Forms.DataGridView dgvJPT;
        private System.Windows.Forms.Button btnInsert_JPT;
        private System.Windows.Forms.Button btnDelete_JPT;
        private System.Windows.Forms.Button btnUpdate_JPT;
        private System.Windows.Forms.Button btnDelete_TTN;
        private System.Windows.Forms.Button btnUpdate_TTN;
        private System.Windows.Forms.Button btnInsert_TTN;
        private System.Windows.Forms.Button btnDelete_JUDTNS;
        private System.Windows.Forms.Button btnUpdate_JUDTNS;
        private System.Windows.Forms.Button btnInsert_JUDTNS;
        private System.Windows.Forms.Button btnDelete_Spros;
        private System.Windows.Forms.Button btnUpdate_Spros;
        private System.Windows.Forms.Button btnInsert_Spros;
        private System.Windows.Forms.Button btnDelete_Sopr;
        private System.Windows.Forms.Button btnUpdate_Sopr;
        private System.Windows.Forms.Button btnInsert_Sopr;
        private System.Windows.Forms.Button btnDelete_Shet;
        private System.Windows.Forms.Button btnUpdate_Shet;
        private System.Windows.Forms.Button btnInsert_Shet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
    }
}