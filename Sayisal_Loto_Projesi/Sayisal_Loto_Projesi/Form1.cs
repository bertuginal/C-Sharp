using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisal_Loto_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0, i1, i2, i3, i4;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                i1 = Convert.ToInt16(textBox1.Text);
                i2 = Convert.ToInt16(textBox2.Text);
                i3 = Convert.ToInt16(textBox3.Text);
                i4 = Convert.ToInt16(textBox4.Text);

                if (i1 > 0 && i1 < 6 && i2 > 0 && i2 < 6 && i3 > 0 && i3 < 6 && i4 > 0 && i4 < 6)
                {
                    button3.Visible = false;
                    button1.Enabled = true;

                }
                else
                {
                    MessageBox.Show("**Hatalı bir sayı girdiniz. Lütfen 1-5 arasında bir sayı giriniz**", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                    textBox1.Focus();

                }
            }

            catch (Exception)
            {
                
                MessageBox.Show("Yanlış bir şeyler girdiniz. Lütfen 1-5 arasında sayı giriniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.Focus();

            }

                    }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label6.Text = sayac.ToString();
            Random rd = new Random();
            int s1, s2, s3, s4;
            s1 = rd.Next(1, 6);
            s2 = rd.Next(1, 6);
            s3 = rd.Next(1, 6);
            s4 = rd.Next(1, 6);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            //sayı 1
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            //sayı 2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            //sayı 3
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            //sayı 4
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (textBox1.Text == label1.Text && textBox2.Text == label2.Text && textBox3.Text == label3.Text && textBox4.Text == label4.Text)
            {
                timer1.Stop();
                MessageBox.Show("**TEBRİKLER** 4 numarayı da " + sayac + ". sayıda tutturdunuz !!!", "Kazandınız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            button3.Visible = true;
            button1.Enabled = false;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;

            label1.Text = "--";
            label2.Text = "--";
            label3.Text = "--";
            label4.Text = "--";
            sayac = 0;
            label6.Text = 0.ToString();

            textBox1.Focus();
        }
    }
}
