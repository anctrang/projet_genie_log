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
    public partial class InformationsCoureurs : Form
    {

        CourseRepository courseRep = new CourseRepository();
        CoureurRepository coureurRep = new CoureurRepository();
        ResultatRepository resultatRep = new ResultatRepository();
        Coureur coureur = new Coureur();





        public InformationsCoureurs(int numLicence)
        {
            InitializeComponent();
            coureur = coureurRep.ListeCoureur(numLicence)[0];

            this.labelNomPrenom.Text = coureur.Nom + " " + coureur.Prenom;
            this.labelNumLicence.Text = Convert.ToString(coureur.NumLicence);
            this.labelSexe.Text = coureur.Sexe;
            int age = DateTime.Now.Year - coureur.DateDeNaissance.Year -
                         (DateTime.Now.Month < coureur.DateDeNaissance.Month ? 1 :
                         (DateTime.Now.Month == coureur.DateDeNaissance.Month && DateTime.Now.Day < coureur.DateDeNaissance.Day) ? 1 : 0);
            this.labelAge.Text = Convert.ToString(age) + "ans";
            AfficherContenu();
            if (Accueil.identifiantEnregistre == "")
            {
                this.buttonModifierResultat.Visible = false;
                this.buttonModifierResultat.Enabled = false;
                this.buttonNouveauResultat.Visible = false;
                this.buttonNouveauResultat.Enabled = false;
            }
        }

        public void AfficherContenu()
        {


            foreach (Resultat resultat in this.resultatRep.ListeResultatsCoureur(coureur.NumLicence))
            {

                Course course = courseRep.GetCourse(resultat.LaCourse.Id);
                string[] res = {course.Id.ToString(),course.Lieu, course.Date.Day.ToString()+"-"+course.Date.Month.ToString()+"-"+course.Date.Year.ToString(),
                     resultat.Classement.ToString(), resultat.NumDossard.ToString(),course.Distance.ToString(), resultat.AllureMoyenne.ToString(),
                    resultat.VitesseMoyenne.ToString(), resultat.Temps.ToString() };
                dataGridView1.Rows.Add(res);

            }

        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNouveauResultat_Click(object sender, EventArgs e)
        {
            AjoutResultat a = new AjoutResultat(ref this.dataGridView1,false, coureur.NumLicence);
            a.Show();
        }

        private void buttonModifierResultat_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Veuillez sélectionner un résultat");
            else
            {
                ModificationResultat m = new ModificationResultat(ref this.dataGridView1, this.dataGridView1.SelectedRows, false, coureur.NumLicence);
                m.Show();

            }
        }

        private void groupBoxInfosCoureur_Enter(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

            foreach (Resultat resultat in this.resultatRep.ListeResultatsCoureur(coureur.NumLicence))
            {

                Course course = courseRep.GetCourse(resultat.LaCourse.Id);
                string[] res = {course.Id.ToString(),course.Lieu, course.Date.Day.ToString()+"-"+course.Date.Month.ToString()+"-"+course.Date.Year.ToString(),
                     resultat.Classement.ToString(), resultat.NumDossard.ToString(),course.Distance.ToString(), resultat.AllureMoyenne.ToString(),
                    resultat.VitesseMoyenne.ToString()};
                dataGridView1.Rows.Add(res);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
