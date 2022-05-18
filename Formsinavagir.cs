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
    public partial class Formsinavagir : Form
    {
        public Formsinavagir()
        {
            InitializeComponent();
        }

        private void Formsinavagir_Load(object sender, EventArgs e)
        {
            yenile();

            SqlCommand sqlsorular = new SqlCommand("SELECT * from soru_bilgileri where hocakodu = @hocakodu", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);
            sqlsorular.Parameters.AddWithValue("@hocakodu", aktifkullanici.aktifkullanici_ogrkod);
            
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsorular);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            int ciguli = Convert.ToInt32(dt2.Compute("max([sorusayisi])", string.Empty));

            comboBox1.SelectedIndex = 0;
        }

        private void yenile()
        {
            SqlCommand sqlsorular = new SqlCommand("SELECT * from soru_bilgileri where sorusayisi=@sorusayisi", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);
            sqlsorular.Parameters.AddWithValue("@sorusayisi", (comboBox1.SelectedIndex+1).ToString());

            SqlDataAdapter da2 = new SqlDataAdapter(sqlsorular);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            
            labelsorukok.Text=dt2.Rows[0]["sorukoku"].ToString();
            checkBoxA.Text= dt2.Rows[0]["cevapa"].ToString();
            checkBoxB.Text = dt2.Rows[0]["cevapb"].ToString();
            checkBoxC.Text = dt2.Rows[0]["cevapc"].ToString();
            checkBoxD.Text = dt2.Rows[0]["cevapd"].ToString();
            checkBoxE.Text = dt2.Rows[0]["cevape"].ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlsorular = new SqlCommand("SELECT * from soru_bilgileri where hocakodu = @hocakodu", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);
            sqlsorular.Parameters.AddWithValue("@hocakodu", aktifkullanici.aktifkullanici_ogrkod);

            SqlDataAdapter da2 = new SqlDataAdapter(sqlsorular);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            int ciguli = Convert.ToInt32(dt2.Compute("max([sorusayisi])", string.Empty));
            
            if (comboBox1.SelectedIndex > ciguli)
            {
                MessageBox.Show($@"Hocanızın yüklediği en son sorunun numarası {ciguli} lütfen daha sonrasını seçmeyiniz.");
            }
            else
            {
                yenile();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrencianaekran yeniforma = new ogrencianaekran();
            yeniforma.Show();
            this.Hide();
        }

        private void buttoncevabıonayla_Click(object sender, EventArgs e)
        {
            SqlCommand sqlsorular = new SqlCommand("SELECT * from soru_bilgileri where hocakodu = @hocakodu", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);
            sqlsorular.Parameters.AddWithValue("@hocakodu", aktifkullanici.aktifkullanici_ogrkod);

            SqlDataAdapter da2 = new SqlDataAdapter(sqlsorular);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);

            MessageBox.Show(dt2.Rows[0]["dogrucevap"].ToString());
            if ((checkBoxA.Checked == true) && (dt2.Rows[0]["dogrucevap"].ToString() == "1"))
            {
                MessageBox.Show("DOĞRU BİLDİN HELAL BÖYLE DEVAM");
            }
            else if ((checkBoxB.Checked == true) && (dt2.Rows[0]["dogrucevap"].ToString() == "2"))
            {
                MessageBox.Show("DOĞRU BİLDİN HELAL BÖYLE DEVAM");
            }
            else if ((checkBoxC.Checked == true) && (dt2.Rows[0]["dogrucevap"].ToString() == "3"))
            {
                MessageBox.Show("DOĞRU BİLDİN HELAL BÖYLE DEVAM");
            }
            else if ((checkBoxD.Checked == true) && (dt2.Rows[0]["dogrucevap"].ToString() == "4"))
            {
                MessageBox.Show("DOĞRU BİLDİN HELAL BÖYLE DEVAM");
            }
            else if ((checkBoxE.Checked == true) && (dt2.Rows[0]["dogrucevap"].ToString() == "5"))
            {
                MessageBox.Show("DOĞRU BİLDİN HELAL BÖYLE DEVAM");
            }
            else
            {
                MessageBox.Show("Yanlış bildin daha dikkatli olmalısın.");
            }
        }
    }
}
