﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class espacecitoyen : Form
    {
        public espacecitoyen()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            apropos f1 = new apropos();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MONITOR f1 = new MONITOR();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            accueil f1 = new accueil();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez Vous Vraiement Quitter", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            certificat f1 = new certificat();
            f1.Show();



        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            certificat f1 = new certificat();
            f1.Show();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            certificat f1 = new certificat();
            f1.Show();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            certificat f1 = new certificat();
            f1.Show();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            this.Hide();
            certificat f1 = new certificat();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            langage f1 = new langage();
            f1.Show();
        }
    }
}
