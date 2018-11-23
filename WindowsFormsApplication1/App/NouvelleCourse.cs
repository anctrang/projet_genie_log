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
    public partial class NouvelleCourse : Form
    {
        //private Accueil accueil;
        private bool creation;


        private List<Coureur> listeCoureursParticipants = new List<Coureur>(); // pour la deuxième datagridview
        private List<Coureur> listeCoureursNonParticipants = new List<Coureur>(); // pour la première datagridview
        private CourseRepository courseRep = new CourseRepository();
        private CoureurRepository coureurRep = new CoureurRepository();
        private ResultatRepository resultatRep = new ResultatRepository();
        private DataGridView dataG = new DataGridView(); // mise à jour du datagridview affichant les courses de la page accueil

        /*public NouvelleCourse(ref ,bool creation ) // Constructeur lors d'une modification de course
        {
            this.textBoxLieu.Text=d.
            this.dataG = d;
            this.creation = true;
            

        }*/

        public NouvelleCourse(ref DataGridView d) // Constructeur lors d'une création de course
        {            
            dataG = d;        
            InitializeComponent();   
            
            foreach(Coureur coureur in coureurRep.GetAll()) // Remplir les non participants (à modifier pour la modification d'une course)
            {
                listeCoureursNonParticipants.Add(coureur);
            }
            AfficherContenu();
        }

        public void AfficherContenu()
        {
            dataG.Rows.Clear();
            dataG.Refresh();
            dataGridViewParticipants.Rows.Clear();
            dataGridViewParticipants.Refresh();
            dataGridViewLicencies.Rows.Clear();
            dataGridViewLicencies.Refresh();

            foreach (Course course in this.courseRep.GetAll())
            {
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(), "10" };
                dataG.Rows.Add(resultat);
            }

            foreach (Coureur coureur in listeCoureursNonParticipants)
            {
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom };
                this.dataGridViewLicencies.Rows.Add(resultat);
            }

            foreach(Coureur coureur in this.listeCoureursParticipants)
            {
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom };
                this.dataGridViewParticipants.Rows.Add(resultat);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Course course = new Course(this.textBoxLieu.Text, Convert.ToDouble(this.textBoxDist.Text), this.richTextBoxDesc.Text, this.dateTimePicker.Value);
            courseRep.Save(course); // Création de la course
            foreach(Coureur coureur in listeCoureursParticipants) // Créations des liens entre coureur et courses avec resultats vides
            {
                Resultat r = new Resultat(course, coureur);
                resultatRep.Save(r);
            }
            MessageBox.Show("Nouvelle course ajoutée !");
            AfficherContenu();
            this.Close();
           
        }

        private void buttonAjouterParticipant_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewLicencies.SelectedRows.Count > 0)
            {

                int selectedRowIndex = this.dataGridViewLicencies.SelectedCells[0].RowIndex;               
                DataGridViewRow selectedRow = dataGridViewLicencies.Rows[selectedRowIndex];
                int numLicenceSelection = Convert.ToInt32(selectedRow.Cells[0].Value);


                foreach(Coureur coureur in coureurRep.GetAll())
                {
                    if(numLicenceSelection == coureur.NumLicence)
                    {
                        Coureur coureurSelectionne = new Coureur();
                        coureurSelectionne = coureur;
                        this.listeCoureursParticipants.Add(coureurSelectionne);
                        this.listeCoureursNonParticipants.Remove(coureur);
                        
                    }
                }             

            }

            AfficherContenu();
          
        
        }

        private void buttonRetirerParticipant_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewParticipants.SelectedRows.Count > 0)
            {

                int selectedRowIndex = this.dataGridViewParticipants.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewParticipants.Rows[selectedRowIndex];
                int numLicenceSelection = Convert.ToInt32(selectedRow.Cells[0].Value);


                foreach (Coureur coureur in coureurRep.GetAll())
                {
                    if (numLicenceSelection == coureur.NumLicence)
                    {
                        Coureur coureurSelectionne = new Coureur();
                        coureurSelectionne = coureur;
                        this.listeCoureursParticipants.Remove(coureurSelectionne);
                        this.listeCoureursNonParticipants.Add(coureur);

                    }
                }

            }

            AfficherContenu();
        }
    }
}
