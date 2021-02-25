using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace AracKiralamaOtomasyonu
{
    class Arac_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-387VI6I\\MSSQLSERVER01;Initial Catalog=Arac_Kiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_guncelle(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti; 
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
        baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Bos_Araclar(ComboBox combo, string sorgu)

        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());  //Comboboxa durumu boş olan plakaları ekleme 
            }
            baglanti.Close();

        }
        public void TC_Ara(TextBox tcara,TextBox tc,TextBox adsoyad,TextBox telefon,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())   //tc girildiğinde dsiğer bilgileri aktarılsın
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

public void satisHesapla(Label lbl)
        {
            baglanti.Open();   //Toplam satışı hesaplama komutu
       SqlCommand komut = new SqlCommand("select sum(tutar) from satis",baglanti);
            lbl.Text = "Toplam Tutar=" + komut.ExecuteScalar() + " TL";
            baglanti.Close();
        }

        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
            }
            baglanti.Close();
        }
            public void Ucret_Hesapla(ComboBox combokirasekli,TextBox ucret,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokirasekli.SelectedIndex == 0)
                {                                   //Kira ücreti günlük haftalık ve aylık farklı hesaplanıyor.
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 3).ToString();
                }
                if (combokirasekli.SelectedIndex == 1)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 2).ToString();
                }
                if (combokirasekli.SelectedIndex == 2)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                }
            }
            baglanti.Close();
        }

    }
}
