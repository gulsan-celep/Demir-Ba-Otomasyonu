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
    public partial class Demirbasİlemleri : Form
    {
        public Demirbasİlemleri()
        {
            InitializeComponent();
        }
        DBOperasyon dbo = new DBOperasyon();    
        List<String[]> Bilgiler;
        List<String[]> DepartmanBilgiler;
        List<String[]> DemirbasBilgiler;
        List<String[]> DemirbasArama;
        List<String[]> PersonelBilgiler;
        List<String[]> PersonelArama;
        int fakulteID;
        int DepartmanID;
        int PersonelID;
        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepartman.Items.Clear();
            string fakulte = cmbFakulte.Text;
            Bilgiler = dbo.Select(sorgularcs.Fakulte);
            DepartmanBilgiler = dbo.Select(sorgularcs.Departman);
            foreach (var item in Bilgiler)
            {
                if(item[1]==fakulte)
                {
                    foreach (var items in DepartmanBilgiler)
                    {
                        if(item[0]==items[0])
                        {
                            cmbDepartman.Items.Add(items[1].ToString());
                            fakulteID =Convert.ToInt32(item[0]);
                            
                        }
                        
                    }
                    
                }
            }



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Bilgiler = dbo.Select(sorgularcs.Fakulte);
            PersonelBilgiler = dbo.Select(sorgularcs.PersonelListele);
            foreach (var item in Bilgiler)
            {
                cmbFakulte.Items.Add(item[1].ToString());

            }
            txtDAlimTarihi.Text = DateTime.Now.ToShortDateString();
            DemirbasBilgiler = dbo.Select(sorgularcs.DemirbasTuru);
            foreach (var item in DemirbasBilgiler)
            {
                cmbTur.Items.Add(item[1]);
            }
            foreach (var item in PersonelBilgiler)
            {
                cPersonel.Items.Add(item[1].ToString());

            }
            lblSorgu.Hide();

            cbDemirbas.Items.Add("Demirbaş Adına Göre Arama");
            cbDemirbas.Items.Add("Fiyata Göre Arama");
            cbDemirbas.Items.Add("Alım Tarihine Göre Arama");
            cbDemirbas.Items.Add("Demirbaşın Türüne Göre Arama");
            cbDemirbas.Items.Add("Adete Göre Arama");

           

        }
        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            string departman = cmbDepartman.Text;
            foreach (var item in DepartmanBilgiler)
            {
                if(departman==item[1])
                {
                    DepartmanID = Convert.ToInt32(item[2]);
                }
            }
           
        }

        private void txtDAlimTarihi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDemirbasEkle_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtAciklama.Text) || String.IsNullOrWhiteSpace(txtAdet.Text) || String.IsNullOrWhiteSpace(txtDAlimTarihi.Text) || String.IsNullOrWhiteSpace(txtDemirbasAdi.Text) || String.IsNullOrWhiteSpace(txtDFiyat.Text) || String.IsNullOrWhiteSpace(cmbTur.Text) || String.IsNullOrWhiteSpace(txtDAlimTarihi.Text) || String.IsNullOrWhiteSpace(txtDemirbasAdi.Text) || String.IsNullOrWhiteSpace(cmbFakulte.Text) || String.IsNullOrWhiteSpace(txtDAlimTarihi.Text) || String.IsNullOrWhiteSpace(txtDemirbasAdi.Text) || String.IsNullOrWhiteSpace(cmbDepartman.Text))
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz..");

            }
       else
            {
                string aciklama = txtAciklama.Text;
                string DemirbasAdi = txtDemirbasAdi.Text;
                string Fiyat = txtDFiyat.Text;
                string DemirbasTuru = cmbTur.Text;
                int adet = Convert.ToInt32(txtAdet.Text);
                DemirbasBilgiler = dbo.Select(sorgularcs.DemirbasTuru);
                foreach (var item in DemirbasBilgiler)
                {
                    if (DemirbasTuru == item[1])
                    {
                        dbo.DemirbasInsert(DemirbasAdi, Convert.ToInt32(Fiyat), Convert.ToDateTime(txtDAlimTarihi.Text), Convert.ToInt32(item[0]), fakulteID, DepartmanID, adet, aciklama);
                        MessageBox.Show("Veri tabanına eklenmiştir..");
                    }

                }
            }
            txtAciklama.Text = txtDemirbasAdi.Text = txtDFiyat.Text  = txtAdet.Text = "";
           // cmbFakulte.SelectedText.; //= cmbDepartman.Text = cmbTur.Text
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDemirbas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDemirbas.Text== "Alım Tarihine Göre Arama")
            lblSorgu.Show();
        }

        private void btnDemirbasArama_Click(object sender, EventArgs e)
        {
           
            if (cbDemirbas.Text == "" || txtSorgu.Text== "")
            {
                MessageBox.Show("Arayacağınız değeri boş bırakmayınız..");
            }
            else
            {
                string demirbas = cbDemirbas.Text;
                string sorgu = txtSorgu.Text;
                DemirbasArama = dbo.Select(sorgularcs.DemirbasArama);
                if (demirbas == "Demirbaş Adına Göre Arama")
                {
                    foreach (var item in DemirbasArama)
                    {

                        if (item[0] == sorgu)
                        {

                            dataDemirbasArama.Rows.Add(item);
                        }
                    }

                }
                else if (demirbas == "Fiyata Göre Arama")
                {
                    foreach (var item in DemirbasArama)
                    {
                        if (item[1] == sorgu)
                        {
                            dataDemirbasArama.Rows.Add(item);
                        }
                    }

                }
                else if (demirbas == "Alım Tarihine Göre Arama")
                {
                    
                    foreach (var item in DemirbasArama)
                    {
                        if (item[2] == Convert.ToDateTime(sorgu).ToString())
                        {
                            dataDemirbasArama.Rows.Add(item);
                        }
                    }

                }
                else if (demirbas == "Demirbaşın Türüne Göre Arama")
                {
                    foreach (var item in DemirbasArama)
                    {
                        if (item[4] == sorgu)
                        {
                            dataDemirbasArama.Rows.Add(item);
                        }
                    }

                }
                else if (demirbas == "Adete Göre Arama")
                {
                    foreach (var item in DemirbasArama)
                    {
                        if (item[3] == sorgu)
                        {
                            dataDemirbasArama.Rows.Add(item);
                        }
                    }

                }


            }

        }

        private void btnPersonelDemirbasArama_Click(object sender, EventArgs e)
        {

            if(cPersonel.Text=="")
            {
                MessageBox.Show("Lütfen personel seçiniz..");
            }
            else
            {
                string personel = cPersonel.Text;
                PersonelArama = dbo.PersonelUzerindeDemirbasArama(PersonelID);
                if (PersonelArama.Count != 0)
                {
                    foreach (string[] item in PersonelArama)
                    {
                        dataPersonelDemirbas.Rows.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Personele demirbaş atanmamıştır..");
                }

            }


        }

        private void cPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string personel = cPersonel.Text;
            foreach (var item in PersonelBilgiler)
            {
                if (personel == item[1])
                {
                   PersonelID = Convert.ToInt32(item[0]);
                }
            }
        }

        private void btnStokListele_Click(object sender, EventArgs e)
        {
            List<String[]> StokListele;
            StokListele = dbo.StokListele();
            foreach (string[] item in StokListele)
            {
                dataStokListele.Rows.Add(item);
            }
        }

        private void txtAciklama_TextChanged(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtDFiyat_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Sadece sayı girebilirsiniz..");
        }

        private void txtAdet_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Sadece sayı girebilirsiniz..");
        }

        private void txtDemirbasAdi_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Sadece harf girebilirsiniz..");
            }
        }

        private void txtDFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSorgu_TextChanged(object sender, KeyPressEventArgs e)
        {
            string demirbas = cbDemirbas.Text;
            string sorgu = txtSorgu.Text;
            DemirbasArama = dbo.Select(sorgularcs.DemirbasArama);
            if (demirbas == "Demirbaş Adına Göre Arama")
            {

                if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
                {
                    MessageBox.Show("Sadece harf girebilirsiniz..");
                }
            }
            else if (demirbas == "Fiyata Göre Arama")
            {
                if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    MessageBox.Show("Sadece sayı girebilirsiniz..");

            }
           else if (demirbas == "Alım Tarihine Göre Arama")
            {
                lblSorgu.Show();
                if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
                    MessageBox.Show("Harf giremezsiniz..");
            }
            else if (demirbas == "Demirbaşın Türüne Göre Arama")
            {
                if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
                {
                    MessageBox.Show("Sadece harf girebilirsiniz..");
                }

            }
            else if (demirbas == "Adete Göre Arama")
            {

                if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    MessageBox.Show("Sadece sayı girebilirsiniz..");


            }

        }
    }
}
