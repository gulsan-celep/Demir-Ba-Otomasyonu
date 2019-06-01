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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        DBOperasyon dbo = new DBOperasyon();
        List<String[]> PersonelBilgiler;
        List<String[]> OdaBilgiler;
        List<String[]> DemirbasBilgiler;
        List<String[]> PersonelArama;
        int PersonelID;
        int DemirbasID;
        int OdaID;
        private void Personel_Load(object sender, EventArgs e)
        {          
            PersonelBilgiler = dbo.Select(sorgularcs.PersonelListele);
            DemirbasBilgiler = dbo.Select(sorgularcs.Demirbas);
            OdaBilgiler = dbo.Select(sorgularcs.Oda);        
            foreach (var item in PersonelBilgiler)
            {
                cbbPersonel.Items.Add(item[1].ToString());
                cPersonel.Items.Add(item[1].ToString());

            }


            foreach (var item in DemirbasBilgiler)
            {
                cbDemirbasAdi.Items.Add(item[1].ToString());

            }
            foreach (var item in OdaBilgiler)
            {
                cbOdaAdi.Items.Add(item[2].ToString());            
            }
        }

        private void btnDemirbasAtama_Click(object sender, EventArgs e)
        {
            if (cbOdaAdi.Text == "" || cbDemirbasAdi.Text == "" || cbbPersonel.Text == "" || txtAdet.Text == "")
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz..");
            }
            else
            {
                int adet = Convert.ToInt32(txtAdet.Text);
                string demirbas = cbDemirbasAdi.Text;
                int sonuc = 0;
                foreach (var item in DemirbasBilgiler)
                {
                    if (demirbas == item[1])
                    {
                        if (adet > Convert.ToInt32(item[7]))
                        {
                            MessageBox.Show(demirbas + " adet yoktur..");
                        }
                        else if (adet < Convert.ToInt32(item[7]) || adet == Convert.ToInt32(item[7]))
                        {
                            sonuc = Convert.ToInt32(item[7]) - adet;
                            dbo.DemirbasGuncelle(sonuc);
                            dbo.OdaDemirbasInsert(OdaID, DemirbasID, adet, PersonelID);
                            MessageBox.Show("Odaya demirbaş ve personel atama gerçekleşti..");
                        }
                    }
                }
            }
            txtAdet.Text = "";
        }

        private void btnPersonelDemirbasArama_Click(object sender, EventArgs e)
        {
            if (cPersonel.Text == "")
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

        private void cbDemirbasAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string demirbas = cbDemirbasAdi.Text;
            foreach (var item in DemirbasBilgiler)
            {
                if (demirbas == item[1])
                {
                    DemirbasID = Convert.ToInt32(item[0]);
                }
            }
        }

        private void cbOdaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oda = cbOdaAdi.Text;
            foreach (var item in OdaBilgiler)
            {
                if (oda == item[2])
                {
                    OdaID = Convert.ToInt32(item[0]);
                }
            }
        }

        private void txtAdet_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Sadece sayı girebilirsiniz..");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisEkrani GE = new GirisEkrani();
            GE.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisEkrani GE = new GirisEkrani();
            GE.Show();
        }
    }
}
