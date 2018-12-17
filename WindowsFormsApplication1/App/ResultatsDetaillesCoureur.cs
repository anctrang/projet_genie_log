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
    /// <summary>
    /// Classe gérant la page de résultats détaillés
    /// </summary>
    public partial class ResultatsDetaillesCoureur : Form
    {
        // Contient les résultats dans la bdd
        ResultatRepository resultatRep = new ResultatRepository();
        // Contient les coureurs dans la bdd
        CoureurRepository coureurRep = new CoureurRepository();
        Resultat resultat = new Resultat();
        Coureur coureur = new Coureur();

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="dossard"></param>
        /// <param name="idCourse"></param>
        public ResultatsDetaillesCoureur(string nom, int dossard, int idCourse)
        {
            InitializeComponent();
            //Si le nom est vide
            if (nom == "")
            {    
                //Récupération des résultats grâce au num de dossard et à l'id de la course
                resultat = resultatRep.ListeResultatAvecDossard(dossard, idCourse)[0];
                coureur = coureurRep.ListeCoureur(resultat.LeCoureur.NumLicence)[0];
            }
            //Sinon
            else
            {
                //On récupère les resultats et le coureur grâce à son nom
                coureur = coureurRep.ListeCoureurAvecNom(nom)[0];
                resultat = resultatRep.listeResultat(idCourse, coureur.NumLicence)[0];
            }
            // On remplit les labels grace au résultat et au coureur sélectionnés
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

        /// <summary>
        /// Fonction de fermeture de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
