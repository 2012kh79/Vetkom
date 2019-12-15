namespace Kursovoy_proekt
{
    partial class Form_Zakaz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Zakaz));
            this.pnlZaliv = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbAdresPostavki = new System.Windows.Forms.TextBox();
            this.lblAdresPostavki = new System.Windows.Forms.Label();
            this.btnZakaz = new System.Windows.Forms.Button();
            this.lbSpisok = new System.Windows.Forms.ListBox();
            this.dgvZakaz_tovar = new System.Windows.Forms.DataGridView();
            this.stlbID_Zakaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stlb_Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stlb_Tovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stlbKol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stlbAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudKolTovara = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKolTovar = new System.Windows.Forms.Label();
            this.lblVibor_tovara = new System.Windows.Forms.Label();
            this.cmbPostavshik = new System.Windows.Forms.ComboBox();
            this.lblNamePostavshik = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbMicro = new System.Windows.Forms.RadioButton();
            this.rbStir = new System.Windows.Forms.RadioButton();
            this.rbTelevizor = new System.Windows.Forms.RadioButton();
            this.lblStir = new System.Windows.Forms.Label();
            this.lblMicro = new System.Windows.Forms.Label();
            this.lblTelevizor = new System.Windows.Forms.Label();
            this.pbMicrovolnovka = new System.Windows.Forms.PictureBox();
            this.pbStir = new System.Windows.Forms.PictureBox();
            this.pbTelevizor = new System.Windows.Forms.PictureBox();
            this.pnlZaliv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaz_tovar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolTovara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrovolnovka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelevizor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlZaliv
            // 
            this.pnlZaliv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlZaliv.Controls.Add(this.btnDelete);
            this.pnlZaliv.Controls.Add(this.tbAdresPostavki);
            this.pnlZaliv.Controls.Add(this.lblAdresPostavki);
            this.pnlZaliv.Controls.Add(this.btnZakaz);
            this.pnlZaliv.Controls.Add(this.lbSpisok);
            this.pnlZaliv.Controls.Add(this.dgvZakaz_tovar);
            this.pnlZaliv.Controls.Add(this.nudKolTovara);
            this.pnlZaliv.Controls.Add(this.button1);
            this.pnlZaliv.Controls.Add(this.lblKolTovar);
            this.pnlZaliv.Controls.Add(this.lblVibor_tovara);
            this.pnlZaliv.Controls.Add(this.cmbPostavshik);
            this.pnlZaliv.Controls.Add(this.lblNamePostavshik);
            this.pnlZaliv.Location = new System.Drawing.Point(12, 12);
            this.pnlZaliv.Name = "pnlZaliv";
            this.pnlZaliv.Size = new System.Drawing.Size(880, 390);
            this.pnlZaliv.TabIndex = 7;
            this.pnlZaliv.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(275, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить товар";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbAdresPostavki
            // 
            this.tbAdresPostavki.Location = new System.Drawing.Point(5, 315);
            this.tbAdresPostavki.Name = "tbAdresPostavki";
            this.tbAdresPostavki.Size = new System.Drawing.Size(347, 20);
            this.tbAdresPostavki.TabIndex = 17;
            // 
            // lblAdresPostavki
            // 
            this.lblAdresPostavki.AutoSize = true;
            this.lblAdresPostavki.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdresPostavki.Location = new System.Drawing.Point(46, 286);
            this.lblAdresPostavki.Name = "lblAdresPostavki";
            this.lblAdresPostavki.Size = new System.Drawing.Size(263, 26);
            this.lblAdresPostavki.TabIndex = 16;
            this.lblAdresPostavki.Text = "Укажите адрес поставки";
            // 
            // btnZakaz
            // 
            this.btnZakaz.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.korz;
            this.btnZakaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZakaz.Location = new System.Drawing.Point(5, 191);
            this.btnZakaz.Name = "btnZakaz";
            this.btnZakaz.Size = new System.Drawing.Size(264, 40);
            this.btnZakaz.TabIndex = 15;
            this.btnZakaz.UseVisualStyleBackColor = true;
            this.btnZakaz.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSpisok
            // 
            this.lbSpisok.FormattingEnabled = true;
            this.lbSpisok.Location = new System.Drawing.Point(5, 90);
            this.lbSpisok.Name = "lbSpisok";
            this.lbSpisok.Size = new System.Drawing.Size(347, 95);
            this.lbSpisok.TabIndex = 14;
            // 
            // dgvZakaz_tovar
            // 
            this.dgvZakaz_tovar.AllowUserToAddRows = false;
            this.dgvZakaz_tovar.AllowUserToDeleteRows = false;
            this.dgvZakaz_tovar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZakaz_tovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakaz_tovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stlbID_Zakaz,
            this.stlb_Firma,
            this.stlb_Tovar,
            this.stlbKol,
            this.stlbAdres});
            this.dgvZakaz_tovar.Location = new System.Drawing.Point(371, 8);
            this.dgvZakaz_tovar.Name = "dgvZakaz_tovar";
            this.dgvZakaz_tovar.Size = new System.Drawing.Size(499, 375);
            this.dgvZakaz_tovar.TabIndex = 13;
            // 
            // stlbID_Zakaz
            // 
            this.stlbID_Zakaz.HeaderText = "Номер заказа";
            this.stlbID_Zakaz.Name = "stlbID_Zakaz";
            this.stlbID_Zakaz.ReadOnly = true;
            this.stlbID_Zakaz.Width = 96;
            // 
            // stlb_Firma
            // 
            this.stlb_Firma.HeaderText = "Фирма";
            this.stlb_Firma.Name = "stlb_Firma";
            this.stlb_Firma.ReadOnly = true;
            this.stlb_Firma.Width = 69;
            // 
            // stlb_Tovar
            // 
            this.stlb_Tovar.HeaderText = "Заказанный товар";
            this.stlb_Tovar.Name = "stlb_Tovar";
            this.stlb_Tovar.ReadOnly = true;
            this.stlb_Tovar.Width = 116;
            // 
            // stlbKol
            // 
            this.stlbKol.HeaderText = "Количество заказанного товара";
            this.stlbKol.Name = "stlbKol";
            this.stlbKol.ReadOnly = true;
            this.stlbKol.Width = 148;
            // 
            // stlbAdres
            // 
            this.stlbAdres.HeaderText = "Адрес поставки";
            this.stlbAdres.Name = "stlbAdres";
            this.stlbAdres.ReadOnly = true;
            this.stlbAdres.Width = 104;
            // 
            // nudKolTovara
            // 
            this.nudKolTovara.Location = new System.Drawing.Point(5, 263);
            this.nudKolTovara.Name = "nudKolTovara";
            this.nudKolTovara.Size = new System.Drawing.Size(347, 20);
            this.nudKolTovara.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Gruz;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 42);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKolTovar
            // 
            this.lblKolTovar.AutoSize = true;
            this.lblKolTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKolTovar.Location = new System.Drawing.Point(31, 234);
            this.lblKolTovar.Name = "lblKolTovar";
            this.lblKolTovar.Size = new System.Drawing.Size(298, 26);
            this.lblKolTovar.TabIndex = 10;
            this.lblKolTovar.Text = "Укажите количество товара";
            // 
            // lblVibor_tovara
            // 
            this.lblVibor_tovara.AutoSize = true;
            this.lblVibor_tovara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVibor_tovara.Location = new System.Drawing.Point(95, 61);
            this.lblVibor_tovara.Name = "lblVibor_tovara";
            this.lblVibor_tovara.Size = new System.Drawing.Size(174, 26);
            this.lblVibor_tovara.TabIndex = 9;
            this.lblVibor_tovara.Text = "Список товаров";
            // 
            // cmbPostavshik
            // 
            this.cmbPostavshik.FormattingEnabled = true;
            this.cmbPostavshik.Location = new System.Drawing.Point(3, 37);
            this.cmbPostavshik.Name = "cmbPostavshik";
            this.cmbPostavshik.Size = new System.Drawing.Size(349, 21);
            this.cmbPostavshik.TabIndex = 8;
            // 
            // lblNamePostavshik
            // 
            this.lblNamePostavshik.AutoSize = true;
            this.lblNamePostavshik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNamePostavshik.Location = new System.Drawing.Point(66, 8);
            this.lblNamePostavshik.Name = "lblNamePostavshik";
            this.lblNamePostavshik.Size = new System.Drawing.Size(230, 26);
            this.lblNamePostavshik.TabIndex = 2;
            this.lblNamePostavshik.Text = "Выбрать поставщика";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbMicro
            // 
            this.rbMicro.AutoSize = true;
            this.rbMicro.Location = new System.Drawing.Point(1108, 174);
            this.rbMicro.Name = "rbMicro";
            this.rbMicro.Size = new System.Drawing.Size(14, 13);
            this.rbMicro.TabIndex = 17;
            this.rbMicro.TabStop = true;
            this.rbMicro.UseVisualStyleBackColor = true;
            this.rbMicro.CheckedChanged += new System.EventHandler(this.rbMicro_CheckedChanged);
            // 
            // rbStir
            // 
            this.rbStir.AutoSize = true;
            this.rbStir.Location = new System.Drawing.Point(962, 381);
            this.rbStir.Name = "rbStir";
            this.rbStir.Size = new System.Drawing.Size(14, 13);
            this.rbStir.TabIndex = 16;
            this.rbStir.TabStop = true;
            this.rbStir.UseVisualStyleBackColor = true;
            this.rbStir.CheckedChanged += new System.EventHandler(this.rbStir_CheckedChanged);
            // 
            // rbTelevizor
            // 
            this.rbTelevizor.AutoSize = true;
            this.rbTelevizor.Location = new System.Drawing.Point(961, 174);
            this.rbTelevizor.Name = "rbTelevizor";
            this.rbTelevizor.Size = new System.Drawing.Size(14, 13);
            this.rbTelevizor.TabIndex = 15;
            this.rbTelevizor.TabStop = true;
            this.rbTelevizor.UseVisualStyleBackColor = true;
            this.rbTelevizor.CheckedChanged += new System.EventHandler(this.rbTelevizor_CheckedChanged);
            // 
            // lblStir
            // 
            this.lblStir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStir.Location = new System.Drawing.Point(898, 187);
            this.lblStir.Name = "lblStir";
            this.lblStir.Size = new System.Drawing.Size(140, 58);
            this.lblStir.TabIndex = 11;
            this.lblStir.Text = "Стиральная машина";
            this.lblStir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMicro
            // 
            this.lblMicro.AutoSize = true;
            this.lblMicro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMicro.Location = new System.Drawing.Point(1033, 12);
            this.lblMicro.Name = "lblMicro";
            this.lblMicro.Size = new System.Drawing.Size(173, 26);
            this.lblMicro.TabIndex = 10;
            this.lblMicro.Text = "Микроволновка";
            // 
            // lblTelevizor
            // 
            this.lblTelevizor.AutoSize = true;
            this.lblTelevizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTelevizor.Location = new System.Drawing.Point(907, 12);
            this.lblTelevizor.Name = "lblTelevizor";
            this.lblTelevizor.Size = new System.Drawing.Size(120, 26);
            this.lblTelevizor.TabIndex = 9;
            this.lblTelevizor.Text = "Телевизор";
            // 
            // pbMicrovolnovka
            // 
            this.pbMicrovolnovka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMicrovolnovka.Location = new System.Drawing.Point(1058, 41);
            this.pbMicrovolnovka.Name = "pbMicrovolnovka";
            this.pbMicrovolnovka.Size = new System.Drawing.Size(115, 127);
            this.pbMicrovolnovka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMicrovolnovka.TabIndex = 14;
            this.pbMicrovolnovka.TabStop = false;
            // 
            // pbStir
            // 
            this.pbStir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStir.Location = new System.Drawing.Point(912, 248);
            this.pbStir.Name = "pbStir";
            this.pbStir.Size = new System.Drawing.Size(115, 127);
            this.pbStir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStir.TabIndex = 13;
            this.pbStir.TabStop = false;
            // 
            // pbTelevizor
            // 
            this.pbTelevizor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTelevizor.Location = new System.Drawing.Point(912, 41);
            this.pbTelevizor.Name = "pbTelevizor";
            this.pbTelevizor.Size = new System.Drawing.Size(115, 127);
            this.pbTelevizor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTelevizor.TabIndex = 12;
            this.pbTelevizor.TabStop = false;
            // 
            // Form_Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(904, 411);
            this.Controls.Add(this.rbMicro);
            this.Controls.Add(this.rbStir);
            this.Controls.Add(this.rbTelevizor);
            this.Controls.Add(this.pbMicrovolnovka);
            this.Controls.Add(this.pbStir);
            this.Controls.Add(this.pbTelevizor);
            this.Controls.Add(this.lblStir);
            this.Controls.Add(this.lblMicro);
            this.Controls.Add(this.lblTelevizor);
            this.Controls.Add(this.pnlZaliv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Zakaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ товара";
            this.Load += new System.EventHandler(this.Form_Zakaz_Load);
            this.pnlZaliv.ResumeLayout(false);
            this.pnlZaliv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaz_tovar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolTovara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrovolnovka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelevizor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlZaliv;
        private System.Windows.Forms.NumericUpDown nudKolTovara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKolTovar;
        private System.Windows.Forms.Label lblVibor_tovara;
        private System.Windows.Forms.Label lblNamePostavshik;
        private System.Windows.Forms.TextBox tbAdresPostavki;
        private System.Windows.Forms.Label lblAdresPostavki;
        private System.Windows.Forms.Button btnZakaz;
        private System.Windows.Forms.DataGridView dgvZakaz_tovar;
        public System.Windows.Forms.ComboBox cmbPostavshik;
        public System.Windows.Forms.ListBox lbSpisok;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbMicro;
        private System.Windows.Forms.RadioButton rbStir;
        private System.Windows.Forms.RadioButton rbTelevizor;
        public System.Windows.Forms.PictureBox pbMicrovolnovka;
        public System.Windows.Forms.PictureBox pbStir;
        public System.Windows.Forms.PictureBox pbTelevizor;
        private System.Windows.Forms.Label lblStir;
        private System.Windows.Forms.Label lblMicro;
        private System.Windows.Forms.Label lblTelevizor;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlbID_Zakaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlb_Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlb_Tovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlbKol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stlbAdres;
        private System.Windows.Forms.Button btnDelete;
    }
}