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
    /// Classe permettant de gérer la page d'ajout de résultats
    /// </summary>
    public partial class AjoutResultat : Form
    {
        // Contient les courses en bdd
        CourseRepository courseRep = new CourseRepository();
        // Contient les coureurs en bdd
        CoureurRepository coureurRep = new CoureurRepository();
        // Contient les résultats en bdd
        ResultatRepository resultatRep = new ResultatRepository();
        // Liste contenant les coureurs
        IList<Coureur> listeCoureurs = new List<Coureur>();
        // Liste contenant les coureurs non participants à une course (pour la liste déroulante)
        List<Coureur> listeCoureursNonParticipants = new List<Coureur>();
        List<Course> listeCoursesNonParticipees = new List<Course>();
        IList<Course> listeCourses = new List<Course>();
        Course course = new Course();
        Coureur coureur = new Coureur();
        // Si oui, id de la course dans le constructeur, si non, id du coureur dans le constructeur
        bool courseConnue;
        
        // Permet de gérer la référence du datagridView de la page d'accueil
        DataGridView d = new DataGridView();

        /// <summary>
        /// Constructeur de la page d'ajout de résultats
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="aPartirDeCourse"></param>
        /// <param name="id"></param>
        public AjoutResultat(ref DataGridView dataGridView, bool aPartirDeCourse,int id)
        {
            courseConnue = aPartirDeCourse;
            d=dataGridView;
            InitializeComponent();
            // Si course connue et donc id = idCourse
            if (aPartirDeCourse)
            {
                // On récupère la course
                course = courseRep.GetCourse(id);
                // On met à jour les affichages et on remplit la liste de non participants
                AfficherContenu();       
                // On récupère l'ensemble des coureurs qui ne participent pas à la course
                foreach (Coureur coureur in listeCoureursNonParticipants)
                {
                    // Remplissage comboBox
                    this.comboBox1.Items.Add(coureur.NumLicence.ToString()+" - "+coureur.Nom + " " + coureur.Prenom);
                }
            }

            else
            {
                // Changement du titre de la page
                this.labelCoureurOuCourse.Text = "Course";
                // On récupère le coureur que l'on veut
                coureur = coureurRep.ListeCoureur(id)[0];
                // Gestion affichage et listes
                AfficherContenu();
                foreach (Course course in listeCoursesNonParticipees)
                {
                    this.comboBox1.Items.Add("Course n°"+course.Id.ToString()+" "+course.Lieu);
                }
            }                
        }


        /// <summary>
        /// PErmet de gérer les affichages et les listes
        /// </summary>
        public void AfficherContenu()
        {
            // Si on part de la course dans la page précédente
            if (courseConnue)
            {
                listeCoureurs = coureurRep.GetAll();
                foreach (Coureur coureur in listeCoureurs)
                {
                    bool existe = false;
                    // Vérification : Si le résultat existe et donc que le coureur est participant à la course
                    foreach (Resultat resultat in resultatRep.GetAll())
                    {
                        if (coureur == resultat.LeCoureur)
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {
                        // Sinon on le place dans la liste des non participants
                        listeCoureursNonParticipants.Add(coureur);                        
                    }
                }
            }
            else
            {
                // On récupère la liste des courses en bdd
                listeCourses = courseRep.GetAll();
                //Pour chaque course
                foreach(Course course in listeCourses)
                {
                    bool existe = false;
                    //On vérifie dans chaque résultat de la bdd
                    foreach(Resultat resultat in resultatRep.GetAll())
                    {
                        // Si le coureur sélectionné dans la gridview de la page précédente à déjà un résultat pour la course on ne fait rien
                        if (course == resultat.LaCourse && resultat.LeCoureur==coureurRep.ListeCoureur(coureur.NumLicence)[0])
                        {
                            existe = true;                           
                        }
                    }
                    // Sinon on l'ajout dans la liste des courses non participées par le coureur
                    if (!existe)
                    {
                        listeCoursesNonParticipees.Add(course);                       
                    }
                }
            }
        }

        /// <summary>
        /// Fonction permettant de gérer le bouton de fermeture de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  Fonction permettant de gérer l'ajout d'un résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
           // Si les champs n'ont pas été remplis
            if ((this.comboBox1.Text == "") || this.textBoxDossard.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs !");
            }
            //sinon
            else
            {
                // L'index du choix du comboBox est sauvegardé
                int choix = this.comboBox1.SelectedIndex;
                Resultat resultat = new Resultat();
                if (courseConnue) // Si on part de la page informationCourse
                {
                    resultat.LaCourse = course;
                    // Le comboBox contient le coureur, on l'utilise donc pour remplir LeCoureur du résultat
                    resultat.LeCoureur = listeCoureursNonParticipants[choix];       
                }
                else
                {
                    // Le comboBox contient la course, on l'utilise donc pour remplir LaCourse du résultat
                    resultat.LaCourse = listeCoursesNonParticipees[choix];                    
                    resultat.LeCoureur = coureur;
                }

                if (this.textBoxDossard.Text != "")
                    resultat.NumDossard = Int32.Parse(this.textBoxDossard.Text);
                // On parse le texte du textbox de temps et on le met dans Temps du résultat
                resultat.Temps = TimeSpan.Parse(this.textBox1.Text);

                int age;
                
               // Remplissage des données de résultat
                resultat.TempsEnSecondes = resultat.CalculTempsEnSeconde(resultat.Temps);               
                resultat.AllureMoyenne= resultat.TempsEnSecondes / 60 / resultat.LaCourse.Distance / 1000;
                //resultat.VitesseMoyenne = resultat.CalculVitesseMoyenne(course.Distance);
                resultat.VitesseMoyenne= resultat.LaCourse.Distance / 1000 / resultat.TempsEnSecondes / 60 / 60;

                // Gestion du classement
                List<Resultat> listeResultats = new List<Resultat>();
                int classement = 1;
                //On ajoute tous les résultats de la course sélectionnée dans une liste de résultats
                foreach (Resultat resultat1 in resultatRep.ListeResultatsCourse(resultat.LaCourse.Id))
                {
                    listeResultats.Add(resultat1);
                }
                listeResultats.Add(resultat);
                // On trie la liste précédente en fonction des temps effectués
                List<Resultat> SortedList = listeResultats.OrderBy(o => o.TempsEnSecondes).ToList();
                foreach (Resultat resultat1 in SortedList)
                {
                    // On met à jour les classements
                    resultat1.Classement = classement;
                    classement++;
                    resultatRep.Save(resultat1);
                }
                // On sauvegarde les résultats
                resultatRep.Save(resultat);

                if (courseConnue)
                {
                    //On efface toutes les données de la GridView de la page informations
                    d.Rows.Clear();
                    d.Refresh();
                    // Pour chaque résultat concernant la course sélectionnée
                    foreach (Resultat resultat1 in this.resultatRep.ListeResultatsCourse(course.Id))
                    {
                        // On ajoute la ligne au DataGridView
                        Coureur coureur = coureurRep.ListeCoureur(resultat1.LeCoureur.NumLicence)[0];
                        age = coureur.CalculAge(coureur);
                        string[] res1 = { resultat1.Classement.ToString(), resultat1.Temps.ToString(), resultat1.NumDossard.ToString(), coureur.NumLicence.ToString(),
                            coureur.Nom, coureur.Prenom, resultat1.VitesseMoyenne.ToString(), resultat1.AllureMoyenne.ToString(), coureur.Sexe, age.ToString() };
                        d.Rows.Add(res1);
                    }                    
                }
                else
                {
                    //Mise à jour de l'affichage du GridView des resultats par coureur pour le coureur sélectionné sur la page d'accueil
                    d.Rows.Clear();
                    d.Refresh();
                    foreach (Resultat resultat1 in this.resultatRep.ListeResultatsCoureur(coureur.NumLicence))
                    {
                        Course course = courseRep.GetCourse(resultat1.LaCourse.Id);
                        string[] res = {course.Id.ToString(),course.Lieu, course.Date.Day.ToString()+"-"+course.Date.Month.ToString()+"-"+course.Date.Year.ToString(),
                     resultat1.Classement.ToString(), resultat.NumDossard.ToString(),course.Distance.ToString(),resultat1.AllureMoyenne.ToString(),
                    resultat1.VitesseMoyenne.ToString(), resultat1.Temps.ToString() };
                        d.Rows.Add(res);

                    }
                   
                }

                this.Close();
            }
        }
    }
}
