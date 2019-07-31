namespace Mhrs.UI.WinForm
{
    partial class MuayeneFrm
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
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.cmbTeshis = new System.Windows.Forms.ComboBox();
            this.cmbTahlil = new System.Windows.Forms.ComboBox();
            this.gBoxTeshis = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReceteOlustur = new System.Windows.Forms.Button();
            this.cmbIlac = new System.Windows.Forms.ComboBox();
            this.btnBitir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBoxTahlil = new System.Windows.Forms.GroupBox();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rButtonTeshis = new System.Windows.Forms.RadioButton();
            this.rButtonTahlil = new System.Windows.Forms.RadioButton();
            this.gBoxTeshis.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxTahlil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHasta
            // 
            this.lblHasta.BackColor = System.Drawing.Color.Green;
            this.lblHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(8, 9);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(541, 32);
            this.lblHasta.TabIndex = 0;
            this.lblHasta.Text = "Hasta ";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNot.Location = new System.Drawing.Point(6, 25);
            this.txtNot.MaxLength = 100;
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(241, 157);
            this.txtNot.TabIndex = 3;
            // 
            // cmbTeshis
            // 
            this.cmbTeshis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTeshis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeshis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTeshis.FormattingEnabled = true;
            this.cmbTeshis.Location = new System.Drawing.Point(6, 35);
            this.cmbTeshis.Name = "cmbTeshis";
            this.cmbTeshis.Size = new System.Drawing.Size(240, 24);
            this.cmbTeshis.TabIndex = 4;
            // 
            // cmbTahlil
            // 
            this.cmbTahlil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTahlil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTahlil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTahlil.FormattingEnabled = true;
            this.cmbTahlil.Location = new System.Drawing.Point(6, 34);
            this.cmbTahlil.Name = "cmbTahlil";
            this.cmbTahlil.Size = new System.Drawing.Size(240, 24);
            this.cmbTahlil.TabIndex = 6;
            // 
            // gBoxTeshis
            // 
            this.gBoxTeshis.Controls.Add(this.groupBox3);
            this.gBoxTeshis.Controls.Add(this.cmbTeshis);
            this.gBoxTeshis.Controls.Add(this.btnBitir);
            this.gBoxTeshis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxTeshis.Location = new System.Drawing.Point(283, 53);
            this.gBoxTeshis.Name = "gBoxTeshis";
            this.gBoxTeshis.Size = new System.Drawing.Size(257, 276);
            this.gBoxTeshis.TabIndex = 7;
            this.gBoxTeshis.TabStop = false;
            this.gBoxTeshis.Text = "Teşhis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReceteOlustur);
            this.groupBox3.Controls.Add(this.cmbIlac);
            this.groupBox3.Location = new System.Drawing.Point(6, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 123);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İlaç";
            // 
            // btnReceteOlustur
            // 
            this.btnReceteOlustur.BackColor = System.Drawing.Color.Transparent;
            this.btnReceteOlustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceteOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceteOlustur.Location = new System.Drawing.Point(6, 77);
            this.btnReceteOlustur.Name = "btnReceteOlustur";
            this.btnReceteOlustur.Size = new System.Drawing.Size(218, 33);
            this.btnReceteOlustur.TabIndex = 9;
            this.btnReceteOlustur.Text = "Reçete Oluştur";
            this.btnReceteOlustur.UseVisualStyleBackColor = false;
            this.btnReceteOlustur.Click += new System.EventHandler(this.btnReceteOlustur_Click);
            // 
            // cmbIlac
            // 
            this.cmbIlac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbIlac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIlac.FormattingEnabled = true;
            this.cmbIlac.Location = new System.Drawing.Point(6, 36);
            this.cmbIlac.Name = "cmbIlac";
            this.cmbIlac.Size = new System.Drawing.Size(218, 24);
            this.cmbIlac.TabIndex = 6;
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.Transparent;
            this.btnBitir.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.MuaneBitir1;
            this.btnBitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.Location = new System.Drawing.Point(186, 214);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(60, 54);
            this.btnBitir.TabIndex = 9;
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNot);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 188);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Not";
            // 
            // gBoxTahlil
            // 
            this.gBoxTahlil.Controls.Add(this.btnRandevuOlustur);
            this.gBoxTahlil.Controls.Add(this.dateTimePicker1);
            this.gBoxTahlil.Controls.Add(this.cmbTahlil);
            this.gBoxTahlil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxTahlil.Location = new System.Drawing.Point(283, 53);
            this.gBoxTahlil.Name = "gBoxTahlil";
            this.gBoxTahlil.Size = new System.Drawing.Size(255, 173);
            this.gBoxTahlil.TabIndex = 9;
            this.gBoxTahlil.TabStop = false;
            this.gBoxTahlil.Text = "Tahlil";
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevuOlustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevuOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuOlustur.Location = new System.Drawing.Point(6, 124);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(237, 33);
            this.btnRandevuOlustur.TabIndex = 8;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // rButtonTeshis
            // 
            this.rButtonTeshis.AutoSize = true;
            this.rButtonTeshis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rButtonTeshis.Location = new System.Drawing.Point(12, 254);
            this.rButtonTeshis.Name = "rButtonTeshis";
            this.rButtonTeshis.Size = new System.Drawing.Size(79, 24);
            this.rButtonTeshis.TabIndex = 10;
            this.rButtonTeshis.TabStop = true;
            this.rButtonTeshis.Text = "Teşhis";
            this.rButtonTeshis.UseVisualStyleBackColor = true;
            this.rButtonTeshis.CheckedChanged += new System.EventHandler(this.rButtonTeshis_CheckedChanged);
            // 
            // rButtonTahlil
            // 
            this.rButtonTahlil.AutoSize = true;
            this.rButtonTahlil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rButtonTahlil.Location = new System.Drawing.Point(126, 254);
            this.rButtonTahlil.Name = "rButtonTahlil";
            this.rButtonTahlil.Size = new System.Drawing.Size(69, 24);
            this.rButtonTahlil.TabIndex = 11;
            this.rButtonTahlil.TabStop = true;
            this.rButtonTahlil.Text = "Tahlil";
            this.rButtonTahlil.UseVisualStyleBackColor = true;
            this.rButtonTahlil.CheckedChanged += new System.EventHandler(this.rButtonTahlil_CheckedChanged);
            // 
            // MuayeneFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 348);
            this.Controls.Add(this.rButtonTahlil);
            this.Controls.Add(this.gBoxTeshis);
            this.Controls.Add(this.gBoxTahlil);
            this.Controls.Add(this.rButtonTeshis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuayeneFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muayene Formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MuayeneFrm_FormClosed);
            this.gBoxTeshis.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxTahlil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.ComboBox cmbTeshis;
        private System.Windows.Forms.ComboBox cmbTahlil;
        private System.Windows.Forms.GroupBox gBoxTeshis;
        private System.Windows.Forms.ComboBox cmbIlac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBoxTahlil;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReceteOlustur;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rButtonTeshis;
        private System.Windows.Forms.RadioButton rButtonTahlil;
    }
}