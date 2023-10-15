using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class MainMenu : Form
    {
        KayitEkrani frm2;
        Randevular frm3;

        List<Hasta> hastalar1 = new List<Hasta>();
        List<Randevu> randevular1 = new List<Randevu>();
        
        public MainMenu()
        {
            InitializeComponent();
            frm2 = new KayitEkrani(this);
            frm3 = new Randevular(this, hastalar1, randevular1);
        }

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm3.Hide();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(0, 0);
            this.Size = frm2.ClientSize;
            frm2.Show();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2.Hide();
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Location = new Point(0, 0);
            this.Size = frm3.ClientSize;
            frm3.Randevular_Load(sender, e);
            frm3.Show();    
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        internal void ListeleriGonder(List<Hasta> hastalar, List<Randevu> randevular)
        {
            foreach (var item in hastalar)
            {
                hastalar1.Add(item);
            }
            foreach (var item in randevular)
            {
                randevular1.Add(item);

            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            frm2.MdiParent = this;
            frm3.MdiParent = this;
        }
    }
}
