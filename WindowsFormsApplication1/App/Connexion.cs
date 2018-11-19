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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        public bool VerificationLogin(string identifiant, string mdp, IList<Utilisateur> ListeUtilisateurs)
        {

            bool existe = false;

            foreach (Utilisateur u in ListeUtilisateurs)
            {

                if (u.Pseudo == identifiant && u.MotDePasse == mdp)
                    existe = true;

            }
            
            return existe;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            UtilisateurRepository Ur = new UtilisateurRepository();
            IList<Utilisateur> listeUtilisateurs = Ur.GetAll();

            bool utilisateurConnu = VerificationLogin(textBoxId.Text, textBoxMdp.Text, listeUtilisateurs);
            if (utilisateurConnu)
            {
                MessageBox.Show("Connexion réussie !");
                this.Close();
            }

            else
            {
                System.Windows.Forms.MessageBox.Show("Identifiant incorrect");
            }

            
        }


    }
}
