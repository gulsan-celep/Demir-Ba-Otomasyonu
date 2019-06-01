namespace YazilimSinama
{
    partial class Demirbasİlemleri
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSorgu = new System.Windows.Forms.TextBox();
            this.cbDemirbas = new System.Windows.Forms.ComboBox();
            this.btnDemirbasArama = new System.Windows.Forms.Button();
            this.dataDemirbasArama = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataPersonelDemirbas = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPersonelDemirbasArama = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cPersonel = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDemirbasAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDAlimTarihi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataStokListele = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStokListele = new System.Windows.Forms.Button();
            this.lblSorgu = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDemirbasArama)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonelDemirbas)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStokListele)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSorgu);
            this.tabPage3.Controls.Add(this.txtSorgu);
            this.tabPage3.Controls.Add(this.cbDemirbas);
            this.tabPage3.Controls.Add(this.btnDemirbasArama);
            this.tabPage3.Controls.Add(this.dataDemirbasArama);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(828, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Demirbaş Arama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSorgu
            // 
            this.txtSorgu.Location = new System.Drawing.Point(5, 100);
            this.txtSorgu.Name = "txtSorgu";
            this.txtSorgu.Size = new System.Drawing.Size(177, 20);
            this.txtSorgu.TabIndex = 3;
            this.txtSorgu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSorgu_TextChanged);
            // 
            // cbDemirbas
            // 
            this.cbDemirbas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDemirbas.FormattingEnabled = true;
            this.cbDemirbas.Location = new System.Drawing.Point(5, 47);
            this.cbDemirbas.Name = "cbDemirbas";
            this.cbDemirbas.Size = new System.Drawing.Size(177, 21);
            this.cbDemirbas.TabIndex = 2;
            this.cbDemirbas.SelectedIndexChanged += new System.EventHandler(this.cbDemirbas_SelectedIndexChanged);
            // 
            // btnDemirbasArama
            // 
            this.btnDemirbasArama.Location = new System.Drawing.Point(40, 142);
            this.btnDemirbasArama.Name = "btnDemirbasArama";
            this.btnDemirbasArama.Size = new System.Drawing.Size(102, 46);
            this.btnDemirbasArama.TabIndex = 1;
            this.btnDemirbasArama.Text = "DEMİRBAŞ ARAMA";
            this.btnDemirbasArama.UseVisualStyleBackColor = true;
            this.btnDemirbasArama.Click += new System.EventHandler(this.btnDemirbasArama_Click);
            // 
            // dataDemirbasArama
            // 
            this.dataDemirbasArama.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataDemirbasArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDemirbasArama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            this.dataDemirbasArama.Location = new System.Drawing.Point(205, 47);
            this.dataDemirbasArama.Name = "dataDemirbasArama";
            this.dataDemirbasArama.Size = new System.Drawing.Size(597, 237);
            this.dataDemirbasArama.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Demirbaş Adı";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fiyat";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Alım Tarihi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adet";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Demirbaşın Türü";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataPersonelDemirbas);
            this.tabPage2.Controls.Add(this.btnPersonelDemirbasArama);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cPersonel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Üzerindeki Demirbaşı Aratma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataPersonelDemirbas
            // 
            this.dataPersonelDemirbas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPersonelDemirbas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonelDemirbas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column17,
            this.Column18});
            this.dataPersonelDemirbas.Location = new System.Drawing.Point(19, 66);
            this.dataPersonelDemirbas.Name = "dataPersonelDemirbas";
            this.dataPersonelDemirbas.Size = new System.Drawing.Size(549, 150);
            this.dataPersonelDemirbas.TabIndex = 19;
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
            // Column17
            // 
            this.Column17.HeaderText = "Oda Adı";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Personel Adı";
            this.Column18.Name = "Column18";
            // 
            // btnPersonelDemirbasArama
            // 
            this.btnPersonelDemirbasArama.Location = new System.Drawing.Point(264, 13);
            this.btnPersonelDemirbasArama.Name = "btnPersonelDemirbasArama";
            this.btnPersonelDemirbasArama.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelDemirbasArama.TabIndex = 18;
            this.btnPersonelDemirbasArama.Text = "ARA";
            this.btnPersonelDemirbasArama.UseVisualStyleBackColor = true;
            this.btnPersonelDemirbasArama.Click += new System.EventHandler(this.btnPersonelDemirbasArama_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Personel :";
            // 
            // cPersonel
            // 
            this.cPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cPersonel.FormattingEnabled = true;
            this.cPersonel.Location = new System.Drawing.Point(84, 16);
            this.cPersonel.Name = "cPersonel";
            this.cPersonel.Size = new System.Drawing.Size(144, 21);
            this.cPersonel.TabIndex = 16;
            this.cPersonel.SelectedIndexChanged += new System.EventHandler(this.cPersonel_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAciklama);
            this.tabPage1.Controls.Add(this.txtAciklama);
            this.tabPage1.Controls.Add(this.cmbTur);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtAdet);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbDepartman);
            this.tabPage1.Controls.Add(this.cmbFakulte);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtDemirbasAdi);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDFiyat);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDAlimTarihi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Demirbaş Ekleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(123, 123);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(46, 13);
            this.lblAciklama.TabIndex = 20;
            this.lblAciklama.Text = "Özelliği :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(224, 123);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(153, 20);
            this.txtAciklama.TabIndex = 19;
            this.txtAciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAciklama_TextChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(224, 24);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(153, 21);
            this.cmbTur.TabIndex = 18;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "DEMİRBAŞ EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDemirbasEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adet:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(512, 163);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(149, 20);
            this.txtAdet.TabIndex = 15;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fakülte :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departman:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(512, 65);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(149, 21);
            this.cmbDepartman.TabIndex = 12;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbDepartman_SelectedIndexChanged);
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(512, 19);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(149, 21);
            this.cmbFakulte.TabIndex = 11;
            this.cmbFakulte.SelectedIndexChanged += new System.EventHandler(this.cmbFakulte_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Demirbaş Adı:";
            // 
            // txtDemirbasAdi
            // 
            this.txtDemirbasAdi.Location = new System.Drawing.Point(224, 73);
            this.txtDemirbasAdi.Name = "txtDemirbasAdi";
            this.txtDemirbasAdi.Size = new System.Drawing.Size(153, 20);
            this.txtDemirbasAdi.TabIndex = 9;
            this.txtDemirbasAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDemirbasAdi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fiyat:";
            // 
            // txtDFiyat
            // 
            this.txtDFiyat.Location = new System.Drawing.Point(512, 116);
            this.txtDFiyat.Name = "txtDFiyat";
            this.txtDFiyat.Size = new System.Drawing.Size(149, 20);
            this.txtDFiyat.TabIndex = 7;
            this.txtDFiyat.TextChanged += new System.EventHandler(this.txtDFiyat_TextChanged);
            this.txtDFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDFiyat_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Demirbaş Alım Tarihi:";
            // 
            // txtDAlimTarihi
            // 
            this.txtDAlimTarihi.Location = new System.Drawing.Point(224, 170);
            this.txtDAlimTarihi.Name = "txtDAlimTarihi";
            this.txtDAlimTarihi.ReadOnly = true;
            this.txtDAlimTarihi.Size = new System.Drawing.Size(153, 20);
            this.txtDAlimTarihi.TabIndex = 5;
            this.txtDAlimTarihi.TextChanged += new System.EventHandler(this.txtDAlimTarihi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Demirbas Türü :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataStokListele);
            this.tabPage4.Controls.Add(this.btnStokListele);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(828, 316);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stok Listeleme";
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
            this.Column15,
            this.Column14,
            this.Column11,
            this.Column12});
            this.dataStokListele.Location = new System.Drawing.Point(31, 70);
            this.dataStokListele.Name = "dataStokListele";
            this.dataStokListele.Size = new System.Drawing.Size(739, 224);
            this.dataStokListele.TabIndex = 1;
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
            // Column15
            // 
            this.Column15.HeaderText = "Fiyat";
            this.Column15.Name = "Column15";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Alım Tarihi";
            this.Column14.Name = "Column14";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Adet";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Stok";
            this.Column12.Name = "Column12";
            // 
            // btnStokListele
            // 
            this.btnStokListele.Location = new System.Drawing.Point(31, 26);
            this.btnStokListele.Name = "btnStokListele";
            this.btnStokListele.Size = new System.Drawing.Size(94, 38);
            this.btnStokListele.TabIndex = 0;
            this.btnStokListele.Text = "LİSTELE";
            this.btnStokListele.UseVisualStyleBackColor = true;
            this.btnStokListele.Click += new System.EventHandler(this.btnStokListele_Click);
            // 
            // lblSorgu
            // 
            this.lblSorgu.AutoSize = true;
            this.lblSorgu.Location = new System.Drawing.Point(3, 84);
            this.lblSorgu.Name = "lblSorgu";
            this.lblSorgu.Size = new System.Drawing.Size(196, 13);
            this.lblSorgu.TabIndex = 4;
            this.lblSorgu.Text = "Alım Tarihi bu şekilde olmalıdır: yıl-ay-gün";
            // 
            // Demirbasİlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 330);
            this.Controls.Add(this.tabControl1);
            this.Name = "Demirbasİlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş İşlemleri";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDemirbasArama)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonelDemirbas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStokListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDemirbasAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDAlimTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cbDemirbas;
        private System.Windows.Forms.Button btnDemirbasArama;
        private System.Windows.Forms.DataGridView dataDemirbasArama;
        private System.Windows.Forms.TextBox txtSorgu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cPersonel;
        private System.Windows.Forms.DataGridView dataPersonelDemirbas;
        private System.Windows.Forms.Button btnPersonelDemirbasArama;
        private System.Windows.Forms.DataGridView dataStokListele;
        private System.Windows.Forms.Button btnStokListele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Label lblSorgu;
    }
}