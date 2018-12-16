﻿using System;
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
        private CourseRepository courseRep = new CourseRepository();
        List<Coureur> listeCoureurs = new List<Coureur>();
        List<Resultat> listeResultats = new List<Resultat>();
        Course course = new Course();
        private int idCourseSelectionnee;

        public InformationsCourse(int id)
        {
            InitializeComponent();
            this.idCourseSelectionnee = id;           
            course = courseRep.GetCourse(id);
            this.labelDate.Text = course.Date.Day.ToString() + "-" + course.Date.Month.ToString() + "-" + course.Date.Year.ToString() ;
            this.labelLieu.Text = course.Lieu;            
            AfficherContenu();
        }

        public void AfficherContenu()
        {           

            foreach(Resultat resultat in this.resultatRep.ListeResultatsCourse(this.idCourseSelectionnee))
            {
                Coureur coureur = coureurRep.ListeCoureur(resultat.LeCoureur.NumLicence)[0];
                int age = DateTime.Now.Year - coureur.DateDeNaissance.Year -
                         (DateTime.Now.Month < coureur.DateDeNaissance.Month ? 1 :
                         (DateTime.Now.Month == coureur.DateDeNaissance.Month && DateTime.Now.Day < coureur.DateDeNaissance.Day) ? 1 : 0);
                string[] res = { resultat.Classement.ToString(), resultat.NumDossard.ToString(), coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, resultat.VitesseMoyenne.ToString(), resultat.AllureMoyenne.ToString(), coureur.Sexe,age.ToString() };
                dataGridView1.Rows.Add(res);

            }           
           
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {

        }

        private void buttonNouveauResultat_Click(object sender, EventArgs e)
        {
            AjoutResultat a = new AjoutResultat(true, idCourseSelectionnee);
            a.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}
