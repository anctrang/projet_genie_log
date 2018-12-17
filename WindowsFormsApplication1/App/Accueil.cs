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
using System.Diagnostics;
using System.IO;

namespace App
{
    /// <summary>
    /// Classe permettant de contrôler la page d'accueil
    /// </summary>
    public partial class Accueil : Form
    {
        // Variable contenant l'identifiant de la personne identifiée
        public static string identifiantEnregistre = "";
        // Liste des utilisateurs en bdd
        UtilisateurRepository utilisateurRepository = new UtilisateurRepository();
        // Liste des courses en bdd
        CourseRepository courseRepository = new CourseRepository();
        // Liste des résultats en bdd
        ResultatRepository resultatRepository = new ResultatRepository();
        // Liste des coureurs en bdd
        CoureurRepository coureurRepository = new CoureurRepository();


        /// <summary>
        /// Constructeur de la page d'accueil
        /// </summary>
        /// <param name="utilisateurRepository"></param>
        /// <param name="courseRepository"></param>
        /// <param name="resultatRepository"></param>
        /// <param name="coureurRepository"></param>
        public Accueil(UtilisateurRepository utilisateurRepository, CourseRepository courseRepository, ResultatRepository resultatRepository, CoureurRepository coureurRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            this.courseRepository = courseRepository;
            this.resultatRepository = resultatRepository;
            this.coureurRepository = coureurRepository;

            // Changements des états des boutons car non connecté
            this.buttonAjouterCourse.Visible = false;
            this.buttonAjouterCourse.Enabled = false;
            this.buttonImportCoureurs.Visible = false;
            this.buttonImportCoureurs.Enabled = false;
            this.buttonNouveauCoureur.Visible = false;
            this.buttonNouveauCoureur.Enabled = false;
            this.buttonModifierCourse.Visible = false;
            this.buttonModifierCourse.Enabled = false;
            this.buttonImportResultats.Visible = false;
            this.buttonImportResultats.Enabled = false;

            // Remplit les dataGridViews
            AfficherContenu();
        }

        /// <summary>
        /// Fonction permettant de remplir les datagridview de la page d'accueil
        /// </summary>
        public void AfficherContenu()
        {

            // Pour chaque coureur en bdd
            foreach (Coureur coureur in this.coureurRepository.GetAll())
            {
                // On rempli le datagridview
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, coureur.DateDeNaissance.ToString() };
                dataGridViewCoureurs.Rows.Add(resultat);
            }

