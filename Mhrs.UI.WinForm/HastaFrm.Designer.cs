namespace Mhrs.UI.WinForm
{
    partial class HastaFrm
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
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuTaleplerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuGeçmişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHasta = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.randevuTaleplerimToolStripMenuItem,
            this.randevuGeçmişiToolStripMenuItem,
            this.hesapBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // randevuTaleplerimToolStripMenuItem
            // 
            this.randevuTaleplerimToolStripMenuItem.Name = "randevuTaleplerimToolStripMenuItem";
            this.randevuTaleplerimToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.randevuTaleplerimToolStripMenuItem.Text = "Randevu Taleplerim";
            this.randevuTaleplerimToolStripMenuItem.Click += new System.EventHandler(this.randevuTaleplerimToolStripMenuItem_Click);
            // 
            // randevuGeçmişiToolStripMenuItem
            // 
            this.randevuGeçmişiToolStripMenuItem.Name = "randevuGeçmişiToolStripMenuItem";
            this.randevuGeçmişiToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.randevuGeçmişiToolStripMenuItem.Text = "Randevu Geçmişi";
            this.randevuGeçmişiToolStripMenuItem.Click += new System.EventHandler(this.randevuGeçmişiToolStripMenuItem_Click);
            // 
            // hesapBilgileriToolStripMenuItem
            // 
            this.hesapBilgileriToolStripMenuItem.Name = "hesapBilgileriToolStripMenuItem";
            this.hesapBilgileriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.hesapBilgileriToolStripMenuItem.Text = "Hesap Bilgileri";
            this.hesapBilgileriToolStripMenuItem.Click += new System.EventHandler(this.hesapBilgileriToolStripMenuItem_Click);
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.BackColor = System.Drawing.Color.Transparent;
            this.labelHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHasta.Location = new System.Drawing.Point(558, 8);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(0, 16);
            this.labelHasta.TabIndex = 2;
            this.labelHasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HastaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 297);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HastaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HastaFrm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuTaleplerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuGeçmişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapBilgileriToolStripMenuItem;
        private System.Windows.Forms.Label labelHasta;
    }
}