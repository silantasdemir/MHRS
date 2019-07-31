namespace Mhrs.UI.WinForm
{
    partial class EczaciFrm
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
            this.reçeteSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteGeçmişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEczaci = new System.Windows.Forms.Label();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.lstvRecete = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvIlac = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reçeteSorgulaToolStripMenuItem,
            this.reçeteGeçmişiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reçeteSorgulaToolStripMenuItem
            // 
            this.reçeteSorgulaToolStripMenuItem.Name = "reçeteSorgulaToolStripMenuItem";
            this.reçeteSorgulaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.reçeteSorgulaToolStripMenuItem.Text = "Reçete Sorgula";
            this.reçeteSorgulaToolStripMenuItem.Click += new System.EventHandler(this.reçeteSorgulaToolStripMenuItem_Click);
            // 
            // reçeteGeçmişiToolStripMenuItem
            // 
            this.reçeteGeçmişiToolStripMenuItem.Name = "reçeteGeçmişiToolStripMenuItem";
            this.reçeteGeçmişiToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.reçeteGeçmişiToolStripMenuItem.Text = "Reçete Geçmişi";
            this.reçeteGeçmişiToolStripMenuItem.Click += new System.EventHandler(this.reçeteGeçmişiToolStripMenuItem_Click);
            // 
            // labelEczaci
            // 
            this.labelEczaci.AutoSize = true;
            this.labelEczaci.BackColor = System.Drawing.Color.Transparent;
            this.labelEczaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEczaci.Location = new System.Drawing.Point(622, 8);
            this.labelEczaci.Name = "labelEczaci";
            this.labelEczaci.Size = new System.Drawing.Size(0, 16);
            this.labelEczaci.TabIndex = 2;
            this.labelEczaci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBox
            // 
            this.gBox.BackColor = System.Drawing.Color.Transparent;
            this.gBox.Controls.Add(this.lstvRecete);
            this.gBox.Controls.Add(this.lstvIlac);
            this.gBox.Controls.Add(this.button1);
            this.gBox.Controls.Add(this.textBox1);
            this.gBox.Controls.Add(this.label1);
            this.gBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBox.Location = new System.Drawing.Point(0, 24);
            this.gBox.Margin = new System.Windows.Forms.Padding(2);
            this.gBox.Name = "gBox";
            this.gBox.Padding = new System.Windows.Forms.Padding(2);
            this.gBox.Size = new System.Drawing.Size(685, 330);
            this.gBox.TabIndex = 5;
            this.gBox.TabStop = false;
            // 
            // lstvRecete
            // 
            this.lstvRecete.BackColor = System.Drawing.Color.LightGray;
            this.lstvRecete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstvRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvRecete.GridLines = true;
            this.lstvRecete.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvRecete.Location = new System.Drawing.Point(44, 110);
            this.lstvRecete.Name = "lstvRecete";
            this.lstvRecete.Size = new System.Drawing.Size(506, 211);
            this.lstvRecete.TabIndex = 5;
            this.lstvRecete.UseCompatibleStateImageBehavior = false;
            this.lstvRecete.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hasta Adı";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hasta Soyadı";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Reçete Numarası";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "İlaç";
            this.columnHeader7.Width = 127;
            // 
            // lstvIlac
            // 
            this.lstvIlac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvIlac.GridLines = true;
            this.lstvIlac.Location = new System.Drawing.Point(44, 110);
            this.lstvIlac.Name = "lstvIlac";
            this.lstvIlac.Size = new System.Drawing.Size(405, 208);
            this.lstvIlac.TabIndex = 3;
            this.lstvIlac.UseCompatibleStateImageBehavior = false;
            this.lstvIlac.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reçete ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlaç ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İlaç Adı";
            this.columnHeader3.Width = 137;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(105, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // EczaciFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 354);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.labelEczaci);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EczaciFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eczacı Formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EczaciFrm_FormClosed);
            this.Load += new System.EventHandler(this.EczaciFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reçeteSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteGeçmişiToolStripMenuItem;
        private System.Windows.Forms.Label labelEczaci;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.ListView lstvRecete;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lstvIlac;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}