            // Pour chaque course
            foreach (Course course in this.courseRepository.GetAll())
            {
                // On remplit le datagridview
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(), Convert.ToString(resultatRepository.ListeResultatsCourse(course.Id).Count) };
                dataGridViewCourses.Rows.Add(resultat);
            }
        }

        /// <summary>
        /// Classe permettant de lancer la page de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            Connexion connexion = new Connexion(ref this.buttonLogin, ref this.buttonSignUp, ref buttonDeconnexion, ref buttonAjouterCourse, ref buttonNouveauCoureur,
                ref buttonImportCoureurs, ref buttonImportResultats, ref buttonModifierCourse);
            connexion.Show();


        }

        /// <summary>
        /// Gestion de la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription(ref this.buttonLogin, ref this.buttonSignUp, ref buttonDeconnexion, ref buttonAjouterCourse, ref buttonNouveauCoureur,
                ref buttonImportCoureurs, ref buttonImportResultats, ref buttonModifierCourse);
            inscription.Show();
        }

        /// <summary>
        /// Gestion du bouton deconnexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            // On change la valeur de la variable globale définissant le statut de la connexion
            Accueil.identifiantEnregistre = "";
            MessageBox.Show("Deconnexion reussie !");

            // Gestion de visibilité des boutons
            this.buttonAjouterCourse.Visible = false;
            this.buttonAjouterCourse.Enabled = false;
            this.buttonImportCoureurs.Visible = false;
            this.buttonImportCoureurs.Enabled = false;
            this.buttonNouveauCoureur.Visible = false;
            this.buttonNouveauCoureur.Enabled = false;
            this.buttonModifierCourse.Visible = false;
            this.buttonModifierCourse.Enabled = false;
            this.buttonImportResultats.Visible = false;
            this.buttonImportResultats.Enabled = false;
            this.buttonSignUp.Visible = true;
            this.buttonSignUp.Visible = true;
            this.buttonDeconnexion.Visible = false;
            this.buttonDeconnexion.Enabled = false;
            this.buttonLogin.Visible = true;
            this.buttonLogin.Enabled = true;
        }

      /// <summary>
      /// Fonction permettant de lancer la page d'ajout de course
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void buttonAjouterCourse_Click(object sender, EventArgs e)
        {
            NouvelleCourse nouvelleCourse = new NouvelleCourse(ref this.dataGridViewCourses);
            nouvelleCourse.Show();
        }

        /// <summary>
        ///  Classe permettant de lancer la page de modification de course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierCourse_Click(object sender, EventArgs e)
        {
            // Si aucune course n'a été sélectionnée dans le dataGridView
            if (this.dataGridViewCourses.SelectedRows.Count == 0)
                MessageBox.Show("Veuillez sélectionner une course");
            else
            {
                NouvelleCourse nouvelleCourse = new NouvelleCourse(ref this.dataGridViewCourses, this.dataGridViewCourses.SelectedRows);
                nouvelleCourse.Show();
            }
        }

        /// <summary>
        /// Classe permettant de lancer la page de résultats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            // Si aucune course et aucun coureur n'ont été séléctionnés
            if (this.dataGridViewCourses.SelectedRows.Count == 0 && this.dataGridViewCoureurs.SelectedRows.Count == 0)
                MessageBox.Show("Veuillez sélectionner une course ou un coureur");
            else
            {
                // Si on est dans l'onglet Courses
                if (this.TabCoureurs.SelectedIndex == 0)
                {
                    //Stockage de la ligne sélectionnée
                    DataGridViewRow ligneSelectionnee = this.dataGridViewCourses.SelectedRows[0];
                    //Récupération de l'id de la course sélectionnée
                    int id = Convert.ToInt32(ligneSelectionnee.Cells[0].Value);
                    //Lancement de la page résultat
                    InformationsCourse informationsCourse = new InformationsCourse(id);
                    informationsCourse.Show();

                }
                else
                {
                    // Récupération de la ligne sélectionnée
                    DataGridViewRow ligneSelectionnee = this.dataGridViewCoureurs.SelectedRows[0];
                    // Récupération de l'id du coureur
                    int id = Convert.ToInt32(ligneSelectionnee.Cells[0].Value);
                    // Lancement de la page de résultat
                    InformationsCoureurs informationsCoureur = new InformationsCoureurs(id);
                    informationsCoureur.Show();
                }
            }
        }
        
        /// <summary>
        /// Gestion du bouton de fermeture de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fonction permettant de lancer la page de nouveaux coureurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNouveauCoureur_Click(object sender, EventArgs e)
        {
            NouveauCoureur n = new NouveauCoureur(ref this.dataGridViewCoureurs);
            n.Show();
        }

        /// <summary>
        /// Fonction permettant de gérer la recherche d'un résultat sur la page d'accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool existe = false;
            // Pour chaque coureur en bdd
            foreach (Coureur coureur in coureurRepository.GetAll())
            {
                // On vérifie si le coureur existe bien
                if (coureur.NumLicence == int.Parse(this.textBoxNumLicence.Text))
                {
                    existe = true;
                }
            }

            //Si oui
            if (existe)
            {
                // On lance la page d'informations
                InformationsCoureurs i = new InformationsCoureurs(Convert.ToInt32(this.textBoxNumLicence.Text));
                i.Show();
                this.Close();
            }

        }

        /// <summary>
        /// Fonction permettant de traduire une ligne CSV en un coureur et le renvoyer
        /// </summary>
        /// <param name="csvLine"></param>
        /// <returns></returns>
        public static Coureur CoureursFromCsv(string csvLine)
        {
            //Séparateur
            string[] values = csvLine.Split(';');
            Coureur coureur = new Coureur();
            coureur.Nom = values[0];
            coureur.Prenom = values[1];
            coureur.DateDeNaissance = DateTime.Parse(values[2]);
            coureur.Courriel = values[3];

            return coureur;
        }

        /// <summary>
        /// Fonction permettant de transformer une ligne CSV en un résultat et le renvoyer
        /// </summary>
        /// <param name="csvLine"></param>
        /// <returns></returns>
        public Resultat ResultatFromCsv(string csvLine)
        {
            // Séparateur

            string[] values = csvLine.Split(';');
            Resultat resultat = new Resultat();
            resultat.Temps = TimeSpan.Parse(values[0]);
            resultat.NumDossard = Convert.ToInt32(values[1]);
            resultat.LaCourse = courseRepository.GetCourse(Convert.ToInt32(values[2]));
            resultat.LeCoureur = coureurRepository.ListeCoureur(Convert.ToInt32(values[3]))[0];

            return resultat;
        }
                     
        /// <summary>
        /// Fonction permettant de gérer l'import CSV de coureurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImportCoureurs_Click(object sender, EventArgs e)
        {
            string sourceFolder = "";
            //Explorateur de fichier
            OpenFileDialog ofd = new OpenFileDialog();
            string strfilename = "";

            //Si l'explorateur est bien ouvert
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = ofd.FileName;
                sourceFolder = "C:\\";
                // On récupère le chemin 
                strfilename = ofd.InitialDirectory + ofd.FileName;
            }

            // On construit la liste des coureurs à partir du CSV
            List<Coureur> values = File.ReadAllLines(strfilename)
                                           .Skip(1)
                                           .Select(v => CoureursFromCsv(v))
                                           .ToList();
            // On sauvegarde chaque coureurs de la liste et on remplit le dataGridView
            foreach (Coureur coureur in values)
            {
                coureurRepository.Save(coureur);
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, coureur.DateDeNaissance.ToString() };
                dataGridViewCoureurs.Rows.Add(resultat);
            }
        }

        /// <summary>
        /// Fonction permettant de gérer l'importation des résultats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImportResultats_Click(object sender, EventArgs e)
        {
            //Pareil que pour l'importation des coureurs

            string sourceFolder = "";
            OpenFileDialog ofd = new OpenFileDialog();    
            string strfilename = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = ofd.FileName;
                sourceFolder = "C:\\";
                strfilename = ofd.InitialDirectory + ofd.FileName;
            }
            bool existant = false;
            List<Resultat> values = File.ReadAllLines(strfilename)
                                           .Skip(1)
                                           .Select(v => ResultatFromCsv(v))
                                           .ToList();

            foreach (Resultat resultat in values)
            {
                if (courseRepository.GetListCourse(resultat.LaCourse.Id).Count != 0 && coureurRepository.ListeCoureur(resultat.LeCoureur.NumLicence).Count != 0)
                {
                    if (resultatRepository.listeResultat(resultat.LaCourse.Id, resultat.LeCoureur.NumLicence).Count == 0)
                    {
                        resultat.TempsEnSecondes = resultat.CalculTempsEnSeconde(resultat.Temps);
                        resultat.AllureMoyenne = resultat.CalculAllureMoyenne(resultat.LaCourse.Distance);
                        resultat.VitesseMoyenne = resultat.CalculVitesseMoyenne(resultat.LaCourse.Distance);
                        resultatRepository.Save(resultat);
                    }
                    else
                        existant = true;
                }
                else
                    existant = true;

                if (!existant)
                {
                    MessageBox.Show("Résultat(s) ajouté(s) avec succès !");
                }
                else
                    MessageBox.Show("Un ou plusieurs résultats n'ont pas pu être ajoutés, vérifiez vos fichier CSV");

            }
        }
    }
}
