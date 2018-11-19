using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool existe = false;
            Utilisateur utilisateur = new Utilisateur(textBoxId.Text, textBoxMdp.Text);
            UtilisateurRepository uR = new UtilisateurRepository();
            foreach (Utilisateur u in uR.GetAll())
            {
                if(u.Pseudo==utilisateur.Pseudo && u.MotDePasse==utilisateur.MotDePasse)
                {
                    existe = true;
                }
            }

            if (existe)
            {
                MessageBox.Show("Utilisateur déjà existant !");
            }

            else
            {
                uR.Save(utilisateur);
                Program.identifiantEnregistre = utilisateur.Pseudo;
            }
            //uR.Save(utilisateur);
        }
    }
}
