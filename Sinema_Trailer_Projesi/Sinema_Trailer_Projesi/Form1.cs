using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumPurple;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Bertuğ İNAL tarafından yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxFuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Mad Max:Fury Road";
        }

        private void pSILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "PS:I Love You";
        }
        private void titanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=kVrqfYjkTdQ&t=6s");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Titanic";
        }

        private void korkuSeansı1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E&t=7s");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Korku Seansı 1";
        
        }

        private void korkuSeansı2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XwcxcNkLSGE");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Korku Seansı 2";
        }

        private void korkuSeansı3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=yBQza7CDStM");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Korku Seansı 3";
        }

        private void marvelsTheAvengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=eOrNdBpGMv8");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "The Avengers";
        }

        private void avengersAgeOfUltronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=tmeOjFno6Do");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Avengers: Age Of Ultron";
        }

        private void avengersInfinityWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=6ZfuNTqbHE8");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Avengers: Infinity War";
        }

        private void avengersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=TcMBFSGVi1c");
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Avengers: Endgame";
        }

        
    }
}
