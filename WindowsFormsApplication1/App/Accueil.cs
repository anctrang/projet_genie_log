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

        UtilisateurRepository utilisateurRepository = new UtilisateurRepository();
        CourseRepository courseRepository = new CourseRepository();
        ResultatRepository resultatRepository = new ResultatRepository();
        CoureurRepository coureurRepository = new CoureurRepository();



        public Accueil(UtilisateurRepository utilisateurRepository, CourseRepository courseRepository, ResultatRepository resultatRepository, CoureurRepository coureurRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            this.courseRepository = courseRepository;
            this.resultatRepository = resultatRepository;
            this.coureurRepository = coureurRepository;

            
                this.buttonAjouterCourse.Visible = false ;
                this.buttonAjouterCourse.Enabled = false ;
                this.buttonImportCoureurs.Visible = false ;
                this.buttonImportCoureurs.Enabled = false ;
                this.buttonNouveauCoureur.Visible = false ;
                this.buttonNouveauCoureur.Enabled = false ;
                this.buttonModifierCourse.Visible = false;
                this.buttonModifierCourse.Enabled = false;
                this.buttonImportResultats.Visible = false;
                this.buttonImportResultats.Enabled = false;
               
            
            AfficherContenu();
        }

        public void AfficherContenu()
        {
            
            foreach (Coureur coureur in this.coureurRepository.GetAll())
            {
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, coureur.DateDeNaissance.ToString() };
                dataGridViewCoureurs.Rows.Add(resultat);
            }

            foreach (Course course in this.courseRepository.GetAll())
            {
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(), Convert.ToString(resultatRepository.ListeResultatsCourse(course.Id).Count) };
                dataGridViewCourses.Rows.Add(resultat);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            Connexion connexion = new Connexion(ref this.buttonLogin, ref this.buttonSignUp, ref buttonDeconnexion,ref buttonAjouterCourse,ref buttonNouveauCoureur, 
                ref buttonImportCoureurs, ref buttonImportResultats, ref buttonModifierCourse);
            connexion.Show();


        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription(ref this.buttonLogin, ref this.buttonSignUp, ref buttonDeconnexion, ref buttonAjouterCourse, ref buttonNouveauCoureur,
                ref buttonImportCoureurs, ref buttonImportResultats, ref buttonModifierCourse);
            inscription.Show();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Accueil.identifiantEnregistre = "";
            MessageBox.Show("Deconnexion reussie !");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAjouterCourse_Click(object sender, EventArgs e)
        {
            NouvelleCourse nouvelleCourse = new NouvelleCourse(ref this.dataGridViewCourses);
            nouvelleCourse.Show();
        }

        private void buttonModifierCourse_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCourses.SelectedRows.Count == 0)
                MessageBox.Show("Veuillez sélectionner une course");
            else
            {
                NouvelleCourse nouvelleCourse = new NouvelleCourse(ref this.dataGridViewCourses, this.dataGridViewCourses.SelectedRows);
                nouvelleCourse.Show();
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewCourses.SelectedRows.Count == 0 && this.dataGridViewCoureurs.SelectedRows.Count == 0)
                MessageBox.Show("Veuillez sélectionner une course ou un coureur");
            else
            {
                if (this.TabCoureurs.SelectedIndex == 0)
                {
                    DataGridViewRow ligneSelectionnee = this.dataGridViewCourses.SelectedRows[0];
                    int id = Convert.ToInt32(ligneSelectionnee.Cells[0].Value);

                    InformationsCourse informationsCourse = new InformationsCourse(id);
                    informationsCourse.Show();

                }
                else

                {

                    DataGridViewRow ligneSelectionnee = this.dataGridViewCoureurs.SelectedRows[0];
                    int id = Convert.ToInt32(ligneSelectionnee.Cells[0].Value);
                    InformationsCoureurs informationsCoureur = new InformationsCoureurs(id);
                    informationsCoureur.Show();
                }

            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNouveauCoureur_Click(object sender, EventArgs e)
        {
            NouveauCoureur n = new NouveauCoureur(ref this.dataGridViewCoureurs);
            n.Show();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool existe = false;
            foreach (Coureur coureur in coureurRepository.GetAll())
            {
                if (coureur.NumLicence == int.Parse(this.textBoxNumLicence.Text))
                {
                    existe = true;
                }
            }

            if (existe)
            {
                InformationsCoureurs i = new InformationsCoureurs(Convert.ToInt32(this.textBoxNumLicence.Text));
                i.Show();
                this.Close();
            }

        }
        public static Coureur CoureursFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            Coureur coureur = new Coureur();
            coureur.Nom = values[0];
            coureur.Prenom = values[1];
            coureur.DateDeNaissance = DateTime.Parse(values[2]);
            coureur.Courriel = values[3];

            return coureur;
        }

        public Resultat ResultatFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            Resultat resultat = new Resultat();
            resultat.Temps = TimeSpan.Parse(values[0]);
            resultat.NumDossard = Convert.ToInt32(values[1]);
            resultat.LaCourse = courseRepository.GetCourse(Convert.ToInt32(values[2]));
            resultat.LeCoureur = coureurRepository.ListeCoureur(Convert.ToInt32(values[3]))[0];

            return resultat;
        }



        private void buttonImportCoureurs_Click(object sender, EventArgs e)
        {
            string sourceFolder = "";
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();


            string strfilename = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = ofd.FileName;
                sourceFolder = "C:\\";
                strfilename = ofd.InitialDirectory + ofd.FileName;
            }
           
            
            List<Coureur> values = File.ReadAllLines(strfilename)
                                           .Skip(1)
                                           .Select(v => CoureursFromCsv(v))
                                           .ToList();
            foreach(Coureur coureur in values)
            {
                coureurRepository.Save(coureur);
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, coureur.DateDeNaissance.ToString() };
                dataGridViewCoureurs.Rows.Add(resultat);
            }
        }

        private void buttonImportResultats_Click(object sender, EventArgs e)
        {

            string sourceFolder = "";
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();


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
