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
    public partial class citizenform : Form
    {
        public citizenform()
        {

            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            this.Hide();
            citizenspace f1 = new citizenspace();
            f1.Show();
            Citoyen c = new Citoyen();
            c.login_C =  int.Parse(txtlog.Text);
            c.password_C = txtpass.Text;
            c.code = int.Parse(txtcode.Text);
            c.nom = txtlastname.Text;
            c.prenom = txtfisrtname.Text;
            c.date_de_naissance = DateTime.Parse(txtbirthdate.Text);
            c.adresse_email = txtemail.Text;
            c.fonction = txtfunction.Text;
            c.photo_C = "";
            adminspace.DbDataContetxt.Citoyen.InsertOnSubmit(c);
            adminspace.DbDataContetxt.SubmitChanges();

            MessageBox.Show("Citizen has been added");



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

        private void image_Click(object sender, EventArgs e)
        {

        }
    }
}
