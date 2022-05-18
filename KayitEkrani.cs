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
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void button_kayitol_Click(object sender, EventArgs e)
        {
            if (checkBox_ogretmen.Checked == true)
            {

                new Kullanici_ogretmen(tboxisim.Text, tboxsoyisim.Text, tboxkullaniciadi.Text, tboxsifre.Text, tboxmail.Text);

                MessageBox.Show("Başarıyla kayıt olundu.");

                SqlCommand sqlkayıtol = new SqlCommand("SELECT * from ogretmen_bilgileri", SqlFile.SqlVariables.baglanti);
                SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                SqlDataAdapter da2 = new SqlDataAdapter(sqlkayıtol);
                DataTable dt2 = new DataTable();

                da2.Fill(dt2);
                int ciguli = Convert.ToInt32(dt2.Compute("max([ogretmenkodu])", string.Empty));

                MessageBox.Show("Öğretmen kodunuz : " + (ciguli));

                GirisEkrani yeniform = new GirisEkrani();
                yeniform.Show();
                this.Hide();

                SqlCommand sqlsoruekle = new SqlCommand("Insert into soru_bilgileri (sorukoku,sorukonusu,cevapa,cevapb,cevapc,cevapd,cevape,dogrucevap,sorusayisi,hocakodu) values (@sorukoku,@sorukonusu,@cevapa,@cevapb,@cevapc,@cevapd,@cevape,@dogrucevap,@sorusayisi,@hocakodu)", SqlFile.SqlVariables.baglanti);

                SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                string a = "a";
                sqlsoruekle.Parameters.AddWithValue("@sorukoku", a);
                sqlsoruekle.Parameters.AddWithValue("@sorukonusu", a);
                sqlsoruekle.Parameters.AddWithValue("@cevapa", a);
                sqlsoruekle.Parameters.AddWithValue("@cevapb", a);
                sqlsoruekle.Parameters.AddWithValue("@cevapc", a);
                sqlsoruekle.Parameters.AddWithValue("@cevapd", a);
                sqlsoruekle.Parameters.AddWithValue("@cevape", a);
                sqlsoruekle.Parameters.AddWithValue("@dogrucevap", 0);
                sqlsoruekle.Parameters.AddWithValue("@sorusayisi", 0);
                sqlsoruekle.Parameters.AddWithValue("@hocakodu", ciguli);

                sqlsoruekle.ExecuteNonQuery();

            }
            else if (checkBox_ogrenci.Checked == true)
            {
                new Kullanici_ogrenci(tboxisim.Text, tboxsoyisim.Text, tboxkullaniciadi.Text, tboxsifre.Text, tboxmail.Text,tboxogretmenkod.Text);
                MessageBox.Show("Başarıyla kayıt olundu.");



            }
        }

        private void checkBox_ogrenci_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_ogretmen.Checked = false;
            label_ogretmenkod.Visible = true;
            tboxogretmenkod.Visible = true;
        }

        private void checkBox_ogretmen_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_ogrenci.Checked = false;
            label_ogretmenkod.Visible = false;
            tboxogretmenkod.Visible = false;
        }

        private void KayitEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
