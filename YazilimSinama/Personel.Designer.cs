namespace YazilimSinama
{
    partial class Personel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataPersonelDemirbas = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPersonelDemirbasArama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cPersonel = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDemirbasAtama = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPersonel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDemirbasAdi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOdaAdi = new System.Windows.Forms.ComboBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonelDemirbas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCikis);
            this.tabPage1.Controls.Add(this.dataPersonelDemirbas);
            this.tabPage1.Controls.Add(this.btnPersonelDemirbasArama);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cPersonel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Arama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataPersonelDemirbas
            // 
            this.dataPersonelDemirbas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPersonelDemirbas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonelDemirbas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1,
            this.Column2});
            this.dataPersonelDemirbas.Location = new System.Drawing.Point(6, 93);
            this.dataPersonelDemirbas.Name = "dataPersonelDemirbas";
            this.dataPersonelDemirbas.Size = new System.Drawing.Size(542, 220);
            this.dataPersonelDemirbas.TabIndex = 22;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Demirbaş Kodu";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Demirbaş Adı";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Demirbaş Sayısı";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Oda Adı";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Personel Adı";
            this.Column2.Name = "Column2";
            // 
            // btnPersonelDemirbasArama
            // 
            this.btnPersonelDemirbasArama.Location = new System.Drawing.Point(293, 20);
            this.btnPersonelDemirbasArama.Name = "btnPersonelDemirbasArama";
            this.btnPersonelDemirbasArama.Size = new System.Drawing.Size(80, 23);
            this.btnPersonelDemirbasArama.TabIndex = 21;
            this.btnPersonelDemirbasArama.Text = "ARA";
            this.btnPersonelDemirbasArama.UseVisualStyleBackColor = true;
            this.btnPersonelDemirbasArama.Click += new System.EventHandler(this.btnPersonelDemirbasArama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Personel :";
            // 
            // cPersonel
            // 
            this.cPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cPersonel.FormattingEnabled = true;
            this.cPersonel.Location = new System.Drawing.Point(119, 20);
            this.cPersonel.Name = "cPersonel";
            this.cPersonel.Size = new System.Drawing.Size(149, 21);
            this.cPersonel.TabIndex = 19;
            this.cPersonel.SelectedIndexChanged += new System.EventHandler(this.cPersonel_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnDemirbasAtama);
            this.tabPage2.Controls.Add(this.txtAdet);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbbPersonel);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbDemirbasAdi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbOdaAdi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odaya Personel ve Demirbaş Atama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDemirbasAtama
            // 
            this.btnDemirbasAtama.Location = new System.Drawing.Point(250, 210);
            this.btnDemirbasAtama.Name = "btnDemirbasAtama";
            this.btnDemirbasAtama.Size = new System.Drawing.Size(82, 35);
            this.btnDemirbasAtama.TabIndex = 27;
            this.btnDemirbasAtama.Text = "ATA";
            this.btnDemirbasAtama.UseVisualStyleBackColor = true;
            this.btnDemirbasAtama.Click += new System.EventHandler(this.btnDemirbasAtama_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(360, 134);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(121, 20);
            this.txtAdet.TabIndex = 26;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Adet  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Personel Adı :";
            // 
            // cbbPersonel
            // 
            this.cbbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPersonel.FormattingEnabled = true;
            this.cbbPersonel.Location = new System.Drawing.Point(360, 86);
            this.cbbPersonel.Name = "cbbPersonel";
            this.cbbPersonel.Size = new System.Drawing.Size(121, 21);
            this.cbbPersonel.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Demirbaş Adı :";
            // 
            // cbDemirbasAdi
            // 
            this.cbDemirbasAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDemirbasAdi.FormattingEnabled = true;
            this.cbDemirbasAdi.Location = new System.Drawing.Point(134, 134);
            this.cbDemirbasAdi.Name = "cbDemirbasAdi";
            this.cbDemirbasAdi.Size = new System.Drawing.Size(121, 21);
            this.cbDemirbasAdi.TabIndex = 21;
            this.cbDemirbasAdi.SelectedIndexChanged += new System.EventHandler(this.cbDemirbasAdi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Oda Adı :";
            // 
            // cbOdaAdi
            // 
            this.cbOdaAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdaAdi.FormattingEnabled = true;
            this.cbOdaAdi.Location = new System.Drawing.Point(134, 86);
            this.cbOdaAdi.Name = "cbOdaAdi";
            this.cbOdaAdi.Size = new System.Drawing.Size(121, 21);
            this.cbOdaAdi.TabIndex = 19;
            this.cbOdaAdi.SelectedIndexChanged += new System.EventHandler(this.cbOdaAdi_SelectedIndexChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(410, 20);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonelDemirbas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDemirbasAtama;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPersonel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDemirbasAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOdaAdi;
        private System.Windows.Forms.Button btnPersonelDemirbasArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cPersonel;
        private System.Windows.Forms.DataGridView dataPersonelDemirbas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button1;
    }
}