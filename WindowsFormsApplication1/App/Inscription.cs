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
    /// <summary>
    ///  Classe gérant la page d'inscription
    /// </summary>
    public partial class Inscription : Form
    {
        // Gestion des boutons en référence
        private Button buttonConnexion;
        private Button buttonInscription;
        private Button buttonDeconnexion;
        private Button buttonAjouterCourse;
        private Button buttonAjouterCoureur;
        private Button buttonImporterCoureur;
        private Button buttonImporterResultats;
        private Button buttonModifierCourse;
        private Button buttonSuppression;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="buttonConnexion"></param>
        /// <param name="buttonInscription"></param>
        /// <param name="buttonDeconnexion"></param>
        /// <param name="buttonAjouterCourse"></param>
        /// <param name="buttonAjouterCoureur"></param>
        /// <param name="buttonImporterCoureur"></param>
        /// <param name="buttonImporterResultats"></param>
        /// <param name="buttonModifierCourse"></param>
        public Inscription(ref Button buttonConnexion, ref Button buttonInscription, ref Button buttonDeconnexion, ref Button buttonAjouterCourse, ref Button buttonAjouterCoureur,
            ref Button buttonImporterCoureur, ref Button buttonImporterResultats, ref Button buttonModifierCourse, ref Button buttonSuppression)
        {
            InitializeComponent();
            //Gestion des boutons en référence
            this.buttonConnexion = buttonConnexion;
            this.buttonInscription = buttonInscription;
            this.buttonDeconnexion = buttonDeconnexion;
            this.buttonAjouterCourse = buttonAjouterCourse;
            this.buttonAjouterCoureur = buttonAjouterCoureur;
            this.buttonImporterCoureur = buttonImporterCoureur;
            this.buttonImporterResultats = buttonImporterResultats;
            this.buttonModifierCourse = buttonModifierCourse;
            this.buttonSuppression = buttonSuppression;
        }

        /// <summary>
        /// Gère la création d'un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool existe = false;

            // Création d'un utilisateur selon les données rentrées dans les 2 textBox
            Utilisateur utilisateur = new Utilisateur(textBoxId.Text, textBoxMdp.Text);
            UtilisateurRepository uR = new UtilisateurRepository();
            foreach (Utilisateur u in uR.GetAll())
            {
                //On vérifie que l'utilisateur existe déjà ou non
                if (u.Pseudo == utilisateur.Pseudo)
                {
                    existe = true;
                }
            }



            
            

            if (existe)
            {
                MessageBox.Show("Utilisateur déjà existant !");
            }
            

            else if (utilisateur.VerificationMotDePasse(this.textBoxMdp.Text) ){
                MessageBox.Show("Mot de passe pas assez sécurisé, il doit comporter au minimum une majuscule, une minuscule, un chiffre, un caractère spécial et doit " +
                    "être composé au minimum de 6 caractères.");
            }

            else
            {
                //S'il n'existe pas, on le créé, on connecte l'utilisateur et on change l'état des boutons de la page d'accueil
                uR.Save(utilisateur);
                Accueil.identifiantEnregistre = utilisateur.Pseudo;
                MessageBox.Show("Inscription réussie !");
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
                this.buttonSuppression.Visible = true;
                this.buttonSuppression.Visible = true;
                this.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
