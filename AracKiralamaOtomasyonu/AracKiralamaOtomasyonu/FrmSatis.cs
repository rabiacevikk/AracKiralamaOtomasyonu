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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        Arac_Kiralama arac = new Arac_Kiralama();
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from satis";  //satışları datagritte getirme,listeleme toplam satış tutarını labela yazdırma 
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu2);
            arac.satisHesapla(label1);
        }
    }
}
