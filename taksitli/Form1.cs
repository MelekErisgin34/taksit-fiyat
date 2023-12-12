using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksitli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {

            double fiyat, taksitSayisi, taksitTutari;
            fiyat = Convert.ToDouble(txtFiyat.Text);
            taksitSayisi = Convert.ToDouble(tbTaksitsayisi.Value);
            taksitTutari = fiyat / taksitSayisi;
            lblTaksittutari.Text = "Taksit Tutarınız: " + taksitTutari;
        }
    }
}
