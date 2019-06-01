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
    public partial class Odaslemleri : Form
    {
        public Odaslemleri()
        {
            InitializeComponent();

        }
 
        DBOperasyon dbo = new DBOperasyon();
        List<String[]> Bilgiler;
        List<String[]> DepartmanBilgiler;
        List<String[]> PersonelBilgiler;
        List<String[]> OdaBilgiler;
        List<String[]> DemirbasBilgiler;
        int fakulteID;
        int DepartmanID;
        int PersonelID;
        int DemirbasID;
        int OdaID;
        private void Form5_Load(object sender, EventArgs e)
        {
            Bilgiler = dbo.Select(sorgularcs.Fakulte);
            PersonelBilgiler = dbo.Select(sorgularcs.PersonelListele);
            DemirbasBilgiler = dbo.Select(sorgularcs.Demirbas);
            OdaBilgiler = dbo.Select(sorgularcs.Oda);
            foreach (var item in Bilgiler)
            {
                cbFakulte.Items.Add(item[1].ToString());

            }

            foreach (var item in PersonelBilgiler)
            {              
                cbbPersonel.Items.Add(item[1].ToString());

            }

          
            foreach (var item in DemirbasBilgiler)
            {
                cbDemirbasAdi.Items.Add(item[1].ToString());

            }
            foreach (var item in OdaBilgiler)
            {
                cbOdaAdi.Items.Add(item[2].ToString());
                cboda.Items.Add(item[2].ToString());
            }

        }

        private void cbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDepartman.Items.Clear();
            string fakulte = cbFakulte.Text;
            Bilgiler = dbo.Select(sorgularcs.Fakulte);
            DepartmanBilgiler = dbo.Select(sorgularcs.Departman);
            OdaBilgiler = dbo.Select(sorgularcs.Oda);
            foreach (var item in Bilgiler)
            {
                if (item[1] == fakulte)
                {
                    foreach (var items in DepartmanBilgiler)
                    {
                        if (item[0] == items[0])
                        {
                            cbDepartman.Items.Add(items[1].ToString());
                            fakulteID = Convert.ToInt32(item[0]);

                        }

                    }

                }
            }
            }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {

            if (txtOda.Text == "" || cbFakulte.Text == "" || cbDepartman.Text == "")
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz..");
            }
            else
            {
                string OdaAdi = txtOda.Text;
                string fakulte = cbFakulte.SelectedItem.ToString();
                dbo.InsertOda(OdaAdi, DepartmanID);
                MessageBox.Show("Veri tabanına oda eklenmiştir.");
            }
            txtOda.Text = "";
           
        }

        private void cbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departman = cbDepartman.Text;
            foreach (var item in DepartmanBilgiler)
            {
                if (departman == item[1])
                {
                    DepartmanID = Convert.ToInt32(item[2]);
                }
            }
        }

    

        private void btnDemirbasAtama_Click(object sender, EventArgs e)
        {

            if (cbOdaAdi.Text == "" || cbbPersonel.Text == "" || txtAdet.Text == "" || cbDemirbasAdi.Text == "")
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
                            sonuc =( Convert.ToInt32(item[9]) )- adet;
                            dbo.DemirbasGuncelle(sonuc);
                            dbo.OdaDemirbasInsert(OdaID, DemirbasID, adet, PersonelID);
                            MessageBox.Show("Odaya demirbaş ve personel atama gerçekleşti..");
                        }
                    }
                }
            }
            txtAdet.Text = "";
        }

        private void cbbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string personel = cbbPersonel.Text;
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

        private void tabPage3_Click(object sender, EventArgs e)
        {
          
        }

        private void btnOdaArama_Click(object sender, EventArgs e)
        {

            if (cboda.Text == "")
            {
                MessageBox.Show("Arayacağınız odayı seçiniz..");
            }
            else
            {
                List<String[]> OdaArama;
                string odaArama = cboda.Text;
                int oda = 0;
                foreach (var item in OdaBilgiler)
                {
                    if (odaArama == item[2])
                    {
                        oda = Convert.ToInt32(item[0]);

                    }
                }

                OdaArama = dbo.Arama(oda);
                if (OdaArama.Count != 0)
                {
                    foreach (string[] item in OdaArama)
                    {
                        dataOdaArama.Rows.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Oda boştur..");
                }


            }

        }

        private void txtAdet_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                MessageBox.Show("Sadece sayı girebilirsiniz..");
        }

        private void btnStokListele_Click(object sender, EventArgs e)
        {
            List<String[]> StokListele;
            StokListele = dbo.OdaDemirbasListeleme();
            foreach (string[] item in StokListele)
            {
                dataStokListele.Rows.Add(item);
            }
        }

        private void txtOda_TextChanged(object sender, KeyPressEventArgs e)
        {
           if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Özel karakter giremezsiniz..");
            }
        }

        private void txtOda_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
