namespace Mhrs.UI.WinForm
{
    partial class MainFrm
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEczaciGiris = new System.Windows.Forms.Button();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(141, 69);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(228, 22);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Merkezi Hekim Randevu Sistemi";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSifre.Location = new System.Drawing.Point(141, 111);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(228, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Adı  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre :";
            // 
            // btnEczaciGiris
            // 
            this.btnEczaciGiris.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.eczaci;
            this.btnEczaciGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEczaciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEczaciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEczaciGiris.Location = new System.Drawing.Point(231, 308);
            this.btnEczaciGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEczaciGiris.Name = "btnEczaciGiris";
            this.btnEczaciGiris.Size = new System.Drawing.Size(113, 105);
            this.btnEczaciGiris.TabIndex = 5;
            this.btnEczaciGiris.UseVisualStyleBackColor = true;
            this.btnEczaciGiris.Click += new System.EventHandler(this.btnEczaciGiris_Click);
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.doktor;
            this.btnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGiris.Location = new System.Drawing.Point(76, 308);
            this.btnDoktorGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(113, 105);
            this.btnDoktorGiris.TabIndex = 4;
            this.btnDoktorGiris.UseVisualStyleBackColor = true;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.kayit;
            this.btnKaydol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydol.Location = new System.Drawing.Point(231, 176);
            this.btnKaydol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(113, 105);
            this.btnKaydol.TabIndex = 3;
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = global::Mhrs.UI.WinForm.Properties.Resources.hasta;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(76, 176);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(113, 105);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEczaciGiris);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.Button btnEczaciGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}