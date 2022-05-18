using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6SigmaileSınavSistemi_MehmetKaanALTUN_
{
    public partial class ogretmenanaekran : Form
    {
        public ogretmenanaekran()
        {
            InitializeComponent();
        }

        public void sayfayiyenile()
        {
            labelhocaadi.Text = aktifkullanici.aktifkullanici_isim;
            labelhocanum.Text = aktifkullanici.aktifkullanici_ogrkod;
        }
        private void ogretmenanaekran_Load(object sender, EventArgs e)
        {
            sayfayiyenile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sinavsorusueklemeekrani yeniforma = new sinavsorusueklemeekrani();
            yeniforma.Show();
            this.Hide();
        }

        private void button_kayit_Click(object sender, EventArgs e)
        {
          aktifkullanici.aktifkullanici_isim = null;
          aktifkullanici.aktifkullanici_soyisim = null;
          aktifkullanici.aktifkullanici_kullaniciadi = null;
          aktifkullanici.aktifkullanici_sifre = null;
          aktifkullanici.aktifkullanici_email = null;
          aktifkullanici.aktifkullanici_ogrkod = null;

          GirisEkrani yeniforma = new GirisEkrani();
          yeniforma.Show();
          this.Hide();
        }
    }
}
