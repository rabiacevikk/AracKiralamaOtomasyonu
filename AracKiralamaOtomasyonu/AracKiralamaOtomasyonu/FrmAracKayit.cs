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
    public partial class FrmAracKayit : Form
    {
        public FrmAracKayit()
        {
            InitializeComponent();
        }

        Arac_Kiralama arckiralama = new Arac_Kiralama();

      

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CmbSeri.Items.Clear();
                if (CmbMarka.SelectedIndex == 0)           //0.indeksteki markayı seçerse 3 seri, 1.indeksteki markayı seçerse 2 seri...
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
                else if (CmbMarka.SelectedIndex==3)
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

        private void BtnKayit_Click(object sender, EventArgs e)
        {     //kayıt ekleme komutu
            string cumle = "insert into arac(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,tarih,durumu)values (@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@tarih,@durumu)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", CmbMarka.Text);
            komut.Parameters.AddWithValue("@seri", CmbSeri.Text);
            komut.Parameters.AddWithValue("@yil", TxtYil.Text);
            komut.Parameters.AddWithValue("@renk", TxtRenk.Text);
            komut.Parameters.AddWithValue("@km", TxtKM.Text);
            komut.Parameters.AddWithValue("@yakit", CmbYakit.Text);
            komut.Parameters.AddWithValue("@kiraucreti",TxtKiraUcreti.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@durumu", "BOŞ");
            arckiralama.ekle_sil_guncelle(komut, cumle);
            CmbSeri.Items.Clear();       
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    {
                    item.Text= "";             //textbox ve comboboxları temizleme
                }
            else if (item is ComboBox)
            {
                    item.Text = "";
            }
            }
        }


    }
}
