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
    public partial class sinavsorusueklemeekrani : Form
    {
        public sinavsorusueklemeekrani()
        {
            InitializeComponent();
        }

        private void buttonsoruekle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlsorusayisi = new SqlCommand("SELECT * from soru_bilgileri where hocakodu = @hocakodu", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlsorusayisi.Parameters.AddWithValue("@hocakodu", aktifkullanici.aktifkullanici_ogrkod);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsorusayisi);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            int ciguli = Convert.ToInt32(dt2.Compute("max([sorusayisi])", string.Empty));

            int dogrucevap = 0;

            if (checkBoxA.Checked == true) { dogrucevap = 1; }
            if (checkBoxB.Checked == true) { dogrucevap = 2; }
            if (checkBoxC.Checked == true) { dogrucevap = 3; }
            if (checkBoxD.Checked == true) { dogrucevap = 4; }
            if (checkBoxE.Checked == true) { dogrucevap = 5; }


            SqlCommand sqlsoruekle = new SqlCommand("Insert into soru_bilgileri (sorukoku,sorukonusu,cevapa,cevapb,cevapc,cevapd,cevape,dogrucevap,sorusayisi,hocakodu) values (@sorukoku,@sorukonusu,@cevapa,@cevapb,@cevapc,@cevapd,@cevape,@dogrucevap,@sorusayisi,@hocakodu)", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlsoruekle.Parameters.AddWithValue("@sorukoku", textBoxKok.Text);
            sqlsoruekle.Parameters.AddWithValue("@sorukonusu", textBoxkonu.Text);
            sqlsoruekle.Parameters.AddWithValue("@cevapa", textBoxA.Text);
            sqlsoruekle.Parameters.AddWithValue("@cevapb", textBoxB.Text);
            sqlsoruekle.Parameters.AddWithValue("@cevapc", textBoxC.Text);
            sqlsoruekle.Parameters.AddWithValue("@cevapd", textBoxD.Text);
            sqlsoruekle.Parameters.AddWithValue("@cevape", textBoxE.Text);
            sqlsoruekle.Parameters.AddWithValue("@dogrucevap",dogrucevap);
            sqlsoruekle.Parameters.AddWithValue("@sorusayisi", ciguli+1);
            sqlsoruekle.Parameters.AddWithValue("@hocakodu", aktifkullanici.aktifkullanici_ogrkod);

            sqlsoruekle.ExecuteNonQuery();

            MessageBox.Show("Sorunuz eklenmiştir."); 

            sinavsorusueklemeekrani yeniforma = new sinavsorusueklemeekrani();
            yeniforma.Show();
            this.Hide();
        }

        private void sinavsorusueklemeekrani_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogretmenanaekran yeniforma = new ogretmenanaekran();
            yeniforma.Show();
            this.Hide();
        }
    }
}
