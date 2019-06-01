using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinama
{
    public partial class Personelİslemleri : Form
    {
        public Personelİslemleri()
        {
            InitializeComponent();
            PersonelListele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonelListele.MultiSelect = false;
            PersonelListele.RowPrePaint += new DataGridViewRowPrePaintEventHandler(PersonelSec_RowPrePaint);
        }
        private void PersonelSec_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }
        DBOperasyon dbo = new DBOperasyon();
        List<String[]> PersonelBilgileri;
        List<String[]> personelBilgileri;
        List<String> gelenBilgiler;
        List<String[]> Bilgiler;
         string degerAdi;
         string degerSoyadi;
         string degerTC;
         string degerID;      
        string yetkiID2;
        string KullaniciID;
        string degerAdi2;
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            bool bulundumu = false;
            string PersonelAdi = txtAdi.Text;
            string Soyadi = txtSoyadi.Text;
            string TC =txtTC.Text;           
            Bilgiler = dbo.Select(sorgularcs.PersonelListele);
            if (String.IsNullOrWhiteSpace(txtAdi.Text) || String.IsNullOrWhiteSpace(txtSoyadi.Text) || String.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Personel Adı,Soyadı veya TC boş bırakılamaz.");

            }
           else if (txtTC.Text.Length == 11)
            {
                bulundumu = true;
            }
            else
            {
                MessageBox.Show("TC 11 haneden oluşmalıdır..");
                bulundumu = false;
            }

            if(bulundumu==true)
            {
                for (int i = 0; i < Bilgiler.Count; i++)
                {
                    if (Bilgiler[i][3] == TC.ToString())
                    {
                        MessageBox.Show("Böyle bir personel vardır..");
                        bulundumu = true;
                        break;
                       
                    }
                    bulundumu = false;
                                   
                }
                
                    if (bulundumu==false)
                    {
                        dbo.Insert(PersonelAdi, Soyadi,TC);
                        MessageBox.Show("Veri tabanına personel eklenmiştir.");                      

                    }                    

            }
            txtAdi.Text = txtSoyadi.Text = txtTC.Text = "";

        }

         
        
        private void PersonelListele_CellDoubleContentClick(object sender, DataGridViewCellEventArgs e)
        {
           degerAdi = PersonelListele.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
           degerSoyadi = PersonelListele.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
           degerTC = PersonelListele.CurrentRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
           degerID = PersonelListele.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();           
           txtAd.Text = degerAdi;        
        }

  

        private void btnListele_Click(object sender, EventArgs e)
        {
            personelBilgileri = dbo.Select(sorgularcs.PersonelListele);
            foreach (string[] item in personelBilgileri)
            {
                PersonelListele.Rows.Add(item);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtAd.Text=="")
            {
                MessageBox.Show("Silmek istediğiniz personeli seçiniz..");
            }
            else
            {
                gelenBilgiler = new List<string>() { degerAdi, degerSoyadi, degerTC };
                PersonelBilgileri = dbo.Select(sorgularcs.Personel, sorgularcs.PersonelParametreler, gelenBilgiler);

                if (PersonelBilgileri[0][1] == degerAdi && PersonelBilgileri[0][2] == degerSoyadi && PersonelBilgileri[0][3] == degerTC)
                {
                    DialogResult durum = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == durum)
                    {                 
                        int id = Convert.ToInt32(degerID);


                        foreach (DataGridViewRow drow in PersonelListele.SelectedRows)  //Seçili Satırları Silme
                        {

                            dbo.PersonelSil(degerAdi, degerSoyadi,degerTC, id);
                            MessageBox.Show("Kayıt Silindi...");
                            PersonelListele.Rows.Clear();

                        }
                        personelBilgileri = dbo.Select(sorgularcs.PersonelListele);
                        foreach (string[] item in personelBilgileri)
                        {
                            PersonelListele.Rows.Add(item);
                        }


                    }


                }
                else
                    MessageBox.Show("Böyle bir personel bulunmamaktadır..");
            }
            
        }
        private void txtTC_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Sadece sayı girebilirsiniz..");
        }

        private void txtAdi_TextChanged(object sender, KeyPressEventArgs e)
        {
           if( e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Sadece harf girebilirsiniz..");
            }
               
    
        }

        private void txtSoyadi_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Sadece harf girebilirsiniz..");
            }
        }


        private void txtYetki_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtYetki1.Text) && String.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Yetki ID boş bırakılamaz ve Kullanıcı Adı boş bırakılamaz..");

            }
            else if (txtKullaniciAdi.Text == "")
            {
                MessageBox.Show("Güncellemek istediğiniz personeli seçiniz..");

            }
            else if (txtYetki1.Text == "")
            {
                MessageBox.Show("Güncellemek istediğiniz Yetki ID seçiniz..");

            }
            else
            {
                if (txtYetki1.Text == yetkiID2)
                {
                    MessageBox.Show("Yetki Id de güncelleme yapmadınız..");
                }
                else
                {
                    int yetki = Convert.ToInt32(txtYetki1.Text);

                    if (yetki == 0 || yetki == 1)
                    {
                        int kullaniciid = Convert.ToInt32(KullaniciID);
                        dbo.Guncelle(yetki, kullaniciid);
                        MessageBox.Show("Yetki İD güncellendi");
                    }
                    else
                        MessageBox.Show("Yetki İD 0 yada 1 olmalıdır..");
                }
            }
            txtYetki1.Text = "";
            txtKullaniciAdi.Text = "";


        }

        private void dataKullanici_CellDoubleContentClick(object sender, DataGridViewCellEventArgs e)
        {
            degerAdi2 = dataKullanici.CurrentRow.Cells["Column2"].Value.ToString();
            yetkiID2= dataKullanici.CurrentRow.Cells["Column3"].Value.ToString();
            KullaniciID= dataKullanici.CurrentRow.Cells["Column1"].Value.ToString();
            txtKullaniciAdi.Text = degerAdi2;
            txtYetki1.Text = yetkiID2;
           
        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            personelBilgileri = dbo.Select(sorgularcs.Kullanici);
            foreach (string[] item in personelBilgileri)
            {
                dataKullanici.Rows.Add(item);
            }
        }

        private void txtYetki1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Sadece sayı girebilirsiniz..");
        }

      
    }
        }
    
    

