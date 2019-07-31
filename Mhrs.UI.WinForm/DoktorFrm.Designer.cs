namespace Mhrs.UI.WinForm
{
    partial class DoktorFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışmaGünüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDoktor = new System.Windows.Forms.Label();
            this.gBoxCalismaGunu = new System.Windows.Forms.GroupBox();
            this.datePic = new System.Windows.Forms.DateTimePicker();
            this.lstvRandevular = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxMuaneSorgula = new System.Windows.Forms.GroupBox();
            this.gBoxHesapBilgileri = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.lsvMuaneler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastaID = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gBoxCalismaGunu.SuspendLayout();
            this.gBoxMuaneSorgula.SuspendLayout();
            this.gBoxHesapBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışmaGünüToolStripMenuItem,
            this.muayeneSorgulaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışmaGünüToolStripMenuItem
            // 
            this.çalışmaGünüToolStripMenuItem.Name = "çalışmaGünüToolStripMenuItem";
            this.çalışmaGünüToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.çalışmaGünüToolStripMenuItem.Text = "Çalışma Günü";
            this.çalışmaGünüToolStripMenuItem.Click += new System.EventHandler(this.çalışmaGünüToolStripMenuItem_Click);
            // 
            // muayeneSorgulaToolStripMenuItem
            // 
            this.muayeneSorgulaToolStripMenuItem.Name = "muayeneSorgulaToolStripMenuItem";
            this.muayeneSorgulaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.muayeneSorgulaToolStripMenuItem.Text = "Muayene Sorgula";
            this.muayeneSorgulaToolStripMenuItem.Click += new System.EventHandler(this.muayeneSorgulaToolStripMenuItem_Click);
            // 
            // labelDoktor
            // 
            this.labelDoktor.AutoSize = true;
            this.labelDoktor.BackColor = System.Drawing.Color.Transparent;
            this.labelDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDoktor.Location = new System.Drawing.Point(554, 8);
            this.labelDoktor.Name = "labelDoktor";
            this.labelDoktor.Size = new System.Drawing.Size(0, 16);
            this.labelDoktor.TabIndex = 2;
            this.labelDoktor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxCalismaGunu
            // 
            this.gBoxCalismaGunu.BackColor = System.Drawing.Color.Transparent;
            this.gBoxCalismaGunu.Controls.Add(this.datePic);
            this.gBoxCalismaGunu.Controls.Add(this.lstvRandevular);
            this.gBoxCalismaGunu.Controls.Add(this.btnGoster);
            this.gBoxCalismaGunu.Controls.Add(this.label1);
            this.gBoxCalismaGunu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxCalismaGunu.Location = new System.Drawing.Point(0, 24);
            this.gBoxCalismaGunu.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxCalismaGunu.Name = "gBoxCalismaGunu";
            this.gBoxCalismaGunu.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxCalismaGunu.Size = new System.Drawing.Size(823, 372);
            this.gBoxCalismaGunu.TabIndex = 6;
            this.gBoxCalismaGunu.TabStop = false;
            // 
            // datePic
            // 
            this.datePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datePic.Location = new System.Drawing.Point(14, 48);
            this.datePic.Name = "datePic";
            this.datePic.Size = new System.Drawing.Size(208, 22);
            this.datePic.TabIndex = 6;
            // 
            // lstvRandevular
            // 
            this.lstvRandevular.BackColor = System.Drawing.Color.LightGray;
            this.lstvRandevular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvRandevular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvRandevular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvRandevular.FullRowSelect = true;
            this.lstvRandevular.GridLines = true;
            this.lstvRandevular.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvRandevular.Location = new System.Drawing.Point(12, 122);
            this.lstvRandevular.MultiSelect = false;
            this.lstvRandevular.Name = "lstvRandevular";
            this.lstvRandevular.Size = new System.Drawing.Size(391, 208);
            this.lstvRandevular.TabIndex = 3;
            this.lstvRandevular.UseCompatibleStateImageBehavior = false;
            this.lstvRandevular.View = System.Windows.Forms.View.Details;
            this.lstvRandevular.DoubleClick += new System.EventHandler(this.lstvRandevular_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sıra";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hasta";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 208;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Seans";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGoster
            // 
            this.btnGoster.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.goster;
            this.btnGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoster.Location = new System.Drawing.Point(278, 17);
            this.btnGoster.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(102, 68);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih Seçiniz :";
            // 
            // gBoxMuaneSorgula
            // 
            this.gBoxMuaneSorgula.BackColor = System.Drawing.Color.Transparent;
            this.gBoxMuaneSorgula.Controls.Add(this.gBoxHesapBilgileri);
            this.gBoxMuaneSorgula.Controls.Add(this.btnSorgula);
            this.gBoxMuaneSorgula.Controls.Add(this.lsvMuaneler);
            this.gBoxMuaneSorgula.Controls.Add(this.label2);
            this.gBoxMuaneSorgula.Controls.Add(this.txtHastaID);
            this.gBoxMuaneSorgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxMuaneSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxMuaneSorgula.Location = new System.Drawing.Point(0, 24);
            this.gBoxMuaneSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxMuaneSorgula.Name = "gBoxMuaneSorgula";
            this.gBoxMuaneSorgula.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxMuaneSorgula.Size = new System.Drawing.Size(823, 372);
            this.gBoxMuaneSorgula.TabIndex = 7;
            this.gBoxMuaneSorgula.TabStop = false;
            // 
            // gBoxHesapBilgileri
            // 
            this.gBoxHesapBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gBoxHesapBilgileri.Controls.Add(this.lblID);
            this.gBoxHesapBilgileri.Controls.Add(this.lblCinsiyet);
            this.gBoxHesapBilgileri.Controls.Add(this.lblMail);
            this.gBoxHesapBilgileri.Controls.Add(this.lblSoyad);
            this.gBoxHesapBilgileri.Controls.Add(this.lblAd);
            this.gBoxHesapBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxHesapBilgileri.Location = new System.Drawing.Point(446, 14);
            this.gBoxHesapBilgileri.Name = "gBoxHesapBilgileri";
            this.gBoxHesapBilgileri.Size = new System.Drawing.Size(365, 240);
            this.gBoxHesapBilgileri.TabIndex = 9;
            this.gBoxHesapBilgileri.TabStop = false;
            this.gBoxHesapBilgileri.Text = "Hasta Bilgileri";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(6, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(342, 25);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.Black;
            this.lblCinsiyet.Location = new System.Drawing.Point(6, 147);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(342, 25);
            this.lblCinsiyet.TabIndex = 7;
            this.lblCinsiyet.Text = "Cinsiyet :";
            this.lblCinsiyet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(6, 188);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(342, 25);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail :";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad.Location = new System.Drawing.Point(6, 106);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(342, 25);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad :";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(6, 65);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(342, 25);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad :";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.goster;
            this.btnSorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorgula.Location = new System.Drawing.Point(248, 14);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(65, 27);
            this.btnSorgula.TabIndex = 6;
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // lsvMuaneler
            // 
            this.lsvMuaneler.BackColor = System.Drawing.Color.LightGray;
            this.lsvMuaneler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvMuaneler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvMuaneler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsvMuaneler.FullRowSelect = true;
            this.lsvMuaneler.GridLines = true;
            this.lsvMuaneler.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvMuaneler.Location = new System.Drawing.Point(19, 67);
            this.lsvMuaneler.MultiSelect = false;
            this.lsvMuaneler.Name = "lsvMuaneler";
            this.lsvMuaneler.Size = new System.Drawing.Size(384, 187);
            this.lsvMuaneler.TabIndex = 4;
            this.lsvMuaneler.UseCompatibleStateImageBehavior = false;
            this.lsvMuaneler.View = System.Windows.Forms.View.Details;
            this.lsvMuaneler.DoubleClick += new System.EventHandler(this.lsvMuaneler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "M. ID";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "R. ID";
            this.columnHeader5.Width = 61;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tarih";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 149;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Saat";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta ID :";
            // 
            // txtHastaID
            // 
            this.txtHastaID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHastaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHastaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaID.Location = new System.Drawing.Point(111, 15);
            this.txtHastaID.Multiline = true;
            this.txtHastaID.Name = "txtHastaID";
            this.txtHastaID.Size = new System.Drawing.Size(120, 26);
            this.txtHastaID.TabIndex = 0;
            this.txtHastaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoktorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 396);
            this.Controls.Add(this.gBoxMuaneSorgula);
            this.Controls.Add(this.gBoxCalismaGunu);
            this.Controls.Add(this.labelDoktor);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoktorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxCalismaGunu.ResumeLayout(false);
            this.gBoxCalismaGunu.PerformLayout();
            this.gBoxMuaneSorgula.ResumeLayout(false);
            this.gBoxMuaneSorgula.PerformLayout();
            this.gBoxHesapBilgileri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışmaGünüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneSorgulaToolStripMenuItem;
        private System.Windows.Forms.Label labelDoktor;
        private System.Windows.Forms.GroupBox gBoxCalismaGunu;
        private System.Windows.Forms.DateTimePicker datePic;
        private System.Windows.Forms.ListView lstvRandevular;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox gBoxMuaneSorgula;
        private System.Windows.Forms.TextBox txtHastaID;
        private System.Windows.Forms.ListView lsvMuaneler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.GroupBox gBoxHesapBilgileri;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}