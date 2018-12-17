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
    /// <summary>
    ///  Classe gérant la page de création d'un coureur
    /// </summary>
    public partial class NouveauCoureur : Form
    {
        DataGridView d = new DataGridView();
        CoureurRepository coureurRep = new CoureurRepository();

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="dataGridView"></param>
        public NouveauCoureur(ref DataGridView dataGridView)
        {
            InitializeComponent();
            d = dataGridView;
        }

        /// <summary>
        /// FOnction gérant la fermeture de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fonction permettant al création du nouveau coureur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            //Création d'un coureur et remplissage de ses caractéristiques selons les données du formulaire
            Coureur coureur = new Coureur();
            coureur.Nom = this.textBoxNom.Text;
            coureur.Prenom = this.textBoxPrenom.Text;
            if (this.M.Checked)
                coureur.Sexe = "M";
            else if (this.F.Checked)
                coureur.Sexe = "F";
            coureur.Courriel = this.textBoxCourriel.Text;
            coureur.DateDeNaissance = this.dateTimePicker1.Value;
            coureurRep.Save(coureur);
            string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom, coureur.Prenom, coureur.DateDeNaissance.ToString() };
            d.Rows.Add(resultat);
            this.Close();
        }
    }
}
