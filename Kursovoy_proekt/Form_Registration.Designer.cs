namespace Kursovoy_proekt
{
    partial class Form_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registration));
            this.tbRepeatPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btReg = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbAuth = new System.Windows.Forms.Label();
            this.tbImya = new System.Windows.Forms.TextBox();
            this.tb_Fam = new System.Windows.Forms.TextBox();
            this.lblFam = new System.Windows.Forms.Label();
            this.lbl_Imya = new System.Windows.Forms.Label();
            this.tb_Pochta = new System.Windows.Forms.TextBox();
            this.lbl_Pochta = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.lbl_Otch = new System.Windows.Forms.Label();
            this.btProv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btGlaz = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRepeatPass
            // 
            this.tbRepeatPass.Location = new System.Drawing.Point(146, 278);
            this.tbRepeatPass.MaxLength = 16;
            this.tbRepeatPass.Name = "tbRepeatPass";
            this.tbRepeatPass.Size = new System.Drawing.Size(280, 20);
            this.tbRepeatPass.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Повтор пароля";
            // 
            // btReg
            // 
            this.btReg.Enabled = false;
            this.btReg.Location = new System.Drawing.Point(293, 300);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(133, 32);
            this.btReg.TabIndex = 21;
            this.btReg.Text = "Зарегистрироваться";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(146, 242);
            this.tbPass.MaxLength = 16;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(280, 20);
            this.tbPass.TabIndex = 20;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(146, 208);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(280, 20);
            this.tbLogin.TabIndex = 19;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(59, 240);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(67, 20);
            this.lbPass.TabIndex = 18;
            this.lbPass.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(59, 206);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(55, 20);
            this.lbLogin.TabIndex = 17;
            this.lbLogin.Text = "Логин";
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.BackColor = System.Drawing.Color.Transparent;
            this.lbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuth.Location = new System.Drawing.Point(117, 9);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(277, 51);
            this.lbAuth.TabIndex = 16;
            this.lbAuth.Text = "Регистрация";
            // 
            // tbImya
            // 
            this.tbImya.Location = new System.Drawing.Point(146, 98);
            this.tbImya.Name = "tbImya";
            this.tbImya.Size = new System.Drawing.Size(280, 20);
            this.tbImya.TabIndex = 24;
            this.tbImya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Fam_KeyPress);
            // 
            // tb_Fam
            // 
            this.tb_Fam.Location = new System.Drawing.Point(146, 63);
            this.tb_Fam.Name = "tb_Fam";
            this.tb_Fam.Size = new System.Drawing.Size(280, 20);
            this.tb_Fam.TabIndex = 25;
            this.tb_Fam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Fam_KeyPress);
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.BackColor = System.Drawing.Color.Transparent;
            this.lblFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFam.Location = new System.Drawing.Point(59, 63);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(81, 20);
            this.lblFam.TabIndex = 26;
            this.lblFam.Text = "Фамилия";
            // 
            // lbl_Imya
            // 
            this.lbl_Imya.AutoSize = true;
            this.lbl_Imya.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Imya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Imya.Location = new System.Drawing.Point(59, 98);
            this.lbl_Imya.Name = "lbl_Imya";
            this.lbl_Imya.Size = new System.Drawing.Size(40, 20);
            this.lbl_Imya.TabIndex = 27;
            this.lbl_Imya.Text = "Имя";
            // 
            // tb_Pochta
            // 
            this.tb_Pochta.Location = new System.Drawing.Point(146, 171);
            this.tb_Pochta.Name = "tb_Pochta";
            this.tb_Pochta.Size = new System.Drawing.Size(280, 20);
            this.tb_Pochta.TabIndex = 28;
            // 
            // lbl_Pochta
            // 
            this.lbl_Pochta.AutoSize = true;
            this.lbl_Pochta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pochta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Pochta.Location = new System.Drawing.Point(59, 169);
            this.lbl_Pochta.Name = "lbl_Pochta";
            this.lbl_Pochta.Size = new System.Drawing.Size(57, 20);
            this.lbl_Pochta.TabIndex = 29;
            this.lbl_Pochta.Text = "Почта";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabel1.Location = new System.Drawing.Point(123, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(291, 17);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Уже зарегистрировались? Авторизоваться";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(146, 135);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(280, 20);
            this.tbOtch.TabIndex = 31;
            this.tbOtch.Text = "Нет данных";
            this.tbOtch.Click += new System.EventHandler(this.tbOtch_Click);
            this.tbOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Fam_KeyPress);
            this.tbOtch.Leave += new System.EventHandler(this.tbOtch_Leave);
            // 
            // lbl_Otch
            // 
            this.lbl_Otch.AutoSize = true;
            this.lbl_Otch.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Otch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Otch.Location = new System.Drawing.Point(59, 133);
            this.lbl_Otch.Name = "lbl_Otch";
            this.lbl_Otch.Size = new System.Drawing.Size(83, 20);
            this.lbl_Otch.TabIndex = 32;
            this.lbl_Otch.Text = "Отчество";
            // 
            // btProv
            // 
            this.btProv.Location = new System.Drawing.Point(194, 300);
            this.btProv.Name = "btProv";
            this.btProv.Size = new System.Drawing.Size(93, 32);
            this.btProv.TabIndex = 33;
            this.btProv.Text = "Проверить";
            this.btProv.UseVisualStyleBackColor = true;
            this.btProv.Click += new System.EventHandler(this.btProv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(432, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(432, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(432, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // btGlaz
            // 
            this.btGlaz.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.glaz;
            this.btGlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGlaz.Location = new System.Drawing.Point(432, 278);
            this.btGlaz.Name = "btGlaz";
            this.btGlaz.Size = new System.Drawing.Size(23, 22);
            this.btGlaz.TabIndex = 38;
            this.btGlaz.UseVisualStyleBackColor = true;
            this.btGlaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseDown);
            this.btGlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(432, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(432, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(432, 135);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // Form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btGlaz);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btProv);
            this.Controls.Add(this.lbl_Otch);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_Pochta);
            this.Controls.Add(this.tb_Pochta);
            this.Controls.Add(this.lbl_Imya);
            this.Controls.Add(this.lblFam);
            this.Controls.Add(this.tb_Fam);
            this.Controls.Add(this.tbImya);
            this.Controls.Add(this.tbRepeatPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRepeatPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.TextBox tbImya;
        private System.Windows.Forms.TextBox tb_Fam;
        private System.Windows.Forms.Label lblFam;
        private System.Windows.Forms.Label lbl_Imya;
        private System.Windows.Forms.TextBox tb_Pochta;
        private System.Windows.Forms.Label lbl_Pochta;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.Label lbl_Otch;
        private System.Windows.Forms.Button btProv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btGlaz;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tbPass;
    }
}