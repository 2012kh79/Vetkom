namespace Kursovoy_proekt
{
    partial class Form_Authorize
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authorize));
            this.btVhod = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbAuth = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btGlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVhod
            // 
            this.btVhod.Location = new System.Drawing.Point(193, 228);
            this.btVhod.Name = "btVhod";
            this.btVhod.Size = new System.Drawing.Size(148, 35);
            this.btVhod.TabIndex = 11;
            this.btVhod.Text = "Авторизоваться";
            this.btVhod.UseVisualStyleBackColor = true;
            this.btVhod.Click += new System.EventHandler(this.btVhod_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(161, 202);
            this.tbPass.MaxLength = 16;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(214, 20);
            this.tbPass.TabIndex = 10;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(161, 162);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(214, 20);
            this.tbLogin.TabIndex = 9;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.Location = new System.Drawing.Point(77, 202);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(67, 20);
            this.lbPass.TabIndex = 8;
            this.lbPass.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(77, 162);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(55, 20);
            this.lbLogin.TabIndex = 7;
            this.lbLogin.Text = "Логин";
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.BackColor = System.Drawing.Color.Transparent;
            this.lbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuth.Location = new System.Drawing.Point(91, 75);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(284, 51);
            this.lbAuth.TabIndex = 6;
            this.lbAuth.Text = "Авторизация";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(130, 278);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(245, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Нет аккаунта? Зарегистрироваться";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btGlaz
            // 
            this.btGlaz.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.glaz;
            this.btGlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGlaz.Location = new System.Drawing.Point(381, 202);
            this.btGlaz.Name = "btGlaz";
            this.btGlaz.Size = new System.Drawing.Size(23, 22);
            this.btGlaz.TabIndex = 39;
            this.btGlaz.UseVisualStyleBackColor = true;
            this.btGlaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseDown);
            this.btGlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseUp);
            // 
            // Form_Authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btGlaz);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btVhod);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Authorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form_Authorize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVhod;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btGlaz;
        public System.Windows.Forms.TextBox tbLogin;
        public System.Windows.Forms.TextBox tbPass;
    }
}

