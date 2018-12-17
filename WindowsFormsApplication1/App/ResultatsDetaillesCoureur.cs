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
    public partial class ResultatsDetaillesCoureur : Form
    {
        ResultatRepository resultatRep = new ResultatRepository();
        CoureurRepository coureurRep = new CoureurRepository();
        Resultat resultat = new Resultat();
        Coureur coureur = new Coureur();

        public ResultatsDetaillesCoureur(string nom, int dossard, int idCourse)
        {
            InitializeComponent();
            if (nom == "")
            {
                
                resultat = resultatRep.ListeResultatAvecDossard(dossard, idCourse)[0];
                coureur = coureurRep.ListeCoureur(resultat.LeCoureur.NumLicence)[0];
            }

            else
            {
                coureur = coureurRep.ListeCoureurAvecNom(nom)[0];
                resultat = resultatRep.listeResultat(idCourse, coureur.NumLicence)[0];
            }
            this.labelClassement.Text = resultat.Classement.ToString();
            this.labelDateNaissance.Text = coureur.DateDeNaissance.Day.ToString() + "-" + coureur.DateDeNaissance.Month.ToString() + "-" + coureur.DateDeNaissance.Year.ToString();
            this.labelDossard.Text = resultat.NumDossard.ToString();
            this.labelLicence.Text = coureur.NumLicence.ToString();
            this.labelNom.Text = coureur.Nom;
            this.labelPrenom.Text = coureur.Prenom;
            this.labelSexe.Text = coureur.Sexe;
            this.labelAllure.Text = resultat.AllureMoyenne.ToString();
            this.labelVitesse.Text = resultat.VitesseMoyenne.ToString();
            this.labelTemps.Text = resultat.Temps.ToString();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
