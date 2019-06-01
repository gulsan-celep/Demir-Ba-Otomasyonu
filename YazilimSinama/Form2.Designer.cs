namespace YazilimSinama
{
    partial class frmDemirbasTakipOtomasyonu
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
            this.personeIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demirbasIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeIslemleriToolStripMenuItem,
            this.demirbasIslemleriToolStripMenuItem,
            this.odaIslemleriToolStripMenuItem,
            this.Cıkıs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personeIslemleriToolStripMenuItem
            // 
            this.personeIslemleriToolStripMenuItem.Name = "personeIslemleriToolStripMenuItem";
            this.personeIslemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personeIslemleriToolStripMenuItem.Text = "Personel İşlemleri";
            this.personeIslemleriToolStripMenuItem.Click += new System.EventHandler(this.personelIslemleriToolStripMenuItem_Click);
            // 
            // demirbasIslemleriToolStripMenuItem
            // 
            this.demirbasIslemleriToolStripMenuItem.Name = "demirbasIslemleriToolStripMenuItem";
            this.demirbasIslemleriToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.demirbasIslemleriToolStripMenuItem.Text = "Demirbaş İşlemleri";
            this.demirbasIslemleriToolStripMenuItem.Click += new System.EventHandler(this.demirbasIslemleriToolStripMenuItem_Click);
            // 
            // odaIslemleriToolStripMenuItem
            // 
            this.odaIslemleriToolStripMenuItem.Name = "odaIslemleriToolStripMenuItem";
            this.odaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.odaIslemleriToolStripMenuItem.Text = "Oda İşlemleri";
            this.odaIslemleriToolStripMenuItem.Click += new System.EventHandler(this.odaIslemleriToolStripMenuItem_Click);
            // 
            // Cıkıs
            // 
            this.Cıkıs.Name = "Cıkıs";
            this.Cıkıs.Size = new System.Drawing.Size(46, 20);
            this.Cıkıs.Text = "ÇIKIŞ";
            this.Cıkıs.Click += new System.EventHandler(this.cikis_Click);
            // 
            // frmDemirbasTakipOtomasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 541);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDemirbasTakipOtomasyonu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Otomasyonu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personeIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demirbasIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cıkıs;
    }
}