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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void btnsignadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminspace f1 = new adminspace();
            f1.Show();
            Administrateur ad = new Administrateur();
            ad.prenom = txtfirstnameadmin.Text;
            ad.nom = txtlastnameadmin.Text;
            ad.login_A = int.Parse(txtloginadmin.Text);
            ad.password_A = txtpassadmin.Text;
            ad.photo_A = "";
            adminspace.DbDataContetxt.Administrateur.InsertOnSubmit(ad);
            adminspace.DbDataContetxt.SubmitChanges();
            MessageBox.Show("Admin has been added");
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
    }
}
