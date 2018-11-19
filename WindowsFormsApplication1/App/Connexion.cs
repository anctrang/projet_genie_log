﻿using System;
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
    public partial class Connexion : Form
    {
        
        public Connexion(Button button)
        {
            InitializeComponent();
        }

        public bool VerificationLogin(string identifiant, string mdp, IList<Utilisateur> ListeUtilisateurs)
        {

            bool existe = false;

            foreach (Utilisateur u in ListeUtilisateurs)
            {

                if (u.Pseudo == identifiant && u.MotDePasse == mdp)
                    existe = true;

            }
            
            return existe;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            UtilisateurRepository Ur = new UtilisateurRepository();
            IList<Utilisateur> listeUtilisateurs = Ur.GetAll();

            bool utilisateurConnu = VerificationLogin(textBoxId.Text, textBoxMdp.Text, listeUtilisateurs);
            if (utilisateurConnu)
            {
                Program.identifiantEnregistre = textBoxId.Text;                
                MessageBox.Show("Connexion réussie !");
                this.Close();
            }

            else
            {
                MessageBox.Show("Identifiant incorrect");
            }

            


        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
