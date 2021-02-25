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
    public partial class FrmMusteriListeleme : Form
    {
        Arac_Kiralama arck = new Arac_Kiralama();
        public FrmMusteriListeleme()
        {
            InitializeComponent();
        }

        private void FrmMusteriListeleme_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cumle = "Select * from musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arck.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "ADRES";         //listeleme 
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
        }

        private void TxtTCAra_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select* from musteri where tc like'%" + TxtTCAra.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();    //girilen tc yi bulma

            dataGridView1.DataSource = arck.listele(adtr2, cumle);
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            TxtTC.Text = satir.Cells[0].Value.ToString();
            TxtAdSoyad.Text = satir.Cells[1].Value.ToString();    //Datagritte iki kere tıkladığımızda textboxlara yazdırma
            TxtTelefon.Text = satir.Cells[2].Value.ToString();
            TxtAdres.Text = satir.Cells[3].Value.ToString();
            TxtEmail.Text = satir.Cells[4].Value.ToString();

        }

        private void BtnGuncelleme_Click(object sender, EventArgs e)
        {
            string cumle = "update musteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", TxtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);  //Güncelleme komutu 
            komut2.Parameters.AddWithValue("@telefon", TxtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", TxtAdres.Text);
            komut2.Parameters.AddWithValue("@email", TxtEmail.Text);
            arck.ekle_sil_guncelle(komut2, cumle);
            foreach(Control item in Controls)
                if (item is TextBox)
                {
                    item.Text = "";
                }
            YenileListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from musteri where tc='" + satir.Cells["tc"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arck.ekle_sil_guncelle(komut2, cumle);
            foreach(Control item in Controls)       //Silme komutu 
                if (item is TextBox)
                {
                    item.Text = "";  //Textboxları işlemden sonra temizleme
                }
            YenileListele();  //fresh 
        }
    }
}
