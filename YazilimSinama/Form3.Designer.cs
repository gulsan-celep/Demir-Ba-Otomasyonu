namespace YazilimSinama
{
    partial class Personelİslemleri
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
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.PersonelListele = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.dataKullanici = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtYetki1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListele)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTC);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtSoyadi);
            this.tabPage1.Controls.Add(this.txtAdi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnPersonelEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(330, 165);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(140, 20);
            this.txtTC.TabIndex = 11;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personel TC :";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(330, 119);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(140, 20);
            this.txtSoyadi.TabIndex = 4;
            this.txtSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyadi_TextChanged);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(330, 70);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(140, 20);
            this.txtAdi.TabIndex = 3;
            this.txtAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı:";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(330, 214);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(90, 36);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "EKLE";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAd);
            this.tabPage2.Controls.Add(this.btnListele);
            this.tabPage2.Controls.Add(this.PersonelListele);
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Sil ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(22, 222);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 20);
            this.txtAd.TabIndex = 21;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(22, 265);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 37);
            this.btnListele.TabIndex = 20;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // PersonelListele
            // 
            this.PersonelListele.BackgroundColor = System.Drawing.Color.White;
            this.PersonelListele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.PersonelListele.Location = new System.Drawing.Point(34, 24);
            this.PersonelListele.Name = "PersonelListele";
            this.PersonelListele.Size = new System.Drawing.Size(472, 192);
            this.PersonelListele.TabIndex = 19;
            this.PersonelListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonelListele_CellDoubleContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Personel ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Personel Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Personel Soyadı";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Personel TC";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(116, 265);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 37);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnListeleme);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtKullaniciAdi);
            this.tabPage3.Controls.Add(this.dataKullanici);
            this.tabPage3.Controls.Add(this.btnGuncelle);
            this.tabPage3.Controls.Add(this.txtYetki1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(696, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kullanıcı Güncelle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnListeleme
            // 
            this.btnListeleme.Location = new System.Drawing.Point(142, 267);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 37);
            this.btnListeleme.TabIndex = 31;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = true;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(333, 216);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(169, 20);
            this.txtKullaniciAdi.TabIndex = 29;
            // 
            // dataKullanici
            // 
            this.dataKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKullanici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dataKullanici.Location = new System.Drawing.Point(20, 16);
            this.dataKullanici.Name = "dataKullanici";
            this.dataKullanici.Size = new System.Drawing.Size(542, 150);
            this.dataKullanici.TabIndex = 28;
            this.dataKullanici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKullanici_CellDoubleContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kullanıcı ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Personel Adı";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Personel Soyadı";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Personel TC";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Yetki ID";
            this.Column3.Name = "Column3";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(247, 267);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 37);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // txtYetki1
            // 
            this.txtYetki1.Location = new System.Drawing.Point(104, 216);
            this.txtYetki1.Name = "txtYetki1";
            this.txtYetki1.Size = new System.Drawing.Size(140, 20);
            this.txtYetki1.TabIndex = 26;
            this.txtYetki1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYetki1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Yetki ID :";
            // 
            // Personelİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 406);
            this.Controls.Add(this.tabControl1);
            this.Name = "Personelİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListele)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView PersonelListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataKullanici;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtYetki1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnListeleme;
    }
}