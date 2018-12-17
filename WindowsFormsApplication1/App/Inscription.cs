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

        private Button buttonConnexion;
        private Button buttonInscription;
        private Button buttonDeconnexion;
        private Button buttonAjouterCourse;
        private Button buttonAjouterCoureur;
        private Button buttonImporterCoureur;
        private Button buttonImporterResultats;
        private Button buttonModifierCourse;

        public Inscription(ref Button buttonConnexion, ref Button buttonInscription, ref Button buttonDeconnexion, ref Button buttonAjouterCourse, ref Button buttonAjouterCoureur,
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
                this.Close();

            }
           
        }
    }
}
