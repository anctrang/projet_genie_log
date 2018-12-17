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
    /// Classe permettant de gérer le formulaire de modification d'une course et la création d'une nouvelle course
    /// </summary>
    
    public partial class NouvelleCourse : Form
    {
        //Booléen définissant si nous sommes en présence d'une modification de course ou d'une création de course
        private bool modification = false;
        //Permet de récupérer l'id de la course sélectionnée au moment du clic sur le bouton "Modification course"
        private int idCourseSelectionnee;
        // Stocke la course à modifier sélectionnée
        private Course courseAModifier = new Course();
        // pour la deuxième datagridview
        private List<Coureur> listeCoureursParticipants = new List<Coureur>();
        // pour la première datagridview
        private List<Coureur> listeCoureursNonParticipants = new List<Coureur>(); 
        // Contient la liste des courses en base de données
        private CourseRepository courseRep = new CourseRepository();
        // Contient les coureurs en base de données
        private CoureurRepository coureurRep = new CoureurRepository();
        // Contient les résultats en base de données
        private ResultatRepository resultatRep = new ResultatRepository();
        // mise à jour du datagridview affichant les courses de la page accueil
        private DataGridView dataG = new DataGridView();


        /// <summary>
        ///  Constructeur lors d'une modification de course
        /// </summary>
        /// <param name="d">Référence au DataGridView de la page d'accueil pour le modifier</param>
        /// <param name="collectionLignesSelec"> Ligne sélectionnée dans le dataGridView </param>
        public NouvelleCourse(ref DataGridView d, DataGridViewSelectedRowCollection collectionLignesSelec)
        
        {
            // Récupère la ligne sélectionnée
            DataGridViewRow ligneSelectionnee = collectionLignesSelec[0];
            this.idCourseSelectionnee = Convert.ToInt32(ligneSelectionnee.Cells[0].Value);
            this.dataG = d;
            this.modification = true;
            InitializeComponent();

            //Récupère la course que l'on souhaite modifier
            courseAModifier = courseRep.GetCourse(this.idCourseSelectionnee);


  
            bool trouve;
            // Remplit les participants et non participants
            foreach (Coureur coureur in coureurRep.GetAll())
            {
                trouve = false;
                foreach (Resultat resultat in resultatRep.GetAll())
                {
                    if (resultat.LeCoureur == coureur && resultat.LaCourse == courseAModifier)
                    {
                        trouve = true;
                    }
                }
                if (trouve)
                {
                    listeCoureursParticipants.Add(coureur);
                }

                else
                    listeCoureursNonParticipants.Add(coureur);
            }


            this.textBoxLieu.Text = courseAModifier.Lieu;
            this.textBoxDist.Text = courseAModifier.Distance.ToString();
            this.dateTimePicker.Value = courseAModifier.Date;

            //this.richTextBoxDesc - Pour le moment on ne peut pas... manque un assembly

            this.buttonAjouter.Text = "Modifier";

            AfficherContenu();

        }


        /// <summary>
        /// Constructeur création d'une course
        /// </summary>
        /// <param name="d"> Permet de mettre à jour la dataGridView de la page d'accueil après la création de la course </param>
        public NouvelleCourse(ref DataGridView d) 
        {
            dataG = d;
            InitializeComponent();

            foreach (Coureur coureur in coureurRep.GetAll()) // Remplir les non participants 
            {
                listeCoureursNonParticipants.Add(coureur);
            }
            this.AfficherContenu();
        }

        /// <summary>
        /// Fonction permettant de refresh l'ensemble des gridview selon les modifications faites.tyr
        /// </summary>
        public void AfficherContenu()
        {
            // On nettoie les 2 dataGridView
            dataG.Rows.Clear();
            dataG.Refresh();
            dataGridViewParticipants.Rows.Clear();
            dataGridViewParticipants.Refresh();
            dataGridViewLicencies.Rows.Clear();
            dataGridViewLicencies.Refresh();

            // On remplit le datagridView de la page d'accueil avec toutes les courses en bdd
            foreach (Course course in this.courseRep.GetAll())
            {
                string[] resultat = { course.Id.ToString(), course.Date.ToString(), course.Lieu, course.Distance.ToString(), Convert.ToString(resultatRep.ListeResultatsCourse(course.Id).Count) };
                dataG.Rows.Add(resultat);
            }

            // On remplit le dataGridView des coureurs non participnts à la course sélectionnée
            foreach (Coureur coureur in listeCoureursNonParticipants)
            {
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom };
                this.dataGridViewLicencies.Rows.Add(resultat);
            }

            // Idem avec les coureurs participants à la course sélectionnée
            foreach (Coureur coureur in this.listeCoureursParticipants)
            {
                string[] resultat = { coureur.NumLicence.ToString(), coureur.Nom };
                this.dataGridViewParticipants.Rows.Add(resultat);
            }
        }

        /// <summary>
        /// Fonction permettant de gérer la création de la nouvelle course ou la modification de la course sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            bool existe = false;
            Course course;
            // Si nous sommes dans le cadre d'une modification de course
            if (modification)
            {
                // On récupère tous les coureurs qui sont dans le datagridview des non participants
                foreach (Coureur coureur in listeCoureursNonParticipants)
                {
                    // On rcupère tous les coureurs qui participaient à la course avant modifictation
                    foreach (Resultat resultat in resultatRep.GetAll())
                    {
                        // S'ils ne participent plus (et qu'ils sont donc dans le gridview non participants, on supprime l'objet résultat associé
                        if (resultat.LaCourse == courseAModifier && resultat.LeCoureur == coureur)
                        {
                            resultatRep.Delete(resultat);
                        }
                    }
                }

                // On vérifie si pour chaque coureur participant à la course (présent dans le datagridview des participants), un résultat est déjà existant
                foreach (Coureur coureur in listeCoureursParticipants)
                {
                    existe = false;
                    foreach (Resultat resultat in resultatRep.GetAll())
                    {
                        if (resultat.LeCoureur == coureur)
                        {
                            existe = true;
                        }
                    }
                    // Si pas, on créé le résultat
                    if (!existe)
                    {
                        Resultat resultat = new Resultat(courseAModifier,coureur);                       
                        resultatRep.Save(resultat);
                    }
                }
                // On change les données de la course à modifier en fonction de ce qui est indiqué dans le formulaire
                courseAModifier.Date = this.dateTimePicker.Value;
                courseAModifier.Distance = Convert.ToInt32(this.textBoxDist.Text);
                courseAModifier.Lieu = this.textBoxLieu.Text;
                courseRep.Save(courseAModifier);

                // On ajoute/met à jour les différents résultats en fonction des modifications sur les coureurs effectués
                foreach(Resultat resultat in resultatRep.ListeResultatsCourse(courseAModifier.Id))
                {
                    resultat.AllureMoyenne = resultat.CalculAllureMoyenne(courseAModifier.Distance);
                    resultatRep.Save(resultat);
                }   
            }          
            // Si création de course
            else
            {
                course = new Course(this.textBoxLieu.Text, Convert.ToDouble(this.textBoxDist.Text), this.richTextBoxDesc.Text, this.dateTimePicker.Value);
                // Création de la course
                courseRep.Save(course); 
                courseRep.Delete(courseAModifier);
                // Créations des liens entre coureur et courses avec resultats vides
                foreach (Coureur coureur in listeCoureursParticipants) 
                {
                    Resultat r = new Resultat(course, coureur);
                    resultatRep.Save(r);
                }
                MessageBox.Show("Nouvelle course ajoutée !");
            }
            //Mise à jour de l'affichage
            AfficherContenu();
            dataG.Rows.Clear();
            dataG.Refresh();
            //Mise à jour du datagridview de la page d'accueil concernant les courses
            foreach (Course course1 in this.courseRep.GetAll())
            {
                string[] resultat = { course1.Id.ToString(), course1.Date.ToString(), course1.Lieu, course1.Distance.ToString(), Convert.ToString(resultatRep.ListeResultatsCourse(course1.Id).Count) };
                dataG.Rows.Add(resultat);
            }
            this.Close();

        }

        /// <summary>
        /// Fonction permettant de gérer l'ajout d'un participant (passage du gridview non participant à participant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterParticipant_Click(object sender, EventArgs e)
        {
            // Si un coureur à été sélectionné
            if (this.dataGridViewLicencies.SelectedRows.Count > 0)
            {
                // On récupère le coureur sélectionné
                int selectedRowIndex = this.dataGridViewLicencies.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLicencies.Rows[selectedRowIndex];
                int numLicenceSelection = Convert.ToInt32(selectedRow.Cells[0].Value);

                // On retire le coureur de la liste des participants et on l'ajoute à la liste des non participants
                foreach (Coureur coureur in coureurRep.GetAll())
                {
                    if (numLicenceSelection == coureur.NumLicence)
                    {
                        Coureur coureurSelectionne = new Coureur();
                        coureurSelectionne = coureur;
                        this.listeCoureursParticipants.Add(coureurSelectionne);
                        this.listeCoureursNonParticipants.Remove(coureur);
                    }
                }
            }
            // On met à jour l'affichage des datagridview
            AfficherContenu();
        }

        /// <summary>
        /// Fonction permettant de gérer le retrait d'un coureur à la course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRetirerParticipant_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewParticipants.SelectedRows.Count > 0)
            {
                //Récupération du coureur sélectionné
                int selectedRowIndex = this.dataGridViewParticipants.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewParticipants.Rows[selectedRowIndex];
                int numLicenceSelection = Convert.ToInt32(selectedRow.Cells[0].Value);
                //On retire le coureur de la liste des participants et on l'ajoute aux coureurs non participants
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
            //Mise à jour de l'affichage des gridview
            AfficherContenu();
        } 

        /// <summary>
        /// Fonction gérant la fermeture de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
