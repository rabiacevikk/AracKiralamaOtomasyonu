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

namespace AracKiralamaOtomasyonu
{
    public partial class FrmSozlesme : Form
    {
        public FrmSozlesme()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();
        private void FrmSozlesme_Load(object sender, EventArgs e)
        {
            BosAraclar();
        }

        private void BosAraclar()
        {
            string sorgu2 = "select * from arac where durumu='BOŞ'";
            arac.Bos_Araclar(CmbAraclar, sorgu2);   
            Yenile();
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sozlesme"; 
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {
            if (TxtTC.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            string sorgu2 = "select * from musteri where tc like'" + TxtTC.Text + "'";
            arac.TC_Ara(TxtTCAra,TxtTC, TxtAdSoyad, TxtTelefon, sorgu2);
        }

        private void CmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where plaka like '" + CmbAraclar.SelectedItem + "'";
            arac.CombodanGetir(CmbAraclar, TxtMarka, TxtSeri, TxtModelYil, TxtRenk, sorgu);
        }

        private void CmbKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select* from arac where plaka like'" + CmbAraclar.SelectedItem + "'";
            arac.Ucret_Hesapla(CmbKiraSekli, TxtKiraUcreti, sorgu2);
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(datedonus.Text) - DateTime.Parse(datecikis.Text);
            int gun2 = gun.Days;                                      //Kiralanan günü ve tutarı hesaplama
            TxtGun.Text = gun2.ToString();
            TxtTutar.Text = (gun2 * int.Parse(TxtKiraUcreti.Text)).ToString();
        }


        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            datecikis.Text = DateTime.Now.ToShortDateString();
            datedonus.Text = DateTime.Now.ToShortDateString();
            CmbKiraSekli.Text = "";                       //İTemleri temizleme
            TxtKiraUcreti.Text = "";
            TxtGun.Text = "";
            TxtTutar.Text = "";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sozlesme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih)values (@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", TxtTC.Text);          //Butona tıklandığında sözleşme bilgileri ekleme
            komut2.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", TxtEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@e_tarih", TxtEhliyetTarihi.Text);
            komut2.Parameters.AddWithValue("@e_yer", TxtEverildiğiYer.Text);
            komut2.Parameters.AddWithValue("@plaka", CmbAraclar.Text);
            komut2.Parameters.AddWithValue("@marka", TxtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", TxtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", TxtModelYil.Text);
            komut2.Parameters.AddWithValue("@renk", TxtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", CmbKiraSekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(TxtKiraUcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(TxtGun.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", datecikis.Text);
            komut2.Parameters.AddWithValue("@dtarih", datedonus.Text);
            arac.ekle_sil_guncelle(komut2, sorgu2);


