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
    class Kullanici_ogrenci
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string ogretmenkod { get; set; }

        public Kullanici_ogrenci()
        {
        }
        public Kullanici_ogrenci(string gisim, string gsoyisim, string gkullaniciadi, string gsifre, string gemail ,string gogretmenkod)
        {
            isim = gisim;
            soyisim = gsoyisim;
            kullaniciadi = gkullaniciadi;
            sifre = gsifre;
            email = gemail;
            ogretmenkod = gogretmenkod;

            Random rnd = new Random();
            int RastgeleSayi1 = rnd.Next(1, 9);
            int RastgeleSayi2 = rnd.Next(1, 9);
            int RastgeleSayi3 = rnd.Next(1, 9);
            int RastgeleSayi4 = rnd.Next(1, 9);
            int RastgeleSayi5 = rnd.Next(1, 9);

            string hatırlatmakodu = RastgeleSayi1.ToString() + RastgeleSayi2.ToString() + RastgeleSayi3.ToString() + RastgeleSayi4.ToString() + RastgeleSayi5.ToString();
            Convert.ToInt32(hatırlatmakodu);
            
            SqlCommand sqlkayitolma = new SqlCommand("Insert into ogrenci_bilgileri (isim,soyisim,kullaniciadi,sifre,email,ogretmenkodu,hatırlatma) values (@isim,@soyisim,@kullaniciadi,@sifre,@email,@ogretmenkod,@hatırlatma)", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlkayitolma.Parameters.AddWithValue("@isim", isim);
            sqlkayitolma.Parameters.AddWithValue("@soyisim", soyisim);
            sqlkayitolma.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            sqlkayitolma.Parameters.AddWithValue("@sifre", sifre);
            sqlkayitolma.Parameters.AddWithValue("@email", email);
            sqlkayitolma.Parameters.AddWithValue("@ogretmenkod", ogretmenkod);
            sqlkayitolma.Parameters.AddWithValue("@hatırlatma", hatırlatmakodu);

            sqlkayitolma.ExecuteNonQuery();
    }
        
    }

    class Kullanici_ogretmen
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string ogretmenkod { get; set; }

        public Kullanici_ogretmen()
        {
        }
        public Kullanici_ogretmen(string gisim, string gsoyisim, string gkullaniciadi, string gsifre, string gemail)
        {
            isim = gisim;
            soyisim = gsoyisim;
            kullaniciadi = gkullaniciadi;
            sifre = gsifre;
            email = gemail;

            Random rnd = new Random();
            int RastgeleSayi1 = rnd.Next(1, 9);
            int RastgeleSayi2 = rnd.Next(1, 9);
            int RastgeleSayi3 = rnd.Next(1, 9);
            int RastgeleSayi4 = rnd.Next(1, 9);
            int RastgeleSayi5 = rnd.Next(1, 9);

            string hatırlatmakodu = RastgeleSayi1.ToString() + RastgeleSayi2.ToString() + RastgeleSayi3.ToString() + RastgeleSayi4.ToString() + RastgeleSayi5.ToString();
            Convert.ToInt32(hatırlatmakodu);

            SqlCommand sqlkayitolma = new SqlCommand("Insert into ogretmen_bilgileri (isim,soyisim,kullaniciadi,sifre,email,hatırlatma) values (@isim,@soyisim,@kullaniciadi,@sifre,@email,@hatırlatma)", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlkayitolma.Parameters.AddWithValue("@isim", isim);
            sqlkayitolma.Parameters.AddWithValue("@soyisim", soyisim);
            sqlkayitolma.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            sqlkayitolma.Parameters.AddWithValue("@sifre", sifre);
            sqlkayitolma.Parameters.AddWithValue("@email", email);
            sqlkayitolma.Parameters.AddWithValue("@hatırlatma", hatırlatmakodu);

            sqlkayitolma.ExecuteNonQuery();
        }

    }

    public class aktifkullanici
    {
        public static string aktifkullanici_isim = null;
        public static string aktifkullanici_soyisim = null;
        public static string aktifkullanici_kullaniciadi = null;
        public static string aktifkullanici_sifre = null;
        public static string aktifkullanici_email = null;
        public static string aktifkullanici_ogrkod = null;
    }

    public class sorudogrumu
    {
        public static int soru1 = 0;
        public static int soru2 = 0;
        public static int soru3 = 0;
        public static int soru4 = 0;
        public static int soru5 = 0;
        public static int soru6 = 0;
        public static int soru7 = 0;
        public static int soru8 = 0;
        public static int soru9 = 0;
        public static int soru10 = 0;
        public static int soru11 = 0;
        public static int soru12 = 0;
        public static int soru13 = 0;
        public static int soru14 = 0;
        public static int soru15 = 0;
        public static int soru16 = 0;
        public static int soru17 = 0;
        public static int soru18 = 0;
        public static int soru19 = 0;
        public static int soru20 = 0;
        public static int soru21 = 0;
        public static int soru22 = 0;
        public static int soru23 = 0;
        public static int soru24 = 0;
        public static int soru25 = 0;
        public static int soru26 = 0;
        public static int soru27 = 0;
        public static int soru28 = 0;
        public static int soru29 = 0;
        public static int soru30 = 0;
        public static int soru31 = 0;
        public static int soru32 = 0;
        public static int soru33 = 0;
        public static int soru34 = 0;
        public static int soru35 = 0;
        public static int soru36 = 0;
        public static int soru37 = 0;
        public static int soru38 = 0;
        public static int soru39 = 0;
        public static int soru40 = 0;
        public static int soru41 = 0;
        public static int soru42 = 0;
        public static int soru43 = 0;
        public static int soru44 = 0;
        public static int soru45 = 0;
        public static int soru46 = 0;
        public static int soru47 = 0;
        public static int soru48 = 0;
        public static int soru49 = 0;
        public static int soru50 = 0;
        public static int soru51 = 0;
        public static int soru52 = 0;
        public static int soru53 = 0;
        public static int soru54 = 0;
        public static int soru55 = 0;
        public static int soru56 = 0;
        public static int soru57 = 0;
        public static int soru58 = 0;
        public static int soru59 = 0;
        public static int soru60 = 0;
        public static int soru61 = 0;
        public static int soru62 = 0;
        public static int soru63 = 0;
        public static int soru64 = 0;
        public static int soru65 = 0;
        public static int soru66 = 0;
        public static int soru67 = 0;
        public static int soru68 = 0;
        public static int soru69 = 0;
        public static int soru70 = 0;
        public static int soru71 = 0;
        public static int soru72 = 0;
        public static int soru73 = 0;
        public static int soru74 = 0;
        public static int soru75 = 0;
        public static int soru76 = 0;
        public static int soru77 = 0;
        public static int soru78 = 0;
        public static int soru79 = 0;
        public static int soru80 = 0;
        public static int soru81 = 0;
        public static int soru82 = 0;
        public static int soru83 = 0;
        public static int soru84 = 0;
        public static int soru85 = 0;
        public static int soru86 = 0;
        public static int soru87 = 0;
        public static int soru88 = 0;
        public static int soru89 = 0;
        public static int soru90 = 0;
        public static int soru91 = 0;
        public static int soru92 = 0;
        public static int soru93 = 0;
        public static int soru94 = 0;
        public static int soru95 = 0;
        public static int soru96 = 0;
        public static int soru97 = 0;
        public static int soru98 = 0;
        public static int soru99 = 0;
        public static int soru100 = 0;
    }


}


