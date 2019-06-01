using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace YazilimSinama
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        DBOperasyon dbo = new DBOperasyon();
        List<String[]> kullaniciBilgileri;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Boş değer girilmesini engelliyoruz.     
            if (String.IsNullOrWhiteSpace(txtKullaniAdi.Text) || String.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre boş bırakılamaz.");

            }
            else
            {
                string kullaniciAdi = txtKullaniAdi.Text;
                string sifre = txtSifre.Text;            
                kullaniciBilgileri = dbo.Select(sorgularcs.Kullanicigirisi);
                bool kontrol = false;
                if (kullaniciBilgileri.Count > 0)
                {

                    for (int i = 0; i <kullaniciBilgileri.Count; i++)
                    {
                        if (kullaniciAdi == kullaniciBilgileri[i][2] && sifre == kullaniciBilgileri[i][4])
                        {
                            kontrol = true;
                            if (kullaniciBilgileri[i][3] == "1")
                            {
                                this.Hide();
                                frmDemirbasTakipOtomasyonu frm2 = new frmDemirbasTakipOtomasyonu();
                                frm2.Show();

                            }
                            else if (kullaniciBilgileri[i][3] == "0")
                            {
                                this.Hide();
                                Personel frm = new Personel();
                                frm.Show();
                            }
                           
                        }

                    }
                     if(kontrol==false)
                      MessageBox.Show("Kullanıcı adı yada şifre hatalıdır.");

                }

            }
                           
            }
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKaydol frm = new FrmKaydol();
            frm.Show();
        }

        private void txtKullaniAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniAdi.TextLength>20)
            {
                MessageBox.Show("Kullanıcı Adı 20 karakterden fazla olamaz...");
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.TextLength > 20)
            {
                MessageBox.Show("Kullanıcı Adı 20 karakterden fazla olamaz...");
            }
        }
    } 
    }

