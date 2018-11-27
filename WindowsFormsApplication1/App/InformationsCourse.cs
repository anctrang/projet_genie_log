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
    public partial class InformationsCourse : Form
    {
        private ResultatRepository resultatRep = new ResultatRepository();
        private CoureurRepository coureurRep = new CoureurRepository();
        List<Coureur> listeCoureurs = new List<Coureur>();
        List<Resultat> listeResultats = new List<Resultat>();
        private int idCourseSelectionnee;

        public InformationsCourse(int id)
        {
            this.idCourseSelectionnee = id;
            InitializeComponent();
        }

        public void AfficherContenu()
        {
            int age;
            foreach (Resultat resultat in this.resultatRep.GetAll())
            {
                if (resultat.LaCourse.Id == idCourseSelectionnee) // Le resultat concerne la course sélectionnée
                {
                    foreach(Coureur coureur in coureurRep.GetAll())
                    {
                        if (resultat.LeCoureur.NumLicence == coureur.NumLicence) // on récupère le coureur concerné par le résultat
                        {
                            listeCoureurs.Add(coureur);
                            listeResultats.Add(resultat);
                        }
                    }
                }
            }

            for (int i = 0; i < listeCoureurs.Count; i++)
            {
                //calcul age
               /* int ageCoureur = Convert.ToInt32(listeCoureurs[i].DateDeNaissance.Year - DateTime.Now.Year);                
                string[] resultat = { listeResultats[i].NumDossard.ToString(), listeCoureurs[i].Nom, listeCoureurs[i].Prenom };*/
            }
            /*foreach (Coureur coureur in this.coureurRepository.GetAll())
            {
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, coureur.DateDeNaissance.ToString() };
                dataGridViewCoureurs.Rows.Add(resultat);
            }

            foreach (Course course in this.courseRepository.GetAll())
            {
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(), "A Calculer" };
                dataGridViewCourses.Rows.Add(resultat);
            }*/
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {

        }
    }
}
