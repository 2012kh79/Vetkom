namespace Kursovoy_proekt
{
    partial class Form_Sklad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sklad));
            this.tcSklad = new System.Windows.Forms.TabControl();
            this.tpTovary_post = new System.Windows.Forms.TabPage();
            this.cmbPostavshik_ID = new System.Windows.Forms.ComboBox();
            this.lblPostavshik_ID = new System.Windows.Forms.Label();
            this.mtbData_proizv = new System.Windows.Forms.MaskedTextBox();
            this.lblData_proizv = new System.Windows.Forms.Label();
            this.lblNazv_tovar = new System.Windows.Forms.Label();
            this.tbNazv_tovar = new System.Windows.Forms.TextBox();
            this.btnDelete_Tovary_Post = new System.Windows.Forms.Button();
            this.btnUpdate_Tovary_Post = new System.Windows.Forms.Button();
            this.btnInsert_Tovary_Post = new System.Windows.Forms.Button();
            this.dgvTovary_Post = new System.Windows.Forms.DataGridView();
            this.tpTPP = new System.Windows.Forms.TabPage();
            this.cmbSertificat_ID = new System.Windows.Forms.ComboBox();
            this.cmbTovar_ID = new System.Windows.Forms.ComboBox();
            this.lblSertificat_ID = new System.Windows.Forms.Label();
            this.lblTovar_ID = new System.Windows.Forms.Label();
            this.nudKol_tovar = new System.Windows.Forms.NumericUpDown();
            this.lblKol_tovar = new System.Windows.Forms.Label();
            this.mtbVremya_otsenky = new System.Windows.Forms.MaskedTextBox();
            this.mtbData_otsenky = new System.Windows.Forms.MaskedTextBox();
            this.lblVremya_Otsenky = new System.Windows.Forms.Label();
            this.lblData_Otsenky = new System.Windows.Forms.Label();
            this.btnDelete_TPP = new System.Windows.Forms.Button();
            this.btnUpdate_TPP = new System.Windows.Forms.Button();
            this.btnInsert_TPP = new System.Windows.Forms.Button();
            this.dgvTPP = new System.Windows.Forms.DataGridView();
            this.tpSort = new System.Windows.Forms.TabPage();
            this.mtb_Srok_do = new System.Windows.Forms.MaskedTextBox();
            this.mtbSrok_ot = new System.Windows.Forms.MaskedTextBox();
            this.cmbTPP_ID = new System.Windows.Forms.ComboBox();
            this.cmb_Naim_sklad = new System.Windows.Forms.ComboBox();
            this.tbOblast = new System.Windows.Forms.TextBox();
            this.lblTPP_ID = new System.Windows.Forms.Label();
            this.lblSrok_do = new System.Windows.Forms.Label();
            this.lblSrok_ot = new System.Windows.Forms.Label();
            this.lblNaim_Sklad = new System.Windows.Forms.Label();
            this.lblOblast = new System.Windows.Forms.Label();
            this.btnDelete_Sort = new System.Windows.Forms.Button();
            this.btnUpdate_Sort = new System.Windows.Forms.Button();
            this.btnInsert_Sort = new System.Windows.Forms.Button();
            this.dgvSort = new System.Windows.Forms.DataGridView();
            this.tpZakaz = new System.Windows.Forms.TabPage();
            this.cmbSort_ID = new System.Windows.Forms.ComboBox();
            this.cmbKlient_Login = new System.Windows.Forms.ComboBox();
            this.cmbSposob_dostavki = new System.Windows.Forms.ComboBox();
            this.nudKol_zakaz = new System.Windows.Forms.NumericUpDown();
            this.lblKlient_Login = new System.Windows.Forms.Label();
            this.lblSort_ID = new System.Windows.Forms.Label();
            this.lblKol_zakaz = new System.Windows.Forms.Label();
            this.lblSposob_dostavki = new System.Windows.Forms.Label();
            this.btnDelete_Zakaz = new System.Windows.Forms.Button();
            this.btnUpdate_Zakaz = new System.Windows.Forms.Button();
            this.btnInsert_Zakaz = new System.Windows.Forms.Button();
            this.dgvZakaz = new System.Windows.Forms.DataGridView();
            this.tpKompl = new System.Windows.Forms.TabPage();
            this.cmbSopr_ID = new System.Windows.Forms.ComboBox();
            this.lblSopr_ID = new System.Windows.Forms.Label();
            this.cmbZakaz_ID = new System.Windows.Forms.ComboBox();
            this.lblZakaz_ID = new System.Windows.Forms.Label();
            this.lblData_kompl = new System.Windows.Forms.Label();
            this.mtbData_kompl = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete_Kompl = new System.Windows.Forms.Button();
            this.btnUpdate_Kompl = new System.Windows.Forms.Button();
            this.btnInsert_Kompl = new System.Windows.Forms.Button();
            this.dgv_Kompl = new System.Windows.Forms.DataGridView();
            this.tpPeredan = new System.Windows.Forms.TabPage();
            this.cmbShet_ID = new System.Windows.Forms.ComboBox();
            this.lblShet_ID = new System.Windows.Forms.Label();
            this.cmb_Kompl = new System.Windows.Forms.ComboBox();
            this.lblKompl_ID = new System.Windows.Forms.Label();
            this.mtbVremya_peredachi = new System.Windows.Forms.MaskedTextBox();
            this.mtbData_peredachi = new System.Windows.Forms.MaskedTextBox();
            this.lblVremya_peredachi = new System.Windows.Forms.Label();
            this.lblData_peredachi = new System.Windows.Forms.Label();
            this.btnDelete_Peredan = new System.Windows.Forms.Button();
            this.btnUpdate_Peredan = new System.Windows.Forms.Button();
            this.btnInsert_Peredan = new System.Windows.Forms.Button();
            this.dgvPeredan = new System.Windows.Forms.DataGridView();
            this.tcSklad.SuspendLayout();
            this.tpTovary_post.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovary_Post)).BeginInit();
            this.tpTPP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol_tovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPP)).BeginInit();
            this.tpSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSort)).BeginInit();
            this.tpZakaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol_zakaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaz)).BeginInit();
            this.tpKompl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kompl)).BeginInit();
            this.tpPeredan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeredan)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSklad
            // 
            this.tcSklad.Controls.Add(this.tpTovary_post);
            this.tcSklad.Controls.Add(this.tpTPP);
            this.tcSklad.Controls.Add(this.tpSort);
            this.tcSklad.Controls.Add(this.tpZakaz);
            this.tcSklad.Controls.Add(this.tpKompl);
            this.tcSklad.Controls.Add(this.tpPeredan);
            this.tcSklad.Location = new System.Drawing.Point(12, 46);
            this.tcSklad.Name = "tcSklad";
            this.tcSklad.SelectedIndex = 0;
            this.tcSklad.Size = new System.Drawing.Size(860, 380);
            this.tcSklad.TabIndex = 1;
            // 
            // tpTovary_post
            // 
            this.tpTovary_post.Controls.Add(this.cmbPostavshik_ID);
            this.tpTovary_post.Controls.Add(this.lblPostavshik_ID);
            this.tpTovary_post.Controls.Add(this.mtbData_proizv);
            this.tpTovary_post.Controls.Add(this.lblData_proizv);
            this.tpTovary_post.Controls.Add(this.lblNazv_tovar);
            this.tpTovary_post.Controls.Add(this.tbNazv_tovar);
            this.tpTovary_post.Controls.Add(this.btnDelete_Tovary_Post);
            this.tpTovary_post.Controls.Add(this.btnUpdate_Tovary_Post);
            this.tpTovary_post.Controls.Add(this.btnInsert_Tovary_Post);
            this.tpTovary_post.Controls.Add(this.dgvTovary_Post);
            this.tpTovary_post.Location = new System.Drawing.Point(4, 22);
            this.tpTovary_post.Name = "tpTovary_post";
            this.tpTovary_post.Padding = new System.Windows.Forms.Padding(3);
            this.tpTovary_post.Size = new System.Drawing.Size(852, 354);
            this.tpTovary_post.TabIndex = 0;
            this.tpTovary_post.Text = "Товары от поставщиков";
            this.tpTovary_post.UseVisualStyleBackColor = true;
            // 
            // cmbPostavshik_ID
            // 
            this.cmbPostavshik_ID.FormattingEnabled = true;
            this.cmbPostavshik_ID.Location = new System.Drawing.Point(7, 328);
            this.cmbPostavshik_ID.Name = "cmbPostavshik_ID";
            this.cmbPostavshik_ID.Size = new System.Drawing.Size(186, 21);
            this.cmbPostavshik_ID.TabIndex = 15;
            // 
            // lblPostavshik_ID
            // 
            this.lblPostavshik_ID.AutoSize = true;
            this.lblPostavshik_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPostavshik_ID.Location = new System.Drawing.Point(23, 305);
            this.lblPostavshik_ID.Name = "lblPostavshik_ID";
            this.lblPostavshik_ID.Size = new System.Drawing.Size(155, 20);
            this.lblPostavshik_ID.TabIndex = 14;
            this.lblPostavshik_ID.Text = "Номер поставщика";
            // 
            // mtbData_proizv
            // 
            this.mtbData_proizv.Location = new System.Drawing.Point(7, 282);
            this.mtbData_proizv.Mask = "00/00/0000";
            this.mtbData_proizv.Name = "mtbData_proizv";
            this.mtbData_proizv.Size = new System.Drawing.Size(186, 20);
            this.mtbData_proizv.TabIndex = 13;
            this.mtbData_proizv.ValidatingType = typeof(System.DateTime);
            // 
            // lblData_proizv
            // 
            this.lblData_proizv.AutoSize = true;
            this.lblData_proizv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData_proizv.Location = new System.Drawing.Point(23, 259);
            this.lblData_proizv.Name = "lblData_proizv";
            this.lblData_proizv.Size = new System.Drawing.Size(160, 20);
            this.lblData_proizv.TabIndex = 12;
            this.lblData_proizv.Text = "Дата производства";
            // 
            // lblNazv_tovar
            // 
            this.lblNazv_tovar.AutoSize = true;
            this.lblNazv_tovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNazv_tovar.Location = new System.Drawing.Point(32, 213);
            this.lblNazv_tovar.Name = "lblNazv_tovar";
            this.lblNazv_tovar.Size = new System.Drawing.Size(141, 20);
            this.lblNazv_tovar.TabIndex = 11;
            this.lblNazv_tovar.Text = "Название товара";
            // 
            // tbNazv_tovar
            // 
            this.tbNazv_tovar.Location = new System.Drawing.Point(7, 236);
            this.tbNazv_tovar.Name = "tbNazv_tovar";
            this.tbNazv_tovar.Size = new System.Drawing.Size(186, 20);
            this.tbNazv_tovar.TabIndex = 10;
            // 
            // btnDelete_Tovary_Post
            // 
            this.btnDelete_Tovary_Post.Location = new System.Drawing.Point(750, 146);
            this.btnDelete_Tovary_Post.Name = "btnDelete_Tovary_Post";
            this.btnDelete_Tovary_Post.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Tovary_Post.TabIndex = 9;
            this.btnDelete_Tovary_Post.Text = "Удалить";
            this.btnDelete_Tovary_Post.UseVisualStyleBackColor = true;
            this.btnDelete_Tovary_Post.Click += new System.EventHandler(this.btnDelete_Tovary_Post_Click);
            // 
            // btnUpdate_Tovary_Post
            // 
            this.btnUpdate_Tovary_Post.Location = new System.Drawing.Point(750, 76);
            this.btnUpdate_Tovary_Post.Name = "btnUpdate_Tovary_Post";
            this.btnUpdate_Tovary_Post.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Tovary_Post.TabIndex = 8;
            this.btnUpdate_Tovary_Post.Text = "Изменить";
            this.btnUpdate_Tovary_Post.UseVisualStyleBackColor = true;
            this.btnUpdate_Tovary_Post.Click += new System.EventHandler(this.btnUpdate_Tovary_Post_Click);
            // 
            // btnInsert_Tovary_Post
            // 
            this.btnInsert_Tovary_Post.Location = new System.Drawing.Point(750, 6);
            this.btnInsert_Tovary_Post.Name = "btnInsert_Tovary_Post";
            this.btnInsert_Tovary_Post.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Tovary_Post.TabIndex = 7;
            this.btnInsert_Tovary_Post.Text = "Добавить";
            this.btnInsert_Tovary_Post.UseVisualStyleBackColor = true;
            this.btnInsert_Tovary_Post.Click += new System.EventHandler(this.btnInsert_Tovary_Post_Click);
            // 
            // dgvTovary_Post
            // 
            this.dgvTovary_Post.AllowUserToAddRows = false;
            this.dgvTovary_Post.AllowUserToDeleteRows = false;
            this.dgvTovary_Post.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTovary_Post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTovary_Post.Location = new System.Drawing.Point(6, 6);
            this.dgvTovary_Post.Name = "dgvTovary_Post";
            this.dgvTovary_Post.Size = new System.Drawing.Size(740, 204);
            this.dgvTovary_Post.TabIndex = 1;
            this.dgvTovary_Post.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTovary_Post_CellClick);
            // 
            // tpTPP
            // 
            this.tpTPP.Controls.Add(this.cmbSertificat_ID);
            this.tpTPP.Controls.Add(this.cmbTovar_ID);
            this.tpTPP.Controls.Add(this.lblSertificat_ID);
            this.tpTPP.Controls.Add(this.lblTovar_ID);
            this.tpTPP.Controls.Add(this.nudKol_tovar);
            this.tpTPP.Controls.Add(this.lblKol_tovar);
            this.tpTPP.Controls.Add(this.mtbVremya_otsenky);
            this.tpTPP.Controls.Add(this.mtbData_otsenky);
            this.tpTPP.Controls.Add(this.lblVremya_Otsenky);
            this.tpTPP.Controls.Add(this.lblData_Otsenky);
            this.tpTPP.Controls.Add(this.btnDelete_TPP);
            this.tpTPP.Controls.Add(this.btnUpdate_TPP);
            this.tpTPP.Controls.Add(this.btnInsert_TPP);
            this.tpTPP.Controls.Add(this.dgvTPP);
            this.tpTPP.Location = new System.Drawing.Point(4, 22);
            this.tpTPP.Name = "tpTPP";
            this.tpTPP.Padding = new System.Windows.Forms.Padding(3);
            this.tpTPP.Size = new System.Drawing.Size(852, 354);
            this.tpTPP.TabIndex = 1;
            this.tpTPP.Text = "Товары, прошедшие проверку";
            this.tpTPP.UseVisualStyleBackColor = true;
            // 
            // cmbSertificat_ID
            // 
            this.cmbSertificat_ID.FormattingEnabled = true;
            this.cmbSertificat_ID.Location = new System.Drawing.Point(198, 282);
            this.cmbSertificat_ID.Name = "cmbSertificat_ID";
            this.cmbSertificat_ID.Size = new System.Drawing.Size(186, 21);
            this.cmbSertificat_ID.TabIndex = 25;
            // 
            // cmbTovar_ID
            // 
            this.cmbTovar_ID.FormattingEnabled = true;
            this.cmbTovar_ID.Location = new System.Drawing.Point(198, 235);
            this.cmbTovar_ID.Name = "cmbTovar_ID";
            this.cmbTovar_ID.Size = new System.Drawing.Size(186, 21);
            this.cmbTovar_ID.TabIndex = 24;
            // 
            // lblSertificat_ID
            // 
            this.lblSertificat_ID.AutoSize = true;
            this.lblSertificat_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSertificat_ID.Location = new System.Drawing.Point(211, 259);
            this.lblSertificat_ID.Name = "lblSertificat_ID";
            this.lblSertificat_ID.Size = new System.Drawing.Size(166, 20);
            this.lblSertificat_ID.TabIndex = 23;
            this.lblSertificat_ID.Text = "Номер сертификата";
            // 
            // lblTovar_ID
            // 
            this.lblTovar_ID.AutoSize = true;
            this.lblTovar_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTovar_ID.Location = new System.Drawing.Point(238, 213);
            this.lblTovar_ID.Name = "lblTovar_ID";
            this.lblTovar_ID.Size = new System.Drawing.Size(117, 20);
            this.lblTovar_ID.TabIndex = 22;
            this.lblTovar_ID.Text = "Номер товара";
            // 
            // nudKol_tovar
            // 
            this.nudKol_tovar.Location = new System.Drawing.Point(6, 328);
            this.nudKol_tovar.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudKol_tovar.Name = "nudKol_tovar";
            this.nudKol_tovar.Size = new System.Drawing.Size(186, 20);
            this.nudKol_tovar.TabIndex = 21;
            // 
            // lblKol_tovar
            // 
            this.lblKol_tovar.AutoSize = true;
            this.lblKol_tovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKol_tovar.Location = new System.Drawing.Point(21, 305);
            this.lblKol_tovar.Name = "lblKol_tovar";
            this.lblKol_tovar.Size = new System.Drawing.Size(158, 20);
            this.lblKol_tovar.TabIndex = 20;
            this.lblKol_tovar.Text = "Количество товара";
            // 
            // mtbVremya_otsenky
            // 
            this.mtbVremya_otsenky.Location = new System.Drawing.Point(6, 282);
            this.mtbVremya_otsenky.Mask = "00:00";
            this.mtbVremya_otsenky.Name = "mtbVremya_otsenky";
            this.mtbVremya_otsenky.Size = new System.Drawing.Size(186, 20);
            this.mtbVremya_otsenky.TabIndex = 19;
            this.mtbVremya_otsenky.ValidatingType = typeof(System.DateTime);
            // 
            // mtbData_otsenky
            // 
            this.mtbData_otsenky.Location = new System.Drawing.Point(6, 236);
            this.mtbData_otsenky.Mask = "00/00/0000";
            this.mtbData_otsenky.Name = "mtbData_otsenky";
            this.mtbData_otsenky.Size = new System.Drawing.Size(186, 20);
            this.mtbData_otsenky.TabIndex = 18;
            this.mtbData_otsenky.ValidatingType = typeof(System.DateTime);
            // 
            // lblVremya_Otsenky
            // 
            this.lblVremya_Otsenky.AutoSize = true;
            this.lblVremya_Otsenky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVremya_Otsenky.Location = new System.Drawing.Point(48, 259);
            this.lblVremya_Otsenky.Name = "lblVremya_Otsenky";
            this.lblVremya_Otsenky.Size = new System.Drawing.Size(115, 20);
            this.lblVremya_Otsenky.TabIndex = 17;
            this.lblVremya_Otsenky.Text = "Время оценки";
            // 
            // lblData_Otsenky
            // 
            this.lblData_Otsenky.AutoSize = true;
            this.lblData_Otsenky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData_Otsenky.Location = new System.Drawing.Point(48, 213);
            this.lblData_Otsenky.Name = "lblData_Otsenky";
            this.lblData_Otsenky.Size = new System.Drawing.Size(105, 20);
            this.lblData_Otsenky.TabIndex = 16;
            this.lblData_Otsenky.Text = "Дата оценки";
            // 
            // btnDelete_TPP
            // 
            this.btnDelete_TPP.Location = new System.Drawing.Point(750, 146);
            this.btnDelete_TPP.Name = "btnDelete_TPP";
            this.btnDelete_TPP.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_TPP.TabIndex = 15;
            this.btnDelete_TPP.Text = "Удалить";
            this.btnDelete_TPP.UseVisualStyleBackColor = true;
            this.btnDelete_TPP.Click += new System.EventHandler(this.btnDelete_TPP_Click);
            // 
            // btnUpdate_TPP
            // 
            this.btnUpdate_TPP.Location = new System.Drawing.Point(750, 76);
            this.btnUpdate_TPP.Name = "btnUpdate_TPP";
            this.btnUpdate_TPP.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_TPP.TabIndex = 14;
            this.btnUpdate_TPP.Text = "Изменить";
            this.btnUpdate_TPP.UseVisualStyleBackColor = true;
            this.btnUpdate_TPP.Click += new System.EventHandler(this.btnUpdate_TPP_Click);
            // 
            // btnInsert_TPP
            // 
            this.btnInsert_TPP.Location = new System.Drawing.Point(750, 6);
            this.btnInsert_TPP.Name = "btnInsert_TPP";
            this.btnInsert_TPP.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_TPP.TabIndex = 13;
            this.btnInsert_TPP.Text = "Добавить";
            this.btnInsert_TPP.UseVisualStyleBackColor = true;
            this.btnInsert_TPP.Click += new System.EventHandler(this.btnInsert_TPP_Click);
            // 
            // dgvTPP
            // 
            this.dgvTPP.AllowUserToAddRows = false;
            this.dgvTPP.AllowUserToDeleteRows = false;
            this.dgvTPP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTPP.Location = new System.Drawing.Point(6, 6);
            this.dgvTPP.Name = "dgvTPP";
            this.dgvTPP.Size = new System.Drawing.Size(740, 204);
            this.dgvTPP.TabIndex = 12;
            this.dgvTPP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTPP_CellClick);
            // 
            // tpSort
            // 
            this.tpSort.Controls.Add(this.mtb_Srok_do);
            this.tpSort.Controls.Add(this.mtbSrok_ot);
            this.tpSort.Controls.Add(this.cmbTPP_ID);
            this.tpSort.Controls.Add(this.cmb_Naim_sklad);
            this.tpSort.Controls.Add(this.tbOblast);
            this.tpSort.Controls.Add(this.lblTPP_ID);
            this.tpSort.Controls.Add(this.lblSrok_do);
            this.tpSort.Controls.Add(this.lblSrok_ot);
            this.tpSort.Controls.Add(this.lblNaim_Sklad);
            this.tpSort.Controls.Add(this.lblOblast);
            this.tpSort.Controls.Add(this.btnDelete_Sort);
            this.tpSort.Controls.Add(this.btnUpdate_Sort);
            this.tpSort.Controls.Add(this.btnInsert_Sort);
            this.tpSort.Controls.Add(this.dgvSort);
            this.tpSort.Location = new System.Drawing.Point(4, 22);
            this.tpSort.Name = "tpSort";
            this.tpSort.Size = new System.Drawing.Size(852, 354);
            this.tpSort.TabIndex = 2;
            this.tpSort.Text = "Сортированные товары";
            this.tpSort.UseVisualStyleBackColor = true;
            // 
            // mtb_Srok_do
            // 
            this.mtb_Srok_do.Location = new System.Drawing.Point(200, 283);
            this.mtb_Srok_do.Mask = "00/00/0000";
            this.mtb_Srok_do.Name = "mtb_Srok_do";
            this.mtb_Srok_do.Size = new System.Drawing.Size(186, 20);
            this.mtb_Srok_do.TabIndex = 36;
            this.mtb_Srok_do.ValidatingType = typeof(System.DateTime);
            // 
            // mtbSrok_ot
            // 
            this.mtbSrok_ot.Location = new System.Drawing.Point(200, 237);
            this.mtbSrok_ot.Mask = "00/00/0000";
            this.mtbSrok_ot.Name = "mtbSrok_ot";
            this.mtbSrok_ot.Size = new System.Drawing.Size(186, 20);
            this.mtbSrok_ot.TabIndex = 35;
            this.mtbSrok_ot.ValidatingType = typeof(System.DateTime);
            // 
            // cmbTPP_ID
            // 
            this.cmbTPP_ID.FormattingEnabled = true;
            this.cmbTPP_ID.Location = new System.Drawing.Point(8, 330);
            this.cmbTPP_ID.Name = "cmbTPP_ID";
            this.cmbTPP_ID.Size = new System.Drawing.Size(186, 21);
            this.cmbTPP_ID.TabIndex = 34;
            // 
            // cmb_Naim_sklad
            // 
            this.cmb_Naim_sklad.FormattingEnabled = true;
            this.cmb_Naim_sklad.Location = new System.Drawing.Point(8, 283);
            this.cmb_Naim_sklad.Name = "cmb_Naim_sklad";
            this.cmb_Naim_sklad.Size = new System.Drawing.Size(186, 21);
            this.cmb_Naim_sklad.TabIndex = 33;
            // 
            // tbOblast
            // 
            this.tbOblast.Location = new System.Drawing.Point(8, 237);
            this.tbOblast.Name = "tbOblast";
            this.tbOblast.Size = new System.Drawing.Size(186, 20);
            this.tbOblast.TabIndex = 32;
            // 
            // lblTPP_ID
            // 
            this.lblTPP_ID.AutoSize = true;
            this.lblTPP_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTPP_ID.Location = new System.Drawing.Point(50, 307);
            this.lblTPP_ID.Name = "lblTPP_ID";
            this.lblTPP_ID.Size = new System.Drawing.Size(96, 20);
            this.lblTPP_ID.TabIndex = 31;
            this.lblTPP_ID.Text = "Номер ТПП";
            // 
            // lblSrok_do
            // 
            this.lblSrok_do.AutoSize = true;
            this.lblSrok_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSrok_do.Location = new System.Drawing.Point(226, 260);
            this.lblSrok_do.Name = "lblSrok_do";
            this.lblSrok_do.Size = new System.Drawing.Size(144, 20);
            this.lblSrok_do.TabIndex = 30;
            this.lblSrok_do.Text = "Срок хранения до";
            // 
            // lblSrok_ot
            // 
            this.lblSrok_ot.AutoSize = true;
            this.lblSrok_ot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSrok_ot.Location = new System.Drawing.Point(228, 211);
            this.lblSrok_ot.Name = "lblSrok_ot";
            this.lblSrok_ot.Size = new System.Drawing.Size(142, 20);
            this.lblSrok_ot.TabIndex = 29;
            this.lblSrok_ot.Text = "Срок хранения от";
            // 
            // lblNaim_Sklad
            // 
            this.lblNaim_Sklad.AutoSize = true;
            this.lblNaim_Sklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNaim_Sklad.Location = new System.Drawing.Point(10, 260);
            this.lblNaim_Sklad.Name = "lblNaim_Sklad";
            this.lblNaim_Sklad.Size = new System.Drawing.Size(181, 20);
            this.lblNaim_Sklad.TabIndex = 28;
            this.lblNaim_Sklad.Text = "Наименование склада";
            // 
            // lblOblast
            // 
            this.lblOblast.AutoSize = true;
            this.lblOblast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOblast.Location = new System.Drawing.Point(15, 213);
            this.lblOblast.Name = "lblOblast";
            this.lblOblast.Size = new System.Drawing.Size(171, 20);
            this.lblOblast.TabIndex = 27;
            this.lblOblast.Text = "Область применения";
            // 
            // btnDelete_Sort
            // 
            this.btnDelete_Sort.Location = new System.Drawing.Point(749, 146);
            this.btnDelete_Sort.Name = "btnDelete_Sort";
            this.btnDelete_Sort.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Sort.TabIndex = 26;
            this.btnDelete_Sort.Text = "Удалить";
            this.btnDelete_Sort.UseVisualStyleBackColor = true;
            this.btnDelete_Sort.Click += new System.EventHandler(this.btnDelete_Sort_Click);
            // 
            // btnUpdate_Sort
            // 
            this.btnUpdate_Sort.Location = new System.Drawing.Point(749, 76);
            this.btnUpdate_Sort.Name = "btnUpdate_Sort";
            this.btnUpdate_Sort.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Sort.TabIndex = 25;
            this.btnUpdate_Sort.Text = "Изменить";
            this.btnUpdate_Sort.UseVisualStyleBackColor = true;
            this.btnUpdate_Sort.Click += new System.EventHandler(this.btnUpdate_Sort_Click);
            // 
            // btnInsert_Sort
            // 
            this.btnInsert_Sort.Location = new System.Drawing.Point(749, 6);
            this.btnInsert_Sort.Name = "btnInsert_Sort";
            this.btnInsert_Sort.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Sort.TabIndex = 24;
            this.btnInsert_Sort.Text = "Добавить";
            this.btnInsert_Sort.UseVisualStyleBackColor = true;
            this.btnInsert_Sort.Click += new System.EventHandler(this.btnInsert_Sort_Click);
            // 
            // dgvSort
            // 
            this.dgvSort.AllowUserToAddRows = false;
            this.dgvSort.AllowUserToDeleteRows = false;
            this.dgvSort.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSort.Location = new System.Drawing.Point(6, 6);
            this.dgvSort.Name = "dgvSort";
            this.dgvSort.Size = new System.Drawing.Size(740, 204);
            this.dgvSort.TabIndex = 23;
            this.dgvSort.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSort_CellClick);
            // 
            // tpZakaz
            // 
            this.tpZakaz.Controls.Add(this.cmbSort_ID);
            this.tpZakaz.Controls.Add(this.cmbKlient_Login);
            this.tpZakaz.Controls.Add(this.cmbSposob_dostavki);
            this.tpZakaz.Controls.Add(this.nudKol_zakaz);
            this.tpZakaz.Controls.Add(this.lblKlient_Login);
            this.tpZakaz.Controls.Add(this.lblSort_ID);
            this.tpZakaz.Controls.Add(this.lblKol_zakaz);
            this.tpZakaz.Controls.Add(this.lblSposob_dostavki);
            this.tpZakaz.Controls.Add(this.btnDelete_Zakaz);
            this.tpZakaz.Controls.Add(this.btnUpdate_Zakaz);
            this.tpZakaz.Controls.Add(this.btnInsert_Zakaz);
            this.tpZakaz.Controls.Add(this.dgvZakaz);
            this.tpZakaz.Location = new System.Drawing.Point(4, 22);
            this.tpZakaz.Name = "tpZakaz";
            this.tpZakaz.Size = new System.Drawing.Size(852, 354);
            this.tpZakaz.TabIndex = 3;
            this.tpZakaz.Text = "Заказанные товары";
            this.tpZakaz.UseVisualStyleBackColor = true;
            // 
            // cmbSort_ID
            // 
            this.cmbSort_ID.FormattingEnabled = true;
            this.cmbSort_ID.Location = new System.Drawing.Point(198, 236);
            this.cmbSort_ID.Name = "cmbSort_ID";
            this.cmbSort_ID.Size = new System.Drawing.Size(240, 21);
            this.cmbSort_ID.TabIndex = 38;
            // 
            // cmbKlient_Login
            // 
            this.cmbKlient_Login.FormattingEnabled = true;
            this.cmbKlient_Login.Location = new System.Drawing.Point(6, 329);
            this.cmbKlient_Login.Name = "cmbKlient_Login";
            this.cmbKlient_Login.Size = new System.Drawing.Size(186, 21);
            this.cmbKlient_Login.TabIndex = 37;
            // 
            // cmbSposob_dostavki
            // 
            this.cmbSposob_dostavki.FormattingEnabled = true;
            this.cmbSposob_dostavki.Location = new System.Drawing.Point(6, 236);
            this.cmbSposob_dostavki.Name = "cmbSposob_dostavki";
            this.cmbSposob_dostavki.Size = new System.Drawing.Size(186, 21);
            this.cmbSposob_dostavki.TabIndex = 36;
            // 
            // nudKol_zakaz
            // 
            this.nudKol_zakaz.Location = new System.Drawing.Point(6, 283);
            this.nudKol_zakaz.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudKol_zakaz.Name = "nudKol_zakaz";
            this.nudKol_zakaz.Size = new System.Drawing.Size(186, 20);
            this.nudKol_zakaz.TabIndex = 35;
            // 
            // lblKlient_Login
            // 
            this.lblKlient_Login.AutoSize = true;
            this.lblKlient_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlient_Login.Location = new System.Drawing.Point(32, 306);
            this.lblKlient_Login.Name = "lblKlient_Login";
            this.lblKlient_Login.Size = new System.Drawing.Size(122, 20);
            this.lblKlient_Login.TabIndex = 34;
            this.lblKlient_Login.Text = "Логин клиента";
            // 
            // lblSort_ID
            // 
            this.lblSort_ID.AutoSize = true;
            this.lblSort_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSort_ID.Location = new System.Drawing.Point(196, 213);
            this.lblSort_ID.Name = "lblSort_ID";
            this.lblSort_ID.Size = new System.Drawing.Size(244, 20);
            this.lblSort_ID.TabIndex = 33;
            this.lblSort_ID.Text = "Номер сортированного товара";
            // 
            // lblKol_zakaz
            // 
            this.lblKol_zakaz.AutoSize = true;
            this.lblKol_zakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKol_zakaz.Location = new System.Drawing.Point(19, 260);
            this.lblKol_zakaz.Name = "lblKol_zakaz";
            this.lblKol_zakaz.Size = new System.Drawing.Size(158, 20);
            this.lblKol_zakaz.TabIndex = 32;
            this.lblKol_zakaz.Text = "Количество товара";
            // 
            // lblSposob_dostavki
            // 
            this.lblSposob_dostavki.AutoSize = true;
            this.lblSposob_dostavki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSposob_dostavki.Location = new System.Drawing.Point(28, 213);
            this.lblSposob_dostavki.Name = "lblSposob_dostavki";
            this.lblSposob_dostavki.Size = new System.Drawing.Size(140, 20);
            this.lblSposob_dostavki.TabIndex = 31;
            this.lblSposob_dostavki.Text = "Способ доставки";
            // 
            // btnDelete_Zakaz
            // 
            this.btnDelete_Zakaz.Location = new System.Drawing.Point(750, 146);
            this.btnDelete_Zakaz.Name = "btnDelete_Zakaz";
            this.btnDelete_Zakaz.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Zakaz.TabIndex = 30;
            this.btnDelete_Zakaz.Text = "Удалить";
            this.btnDelete_Zakaz.UseVisualStyleBackColor = true;
            this.btnDelete_Zakaz.Click += new System.EventHandler(this.btnDelete_Zakaz_Click);
            // 
            // btnUpdate_Zakaz
            // 
            this.btnUpdate_Zakaz.Location = new System.Drawing.Point(750, 76);
            this.btnUpdate_Zakaz.Name = "btnUpdate_Zakaz";
            this.btnUpdate_Zakaz.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Zakaz.TabIndex = 29;
            this.btnUpdate_Zakaz.Text = "Изменить";
            this.btnUpdate_Zakaz.UseVisualStyleBackColor = true;
            this.btnUpdate_Zakaz.Click += new System.EventHandler(this.btnUpdate_Zakaz_Click);
            // 
            // btnInsert_Zakaz
            // 
            this.btnInsert_Zakaz.Location = new System.Drawing.Point(750, 6);
            this.btnInsert_Zakaz.Name = "btnInsert_Zakaz";
            this.btnInsert_Zakaz.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Zakaz.TabIndex = 28;
            this.btnInsert_Zakaz.Text = "Добавить";
            this.btnInsert_Zakaz.UseVisualStyleBackColor = true;
            this.btnInsert_Zakaz.Click += new System.EventHandler(this.btnInsert_Zakaz_Click);
            // 
            // dgvZakaz
            // 
            this.dgvZakaz.AllowUserToAddRows = false;
            this.dgvZakaz.AllowUserToDeleteRows = false;
            this.dgvZakaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZakaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakaz.Location = new System.Drawing.Point(6, 6);
            this.dgvZakaz.Name = "dgvZakaz";
            this.dgvZakaz.Size = new System.Drawing.Size(740, 204);
            this.dgvZakaz.TabIndex = 27;
            this.dgvZakaz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZakaz_CellClick);
            // 
            // tpKompl
            // 
            this.tpKompl.Controls.Add(this.cmbSopr_ID);
            this.tpKompl.Controls.Add(this.lblSopr_ID);
            this.tpKompl.Controls.Add(this.cmbZakaz_ID);
            this.tpKompl.Controls.Add(this.lblZakaz_ID);
            this.tpKompl.Controls.Add(this.lblData_kompl);
            this.tpKompl.Controls.Add(this.mtbData_kompl);
            this.tpKompl.Controls.Add(this.btnDelete_Kompl);
            this.tpKompl.Controls.Add(this.btnUpdate_Kompl);
            this.tpKompl.Controls.Add(this.btnInsert_Kompl);
            this.tpKompl.Controls.Add(this.dgv_Kompl);
            this.tpKompl.Location = new System.Drawing.Point(4, 22);
            this.tpKompl.Name = "tpKompl";
            this.tpKompl.Size = new System.Drawing.Size(852, 354);
            this.tpKompl.TabIndex = 4;
            this.tpKompl.Text = "Укомплектованные товары";
            this.tpKompl.UseVisualStyleBackColor = true;
            // 
            // cmbSopr_ID
            // 
            this.cmbSopr_ID.FormattingEnabled = true;
            this.cmbSopr_ID.Location = new System.Drawing.Point(7, 329);
            this.cmbSopr_ID.Name = "cmbSopr_ID";
            this.cmbSopr_ID.Size = new System.Drawing.Size(186, 21);
            this.cmbSopr_ID.TabIndex = 41;
            // 
            // lblSopr_ID
            // 
            this.lblSopr_ID.AutoSize = true;
            this.lblSopr_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSopr_ID.Location = new System.Drawing.Point(3, 306);
            this.lblSopr_ID.Name = "lblSopr_ID";
            this.lblSopr_ID.Size = new System.Drawing.Size(366, 20);
            this.lblSopr_ID.TabIndex = 40;
            this.lblSopr_ID.Text = "Номер записи в сопроводительном документе";
            // 
            // cmbZakaz_ID
            // 
            this.cmbZakaz_ID.FormattingEnabled = true;
            this.cmbZakaz_ID.Location = new System.Drawing.Point(7, 282);
            this.cmbZakaz_ID.Name = "cmbZakaz_ID";
            this.cmbZakaz_ID.Size = new System.Drawing.Size(186, 21);
            this.cmbZakaz_ID.TabIndex = 39;
            // 
            // lblZakaz_ID
            // 
            this.lblZakaz_ID.AutoSize = true;
            this.lblZakaz_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZakaz_ID.Location = new System.Drawing.Point(3, 259);
            this.lblZakaz_ID.Name = "lblZakaz_ID";
            this.lblZakaz_ID.Size = new System.Drawing.Size(215, 20);
            this.lblZakaz_ID.TabIndex = 38;
            this.lblZakaz_ID.Text = "Номер заказанного товара";
            // 
            // lblData_kompl
            // 
            this.lblData_kompl.AutoSize = true;
            this.lblData_kompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData_kompl.Location = new System.Drawing.Point(19, 213);
            this.lblData_kompl.Name = "lblData_kompl";
            this.lblData_kompl.Size = new System.Drawing.Size(161, 20);
            this.lblData_kompl.TabIndex = 37;
            this.lblData_kompl.Text = "Дата комплектации";
            // 
            // mtbData_kompl
            // 
            this.mtbData_kompl.Location = new System.Drawing.Point(6, 236);
            this.mtbData_kompl.Mask = "00/00/0000";
            this.mtbData_kompl.Name = "mtbData_kompl";
            this.mtbData_kompl.Size = new System.Drawing.Size(186, 20);
            this.mtbData_kompl.TabIndex = 36;
            this.mtbData_kompl.ValidatingType = typeof(System.DateTime);
            // 
            // btnDelete_Kompl
            // 
            this.btnDelete_Kompl.Location = new System.Drawing.Point(750, 146);
            this.btnDelete_Kompl.Name = "btnDelete_Kompl";
            this.btnDelete_Kompl.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Kompl.TabIndex = 34;
            this.btnDelete_Kompl.Text = "Удалить";
            this.btnDelete_Kompl.UseVisualStyleBackColor = true;
            this.btnDelete_Kompl.Click += new System.EventHandler(this.btnDelete_Kompl_Click);
            // 
            // btnUpdate_Kompl
            // 
            this.btnUpdate_Kompl.Location = new System.Drawing.Point(750, 76);
            this.btnUpdate_Kompl.Name = "btnUpdate_Kompl";
            this.btnUpdate_Kompl.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Kompl.TabIndex = 33;
            this.btnUpdate_Kompl.Text = "Изменить";
            this.btnUpdate_Kompl.UseVisualStyleBackColor = true;
            this.btnUpdate_Kompl.Click += new System.EventHandler(this.btnUpdate_Kompl_Click);
            // 
            // btnInsert_Kompl
            // 
            this.btnInsert_Kompl.Location = new System.Drawing.Point(750, 6);
            this.btnInsert_Kompl.Name = "btnInsert_Kompl";
            this.btnInsert_Kompl.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Kompl.TabIndex = 32;
            this.btnInsert_Kompl.Text = "Добавить";
            this.btnInsert_Kompl.UseVisualStyleBackColor = true;
            this.btnInsert_Kompl.Click += new System.EventHandler(this.btnInsert_Kompl_Click);
            // 
            // dgv_Kompl
            // 
            this.dgv_Kompl.AllowUserToAddRows = false;
            this.dgv_Kompl.AllowUserToDeleteRows = false;
            this.dgv_Kompl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Kompl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kompl.Location = new System.Drawing.Point(6, 6);
            this.dgv_Kompl.Name = "dgv_Kompl";
            this.dgv_Kompl.Size = new System.Drawing.Size(740, 204);
            this.dgv_Kompl.TabIndex = 31;
            this.dgv_Kompl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Kompl_CellClick);
            // 
            // tpPeredan
            // 
            this.tpPeredan.Controls.Add(this.cmbShet_ID);
            this.tpPeredan.Controls.Add(this.lblShet_ID);
            this.tpPeredan.Controls.Add(this.cmb_Kompl);
            this.tpPeredan.Controls.Add(this.lblKompl_ID);
            this.tpPeredan.Controls.Add(this.mtbVremya_peredachi);
            this.tpPeredan.Controls.Add(this.mtbData_peredachi);
            this.tpPeredan.Controls.Add(this.lblVremya_peredachi);
            this.tpPeredan.Controls.Add(this.lblData_peredachi);
            this.tpPeredan.Controls.Add(this.btnDelete_Peredan);
            this.tpPeredan.Controls.Add(this.btnUpdate_Peredan);
            this.tpPeredan.Controls.Add(this.btnInsert_Peredan);
            this.tpPeredan.Controls.Add(this.dgvPeredan);
            this.tpPeredan.Location = new System.Drawing.Point(4, 22);
            this.tpPeredan.Name = "tpPeredan";
            this.tpPeredan.Size = new System.Drawing.Size(852, 354);
            this.tpPeredan.TabIndex = 5;
            this.tpPeredan.Text = "Переданные товары";
            this.tpPeredan.UseVisualStyleBackColor = true;
            // 
            // cmbShet_ID
            // 
            this.cmbShet_ID.FormattingEnabled = true;
            this.cmbShet_ID.Location = new System.Drawing.Point(215, 235);
            this.cmbShet_ID.Name = "cmbShet_ID";
            this.cmbShet_ID.Size = new System.Drawing.Size(234, 21);
            this.cmbShet_ID.TabIndex = 46;
            // 
            // lblShet_ID
            // 
            this.lblShet_ID.AutoSize = true;
            this.lblShet_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShet_ID.Location = new System.Drawing.Point(211, 213);
            this.lblShet_ID.Name = "lblShet_ID";
            this.lblShet_ID.Size = new System.Drawing.Size(238, 20);
            this.lblShet_ID.TabIndex = 45;
            this.lblShet_ID.Text = "Номер записи в счёт-фактуре";
            // 
            // cmb_Kompl
            // 
            this.cmb_Kompl.FormattingEnabled = true;
            this.cmb_Kompl.Location = new System.Drawing.Point(7, 328);
            this.cmb_Kompl.Name = "cmb_Kompl";
            this.cmb_Kompl.Size = new System.Drawing.Size(186, 21);
            this.cmb_Kompl.TabIndex = 44;
            // 
            // lblKompl_ID
            // 
            this.lblKompl_ID.AutoSize = true;
            this.lblKompl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKompl_ID.Location = new System.Drawing.Point(3, 305);
            this.lblKompl_ID.Name = "lblKompl_ID";
            this.lblKompl_ID.Size = new System.Drawing.Size(271, 20);
            this.lblKompl_ID.TabIndex = 43;
            this.lblKompl_ID.Text = "Номер укомплектованного товара";
            // 
            // mtbVremya_peredachi
            // 
            this.mtbVremya_peredachi.Location = new System.Drawing.Point(7, 282);
            this.mtbVremya_peredachi.Mask = "00:00";
            this.mtbVremya_peredachi.Name = "mtbVremya_peredachi";
            this.mtbVremya_peredachi.Size = new System.Drawing.Size(186, 20);
            this.mtbVremya_peredachi.TabIndex = 42;
            this.mtbVremya_peredachi.ValidatingType = typeof(System.DateTime);
            // 
            // mtbData_peredachi
            // 
            this.mtbData_peredachi.Location = new System.Drawing.Point(7, 236);
            this.mtbData_peredachi.Mask = "00/00/0000";
            this.mtbData_peredachi.Name = "mtbData_peredachi";
            this.mtbData_peredachi.Size = new System.Drawing.Size(186, 20);
            this.mtbData_peredachi.TabIndex = 41;
            this.mtbData_peredachi.ValidatingType = typeof(System.DateTime);
            // 
            // lblVremya_peredachi
            // 
            this.lblVremya_peredachi.AutoSize = true;
            this.lblVremya_peredachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVremya_peredachi.Location = new System.Drawing.Point(29, 259);
            this.lblVremya_peredachi.Name = "lblVremya_peredachi";
            this.lblVremya_peredachi.Size = new System.Drawing.Size(136, 20);
            this.lblVremya_peredachi.TabIndex = 40;
            this.lblVremya_peredachi.Text = "Время передачи";
            // 
            // lblData_peredachi
            // 
            this.lblData_peredachi.AutoSize = true;
            this.lblData_peredachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData_peredachi.Location = new System.Drawing.Point(35, 213);
            this.lblData_peredachi.Name = "lblData_peredachi";
            this.lblData_peredachi.Size = new System.Drawing.Size(126, 20);
            this.lblData_peredachi.TabIndex = 39;
            this.lblData_peredachi.Text = "Дата передачи";
            // 
            // btnDelete_Peredan
            // 
            this.btnDelete_Peredan.Location = new System.Drawing.Point(750, 146);
            this.btnDelete_Peredan.Name = "btnDelete_Peredan";
            this.btnDelete_Peredan.Size = new System.Drawing.Size(99, 64);
            this.btnDelete_Peredan.TabIndex = 38;
            this.btnDelete_Peredan.Text = "Удалить";
            this.btnDelete_Peredan.UseVisualStyleBackColor = true;
            this.btnDelete_Peredan.Click += new System.EventHandler(this.btnDelete_Peredan_Click);
            // 
            // btnUpdate_Peredan
            // 
            this.btnUpdate_Peredan.Location = new System.Drawing.Point(750, 76);
            this.btnUpdate_Peredan.Name = "btnUpdate_Peredan";
            this.btnUpdate_Peredan.Size = new System.Drawing.Size(99, 64);
            this.btnUpdate_Peredan.TabIndex = 37;
            this.btnUpdate_Peredan.Text = "Изменить";
            this.btnUpdate_Peredan.UseVisualStyleBackColor = true;
            this.btnUpdate_Peredan.Click += new System.EventHandler(this.btnUpdate_Peredan_Click);
            // 
            // btnInsert_Peredan
            // 
            this.btnInsert_Peredan.Location = new System.Drawing.Point(750, 6);
            this.btnInsert_Peredan.Name = "btnInsert_Peredan";
            this.btnInsert_Peredan.Size = new System.Drawing.Size(99, 64);
            this.btnInsert_Peredan.TabIndex = 36;
            this.btnInsert_Peredan.Text = "Добавить";
            this.btnInsert_Peredan.UseVisualStyleBackColor = true;
            this.btnInsert_Peredan.Click += new System.EventHandler(this.btnInsert_Peredan_Click);
            // 
            // dgvPeredan
            // 
            this.dgvPeredan.AllowUserToAddRows = false;
            this.dgvPeredan.AllowUserToDeleteRows = false;
            this.dgvPeredan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeredan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeredan.Location = new System.Drawing.Point(6, 6);
            this.dgvPeredan.Name = "dgvPeredan";
            this.dgvPeredan.Size = new System.Drawing.Size(740, 204);
            this.dgvPeredan.TabIndex = 35;
            this.dgvPeredan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeredan_CellClick);
            // 
            // Form_Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tcSklad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Sklad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.Form_Sklad_Load);
            this.tcSklad.ResumeLayout(false);
            this.tpTovary_post.ResumeLayout(false);
            this.tpTovary_post.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovary_Post)).EndInit();
            this.tpTPP.ResumeLayout(false);
            this.tpTPP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol_tovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPP)).EndInit();
            this.tpSort.ResumeLayout(false);
            this.tpSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSort)).EndInit();
            this.tpZakaz.ResumeLayout(false);
            this.tpZakaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol_zakaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaz)).EndInit();
            this.tpKompl.ResumeLayout(false);
            this.tpKompl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kompl)).EndInit();
            this.tpPeredan.ResumeLayout(false);
            this.tpPeredan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeredan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSklad;
        private System.Windows.Forms.TabPage tpTovary_post;
        private System.Windows.Forms.TabPage tpTPP;
        private System.Windows.Forms.DataGridView dgvTovary_Post;
        private System.Windows.Forms.Button btnDelete_Tovary_Post;
        private System.Windows.Forms.Button btnUpdate_Tovary_Post;
        private System.Windows.Forms.Button btnInsert_Tovary_Post;
        private System.Windows.Forms.ComboBox cmbPostavshik_ID;
        private System.Windows.Forms.Label lblPostavshik_ID;
        private System.Windows.Forms.MaskedTextBox mtbData_proizv;
        private System.Windows.Forms.Label lblData_proizv;
        private System.Windows.Forms.Label lblNazv_tovar;
        private System.Windows.Forms.TextBox tbNazv_tovar;
        private System.Windows.Forms.Label lblData_Otsenky;
        private System.Windows.Forms.Button btnDelete_TPP;
        private System.Windows.Forms.Button btnUpdate_TPP;
        private System.Windows.Forms.Button btnInsert_TPP;
        private System.Windows.Forms.DataGridView dgvTPP;
        private System.Windows.Forms.ComboBox cmbSertificat_ID;
        private System.Windows.Forms.ComboBox cmbTovar_ID;
        private System.Windows.Forms.Label lblSertificat_ID;
        private System.Windows.Forms.Label lblTovar_ID;
        private System.Windows.Forms.NumericUpDown nudKol_tovar;
        private System.Windows.Forms.Label lblKol_tovar;
        private System.Windows.Forms.MaskedTextBox mtbVremya_otsenky;
        private System.Windows.Forms.MaskedTextBox mtbData_otsenky;
        private System.Windows.Forms.Label lblVremya_Otsenky;
        private System.Windows.Forms.TabPage tpSort;
        private System.Windows.Forms.Label lblTPP_ID;
        private System.Windows.Forms.Label lblSrok_do;
        private System.Windows.Forms.Label lblSrok_ot;
        private System.Windows.Forms.Label lblNaim_Sklad;
        private System.Windows.Forms.Label lblOblast;
        private System.Windows.Forms.Button btnDelete_Sort;
        private System.Windows.Forms.Button btnUpdate_Sort;
        private System.Windows.Forms.Button btnInsert_Sort;
        private System.Windows.Forms.DataGridView dgvSort;
        private System.Windows.Forms.TextBox tbOblast;
        private System.Windows.Forms.ComboBox cmb_Naim_sklad;
        private System.Windows.Forms.ComboBox cmbTPP_ID;
        private System.Windows.Forms.MaskedTextBox mtb_Srok_do;
        private System.Windows.Forms.MaskedTextBox mtbSrok_ot;
        private System.Windows.Forms.TabPage tpZakaz;
        private System.Windows.Forms.Label lblKlient_Login;
        private System.Windows.Forms.Label lblSort_ID;
        private System.Windows.Forms.Label lblKol_zakaz;
        private System.Windows.Forms.Label lblSposob_dostavki;
        private System.Windows.Forms.Button btnDelete_Zakaz;
        private System.Windows.Forms.Button btnUpdate_Zakaz;
        private System.Windows.Forms.Button btnInsert_Zakaz;
        private System.Windows.Forms.DataGridView dgvZakaz;
        private System.Windows.Forms.ComboBox cmbSort_ID;
        private System.Windows.Forms.ComboBox cmbKlient_Login;
        private System.Windows.Forms.ComboBox cmbSposob_dostavki;
        private System.Windows.Forms.NumericUpDown nudKol_zakaz;
        private System.Windows.Forms.TabPage tpKompl;
        private System.Windows.Forms.TabPage tpPeredan;
        private System.Windows.Forms.ComboBox cmbSopr_ID;
        private System.Windows.Forms.Label lblSopr_ID;
        private System.Windows.Forms.ComboBox cmbZakaz_ID;
        private System.Windows.Forms.Label lblZakaz_ID;
        private System.Windows.Forms.Label lblData_kompl;
        private System.Windows.Forms.MaskedTextBox mtbData_kompl;
        private System.Windows.Forms.Button btnDelete_Kompl;
        private System.Windows.Forms.Button btnUpdate_Kompl;
        private System.Windows.Forms.Button btnInsert_Kompl;
        private System.Windows.Forms.DataGridView dgv_Kompl;
        private System.Windows.Forms.Button btnDelete_Peredan;
        private System.Windows.Forms.Button btnUpdate_Peredan;
        private System.Windows.Forms.Button btnInsert_Peredan;
        private System.Windows.Forms.DataGridView dgvPeredan;
        private System.Windows.Forms.ComboBox cmbShet_ID;
        private System.Windows.Forms.Label lblShet_ID;
        private System.Windows.Forms.ComboBox cmb_Kompl;
        private System.Windows.Forms.Label lblKompl_ID;
        private System.Windows.Forms.MaskedTextBox mtbVremya_peredachi;
        private System.Windows.Forms.MaskedTextBox mtbData_peredachi;
        private System.Windows.Forms.Label lblVremya_peredachi;
        private System.Windows.Forms.Label lblData_peredachi;
    }
}