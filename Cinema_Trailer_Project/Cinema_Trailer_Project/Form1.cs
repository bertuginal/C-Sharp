using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Trailer_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumPurple;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Bertuğ İNAL tarafından yapılmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxFuryRoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Mad Max:Fury Road";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8&t=2s");
        }

        private void yesManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Yes Man";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=o-_KBi1dVXw");
        
        }

        private void korkuSeansı1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Korku Seansı 1";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E&t=19s");
        }

        private void korkuSeansı2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Korku Seansı 2";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XwcxcNkLSGE");
        }

        private void korkuSeansı3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Korku Seansı 3";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=yBQza7CDStM");
        }

        private void pSILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "PS: I Love You";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
        }

        private void titanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Titanic";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=kVrqfYjkTdQ&t=6s");
        }

        private void theAvengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "The Avengers";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=eOrNdBpGMv8");
        }

        private void avengersAgeOfUltronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Avengers: Age Of Ultron";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=tmeOjFno6Do");
        }

        private void avengersInfinityWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Avengers: Infinity War";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=6ZfuNTqbHE8");
        }

        private void avengersEndgameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Avengers: Endgame";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=TcMBFSGVi1c");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void sistemdenÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
