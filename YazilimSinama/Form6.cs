using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace YazilimSinama
{
    public partial class FrmKaydol : Form
    {
        public FrmKaydol()
        {
            InitializeComponent();
        }
        DBOperasyon dbo = new DBOperasyon();
        List<String[]> kullaniciBilgileri;
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            string Tc = txtTC.Text;
            string kullanici = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            bool kontrol = false,kontrol2=false;
            // Boş değer girilmesini engelliyoruz.     
            if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || String.IsNullOrWhiteSpace(txtSifre.Text) || String.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Kullanıcı Adı,Şifre veya TC boş bırakılamaz.");
                kontrol = false;

            }
            if (txtTC.Text.Length == 11)
            {

            }
            else
            {
                MessageBox.Show("TC 11 haneden oluşmalıdır..");
                kontrol = false;
            }
            if (txtKullaniciAdi.Text.Length > 6 && txtKullaniciAdi.Text.Length < 20)
            {

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı en az 6 en fazla 20 haneden oluşmalıdır..");
                kontrol = false;
            }
            if (txtSifre.Text.Length > 6 && txtSifre.Text.Length < 20)
            {

            }
            else
            {
                MessageBox.Show("Şifre en az 6 en fazla 20 haneden oluşmalıdır..");
                kontrol = false;
            }
            if (txtSifre.Text.Length > 6 && txtSifre.Text.Length < 20 && txtKullaniciAdi.Text.Length > 6 && txtKullaniciAdi.Text.Length < 20 && txtTC.Text.Length == 11)
            {
                kontrol = true;
            }
            if (kontrol == true)
            {
                kullaniciBilgileri = dbo.Select(sorgularcs.PersonelListele);
                for (int i = 0; i < kullaniciBilgileri.Count; i++)
                {
                    if (kullaniciBilgileri[i][3] == Tc.ToString())
                    {
                        MessageBox.Show("Kayıt Başarılı..");
                        string PersonelID = (kullaniciBilgileri[i][0]);
                        dbo.KullaniciInsert(kullanici, sifre, PersonelID);
                        kontrol2 = true;
                        break;
                    }
                }

                if (kontrol2 == false)
                {
                    MessageBox.Show("Böyle bir personel bulunmamaktadır..");
                }
            }

            txtKullaniciAdi.Text = txtSifre.Text = txtTC.Text = "";
        }
  
        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisEkrani frm = new GirisEkrani();
            this.Hide();
            frm.Show();
        }

        private void txtTC_TextChanged(object sender, KeyPressEventArgs e)
        {
            
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Sadece sayı girebilirsiniz..");
      
               
            
        }
        private void txtTC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmKaydol_Load(object sender, EventArgs e)
        {
          
        }
    }
}
