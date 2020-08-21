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
    public partial class formulairecitoyen : Form
    {
        public formulairecitoyen()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            espacecitoyen f1 = new espacecitoyen();
            f1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez Vous Vraiement Annuler", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void formulairecitoyen_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
