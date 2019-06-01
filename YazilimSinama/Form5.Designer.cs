namespace YazilimSinama
{
    partial class Odaslemleri
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbFakulte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDepartman = new System.Windows.Forms.ComboBox();
            this.txtOda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOdaArama = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboda = new System.Windows.Forms.ComboBox();
            this.dataOdaArama = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDemirbasAtama = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPersonel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDemirbasAdi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOdaAdi = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataStokListele = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStokListele = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOdaArama)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStokListele)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbFakulte);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbDepartman);
            this.tabPage1.Controls.Add(this.txtOda);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnOdaEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Oda Tanımlama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fakülte :";
            // 
            // cbFakulte
            // 
            this.cbFakulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFakulte.FormattingEnabled = true;
            this.cbFakulte.Location = new System.Drawing.Point(268, 111);
            this.cbFakulte.Name = "cbFakulte";
            this.cbFakulte.Size = new System.Drawing.Size(137, 21);
            this.cbFakulte.TabIndex = 16;
            this.cbFakulte.SelectedIndexChanged += new System.EventHandler(this.cbFakulte_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Departman :";
            // 
            // cbDepartman
            // 
            this.cbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartman.FormattingEnabled = true;
            this.cbDepartman.Location = new System.Drawing.Point(268, 182);
            this.cbDepartman.Name = "cbDepartman";
            this.cbDepartman.Size = new System.Drawing.Size(137, 21);
            this.cbDepartman.TabIndex = 14;
            this.cbDepartman.SelectedIndexChanged += new System.EventHandler(this.cbDepartman_SelectedIndexChanged);
            // 
            // txtOda
            // 
            this.txtOda.Location = new System.Drawing.Point(268, 53);
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(137, 20);
            this.txtOda.TabIndex = 12;
            this.txtOda.TextChanged += new System.EventHandler(this.txtOda_TextChanged);
            this.txtOda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Oda Adı :";
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Location = new System.Drawing.Point(307, 239);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(98, 38);
            this.btnOdaEkle.TabIndex = 9;
            this.btnOdaEkle.Text = "EKLE";
            this.btnOdaEkle.UseVisualStyleBackColor = true;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOdaArama);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cboda);
            this.tabPage2.Controls.Add(this.dataOdaArama);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oda Arama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOdaArama
            // 
            this.btnOdaArama.Location = new System.Drawing.Point(263, 39);
            this.btnOdaArama.Name = "btnOdaArama";
            this.btnOdaArama.Size = new System.Drawing.Size(75, 23);
            this.btnOdaArama.TabIndex = 4;
            this.btnOdaArama.Text = "ARA";
            this.btnOdaArama.UseVisualStyleBackColor = true;
            this.btnOdaArama.Click += new System.EventHandler(this.btnOdaArama_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oda Adı :";
            // 
            // cboda
            // 
            this.cboda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboda.FormattingEnabled = true;
            this.cboda.Location = new System.Drawing.Point(111, 39);
            this.cboda.Name = "cboda";
            this.cboda.Size = new System.Drawing.Size(121, 21);
            this.cboda.TabIndex = 2;
            // 
            // dataOdaArama
            // 
            this.dataOdaArama.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataOdaArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOdaArama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5});
            this.dataOdaArama.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataOdaArama.Location = new System.Drawing.Point(29, 103);
            this.dataOdaArama.Name = "dataOdaArama";
            this.dataOdaArama.Size = new System.Drawing.Size(543, 225);
            this.dataOdaArama.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Oda Adı";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fakülte Adı ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Personel Adı";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Departman Adı";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Demirbaş Adı";
            this.Column5.Name = "Column5";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDemirbasAtama);
            this.tabPage3.Controls.Add(this.txtAdet);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cbbPersonel);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cbDemirbasAdi);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbOdaAdi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(823, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Odaya Demirbaş Atama";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnDemirbasAtama
            // 
            this.btnDemirbasAtama.Location = new System.Drawing.Point(426, 205);
            this.btnDemirbasAtama.Name = "btnDemirbasAtama";
            this.btnDemirbasAtama.Size = new System.Drawing.Size(100, 40);
            this.btnDemirbasAtama.TabIndex = 18;
            this.btnDemirbasAtama.Text = "ATA";
            this.btnDemirbasAtama.UseVisualStyleBackColor = true;
            this.btnDemirbasAtama.Click += new System.EventHandler(this.btnDemirbasAtama_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(383, 135);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(143, 20);
            this.txtAdet.TabIndex = 17;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Adet  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personel adı :";
            // 
            // cbbPersonel
            // 
            this.cbbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPersonel.FormattingEnabled = true;
            this.cbbPersonel.Location = new System.Drawing.Point(383, 87);
            this.cbbPersonel.Name = "cbbPersonel";
            this.cbbPersonel.Size = new System.Drawing.Size(143, 21);
            this.cbbPersonel.TabIndex = 14;
            this.cbbPersonel.SelectedIndexChanged += new System.EventHandler(this.cbbPersonel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Demirbaş Adı :";
            // 
            // cbDemirbasAdi
            // 
            this.cbDemirbasAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDemirbasAdi.FormattingEnabled = true;
            this.cbDemirbasAdi.Location = new System.Drawing.Point(157, 135);
            this.cbDemirbasAdi.Name = "cbDemirbasAdi";
            this.cbDemirbasAdi.Size = new System.Drawing.Size(121, 21);
            this.cbDemirbasAdi.TabIndex = 2;
            this.cbDemirbasAdi.SelectedIndexChanged += new System.EventHandler(this.cbDemirbasAdi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Oda Adı :";
            // 
            // cbOdaAdi
            // 
            this.cbOdaAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdaAdi.FormattingEnabled = true;
            this.cbOdaAdi.Location = new System.Drawing.Point(157, 87);
            this.cbOdaAdi.Name = "cbOdaAdi";
            this.cbOdaAdi.Size = new System.Drawing.Size(121, 21);
            this.cbOdaAdi.TabIndex = 0;
            this.cbOdaAdi.SelectedIndexChanged += new System.EventHandler(this.cbOdaAdi_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataStokListele);
            this.tabPage4.Controls.Add(this.btnStokListele);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(823, 360);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Oda Demirbaş Listeleme";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataStokListele
            // 
            this.dataStokListele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataStokListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStokListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column9,
            this.Column13,
            this.Column6,
            this.Column12,
            this.Column15,
            this.Column14,
            this.Column7});
            this.dataStokListele.Location = new System.Drawing.Point(2, 76);
            this.dataStokListele.Name = "dataStokListele";
            this.dataStokListele.Size = new System.Drawing.Size(818, 233);
            this.dataStokListele.TabIndex = 3;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Demirbaş Türü";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Demirbaş Adı";
            this.Column9.Name = "Column9";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Açıklama";
            this.Column13.Name = "Column13";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kalan Adet";
            this.Column6.Name = "Column6";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Stok";
            this.Column12.Name = "Column12";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Oda Adı";
            this.Column15.Name = "Column15";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Personel Adı";
            this.Column14.Name = "Column14";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Personele Atanan Adet";
            this.Column7.Name = "Column7";
            // 
            // btnStokListele
            // 
            this.btnStokListele.Location = new System.Drawing.Point(8, 32);
            this.btnStokListele.Name = "btnStokListele";
            this.btnStokListele.Size = new System.Drawing.Size(94, 38);
            this.btnStokListele.TabIndex = 2;
            this.btnStokListele.Text = "LİSTELE";
            this.btnStokListele.UseVisualStyleBackColor = true;
            this.btnStokListele.Click += new System.EventHandler(this.btnStokListele_Click);
            // 
            // Odaslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "Odaslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda İşlemleri";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOdaArama)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStokListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFakulte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDepartman;
        private System.Windows.Forms.TextBox txtOda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDemirbasAtama;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbPersonel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDemirbasAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOdaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboda;
        private System.Windows.Forms.DataGridView dataOdaArama;
        private System.Windows.Forms.Button btnOdaArama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataStokListele;
        private System.Windows.Forms.Button btnStokListele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}