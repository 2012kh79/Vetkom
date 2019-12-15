namespace Kursovoy_proekt
{
    partial class Form_License
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_License = new System.Windows.Forms.MaskedTextBox();
            this.btn_Voity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(130, 84);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите серийный ключ";
            // 
            // mtb_License
            // 
            this.mtb_License.Location = new System.Drawing.Point(69, 38);
            this.mtb_License.Mask = "0000-0000-0000-0000";
            this.mtb_License.Name = "mtb_License";
            this.mtb_License.Size = new System.Drawing.Size(113, 20);
            this.mtb_License.TabIndex = 7;
            // 
            // btn_Voity
            // 
            this.btn_Voity.Location = new System.Drawing.Point(49, 84);
            this.btn_Voity.Name = "btn_Voity";
            this.btn_Voity.Size = new System.Drawing.Size(75, 23);
            this.btn_Voity.TabIndex = 5;
            this.btn_Voity.Text = "Войти";
            this.btn_Voity.UseVisualStyleBackColor = true;
            this.btn_Voity.Click += new System.EventHandler(this.btn_Voity_Click);
            // 
            // Form_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 130);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_License);
            this.Controls.Add(this.btn_Voity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лицензия";
            this.Load += new System.EventHandler(this.Form_License_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_License;
        private System.Windows.Forms.Button btn_Voity;
    }
}