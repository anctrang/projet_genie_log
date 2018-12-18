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
    /// Classe gérant la page d'information des courses
    /// </summary>
    public partial class InformationsCourse : Form
    {
        // Contient les résultats en bdd
        private ResultatRepository resultatRep = new ResultatRepository();
        // Contient les coureurs en bdd
        private CoureurRepository coureurRep = new CoureurRepository();
        // Contient les courses en bdd
        private CourseRepository courseRep = new CourseRepository();        
        List<Coureur> listeCoureurs = new List<Coureur>();
        List<Resultat> listeResultats = new List<Resultat>();
        Course course = new Course();
        private int idCourseSelectionnee;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        public InformationsCourse(int id)
        {
            InitializeComponent();
            // Récupération de l'id de la course séléctionnée sur la page d'accueil
            this.idCourseSelectionnee = id;           
            course = courseRep.GetCourse(id);
            // Mise à jour des labels selon le contenu de la course sélectionnée
            this.labelDate.Text = course.Date.Day.ToString() + "-" + course.Date.Month.ToString() + "-" + course.Date.Year.ToString() ;
            this.labelLieu.Text = course.Lieu;            
            AfficherContenu();
            //Mise à jour des status des boutons selon le statut de connexion
            if (Accueil.identifiantEnregistre == "")
            {
                this.buttonModifierResultat.Visible = false;
                this.buttonModifierResultat.Enabled = false;
                this.buttonNouveauResultat.Visible = false;
                this.buttonNouveauResultat.Enabled = false;
            }
        }

        /// <summary>
        ///  Fonction gérant les affichages dans la page
        /// </summary>
        public void AfficherContenu()
        {    
            foreach(Resultat resultat in this.resultatRep.ListeResultatsCourse(this.idCourseSelectionnee))
            {
                Coureur coureur = coureurRep.ListeCoureur(resultat.LeCoureur.NumLicence)[0];
                int age = coureur.CalculAge(coureur);
                string[] res = { resultat.Classement.ToString(), resultat.Temps.ToString(), resultat.NumDossard.ToString(), coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, resultat.VitesseMoyenne.ToString(), resultat.AllureMoyenne.ToString(), coureur.Sexe,age.ToString() };
                dataGridView1.Rows.Add(res);
            }                      
        }

        /// <summary>
        /// Fonction permettant d'ouvrir la page d'ajout de résultats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNouveauResultat_Click(object sender, EventArgs e)
        {
            AjoutResultat a = new AjoutResultat(ref this.dataGridView1,true, idCourseSelectionnee);
            a.Show();
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
                ModificationResultat m = new ModificationResultat(ref this.dataGridView1,this.dataGridView1.SelectedRows, true,idCourseSelectionnee);
                m.Show();               
            }
        }

        /// <summary>
        /// Fonction permettant d'afficher les résultats en fonction de l'âge des coureurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
            int ageMin = 0;
            int ageMax = 0;
            // Si les deux textBox sont bien remplis
            if (this.comboBox1.Text!="" && this.comboBox2.Text != "")
            {
                //Pour chaque résultat
                foreach (Resultat resultat in this.resultatRep.ListeResultatsCourse(this.idCourseSelectionnee))
                {
                    Coureur coureur = coureurRep.ListeCoureur(resultat.LeCoureur.NumLicence)[0];
                    int age = coureur.CalculAge(coureur);
                    if (this.comboBox1.SelectedIndex == 0)
                        ageMin = 10;
                    else
                        ageMin = (comboBox1.SelectedIndex + 1) * 10;
                    if (this.comboBox1.SelectedIndex == 0)
                        ageMax = 20;
                    else
                        ageMax = (comboBox2.SelectedIndex + 2) * 10;
                   
                    if (age>=ageMin && age<ageMax)
                    {
                        
                        string[] res = { resultat.Classement.ToString(), resultat.Temps.ToString(), resultat.NumDossard.ToString(), coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, resultat.VitesseMoyenne.ToString(), resultat.AllureMoyenne.ToString(), coureur.Sexe, age.ToString() };
                        dataGridView1.Rows.Add(res);
                    }

                    

                }
            }
        }
        
        /// <summary>
        /// Fonction permettant l'affichage de résultats détaillés en fonction d'un numéro de dossard ou du nom de famille d'un participant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int numDossard;
            string nomFamille="";
            if (this.textBoxDossard.Text == "")
                numDossard = -1;
            else
            {
                // Si le numéro de dossard à été donné, on le sauvegarde dans une variable
                numDossard = Int32.Parse(this.textBoxDossard.Text);
            }
            // sauvegarde du nom de famille spécifié dans le textbox dans une variable
            nomFamille = this.textBoxNom.Text;
            if (numDossard == -1 && nomFamille == "")
            {
                MessageBox.Show("Aucun résultat à afficher !");
            }
            else
            {
                // On donne les résultats détaillés
                ResultatsDetaillesCoureur r = new ResultatsDetaillesCoureur(nomFamille, numDossard, course.Id);
                r.Show();
            }


        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Veuillez sélectionner un résultat");
            else
            {

                DataGridViewRow ligneSelectionnee = this.dataGridView1.SelectedRows[0];
                // Si la page à été lancée à partir de la page d'informations de courses et donc que l'on a l'id de la course dont on veut modifier le resultat

                int idCoureur = Convert.ToInt32(ligneSelectionnee.Cells[3].Value);
                int idCourse = course.Id;
                //Supression du résultat
                resultatRep.Delete(resultatRep.listeResultat(idCourse, idCoureur)[0]);
                List<Resultat> resultatATrier = new List<Resultat>();
                foreach (Resultat resultat1 in resultatRep.ListeResultatsCourse(idCourse))
                {
                    resultatATrier.Add(resultat1);
                }
                int classement = 1;
                List<Resultat> SortedList = resultatATrier.OrderBy(o => o.TempsEnSecondes).ToList();
                foreach (Resultat resultat1 in SortedList)
                {
                    resultat1.Classement = classement;
                    resultatRep.Save(resultat1);
                    classement++;
                }

                this.dataGridView1.Rows.Clear();
                this.dataGridView1.Refresh();
                AfficherContenu();



            }
        }
    }
}
