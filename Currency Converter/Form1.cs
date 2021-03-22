using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string doConvert(string mataUang, double rupiah = 0)
        {
            double hasil = rupiah;

            if (mataUang == "USD") hasil *= 0.000069375;
            else if (mataUang == "MYR") hasil *= 0.00028528;
            else if (mataUang == "SGD") hasil *= 0.000093196;
            else if (mataUang == "CNY") hasil *= 0.00045158192;
            else if (mataUang == "JPY") hasil *= 0.0075548792;

            return Convert.ToString(hasil);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasil_txt.Text = doConvert(matauang_cmb.Text, Convert.ToDouble(rupiah_inp.Text));
        }
    }
}
