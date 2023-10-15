using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{

    public partial class Randevular : Form
    {
        List<Hasta> hastalar1;
        List<Randevu> randevular1;
        MainMenu form1;

        internal Randevular(MainMenu form1, List<Hasta> hastalar, List<Randevu> randevular)
        {
            InitializeComponent();
            this.hastalar1 = hastalar;
            this.randevular1 = randevular;
            this.form1 = form1;

        }

        public void Randevular_Load(object sender, EventArgs e)
        {
            ListeyeEkle();
        }

        private void ListeyeEkle()
        {
            lstBilgiler.Items.Clear();
            string bilgi;


            for (int i = 0; i < hastalar1.Count; i++)
            {
                bilgi = $"{hastalar1[i].AdSoyad} - {hastalar1[i].Cinsiyet} - {randevular1[i].Poliklinik} - {randevular1[i].Tarih} - {randevular1[i].RandevuSaat}";
                lstBilgiler.Items.Add(bilgi);

            }
        }

        private void lstBilgiler_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = lstBilgiler.IndexFromPoint(lstBilgiler.PointToClient(Cursor.Position));

            if (selectedIndex >= 0)
            {
                string selectedPatientInfo = lstBilgiler.Items[selectedIndex].ToString();
                string[] details = selectedPatientInfo.Split('-');

                if (details.Length >= 5)
                {
                    string message = $"Ad Soyad: {details[0].Trim()}\n" +
                        $"Cinsiyet: {details[1].Trim()}\nPoliklinik Adı: {details[2].Trim()}\nTarih: {details[3].Trim()}\nSaat: {details[4].Trim()}";
                    MessageBox.Show(message, "Detaylar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            DialogResult result = MessageBox.Show("Devam etmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                //MainMenu form1 = new MainMenu(hastalar1, randevular1);
                //form1.Show();
                this.Hide();
            }
            else
            {
               Application.Exit();
            }
        }
    }

}
