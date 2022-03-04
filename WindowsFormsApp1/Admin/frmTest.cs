﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();

        }

        private void btnTekmiCiftmi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                label1.Text = "çift";

            }
            else
            {
                label1.Text = "Tek";
            }
        }

        private void btnBasamak_Click(object sender, EventArgs e)
        {
            int birler, onlar, yuzler, sayi, toplam;
            sayi = Convert.ToInt32(textBox1.Text);
            birler = sayi % 10;
            yuzler = sayi / 100;
            onlar = (sayi / 10) % 10;
            toplam = birler + onlar + yuzler;
            label1.Text = toplam.ToString();



        }

        private void btnBakteri_Click(object sender, EventArgs e)
        {

        }
    }
}
