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
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(),Convert.ToString(resultatRepository.ListeResultatsCourse(course.Id).Count) };
                dataGridViewCourses.Rows.Add(resultat);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
          
           MessageBox.Show(Convert.ToString(Convert.ToString(resultatRepository.ListeResultatsCourse(1).Count)));
            
            
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

            if (this.dataGridViewCourses.SelectedRows.Count == 0 && this.dataGridViewCoureurs.SelectedRows.Count==0)
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

        }
    }
}
