using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HastaneRandevuSistemi
{

    public partial class KayitEkrani : Form
    {
        MainMenu form1;
        

        public KayitEkrani(MainMenu form1)
        {
            InitializeComponent();
            this.form1 = form1;
            dtpTarih.MinDate = DateTime.Today;
        }
        

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            List<Hasta> hastalar = new List<Hasta>();
            List<Randevu> randevular = new List<Randevu>();

            Hasta hasta = new Hasta();
            Randevu randevu = new Randevu();
            string randevuSaat = "";

            hasta.Tc = txtTC.Text;
            hasta.AdSoyad = txtAdSoyad.Text;
            hasta.Telefon = maskedTxtTelefon.Text;
            hasta.Cinsiyet = rbErkek.Checked ? "Erkek" : "Kadın";
            randevu.Poliklinik = cmbPolikinik.SelectedItem.ToString();
            if (rb12.Checked) randevuSaat = "12.00";
            else if (rb13.Checked) randevuSaat = "13.00";
            else if (rb14.Checked) randevuSaat = "14.00";
            else if (rb15.Checked) randevuSaat = "15.00";
            randevu.RandevuSaat = randevuSaat;


            hastalar.Add(hasta);
            randevular.Add(randevu);

            form1.ListeleriGonder(hastalar, randevular);

            Temizle();
        }
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // karakter girişini engelle
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Temizle()
        {
            txtTC.Clear();
            txtAdSoyad.Clear();
            maskedTxtTelefon.Clear();
            rbErkek.Checked = false;
            rbKadin.Checked = false;
            cmbPolikinik.SelectedIndex = -1;
            dtpTarih.Value = DateTime.Today;
            rb12.Checked = false;
            rb13.Checked = false;
            rb14.Checked = false;
            rb15.Checked = false;
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
          
            DateTime bugun = DateTime.Now;
        }
    }
}
