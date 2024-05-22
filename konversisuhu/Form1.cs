using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konversisuhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btHasil_Click(object sender, EventArgs e)
        {
            double Hasil = 0;  
            int Celcius, Farenheit, Reamur;

            if (cbDari.SelectedItem == "Celcius" && cbKe.SelectedItem == "Fahrenheit")
            {
                Hasil = int.Parse(txNilai.Text) * 1.8 + 32;
                txHasil.Text = Hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Celcius" && cbKe.SelectedItem == "Reamur")
            {
                Hasil = int.Parse(txNilai.Text) * 0.8;
                txHasil.Text = Hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Celcius" && cbKe.SelectedItem == "Celcius")
            {
                Hasil = int.Parse(txNilai.Text) * 1;
                txHasil.Text = Hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Fahrenheit" && cbKe.SelectedItem == "Reamur")
            {
                Hasil = int.Parse(txNilai.Text) -32 * 0.44;
                txHasil.Text = Hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Fahrenheit" && cbKe.SelectedItem == "Celcius")
            {
                Hasil = int.Parse(txNilai.Text) -32 * 0.55;
                txHasil.Text = Hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Fahrenheit" && cbKe.SelectedItem == "Fahrenheit")
            {
                Hasil = int.Parse(txNilai.Text) * 1;
                txHasil.Text = Hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Reamur" && cbKe.SelectedItem == "Celcius")
            {
                Hasil = int.Parse(txNilai.Text) * 1.25;
                txHasil.Text = Hasil.ToString();
            } 
            else if (cbDari.SelectedItem == "Reamur" && cbKe.SelectedItem == "Fahrenheit")
            {
                Hasil = int.Parse(txNilai.Text) * 2.25 + 32;
                txHasil.Text = Hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Reamur" && cbKe.SelectedItem == "Reamur")
            {
                Hasil = int.Parse(txNilai.Text) * 1;
                txHasil.Text = Hasil.ToString();
            }
        }

        private void btBersih_Click(object sender, EventArgs e)
        {
            txHasil.Text = "";
            txNilai.Text = "";
            cbDari.Text = "";
            cbKe.Text = "";         
        }
    }
}
