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
    public partial class FrmAracListeleme : Form
    {
        public FrmAracListeleme()
        {
            InitializeComponent();
        }
        Arac_Kiralama arc = new Arac_Kiralama();
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            TxtPlaka.Text = satir.Cells["plaka"].Value.ToString();
            CmbMarka.Text = satir.Cells["marka"].Value.ToString();   //Datagritte iki kere tıkladığımızda textbox ve comboboxa verileri yazdırma
            CmbSeri.Text = satir.Cells["seri"].Value.ToString();
            TxtYil.Text = satir.Cells["yil"].Value.ToString();
            TxtRenk.Text = satir.Cells["renk"].Value.ToString();
            TxtKM.Text = satir.Cells["km"].Value.ToString();
            CmbYakit.Text = satir.Cells["yakit"].Value.ToString();
            TxtKiraUcreti.Text = satir.Cells["kiraucreti"].Value.ToString();
        }

        private void FrmAracListeleme_Load(object sender, EventArgs e)
        {
            YenileAraclarListesi();
            CmbAraclar.SelectedIndex = 0;
        }

        private void YenileAraclarListesi()
        {
            string cumle = "select * from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arc.listele(adtr2, cumle);
        }

     

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update arac set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            komut2.Parameters.AddWithValue("@marka", CmbMarka.Text);
            komut2.Parameters.AddWithValue("@seri", CmbSeri.Text);         //Güncelleme komutu
            komut2.Parameters.AddWithValue("@yil", TxtYil.Text);
            komut2.Parameters.AddWithValue("@renk", TxtRenk.Text);
            komut2.Parameters.AddWithValue("@km", TxtRenk.Text);
            komut2.Parameters.AddWithValue("@yakit", CmbYakit.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", TxtKiraUcreti.Text);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());  //şu andaki zamanı alır.
            arc.ekle_sil_guncelle(komut2, cumle);
            CmbSeri.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            YenileAraclarListesi();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from arac where plaka ='" + satir.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arc.ekle_sil_guncelle(komut2, cumle);       //silme komutu
            YenileAraclarListesi();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CmbSeri.Items.Clear();
                if (CmbMarka.SelectedIndex == 0)
                {
                    CmbSeri.Items.Add("Astra");
                    CmbSeri.Items.Add("Vectra");
                    CmbSeri.Items.Add("Corsa");
                }
                else if (CmbMarka.SelectedIndex == 1)
                {
                    CmbSeri.Items.Add("Megane");
                    CmbSeri.Items.Add("Clio");
                }
                else if (CmbMarka.SelectedIndex == 2)
                {
                    CmbSeri.Items.Add("Linea");
                    CmbSeri.Items.Add("Egea");
                }
                else if (CmbMarka.SelectedIndex == 3)
                {
                    CmbSeri.Items.Add("Fiesta");
                    CmbSeri.Items.Add("Focus");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (CmbAraclar.SelectedIndex==0)   //her iki durumda da olanları listeleme
                {
                    YenileAraclarListesi();
                }
                if (CmbAraclar.SelectedIndex==1)
                {
                    string cumle = "select * from arac where durumu='BOS'";  //Durumu boş olanları listeleme
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arc.listele(adtr2, cumle);
                }
                if (CmbAraclar.SelectedIndex == 2)
                {
                    string cumle = "select * from arac where durumu='DOLU'"; //durumu dolu olanları listeleme
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arc.listele(adtr2, cumle);
                }
           
        }
    }
}
