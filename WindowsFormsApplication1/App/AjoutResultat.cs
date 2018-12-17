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
            int choix = this.comboBox1.SelectedIndex;
            Resultat resultat = new Resultat();
            if (courseConnue)
            {
                
                
                resultat.LaCourse = course;
                resultat.LeCoureur = listeCoureursNonParticipants[choix];
                //resultat.Temps = this.textBoxTemps.Text;
            }
            else
            {
                resultat.LaCourse = listeCoursesNonParticipees[choix];
                resultat.LeCoureur = coureur;
            }
            if (this.textBoxDossard.Text != "")
                resultat.NumDossard = Int32.Parse(this.textBoxDossard.Text);

            int age = DateTime.Now.Year - coureur.DateDeNaissance.Year -
                     (DateTime.Now.Month < coureur.DateDeNaissance.Month ? 1 :
                     (DateTime.Now.Month == coureur.DateDeNaissance.Month && DateTime.Now.Day < coureur.DateDeNaissance.Day) ? 1 : 0);
            string[] res = { resultat.Classement.ToString(), resultat.NumDossard.ToString(), coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, resultat.VitesseMoyenne.ToString(), resultat.AllureMoyenne.ToString(), coureur.Sexe, age.ToString() };
            dataGridView1.Rows.Add(res);

            resultatRep.Save(resultat);
            this.Close();
        }
    }
}
