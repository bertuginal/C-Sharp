using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            textBox1.Text = "";
            switch (ay)
            {

                case 1: label2.Text = "Ocak"; break;
                case 2: label2.Text = "Şubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayıs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Ağustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasım"; break;
                case 12: label2.Text = "Aralık"; break;
                default: label2.Text = "Hatalı ay"; break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = comboBox2.Text;
            comboBox2.Text = "";
            switch (mevsim)
            {
                case "Yaz": label9.Text = "Haziran Temmuz Ağustos"; break;
                case "Sonbahar": label9.Text = "Eylül Ekim Kasım"; break;
                case "Kış": label9.Text = "Aralık Ocak Şubat"; break;
                case "İlkbahar": label9.Text = "Mart Nisan Mayıs"; break;
                default:
                    label9.Text = "Hatalı yazı";
                    break;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2, islem, toplam, cıkarma, carpma, bolme;
            string durum = comboBox1.Text;
            s1 = Convert.ToDouble(textBox2.Text);
            s2 = Convert.ToDouble(textBox3.Text);
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            switch (durum)
            {
                case "+": toplam = (s1 + s2); label7.Text = toplam.ToString(); break;
                case "-": cıkarma = (s1 - s2); label7.Text = cıkarma.ToString(); break;
                case "*": carpma = (s1 * s2); label7.Text = carpma.ToString(); break;
                case "/": bolme = (s1 / s2); label7.Text = bolme.ToString("0.000"); break;
                default:
                    break;
            }
            textBox2.Focus();
        }
    }
}
