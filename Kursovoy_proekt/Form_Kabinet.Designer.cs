namespace Kursovoy_proekt
{
    partial class Form_Kabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kabinet));
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbRepeatPass = new System.Windows.Forms.TextBox();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.btGlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.Location = new System.Drawing.Point(12, 12);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(135, 165);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 9;
            this.pbAvatar.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(153, 12);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 20);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Пароль:";
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(157, 37);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(225, 20);
            this.tbPassword.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(254, 20);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(157, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(254, 20);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(157, 132);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(254, 20);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.Text = "Проверить данные";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(388, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // tbRepeatPass
            // 
            this.tbRepeatPass.Enabled = false;
            this.tbRepeatPass.Location = new System.Drawing.Point(157, 85);
            this.tbRepeatPass.Name = "tbRepeatPass";
            this.tbRepeatPass.Size = new System.Drawing.Size(225, 20);
            this.tbRepeatPass.TabIndex = 40;
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRepeatPass.Location = new System.Drawing.Point(153, 60);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(156, 20);
            this.lblRepeatPass.TabIndex = 39;
            this.lblRepeatPass.Text = "Повторите пароль:";
            // 
            // btGlaz
            // 
            this.btGlaz.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.glaz;
            this.btGlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGlaz.Location = new System.Drawing.Point(388, 85);
            this.btGlaz.Name = "btGlaz";
            this.btGlaz.Size = new System.Drawing.Size(23, 20);
            this.btGlaz.TabIndex = 41;
            this.btGlaz.UseVisualStyleBackColor = true;
            this.btGlaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseDown);
            this.btGlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btGlaz_MouseUp);
            // 
            // Form_Kabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 181);
            this.Controls.Add(this.btGlaz);
            this.Controls.Add(this.tbRepeatPass);
            this.Controls.Add(this.lblRepeatPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pbAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Kabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbRepeatPass;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.Button btGlaz;
    }
}