using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2=Convert.ToDouble(txtSayi2.Text);
            string sonuc = (sayi1 + sayi2).ToString();
            MessageBox.Show(sonuc);
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            string sonuc = (sayi1 - sayi2).ToString();
            MessageBox.Show(sonuc);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            string sonuc = (sayi1 * sayi2).ToString();
            MessageBox.Show(sonuc);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            string sonuc = (sayi1 / sayi2).ToString();
            MessageBox.Show(sonuc);
        }
    }
}
