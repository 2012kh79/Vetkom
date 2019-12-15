namespace Kursovoy_proekt
{
    partial class Form_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Config));
            this.lblMestoHran = new System.Windows.Forms.Label();
            this.tbPut = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.pnText = new System.Windows.Forms.Panel();
            this.lblOtstupy = new System.Windows.Forms.Label();
            this.nudVerh = new System.Windows.Forms.NumericUpDown();
            this.nudSleva = new System.Windows.Forms.NumericUpDown();
            this.nudSprava = new System.Windows.Forms.NumericUpDown();
            this.nudSnizu = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSprava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnizu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMestoHran
            // 
            this.lblMestoHran.AutoSize = true;
            this.lblMestoHran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMestoHran.Location = new System.Drawing.Point(90, 9);
            this.lblMestoHran.Name = "lblMestoHran";
            this.lblMestoHran.Size = new System.Drawing.Size(209, 20);
            this.lblMestoHran.TabIndex = 0;
            this.lblMestoHran.Text = "Выберите место хранения";
            // 
            // tbPut
            // 
            this.tbPut.Location = new System.Drawing.Point(12, 32);
            this.tbPut.Name = "tbPut";
            this.tbPut.Size = new System.Drawing.Size(334, 20);
            this.tbPut.TabIndex = 1;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(348, 26);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(34, 31);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // pnText
            // 
            this.pnText.BackColor = System.Drawing.Color.Gray;
            this.pnText.Location = new System.Drawing.Point(120, 101);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(144, 173);
            this.pnText.TabIndex = 3;
            // 
            // lblOtstupy
            // 
            this.lblOtstupy.AutoSize = true;
            this.lblOtstupy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOtstupy.Location = new System.Drawing.Point(106, 55);
            this.lblOtstupy.Name = "lblOtstupy";
            this.lblOtstupy.Size = new System.Drawing.Size(173, 20);
            this.lblOtstupy.TabIndex = 4;
            this.lblOtstupy.Text = "Отступы в документе";
            // 
            // nudVerh
            // 
            this.nudVerh.DecimalPlaces = 1;
            this.nudVerh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudVerh.Location = new System.Drawing.Point(132, 78);
            this.nudVerh.Name = "nudVerh";
            this.nudVerh.Size = new System.Drawing.Size(120, 20);
            this.nudVerh.TabIndex = 5;
            this.nudVerh.ValueChanged += new System.EventHandler(this.nudVerh_ValueChanged);
            // 
            // nudSleva
            // 
            this.nudSleva.DecimalPlaces = 1;
            this.nudSleva.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSleva.Location = new System.Drawing.Point(12, 177);
            this.nudSleva.Name = "nudSleva";
            this.nudSleva.Size = new System.Drawing.Size(102, 20);
            this.nudSleva.TabIndex = 6;
            this.nudSleva.ValueChanged += new System.EventHandler(this.nudSleva_ValueChanged);
            // 
            // nudSprava
            // 
            this.nudSprava.DecimalPlaces = 1;
            this.nudSprava.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSprava.Location = new System.Drawing.Point(270, 177);
            this.nudSprava.Name = "nudSprava";
            this.nudSprava.Size = new System.Drawing.Size(102, 20);
            this.nudSprava.TabIndex = 7;
            this.nudSprava.ValueChanged += new System.EventHandler(this.nudSprava_ValueChanged);
            // 
            // nudSnizu
            // 
            this.nudSnizu.DecimalPlaces = 1;
            this.nudSnizu.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSnizu.Location = new System.Drawing.Point(132, 280);
            this.nudSnizu.Name = "nudSnizu";
            this.nudSnizu.Size = new System.Drawing.Size(120, 20);
            this.nudSnizu.TabIndex = 8;
            this.nudSnizu.ValueChanged += new System.EventHandler(this.nudSnizu_ValueChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(89, 311);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(102, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Применить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudSnizu);
            this.Controls.Add(this.nudSprava);
            this.Controls.Add(this.nudSleva);
            this.Controls.Add(this.nudVerh);
            this.Controls.Add(this.lblOtstupy);
            this.Controls.Add(this.pnText);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbPut);
            this.Controls.Add(this.lblMestoHran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка документа";
            this.Load += new System.EventHandler(this.Form_Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVerh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSprava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnizu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMestoHran;
        private System.Windows.Forms.TextBox tbPut;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Panel pnText;
        private System.Windows.Forms.Label lblOtstupy;
        private System.Windows.Forms.NumericUpDown nudVerh;
        private System.Windows.Forms.NumericUpDown nudSleva;
        private System.Windows.Forms.NumericUpDown nudSprava;
        private System.Windows.Forms.NumericUpDown nudSnizu;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}