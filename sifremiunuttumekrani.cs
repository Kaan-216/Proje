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
    public partial class sifremiunuttumekrani : Form
    {
        public int ogretmen_mi;
        public string sifrekiminisim;
        public string sifrekiminemail;
        public sifremiunuttumekrani()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand sqlgirisyapma = new SqlCommand("Select * from ogrenci_bilgileri where email = @mail and hatırlatma = @kod ", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlgirisyapma.Parameters.AddWithValue("@mail", tboxmail.Text);
            sqlgirisyapma.Parameters.AddWithValue("@kod", textboxkod.Text);

            SqlDataAdapter da = new SqlDataAdapter(sqlgirisyapma);
            DataTable dt = new DataTable();

            da.Fill(dt);

            SqlCommand sqlgirisyapma2 = new SqlCommand("Select * from ogretmen_bilgileri where email = @mail and hatırlatma = @kod ", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlgirisyapma2.Parameters.AddWithValue("@mail", tboxmail.Text);
            sqlgirisyapma2.Parameters.AddWithValue("@kod", textboxkod.Text);

            SqlDataAdapter da2 = new SqlDataAdapter(sqlgirisyapma2);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Kodunuz doğrulanmıştır lütfen yeni şifrenizi belirleyiniz.");
                labelyst.Visible = true;
                labelys.Visible = true;
                buttonys.Visible = true;
                tboxys.Visible = true;
                tboxyst.Visible = true;
                ogretmen_mi = 0;
                sifrekiminisim = dt.Rows[0]["isim"].ToString();
                sifrekiminemail = dt.Rows[0]["email"].ToString();
                labelsuk.Visible = false;
                textboxkod.Visible = false;
                buttonsuk.Visible = false;
                label7.Visible = false;
                tboxmail.Visible = false;
                linkLabel1.Visible = false;
            }
            else if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("Kodunuz doğrulanmıştır lütfen yeni şifrenizi belirleyiniz.");
                labelyst.Visible = true;
                labelys.Visible = true;
                buttonys.Visible = true;
                tboxys.Visible = true;
                tboxyst.Visible = true;
                ogretmen_mi = 1;
                sifrekiminisim = dt2.Rows[0]["isim"].ToString();
                sifrekiminemail = dt2.Rows[0]["email"].ToString();
                labelsuk.Visible = false;
                textboxkod.Visible = false;
                buttonsuk.Visible = false;
                label7.Visible = false;
                tboxmail.Visible = false;
                linkLabel1.Visible = false;
            }
        }

        private void sifremiunuttumekrani_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelsuk.Visible = true;
            textboxkod.Visible = true;
            buttonsuk.Visible = true;
        }

        private void buttonys_Click(object sender, EventArgs e)
        {
            if (ogretmen_mi == 0)
            {
                if (tboxys.Text == tboxyst.Text)
                {
                    SqlCommand sifredegisim = new SqlCommand("Update ogrenci_bilgileri set sifre=@sifre where isim=@isim and email=@email", SqlFile.SqlVariables.baglanti);
                    SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                    sifredegisim.Parameters.AddWithValue("@isim", sifrekiminisim);
                    sifredegisim.Parameters.AddWithValue("@email", sifrekiminemail);
                    sifredegisim.Parameters.AddWithValue("@sifre", tboxys.Text);

                    sifredegisim.ExecuteNonQuery();

                    MessageBox.Show("Şifreniz ayarlanmıştır.");
                }
                else
                {
                    MessageBox.Show("Şifreniz ve şifre tekrarınız uyuşmuyor lütfen kontrol ediniz.");
                }
            }
            else if (ogretmen_mi == 1)
            {
                if (tboxys.Text == tboxyst.Text)
                {
                    SqlCommand sifredegisim = new SqlCommand("Update ogretmen_bilgileri set sifre=@sifre where isim=@isim and email=@email", SqlFile.SqlVariables.baglanti);
                    SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                    sifredegisim.Parameters.AddWithValue("@isim", sifrekiminisim);
                    sifredegisim.Parameters.AddWithValue("@email", sifrekiminemail);
                    sifredegisim.Parameters.AddWithValue("@sifre", tboxys.Text);

                    sifredegisim.ExecuteNonQuery();

                    MessageBox.Show("Şifreniz ayarlanmıştır.");
                }
                else
                {
                    MessageBox.Show("Şifreniz ve şifre tekrarınız uyuşmuyor lütfen kontrol ediniz.");
                }
            }
        }
    }
}