            string sorgu3="update arac set durumu='DOLU' where plaka='"+CmbAraclar.Text+"'";
            SqlCommand komut3 = new SqlCommand();
            arac.ekle_sil_guncelle(komut3, sorgu3);            //Sözleşme yapılınca durumu dolu olarak güncelliyoruz
            CmbAraclar.Items.Clear();
            BosAraclar();
            Yenile();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                   item.Text="";
                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            CmbAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme eklendi.");
        }

        private void TxtTCAra_TextChanged(object sender, EventArgs e)
        {
            if (TxtTCAra.Text=="")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";  
                        string sorgu2 = "select * from musteri where tc like'" + TxtTCAra.Text + "'";
                        arac.TC_Ara(TxtTCAra, TxtTC, TxtAdSoyad, TxtTelefon, sorgu2);
                    }
                }
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sozlesme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,e_yer=e_yer,plaka=@plaka,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kirasekli=@kirasekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", TxtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", TxtEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@e_tarih", TxtEhliyetTarihi.Text);
            komut2.Parameters.AddWithValue("@e_yer", TxtEverildiğiYer.Text);
            komut2.Parameters.AddWithValue("@plaka", CmbAraclar.Text);
            komut2.Parameters.AddWithValue("@marka", TxtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", TxtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", TxtSeri.Text);
            komut2.Parameters.AddWithValue("@renk", TxtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", CmbKiraSekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", TxtKiraUcreti.Text);
            komut2.Parameters.AddWithValue("@gun", TxtGun.Text);
            komut2.Parameters.AddWithValue("@tutar", TxtTutar.Text);
            komut2.Parameters.AddWithValue("@ctarih", datecikis.Text);
            komut2.Parameters.AddWithValue("@dtarih", datedonus.Text);
            arac.ekle_sil_guncelle(komut2, sorgu2);
            CmbAraclar.Items.Clear();
            BosAraclar();
            Yenile();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            CmbAraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme güncellendi.");




        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            TxtTC.Text = satir.Cells[0].Value.ToString();
            TxtAdSoyad.Text = satir.Cells[1].Value.ToString();
            TxtTelefon.Text = satir.Cells[2].Value.ToString();
            TxtEhliyetNo.Text = satir.Cells[3].Value.ToString();
            TxtEhliyetTarihi.Text = satir.Cells[4].Value.ToString();
            TxtEverildiğiYer.Text = satir.Cells[5].Value.ToString();
            CmbAraclar.Text = satir.Cells[6].Value.ToString();
            TxtMarka.Text = satir.Cells[7].Value.ToString();
            TxtSeri.Text = satir.Cells[8].Value.ToString();
            TxtModelYil.Text = satir.Cells[9].Value.ToString();
            TxtRenk.Text = satir.Cells[10].Value.ToString();
            CmbKiraSekli.Text = satir.Cells[11].Value.ToString();
            TxtKiraUcreti.Text = satir.Cells[12].Value.ToString();
            TxtGun.Text = satir.Cells[13].Value.ToString();
            TxtTutar.Text = satir.Cells[14].Value.ToString();
            datecikis.Text = satir.Cells[15].Value.ToString();
            datedonus.Text = satir.Cells[16].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            //Gün Farkı hesaplama
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satir.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarki = bugun - donus;
            int gunFarki = gunfarki.Days;//sayısala çevirdik
            int ucretfarki;
            //Ücret Farkı hesaplama
            ucretfarki = gunFarki * ucret;
            TxtAlacakVerecekDurumu.Text = ucretfarki.ToString();
            //Toplam tutar hesaplama
        }

        private void BtnAracTeslim_Click(object sender, EventArgs e)
        {
            if(int.Parse(TxtAlacakVerecekDurumu.Text) >= 0 || int.Parse(TxtAlacakVerecekDurumu.Text) < 0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(satir.Cells["dtarih"].Value.ToString());
                int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satir.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satir.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                ///Toplam tutar,_gun ve ucret satıs tablosuna aktarılacak
                string sorgu1 = "delete from sozlesme where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_guncelle(komut, sorgu1);

                string sorgu2 = "update arac set durumu='BOŞ' where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                arac.ekle_sil_guncelle(komut2, sorgu2);
                string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,seri,yil,renk,gun,fiyat,tutar,tarih1,tarih2)values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@fiyat,@tutar,@tarih1,@tarih2)";
                SqlCommand komut3 = new SqlCommand();
                komut3.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString());
                komut3.Parameters.AddWithValue("@adsoyad", satir.Cells["adsoyad"].Value.ToString());
                komut3.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                komut3.Parameters.AddWithValue("@marka", satir.Cells["marka"].Value.ToString());
                komut3.Parameters.AddWithValue("@seri", satir.Cells["seri"].Value.ToString());
                komut3.Parameters.AddWithValue("@yil", satir.Cells["yil"].Value.ToString());
                komut3.Parameters.AddWithValue("@renk", satir.Cells["renk"].Value.ToString());
                komut3.Parameters.AddWithValue("@gun", _gun);
                komut3.Parameters.AddWithValue("@tutar",toplamtutar);
                komut3.Parameters.AddWithValue("@tarih1", satir.Cells["ctarih"].Value.ToString()); 
                komut3.Parameters.AddWithValue("@tarih2", satir.Cells["dtarih"].Value.ToString());
                komut3.Parameters.AddWithValue("@fiyat", ucret);
                arac.ekle_sil_guncelle(komut3, sorgu3);
                MessageBox.Show("Araç Teslim Edildi.");
                CmbAraclar.Text = "";
                CmbAraclar.Items.Clear();
                BosAraclar();
                Yenile();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                CmbAraclar.Text = "";
                TxtAlacakVerecekDurumu.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı");   
            }
            }

        private void datedonus_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
