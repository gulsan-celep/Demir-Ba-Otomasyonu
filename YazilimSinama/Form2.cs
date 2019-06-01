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
    public partial class frmDemirbasTakipOtomasyonu : Form
    {
        public frmDemirbasTakipOtomasyonu()
        {
            InitializeComponent();
        }
        public void yavruform(Form yavru)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == yavru.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
                else
                {
                    eleman.Close();
                }
            }
            if (durum == false)
            {
                yavru.MdiParent = this;
                yavru.Show();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void personelIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personelİslemleri ChildForm = new Personelİslemleri();
            yavruform(ChildForm);
        }

        private void demirbasIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Demirbasİlemleri ChildForm = new Demirbasİlemleri();
            yavruform(ChildForm);
        }

        private void odaIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odaslemleri ChildForm = new Odaslemleri();
            yavruform(ChildForm);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisEkrani GE = new GirisEkrani();
            GE.Show();
           
          

        }
    }
}
