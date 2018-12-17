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
    public partial class AjoutResultat : Form
    {
        CourseRepository courseRep = new CourseRepository();
        CoureurRepository coureurRep = new CoureurRepository();
        ResultatRepository resultatRep = new ResultatRepository();
        IList<Coureur> listeCoureurs = new List<Coureur>();
        List<Coureur> listeCoureursNonParticipants = new List<Coureur>();
        List<Course> listeCoursesNonParticipees = new List<Course>();
        IList<Course> listeCourses = new List<Course>();
        Course course = new Course();
        Coureur coureur = new Coureur();
        bool courseConnue;
        DataGridView d = new DataGridView();

        
        public AjoutResultat(ref DataGridView dataGridView, bool aPartirDeCourse,int id)
        {

            courseConnue = aPartirDeCourse;
            d=dataGridView;
            InitializeComponent();
            if (aPartirDeCourse)
            {
                course = courseRep.GetCourse(id);
                AfficherContenu();                
                foreach (Coureur coureur in listeCoureursNonParticipants)
                {
                    this.comboBox1.Items.Add(coureur.NumLicence.ToString()+" - "+coureur.Nom + " " + coureur.Prenom);
                }

            }

            else
            {
                this.labelCoureurOuCourse.Text = "Course";
                coureur = coureurRep.ListeCoureur(id)[0];
                AfficherContenu();
                foreach (Course course in listeCoursesNonParticipees)
                {
                    this.comboBox1.Items.Add("Course n°"+course.Id.ToString()+" "+course.Lieu);
                }

            }
            
            
            
        }

        public void AfficherContenu()
        {
            if (courseConnue)
            {
                listeCoureurs = coureurRep.GetAll();
                foreach (Coureur coureur in listeCoureurs)
                {
                    bool existe = false;
                    foreach (Resultat resultat in resultatRep.GetAll())
                    {
                        if (coureur == resultat.LeCoureur)
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {
                        listeCoureursNonParticipants.Add(coureur);
                        
                    }
                }
            }
            else
            {
                listeCourses = courseRep.GetAll();
                foreach(Course course in listeCourses)
                {
                    bool existe = false;
                    foreach(Resultat resultat in resultatRep.GetAll())
                    {
                        
                        if (course == resultat.LaCourse && resultat.LeCoureur==coureurRep.ListeCoureur(coureur.NumLicence)[0])
                        {
                            existe = true;                           
                        }
                    }
                    if (!existe)
                    {
                        listeCoursesNonParticipees.Add(course);
                       
                    }
                }
            }
            
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
           
            if ((this.comboBox1.Text == "") || this.textBoxDossard.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs !");
            }
            else
            {
                int choix = this.comboBox1.SelectedIndex;
                Resultat resultat = new Resultat();
                if (courseConnue)
                {


                    resultat.LaCourse = course;
                    resultat.LeCoureur = listeCoureursNonParticipants[choix];
                    
                    
                }
                else
                {
                    resultat.LaCourse = listeCoursesNonParticipees[choix];                    
                    resultat.LeCoureur = coureur;
                }
                if (this.textBoxDossard.Text != "")
                    resultat.NumDossard = Int32.Parse(this.textBoxDossard.Text);
                resultat.Temps = TimeSpan.Parse(this.textBox1.Text);
                int age = DateTime.Now.Year - coureur.DateDeNaissance.Year -
                         (DateTime.Now.Month < coureur.DateDeNaissance.Month ? 1 :
                         (DateTime.Now.Month == coureur.DateDeNaissance.Month && DateTime.Now.Day < coureur.DateDeNaissance.Day) ? 1 : 0);

               
                resultat.TempsEnSecondes = resultat.CalculTempsEnSeconde(resultat.Temps);
                resultat.AllureMoyenne = resultat.CalculAllureMoyenne(course.Distance);
                resultat.VitesseMoyenne = resultat.CalculVitesseMoyenne(course.Distance);
                if (courseConnue)
                {
                    string[] res = { resultat.Classement.ToString(), resultat.Temps.ToString(), resultat.NumDossard.ToString(), coureur.NumLicence.ToString(), resultat.LeCoureur.Nom, resultat.LeCoureur.Prenom, resultat.VitesseMoyenne.ToString(), resultat.AllureMoyenne.ToString(), resultat.LeCoureur.Sexe, age.ToString() };
                    d.Rows.Add(res);
                }
                else
                {
                    Course course = courseRep.GetCourse(resultat.LaCourse.Id);
                    string[] res = {course.Id.ToString(),course.Lieu, course.Date.Day.ToString()+"-"+course.Date.Month.ToString()+"-"+course.Date.Year.ToString(),
                     resultat.Classement.ToString(), resultat.NumDossard.ToString(),course.Distance.ToString(), resultat.AllureMoyenne.ToString(),
                    resultat.VitesseMoyenne.ToString(), resultat.Temps.ToString() };
                    d.Rows.Add(res);
                }
                List<Resultat> listeResultats = new List<Resultat>();
                int classement = 1;
                foreach (Resultat resultat1 in resultatRep.ListeResultatsCourse(resultat.LaCourse.Id))
                {
                    listeResultats.Add(resultat);
                }
                List<Resultat> SortedList = listeResultats.OrderBy(o => o.TempsEnSecondes).ToList();
                foreach (Resultat resultat1 in SortedList)
                {
                    resultat1.Classement = classement;
                    classement++;
                    resultatRep.Save(resultat1);
                }
                resultatRep.Save(resultat);
                
                this.Close();
            }
        }
    }
}
