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
    public partial class NouveauCoureur : Form
    {
        DataGridView d = new DataGridView();
        CoureurRepository coureurRep = new CoureurRepository();
        public NouveauCoureur(ref DataGridView dataGridView)
        {
            InitializeComponent();
            d = dataGridView;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
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
