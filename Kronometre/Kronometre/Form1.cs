using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0, salise = 0;



        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            label6.Text = salise.ToString();
            if (salise == 60)
            {
                saniye++;
                label1.Text = saniye.ToString();
                salise = 0;
                if (saniye == 60)
                {
                    dakika++;
                    label2.Text = dakika.ToString();
                    label1.Text = 0.ToString();
                    saniye = 0;
                    if (dakika == 60)
                    {
                        saat++;
                        label3.Text = saat.ToString();
                        label2.Text = 0.ToString();
                        dakika = 0;
                        if (saat == 24)
                        {
                            label3.Text = 0.ToString();
                            label2.Text = 0.ToString();
                            label1.Text = 0.ToString();
                            label6.Text = 0.ToString();

                        }

                    }
                }

                {

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            saat = 0;
            dakika = 0;
            saniye = 0;
            salise = 0;
            label6.Text = 0.ToString();
            label3.Text = 0.ToString();
            label2.Text = 0.ToString();
            label1.Text = 0.ToString();

            timer1.Stop();
        }
    }
}
