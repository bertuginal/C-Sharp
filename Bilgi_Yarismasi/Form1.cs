using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0,sayac=0;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("**BİLGİ YARIŞMASINA HOŞGELDİNİZ**"+"\n" +
                "Kurallar;"+"\n"+
                "-Sorularımız 3 tanedir." +"\n" +
                "-Sorulara tekrar dönme şansınız yoktur."+
                "\n"+
                "-Toplam süreniz 30 saniyedir."+"\n" +
                "BAŞARILAR DİLERİZ :)");
            btnSonraki.Enabled = true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label6.Text = sayac.ToString();
            if (sayac == 30)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                timer1.Stop();
                pictureBox4.Visible = true;
                MessageBox.Show("**Süreniz Doldu**"+"\n" +
                    "Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
                


            }

        }
        
        private void Sonraki_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnSonraki.Text = "Sonraki";
            btnBilgi.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = false;
            soruno++;
            lblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label2.Text = "1923";
                progressBar1.Value += 33;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label2.Text = "Balıkesir";
                progressBar1.Value += 33;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazarımıza aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri";
                label2.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";
                progressBar1.Value += 34;


            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                lblSoruNo.Text = "3";
                timer1.Stop();
                pictureBox3.Visible = true;
                MessageBox.Show("Doğru : " + dogru + "\n" + "Yanlış : " + yanlis);

            }

        }
        
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnB.Text;
            if (label2.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label2.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;
            if (label2.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnA.Text;
            if (label2.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            
        }
        
       

    }
}
