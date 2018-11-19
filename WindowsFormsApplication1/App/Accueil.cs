using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            if (Program.identifiantEnregistre != "")
            {
                this.buttonLogin.Visible = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion(this.buttonLogin);
            connexion.Show();
            
            
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
        }
    }
}
