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
    /// <summary>
    /// Classe gérant la page de modification des résultats
    /// </summary>
    public partial class ModificationResultat : Form
    {
        // permet de stocker la référence du datagridview
        DataGridView d = new DataGridView();
        // Contient les résultats en bdd
        ResultatRepository resultatRep = new ResultatRepository();
        //contient les courses en bdd
        CourseRepository courseRep = new CourseRepository();
        // Contient les coureurs en bdd
        CoureurRepository coureurRep = new CoureurRepository();
        int IdDonne;
        Resultat resultat = new Resultat();
        bool APArtirDeInfoCourse;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="SelectedRows"></param>
        /// <param name="aPartirDeInfoCourse"></param>
        /// <param name="idDonne"></param>
        public ModificationResultat(ref DataGridView dataGridView, DataGridViewSelectedRowCollection SelectedRows,bool aPartirDeInfoCourse, int idDonne)
        {
            InitializeComponent();
            d = dataGridView;
            APArtirDeInfoCourse = aPartirDeInfoCourse;
            IdDonne = idDonne;
            DataGridViewRow ligneSelectionnee = SelectedRows[0];            
          // Si la page à été lancée à partir de la page d'informations de courses et donc que l'on a l'id de la course dont on veut modifier le resultat
            if (aPartirDeInfoCourse)
            {
                int id = Convert.ToInt32(ligneSelectionnee.Cells[3].Value);
                // On récupère le résultat que l'on veut modifier
                resultat = resultatRep.listeResultat(idDonne, id)[0];
            }
            else
            {
                int id = Convert.ToInt32(ligneSelectionnee.Cells[0].Value);
                //On récupère le résultat que l'on veut
                resultat = resultatRep.listeResultat(id, idDonne)[0];
            }      
        }

        /// <summary>
        /// Fonction qui gère la validation de modification du résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            //Remplissage du resultat à renvoyer
            List<Resultat> listeResultats = new List<Resultat>();
            int classement = 1;
            resultat.NumDossard =Convert.ToInt32(this.textBoxDossard.Text);
            resultat.Temps = TimeSpan.Parse(this.textBoxTemps.Text);
            resultat.TempsEnSecondes = resultat.CalculTempsEnSeconde(resultat.Temps);
            resultat.AllureMoyenne = resultat.CalculAllureMoyenne(resultat.LaCourse.Distance);
            resultat.VitesseMoyenne = resultat.CalculVitesseMoyenne(resultat.LaCourse.Distance);
            // On ajoute tous les résultats de la course dans une liste
            foreach(Resultat resultat in resultatRep.ListeResultatsCourse(resultat.LaCourse.Id))
            {
                listeResultats.Add(resultat);
            }
            // On classe les résultats par temps et on met à jour le classement
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
                // On met à jour l'affichage dans les gridviews
                foreach (Resultat resultat in this.resultatRep.ListeResultatsCourse(IdDonne))
                {
                    Coureur coureur = coureurRep.ListeCoureur(resultat.LeCoureur.NumLicence)[0];
                    int age = coureur.CalculAge(coureur);
                    string[] res = { resultat.Classement.ToString(),resultat.Temps.ToString(), resultat.NumDossard.ToString(), coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, resultat.VitesseMoyenne.ToString(), resultat.AllureMoyenne.ToString(), coureur.Sexe, age.ToString() };
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
