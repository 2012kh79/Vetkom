namespace Kursovoy_proekt
{
    partial class Form_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLiteBlue = new System.Windows.Forms.RadioButton();
            this.rbLiteGreen = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNazn_Role = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUpdate_Role = new System.Windows.Forms.Button();
            this.cmbRole_ID = new System.Windows.Forms.ComboBox();
            this.cbOtchet = new System.Windows.Forms.CheckBox();
            this.cbSklad = new System.Windows.Forms.CheckBox();
            this.cbZakaz = new System.Windows.Forms.CheckBox();
            this.cbKabinet = new System.Windows.Forms.CheckBox();
            this.cbInf_o_programe = new System.Windows.Forms.CheckBox();
            this.cbInf_ob_abtore = new System.Windows.Forms.CheckBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.Settings_Base = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLiteBlue);
            this.groupBox1.Controls.Add(this.rbLiteGreen);
            this.groupBox1.Controls.Add(this.rbOrange);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка цвета панелей";
            // 
            // rbLiteBlue
            // 
            this.rbLiteBlue.AutoSize = true;
            this.rbLiteBlue.Location = new System.Drawing.Point(6, 76);
            this.rbLiteBlue.Name = "rbLiteBlue";
            this.rbLiteBlue.Size = new System.Drawing.Size(129, 21);
            this.rbLiteBlue.TabIndex = 2;
            this.rbLiteBlue.Text = "Светло-синий";
            this.rbLiteBlue.UseVisualStyleBackColor = true;
            this.rbLiteBlue.CheckedChanged += new System.EventHandler(this.rbLiteBlue_CheckedChanged);
            // 
            // rbLiteGreen
            // 
            this.rbLiteGreen.AutoSize = true;
            this.rbLiteGreen.Location = new System.Drawing.Point(6, 49);
            this.rbLiteGreen.Name = "rbLiteGreen";
            this.rbLiteGreen.Size = new System.Drawing.Size(149, 21);
            this.rbLiteGreen.TabIndex = 1;
            this.rbLiteGreen.Text = "Светло-зелёный";
            this.rbLiteGreen.UseVisualStyleBackColor = true;
            this.rbLiteGreen.CheckedChanged += new System.EventHandler(this.rbLiteGreen_CheckedChanged);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Checked = true;
            this.rbOrange.Location = new System.Drawing.Point(6, 22);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(112, 21);
            this.rbOrange.TabIndex = 0;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Оранжевый";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.rbOrange_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(27, 279);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(70, 17);
            this.rbMan.TabIndex = 3;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Мужчина";
            this.rbMan.UseVisualStyleBackColor = true;
            this.rbMan.CheckedChanged += new System.EventHandler(this.rbMan_CheckedChanged);
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(177, 279);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(75, 17);
            this.rbWoman.TabIndex = 4;
            this.rbWoman.Text = "Женщина";
            this.rbWoman.UseVisualStyleBackColor = true;
            this.rbWoman.CheckedChanged += new System.EventHandler(this.rbWoman_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.ImageLocation = "C:\\Users\\ilnaz\\OneDrive\\Рабочий стол\\Курсовой проект\\Kursovoy_proekt\\Kursovoy_pro" +
    "ekt\\Resources\\Woman.png";
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(154, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "C:\\Users\\ilnaz\\OneDrive\\Рабочий стол\\Курсовой проект\\Kursovoy_proekt\\Kursovoy_pro" +
    "ekt\\Resources\\Man.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNazn_Role
            // 
            this.btnNazn_Role.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Role;
            this.btnNazn_Role.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNazn_Role.Enabled = false;
            this.btnNazn_Role.Location = new System.Drawing.Point(279, 61);
            this.btnNazn_Role.Name = "btnNazn_Role";
            this.btnNazn_Role.Size = new System.Drawing.Size(58, 212);
            this.btnNazn_Role.TabIndex = 5;
            this.btnNazn_Role.UseVisualStyleBackColor = true;
            this.btnNazn_Role.Click += new System.EventHandler(this.btnNazn_Role_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUpdate_Role
            // 
            this.btnUpdate_Role.Location = new System.Drawing.Point(358, 33);
            this.btnUpdate_Role.Name = "btnUpdate_Role";
            this.btnUpdate_Role.Size = new System.Drawing.Size(123, 21);
            this.btnUpdate_Role.TabIndex = 7;
            this.btnUpdate_Role.Text = "Изменить роль";
            this.btnUpdate_Role.UseVisualStyleBackColor = true;
            this.btnUpdate_Role.Click += new System.EventHandler(this.btnUpdate_Role_Click);
            // 
            // cmbRole_ID
            // 
            this.cmbRole_ID.FormattingEnabled = true;
            this.cmbRole_ID.Location = new System.Drawing.Point(487, 33);
            this.cmbRole_ID.Name = "cmbRole_ID";
            this.cmbRole_ID.Size = new System.Drawing.Size(250, 21);
            this.cmbRole_ID.TabIndex = 8;
            // 
            // cbOtchet
            // 
            this.cbOtchet.AutoSize = true;
            this.cbOtchet.Enabled = false;
            this.cbOtchet.Location = new System.Drawing.Point(755, 61);
            this.cbOtchet.Name = "cbOtchet";
            this.cbOtchet.Size = new System.Drawing.Size(55, 17);
            this.cbOtchet.TabIndex = 15;
            this.cbOtchet.Text = "Отчёт";
            this.cbOtchet.UseVisualStyleBackColor = true;
            // 
            // cbSklad
            // 
            this.cbSklad.AutoSize = true;
            this.cbSklad.Enabled = false;
            this.cbSklad.Location = new System.Drawing.Point(755, 97);
            this.cbSklad.Name = "cbSklad";
            this.cbSklad.Size = new System.Drawing.Size(57, 17);
            this.cbSklad.TabIndex = 16;
            this.cbSklad.Text = "Склад";
            this.cbSklad.UseVisualStyleBackColor = true;
            // 
            // cbZakaz
            // 
            this.cbZakaz.AutoSize = true;
            this.cbZakaz.Enabled = false;
            this.cbZakaz.Location = new System.Drawing.Point(755, 133);
            this.cbZakaz.Name = "cbZakaz";
            this.cbZakaz.Size = new System.Drawing.Size(57, 17);
            this.cbZakaz.TabIndex = 17;
            this.cbZakaz.Text = "Заказ";
            this.cbZakaz.UseVisualStyleBackColor = true;
            // 
            // cbKabinet
            // 
            this.cbKabinet.AutoSize = true;
            this.cbKabinet.Enabled = false;
            this.cbKabinet.Location = new System.Drawing.Point(755, 169);
            this.cbKabinet.Name = "cbKabinet";
            this.cbKabinet.Size = new System.Drawing.Size(68, 17);
            this.cbKabinet.TabIndex = 18;
            this.cbKabinet.Text = "Кабинет";
            this.cbKabinet.UseVisualStyleBackColor = true;
            // 
            // cbInf_o_programe
            // 
            this.cbInf_o_programe.AutoSize = true;
            this.cbInf_o_programe.Enabled = false;
            this.cbInf_o_programe.Location = new System.Drawing.Point(755, 205);
            this.cbInf_o_programe.Name = "cbInf_o_programe";
            this.cbInf_o_programe.Size = new System.Drawing.Size(161, 17);
            this.cbInf_o_programe.TabIndex = 19;
            this.cbInf_o_programe.Text = "Информация о программе";
            this.cbInf_o_programe.UseVisualStyleBackColor = true;
            // 
            // cbInf_ob_abtore
            // 
            this.cbInf_ob_abtore.AutoSize = true;
            this.cbInf_ob_abtore.Enabled = false;
            this.cbInf_ob_abtore.Location = new System.Drawing.Point(755, 241);
            this.cbInf_ob_abtore.Name = "cbInf_ob_abtore";
            this.cbInf_ob_abtore.Size = new System.Drawing.Size(145, 17);
            this.cbInf_ob_abtore.TabIndex = 20;
            this.cbInf_ob_abtore.Text = "Информация об авторе";
            this.cbInf_ob_abtore.UseVisualStyleBackColor = true;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTable.Location = new System.Drawing.Point(752, 34);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(152, 17);
            this.lblTable.TabIndex = 21;
            this.lblTable.Text = "Доступ к таблицам";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(358, 63);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(379, 210);
            this.dgvAccount.TabIndex = 23;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // Settings_Base
            // 
            this.Settings_Base.Location = new System.Drawing.Point(358, 279);
            this.Settings_Base.Name = "Settings_Base";
            this.Settings_Base.Size = new System.Drawing.Size(379, 23);
            this.Settings_Base.TabIndex = 24;
            this.Settings_Base.Text = "Настройка подключения к базе данных";
            this.Settings_Base.UseVisualStyleBackColor = true;
            this.Settings_Base.Click += new System.EventHandler(this.Settings_Base_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(349, 306);
            this.Controls.Add(this.Settings_Base);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cbInf_ob_abtore);
            this.Controls.Add(this.cbInf_o_programe);
            this.Controls.Add(this.cbKabinet);
            this.Controls.Add(this.cbZakaz);
            this.Controls.Add(this.cbSklad);
            this.Controls.Add(this.cbOtchet);
            this.Controls.Add(this.cmbRole_ID);
            this.Controls.Add(this.btnUpdate_Role);
            this.Controls.Add(this.btnNazn_Role);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Settings_FormClosing);
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rbLiteBlue;
        public System.Windows.Forms.RadioButton rbLiteGreen;
        public System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUpdate_Role;
        private System.Windows.Forms.ComboBox cmbRole_ID;
        private System.Windows.Forms.CheckBox cbOtchet;
        private System.Windows.Forms.CheckBox cbSklad;
        private System.Windows.Forms.CheckBox cbZakaz;
        private System.Windows.Forms.CheckBox cbKabinet;
        private System.Windows.Forms.CheckBox cbInf_o_programe;
        private System.Windows.Forms.CheckBox cbInf_ob_abtore;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView dgvAccount;
        public System.Windows.Forms.Button btnNazn_Role;
        private System.Windows.Forms.Button Settings_Base;
    }
}