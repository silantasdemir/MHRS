namespace Mhrs.UI.WinForm
{
    partial class RandevuFrm
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
            this.datepicRandevu = new System.Windows.Forms.DateTimePicker();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnRandevuAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datepicRandevu
            // 
            this.datepicRandevu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datepicRandevu.Location = new System.Drawing.Point(117, 246);
            this.datepicRandevu.Name = "datepicRandevu";
            this.datepicRandevu.Size = new System.Drawing.Size(240, 26);
            this.datepicRandevu.TabIndex = 5;
            this.datepicRandevu.ValueChanged += new System.EventHandler(this.datepicRandevu_ValueChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbDoktor.Location = new System.Drawing.Point(117, 193);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(240, 28);
            this.cmbDoktor.TabIndex = 4;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(117, 91);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(240, 28);
            this.cmbPoliklinik.TabIndex = 2;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // cmbHastane
            // 
            this.cmbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(117, 40);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(240, 28);
            this.cmbHastane.TabIndex = 1;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(117, 142);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(240, 28);
            this.cmbDepartman.TabIndex = 3;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbDepartman_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Departman:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doktor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poliklinik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.datepicRandevu);
            this.groupBox1.Controls.Add(this.cmbDoktor);
            this.groupBox1.Controls.Add(this.cmbPoliklinik);
            this.groupBox1.Controls.Add(this.cmbHastane);
            this.groupBox1.Controls.Add(this.cmbDepartman);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRandevuAra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 389);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Sorgulama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.temizle;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(117, 300);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 65);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnRandevuAra
            // 
            this.btnRandevuAra.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevuAra.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.randevu;
            this.btnRandevuAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevuAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAra.Location = new System.Drawing.Point(257, 300);
            this.btnRandevuAra.Name = "btnRandevuAra";
            this.btnRandevuAra.Size = new System.Drawing.Size(100, 65);
            this.btnRandevuAra.TabIndex = 6;
            this.btnRandevuAra.UseVisualStyleBackColor = false;
            this.btnRandevuAra.Click += new System.EventHandler(this.btnRandevuAra_Click);
            // 
            // RandevuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 418);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandevuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Formu";
            this.Load += new System.EventHandler(this.RandevuFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DateTimePicker datepicRandevu;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRandevuAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}