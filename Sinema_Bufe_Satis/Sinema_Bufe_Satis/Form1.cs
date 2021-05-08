using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(txtMisir.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            lblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMisir.Text = "";
            txtSu.Text = "";
            txtCay.Text = "";
            txtBilet.Text = "";

            txtMisir.Focus();
        }
    }
}
