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

namespace _6SigmaileSınavSistemi_MehmetKaanALTUN_
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand sqlgirisyapma = new SqlCommand("Select * from ogrenci_bilgileri where kullaniciadi = @kullaniciadi and sifre = @sifre ", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlgirisyapma.Parameters.AddWithValue("@kullaniciadi", tboxgiriskullaniciadi.Text);
            sqlgirisyapma.Parameters.AddWithValue("@sifre", tboxgirissifre.Text);

            SqlDataAdapter da = new SqlDataAdapter(sqlgirisyapma);
            DataTable dt = new DataTable();

            da.Fill(dt);

            SqlCommand sqlgirisyapma2 = new SqlCommand("Select * from ogretmen_bilgileri where kullaniciadi = @kullaniciadi and sifre = @sifre ", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlgirisyapma2.Parameters.AddWithValue("@kullaniciadi", tboxgiriskullaniciadi.Text);
            sqlgirisyapma2.Parameters.AddWithValue("@sifre", tboxgirissifre.Text);

            SqlDataAdapter da2 = new SqlDataAdapter(sqlgirisyapma2);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Giriş başarılı hoşgeldiniz dersinizi iyi çalışınız ^^.");

                aktifkullanici.aktifkullanici_isim = dt.Rows[0]["isim"].ToString();
                aktifkullanici.aktifkullanici_soyisim = dt.Rows[0]["soyisim"].ToString();
                aktifkullanici.aktifkullanici_kullaniciadi = dt.Rows[0]["kullaniciadi"].ToString();
                aktifkullanici.aktifkullanici_sifre = dt.Rows[0]["sifre"].ToString();
                aktifkullanici.aktifkullanici_email = dt.Rows[0]["email"].ToString();
                aktifkullanici.aktifkullanici_ogrkod = dt.Rows[0]["ogretmenkodu"].ToString();

                ogrencianaekran yeniforma = new ogrencianaekran();
                yeniforma.Show();
                this.Hide();
            }
            else if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("Giriş başarılı hoşgeldiniz.");

                aktifkullanici.aktifkullanici_isim = dt2.Rows[0]["isim"].ToString();
                aktifkullanici.aktifkullanici_soyisim = dt2.Rows[0]["soyisim"].ToString();
                aktifkullanici.aktifkullanici_kullaniciadi = dt2.Rows[0]["kullaniciadi"].ToString();
                aktifkullanici.aktifkullanici_sifre = dt2.Rows[0]["sifre"].ToString();
                aktifkullanici.aktifkullanici_email = dt2.Rows[0]["email"].ToString();
                aktifkullanici.aktifkullanici_ogrkod = dt2.Rows[0]["ogretmenkodu"].ToString();

                ogretmenanaekran yeniforma = new ogretmenanaekran();
                yeniforma.Show();
                this.Hide();
            }
        }

        private void button_kayit_Click(object sender, EventArgs e)
        {
            KayitEkrani yeniforma = new KayitEkrani();
            yeniforma.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttumekrani yeniforma = new sifremiunuttumekrani();
            yeniforma.Show();
            this.Hide();
        }
    }
}
