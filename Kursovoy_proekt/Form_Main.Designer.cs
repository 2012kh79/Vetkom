namespace Kursovoy_proekt
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbKabinet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAuthor = new System.Windows.Forms.PictureBox();
            this.pbInf_o_program = new System.Windows.Forms.PictureBox();
            this.pbSklad = new System.Windows.Forms.PictureBox();
            this.pbOtchet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKabinet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInf_o_program)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOtchet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Кнопка_настройка;
            this.pbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSettings.Location = new System.Drawing.Point(336, 169);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(71, 53);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 5;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // pbKabinet
            // 
            this.pbKabinet.BackColor = System.Drawing.Color.Transparent;
            this.pbKabinet.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Кнопка_личный_кабинет;
            this.pbKabinet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbKabinet.Location = new System.Drawing.Point(92, 169);
            this.pbKabinet.Name = "pbKabinet";
            this.pbKabinet.Size = new System.Drawing.Size(71, 53);
            this.pbKabinet.TabIndex = 4;
            this.pbKabinet.TabStop = false;
            this.pbKabinet.Click += new System.EventHandler(this.pbKabinet_Click);
            this.pbKabinet.MouseLeave += new System.EventHandler(this.pbKabinet_MouseLeave);
            this.pbKabinet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbKabinet_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(83, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Главное меню";
            // 
            // pbAuthor
            // 
            this.pbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.pbAuthor.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Кнопка_об_авторе;
            this.pbAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAuthor.Location = new System.Drawing.Point(214, 169);
            this.pbAuthor.Name = "pbAuthor";
            this.pbAuthor.Size = new System.Drawing.Size(71, 50);
            this.pbAuthor.TabIndex = 3;
            this.pbAuthor.TabStop = false;
            this.pbAuthor.Click += new System.EventHandler(this.pbAuthor_Click);
            this.pbAuthor.MouseLeave += new System.EventHandler(this.pbAuthor_MouseLeave);
            this.pbAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbAuthor_MouseMove);
            // 
            // pbInf_o_program
            // 
            this.pbInf_o_program.BackColor = System.Drawing.Color.Transparent;
            this.pbInf_o_program.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Кнопка_о_программе;
            this.pbInf_o_program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbInf_o_program.Location = new System.Drawing.Point(336, 93);
            this.pbInf_o_program.Name = "pbInf_o_program";
            this.pbInf_o_program.Size = new System.Drawing.Size(71, 50);
            this.pbInf_o_program.TabIndex = 2;
            this.pbInf_o_program.TabStop = false;
            this.pbInf_o_program.Click += new System.EventHandler(this.pbInf_o_program_Click);
            this.pbInf_o_program.MouseLeave += new System.EventHandler(this.pbInf_o_program_MouseLeave);
            this.pbInf_o_program.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbInf_o_program_MouseMove);
            // 
            // pbSklad
            // 
            this.pbSklad.BackColor = System.Drawing.Color.Transparent;
            this.pbSklad.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Кнопка_Поставщик;
            this.pbSklad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSklad.Location = new System.Drawing.Point(214, 93);
            this.pbSklad.Name = "pbSklad";
            this.pbSklad.Size = new System.Drawing.Size(71, 50);
            this.pbSklad.TabIndex = 1;
            this.pbSklad.TabStop = false;
            this.pbSklad.Click += new System.EventHandler(this.pbPostavshik_Click);
            this.pbSklad.MouseLeave += new System.EventHandler(this.pbPostavshik_MouseLeave);
            this.pbSklad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPostavshik_MouseMove);
            // 
            // pbOtchet
            // 
            this.pbOtchet.BackColor = System.Drawing.Color.Transparent;
            this.pbOtchet.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Кнопка_Отчёты;
            this.pbOtchet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbOtchet.Location = new System.Drawing.Point(92, 93);
            this.pbOtchet.Name = "pbOtchet";
            this.pbOtchet.Size = new System.Drawing.Size(71, 50);
            this.pbOtchet.TabIndex = 0;
            this.pbOtchet.TabStop = false;
            this.pbOtchet.Click += new System.EventHandler(this.pbOtchet_Click);
            this.pbOtchet.MouseLeave += new System.EventHandler(this.pbOtchet_MouseLeave);
            this.pbOtchet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOtchet_MouseMove);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovoy_proekt.Properties.Resources.Фон1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.pbKabinet);
            this.Controls.Add(this.pbAuthor);
            this.Controls.Add(this.pbInf_o_program);
            this.Controls.Add(this.pbSklad);
            this.Controls.Add(this.pbOtchet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKabinet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInf_o_program)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOtchet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbKabinet;
        public System.Windows.Forms.PictureBox pbAuthor;
        public System.Windows.Forms.PictureBox pbInf_o_program;
        public System.Windows.Forms.PictureBox pbSklad;
        public System.Windows.Forms.PictureBox pbOtchet;
        public System.Windows.Forms.PictureBox pbSettings;
    }
}