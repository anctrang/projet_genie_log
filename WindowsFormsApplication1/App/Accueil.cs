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
    public partial class Accueil : Form
    {

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

            if (Program.identifiantEnregistre != "")
            {                
                this.buttonLogin.Visible = false;
            }
            AfficherContenu();
        }

        public void AfficherContenu()
        {
            foreach(Coureur coureur in this.coureurRepository.GetAll())
            {
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, coureur.DateDeNaissance.ToString() };
                dataGridViewCoureurs.Rows.Add(resultat);
            }
            
            foreach(Course course in this.courseRepository.GetAll())
            {
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(),"A Calculer" };
                dataGridViewCourses.Rows.Add(resultat);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion(ref this.buttonLogin, ref this.buttonSignUp, ref this.buttonDeconnexion);
            connexion.Show();
            
            
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription(ref this.buttonLogin, ref this.buttonSignUp, ref this.buttonDeconnexion);
            inscription.Show();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Program.identifiantEnregistre = "";
            MessageBox.Show("Deconnexion reussie !");
            this.buttonSignUp.Visible = true;
            this.buttonDeconnexion.Visible = false;
            this.buttonLogin.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAjouterCourse_Click(object sender, EventArgs e)
        {
            NouvelleCourse nouvelleCourse = new NouvelleCourse(ref this.dataGridViewCourses);
            nouvelleCourse.Show();
        }
    }
}
