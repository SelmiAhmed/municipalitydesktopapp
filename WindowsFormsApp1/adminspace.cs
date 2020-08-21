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

    public partial class adminspace : Form
    {
        internal static DataClasses1DataContext DbDataContetxt = new DataClasses1DataContext();

        public adminspace()
        {
            InitializeComponent();
        }
        public adminspace(DataGridView dataGridViewCitizens, DataGridView dataGridViewAdmin)
        {
            this.dataGridViewCitizens = dataGridViewCitizens;
            this.dataGridViewAdmin = dataGridViewAdmin;

            InitializeComponent();
        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            about f1 = new about();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            monitr f1 = new monitr();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME f1 = new HOME();
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

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            langage f1 = new langage();
            f1.Show();
        }

        private void adminspace_Load(object sender, EventArgs e)
        {
            dataGridViewCitizens.DataSource = DbDataContetxt.Citoyen;
            dataGridViewCitizens.DataSource = (from c in DbDataContetxt.Citoyen select c).ToList<Citoyen>();
            dataGridViewAdmin.DataSource = DbDataContetxt.Administrateur;
            dataGridViewAdmin.DataSource = (from ad in DbDataContetxt.Administrateur select ad).ToList<Administrateur>();

        }

   
    }
}
