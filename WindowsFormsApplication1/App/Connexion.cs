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
        private Button buttonConnexion;
        private Button buttonInscription;
        private Button buttonDeconnexion;
        private Button buttonAjouterCourse;
        private Button buttonAjouterCoureur;
        private Button buttonImporterCoureur;
        private Button buttonImporterResultats;
        private Button buttonModifierCourse;

        public Connexion(ref Button buttonConnexion, ref Button buttonInscription, ref Button buttonDeconnexion, ref Button buttonAjouterCourse, ref Button buttonAjouterCoureur,
            ref Button buttonImporterCoureur, ref Button buttonImporterResultats, ref Button buttonModifierCourse)
        {
            InitializeComponent();
            this.buttonConnexion = buttonConnexion;
            this.buttonInscription = buttonInscription;
            this.buttonDeconnexion = buttonDeconnexion;
            this.buttonAjouterCourse = buttonAjouterCourse;
            this.buttonAjouterCoureur = buttonAjouterCoureur;
            this.buttonImporterCoureur = buttonImporterCoureur;
            this.buttonImporterResultats = buttonImporterResultats;
            this.buttonModifierCourse = buttonModifierCourse;

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
                Accueil.identifiantEnregistre = textBoxId.Text;                
                MessageBox.Show("Connexion réussie !");
                buttonConnexion.Visible = false;
                buttonConnexion.Enabled = false;
                buttonInscription.Visible = false;
                buttonInscription.Enabled = false;
                buttonDeconnexion.Visible = true;
                buttonDeconnexion.Enabled = true;
                this.buttonAjouterCourse.Visible = true;
                this.buttonAjouterCourse.Enabled = true;
                this.buttonImporterCoureur.Visible = true;
                this.buttonImporterCoureur.Enabled = true;
                this.buttonAjouterCoureur.Visible = true;
                this.buttonAjouterCoureur.Enabled = true;
                this.buttonModifierCourse.Visible = true;
                this.buttonModifierCourse.Enabled = true;
                this.buttonImporterResultats.Visible = true;
                this.buttonImporterResultats.Enabled = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Identifiant incorrect");
            }

            


        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
