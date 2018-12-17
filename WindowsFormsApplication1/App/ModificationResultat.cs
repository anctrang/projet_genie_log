using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;
using System.Windows.Forms;

namespace App
{
    public partial class ModificationResultat : Form
    {
        DataGridView d = new DataGridView();
        ResultatRepository resultatRep = new ResultatRepository();
        CourseRepository courseRep = new CourseRepository();
        CoureurRepository coureurRep = new CoureurRepository();
        int IdDonne;
        Resultat resultat = new Resultat();
        bool APArtirDeInfoCourse;

        public ModificationResultat(ref DataGridView dataGridView, DataGridViewSelectedRowCollection SelectedRows,bool aPartirDeInfoCourse, int idDonne)
        {
            InitializeComponent();
            d = dataGridView;
            APArtirDeInfoCourse = aPartirDeInfoCourse;
            IdDonne = idDonne;
            DataGridViewRow ligneSelectionnee = SelectedRows[0];
            
          
            if (aPartirDeInfoCourse)
            {
                int id = Convert.ToInt32(ligneSelectionnee.Cells[2].Value);
                resultat = resultatRep.listeResultat(idDonne, id)[0];
                
            }
            else
            {
                int id = Convert.ToInt32(ligneSelectionnee.Cells[0].Value);
                resultat = resultatRep.listeResultat(id, idDonne)[0];
            }
            

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            List<Resultat> listeResultats = new List<Resultat>();
            int classement = 1;
            resultat.NumDossard =Convert.ToInt32(this.textBoxDossard.Text);
            resultat.Temps = TimeSpan.Parse(this.textBoxTemps.Text);
            resultat.TempsEnSecondes = resultat.CalculTempsEnSeconde(resultat.Temps);
            resultat.AllureMoyenne = resultat.CalculAllureMoyenne(resultat.LaCourse.Distance);
            resultat.VitesseMoyenne = resultat.CalculVitesseMoyenne(resultat.LaCourse.Distance);
            foreach(Resultat resultat in resultatRep.ListeResultatsCourse(resultat.LaCourse.Id))
            {
                listeResultats.Add(resultat);
            }
            List<Resultat> SortedList = listeResultats.OrderBy(o => o.TempsEnSecondes).ToList();
            foreach(Resultat resultat in SortedList)
            {
                resultat.Classement = classement;
                classement++;
            }

            resultatRep.Save(resultat);
            d.Rows.Clear();
            d.Refresh();
            if (APArtirDeInfoCourse)
            {
                foreach (Resultat resultat in this.resultatRep.ListeResultatsCourse(IdDonne))
                {
                    Coureur coureur = coureurRep.ListeCoureur(resultat.LeCoureur.NumLicence)[0];
                    int age = DateTime.Now.Year - coureur.DateDeNaissance.Year -
                             (DateTime.Now.Month < coureur.DateDeNaissance.Month ? 1 :
                             (DateTime.Now.Month == coureur.DateDeNaissance.Month && DateTime.Now.Day < coureur.DateDeNaissance.Day) ? 1 : 0);
                    string[] res = { resultat.Classement.ToString(), resultat.NumDossard.ToString(), coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, resultat.VitesseMoyenne.ToString(), resultat.AllureMoyenne.ToString(), coureur.Sexe, age.ToString() };
                    d.Rows.Add(res);

                }
            }
            else
            {
                foreach (Resultat resultat in this.resultatRep.ListeResultatsCoureur(IdDonne))
                {

                    Course course = courseRep.GetCourse(resultat.LaCourse.Id);
                    string[] res = {course.Id.ToString(),course.Lieu, course.Date.Day.ToString()+"-"+course.Date.Month.ToString()+"-"+course.Date.Year.ToString(),
                    course.Distance.ToString(), resultat.Classement.ToString(), resultat.NumDossard.ToString(), resultat.AllureMoyenne.ToString(),
                    resultat.VitesseMoyenne.ToString()};
                    d.Rows.Add(res);

                }
            }
            this.Close();

        }
    }
}
