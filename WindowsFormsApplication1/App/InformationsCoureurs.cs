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
    /// <summary>
    /// Classe gérant la page d'informations des coureurs
    /// </summary>
    public partial class InformationsCoureurs : Form
    {
        // Contient les courses en bdd
        CourseRepository courseRep = new CourseRepository();
        // Contient les coureurs en bdd
        CoureurRepository coureurRep = new CoureurRepository();
        // Contient les résultats en bdd
        ResultatRepository resultatRep = new ResultatRepository();
        Coureur coureur = new Coureur();

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="numLicence"></param>
        public InformationsCoureurs(int numLicence)
        {
            InitializeComponent();
            // Récupération du coureur sélectionné dans le DataGridView de la page d'accueil
            coureur = coureurRep.ListeCoureur(numLicence)[0];
            // Remplisage des différents labels selon les informations contenues dans l'objet coureur
            this.labelNomPrenom.Text = coureur.Nom + " " + coureur.Prenom;
            this.labelNumLicence.Text = Convert.ToString(coureur.NumLicence);
            this.labelSexe.Text = coureur.Sexe;
            int age = coureur.CalculAge(coureur);
            this.labelAge.Text = Convert.ToString(age) + "ans";
            AfficherContenu();
            // Si pas identifié, boutons non visibles
            if (Accueil.identifiantEnregistre == "")
            {
                this.buttonModifierResultat.Visible = false;
                this.buttonModifierResultat.Enabled = false;
                this.buttonNouveauResultat.Visible = false;
                this.buttonNouveauResultat.Enabled = false;
            }
        }

        /// <summary>
        ///  Fonction permettant de gérer  les données affichées dans le gridview
        /// </summary>
        public void AfficherContenu()
        {
            // Pour chaque résultats du coureur sélectionné, on ajoute les données du résultat dans le gridView
            foreach (Resultat resultat in this.resultatRep.ListeResultatsCoureur(coureur.NumLicence))
            {
                Course course = courseRep.GetCourse(resultat.LaCourse.Id);
                string[] res = {course.Id.ToString(),course.Lieu, course.Date.Day.ToString()+"-"+course.Date.Month.ToString()+"-"+course.Date.Year.ToString(),
                     resultat.Classement.ToString(), resultat.NumDossard.ToString(),course.Distance.ToString(), resultat.AllureMoyenne.ToString(),
                    resultat.VitesseMoyenne.ToString(), resultat.Temps.ToString() };
                dataGridView1.Rows.Add(res);

            }

        }

 
        /// <summary>
        /// Fonction de fermeture de page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fonction permettant d'ouvrir la page d'ajout de résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNouveauResultat_Click(object sender, EventArgs e)
        {
            AjoutResultat a = new AjoutResultat(ref this.dataGridView1,false, coureur.NumLicence);
            a.Show();
        }

        /// <summary>
        /// Fonction permettant d'ouvrir la page de modification de résultats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierResultat_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Veuillez sélectionner un résultat");
            else
            {
                ModificationResultat m = new ModificationResultat(ref this.dataGridView1, this.dataGridView1.SelectedRows, false, coureur.NumLicence);
                m.Show();

            }
        }


        /// <summary>
        /// Fonction permettant de gérer ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            foreach (Resultat resultat in this.resultatRep.ListeResultatsCoureur(coureur.NumLicence))
            {
                Course course = courseRep.GetCourse(resultat.LaCourse.Id);
                string[] res = {course.Id.ToString(),course.Lieu, course.Date.Day.ToString()+"-"+course.Date.Month.ToString()+"-"+course.Date.Year.ToString(),
                     resultat.Classement.ToString(), resultat.NumDossard.ToString(),course.Distance.ToString(), resultat.AllureMoyenne.ToString(),
                    resultat.VitesseMoyenne.ToString()};
                dataGridView1.Rows.Add(res);
            }
        }
    }
}
