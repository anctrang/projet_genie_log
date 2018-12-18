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
    /// Classe gérant la page de connexion
    /// </summary>
    public partial class Connexion : Form
    {
        //Stockage des références des boutons
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
        /// Constructeur de la classe Connexion
        /// </summary>
        /// <param name="buttonConnexion"></param>
        /// <param name="buttonInscription"></param>
        /// <param name="buttonDeconnexion"></param>
        /// <param name="buttonAjouterCourse"></param>
        /// <param name="buttonAjouterCoureur"></param>
        /// <param name="buttonImporterCoureur"></param>
        /// <param name="buttonImporterResultats"></param>
        /// <param name="buttonModifierCourse"></param>
        public Connexion(ref Button buttonConnexion, ref Button buttonInscription, ref Button buttonDeconnexion, ref Button buttonAjouterCourse, ref Button buttonAjouterCoureur,
            ref Button buttonImporterCoureur, ref Button buttonImporterResultats, ref Button buttonModifierCourse, ref Button buttonSuppression)
        {
            InitializeComponent();
            //Stockage des références des boutons
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
        /// Fonction permettant de vérifier si la combinaison Pseudonyme/mot de passe existe
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="mdp"></param>
        /// <param name="ListeUtilisateurs"></param>
        /// <returns></returns>
        public bool VerificationLogin(string identifiant, string mdp, IList<Utilisateur> ListeUtilisateurs)
        {
            bool existe = false;
            foreach (Utilisateur u in ListeUtilisateurs)
            {
                // Si la combinaison existe
                if (u.Pseudo == identifiant && u.MotDePasse == mdp)
                    existe = true;
            }
            
            return existe;
        }

        /// <summary>
        ///  Fonction permettant de gérer la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            UtilisateurRepository Ur = new UtilisateurRepository();
            IList<Utilisateur> listeUtilisateurs = Ur.GetAll();

            bool utilisateurConnu = VerificationLogin(textBoxId.Text, textBoxMdp.Text, listeUtilisateurs);
            if (utilisateurConnu)
            {
                // Mise à jour de la variable global identifiantEnregistre et des visibiltés des boutons
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
                this.buttonSuppression.Visible = true;
                this.buttonSuppression.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Identifiant incorrect");
            }
        }

       /// <summary>
       /// Fonction gérant la fermeture de la page
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
