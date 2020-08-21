using System;
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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            monitr F1 = new monitr();
            F1.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminspace f1 = new adminspace();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            citizenspace f1 = new citizenspace();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME f1 = new HOME();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign f1 = new sign();
            f1.Show();
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminspace f1 = new adminspace();
            f1.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            langage f1 = new langage();
            f1.Show();
        }
    }
}
