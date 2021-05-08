using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_Notlari_Hesaplama_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String urunadi;
            int urunfiyati, kdv, yenifiyat;
            urunadi = comboBox1.Text;

            if (urunadi == "Muz")
            {
                urunfiyati = 20;
                label8.Text = urunfiyati.ToString();
                urunfiyati = Convert.ToInt16(label8.Text);
                kdv = (urunfiyati * 50) / 100;
                yenifiyat = urunfiyati + kdv;

                listBox1.Items.Add("Ürünün adı : " + urunadi + "   Ürünün Fiyatı : " + urunfiyati + "   %50 KDV'li Fiyatı : " + yenifiyat);
            }
            else if (urunadi == "Çikolata")
            {
                urunfiyati = 5;
                label8.Text = urunfiyati.ToString();
                urunfiyati = Convert.ToInt16(label8.Text);
                kdv = (urunfiyati * 50) / 100;
                yenifiyat = urunfiyati + kdv;

                listBox1.Items.Add("Ürünün adı : " + urunadi + "   Ürünün Fiyatı : " + urunfiyati + "   %50 KDV'li Fiyatı : " + yenifiyat);

            }
            else if (urunadi == "Bilgisayar")
            {
                urunfiyati = 10000;
                label8.Text = urunfiyati.ToString();
                urunfiyati = Convert.ToInt16(label8.Text);
                kdv = (urunfiyati * 50) / 100;
                yenifiyat = urunfiyati + kdv;

                listBox1.Items.Add("Ürünün adı : " + urunadi + "   Ürünün Fiyatı : " + urunfiyati + "   %50 KDV'li Fiyatı : " + yenifiyat);

            }



        }
    }
}
