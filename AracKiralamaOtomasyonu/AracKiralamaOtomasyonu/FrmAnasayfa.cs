using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void BtnMusteriEkleme_Click(object sender, EventArgs e)
        {
            FrmMusteriEkleme fr = new FrmMusteriEkleme(); //Formlar arası geçiş
            fr.ShowDialog();
        }

        private void BtnMusteriListeleme_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme fr = new FrmMusteriListeleme();
            fr.ShowDialog();
        }

        private void BtnAracKayit_Click(object sender, EventArgs e)
        {
            FrmAracKayit fr = new FrmAracKayit();
            fr.ShowDialog();
        }

        private void BtnAracListeleme_Click(object sender, EventArgs e)
        {
            FrmAracListeleme fr = new FrmAracListeleme();
            fr.ShowDialog();
        }

        private void BtnSozlesme_Click(object sender, EventArgs e)
        {
            FrmSozlesme fr = new FrmSozlesme();
            fr.ShowDialog();
        }

        private void BtnSatislar_Click(object sender, EventArgs e)
        {
            FrmSatis fr = new FrmSatis();
            fr.ShowDialog();
        }

       
    }
}
