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
using System.Data.Sql;

namespace AracKiralamaOtomasyonu
{
    public partial class FrmMusteriEkleme : Form
    {
        Arac_Kiralama arc = new Arac_Kiralama();
        public FrmMusteriEkleme()
        {
            InitializeComponent();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into musteri(tc,adsoyad,telefon,adres,email)values(@tc,@adsoyad,@telefon,@adres,@email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", TxtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);  //Ekleme komutu
            komut2.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", TxtAdres.Text);
            komut2.Parameters.AddWithValue("@email", TxtEmail.Text);
            arc.ekle_sil_guncelle(komut2, cumle);
            MessageBox.Show("Kayıt eklendi.");
            foreach(Control item in Controls)
                if (item is TextBox)
                {
                    item.Text = "";
                }
        }

      
    }
}
