using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace App
{
    public partial class Accueil : Form
    {

        public UtilisateurRepository utilisateurRepository = new UtilisateurRepository();
        //Utilisateur uti = new Utilisateur("abc","abc");
        



        public Accueil(UtilisateurRepository utilisateurRepository)
        {
            InitializeComponent();
            if (Program.identifiantEnregistre != "")
            {
                this.utilisateurRepository = utilisateurRepository;
                this.buttonLogin.Visible = false;
            }
            AfficherContenu();
        }

        private void AfficherContenu()
        {
            foreach(Utilisateur utilisateur in this.utilisateurRepository.GetAll())
            {
                listViewCourse.Items.Add(utilisateur.Pseudo);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion(ref this.buttonLogin, ref this.buttonSignUp, ref this.buttonDeconnexion);
            connexion.Show();
            
            
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Program.identifiantEnregistre = "";
            MessageBox.Show("Deconnexion reussie !");
            this.buttonSignUp.Visible = true;
            this.buttonDeconnexion.Visible = false;
            this.buttonLogin.Visible = true;
        }
    }
}
