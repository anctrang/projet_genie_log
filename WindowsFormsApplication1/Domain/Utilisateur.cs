using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Classe Utilisateur
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur() { }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pseudo"></param>
        /// <param name="mdp"></param>
        public Utilisateur(string pseudo, string mdp)
        {
            this.Pseudo = pseudo;
            this.MotDePasse = mdp;
        }

        /// <summary>
        /// Attribut id d'un utilisateur
        /// </summary>
        public virtual int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut Pseudo d'un utilisateur
        /// </summary>
        public virtual string Pseudo
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut Mot de passe d'un utilisateur
        /// </summary>
        public virtual string MotDePasse
        {
            get;
            set;
        }

        /// <summary>
        /// Fonction permettant de vérifier si le mot de passe est suffisamment sécurisé
        /// </summary>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public virtual bool VerificationMotDePasse(string mdp)
        {
            int compteur = 1;
            bool majuscule = false;
            bool chiffre = false;
            bool caractereSpe = false;
            bool minuscule = false;
            bool longueur = false;

           
            foreach (char c in mdp)
            {
                //Vérifie s'il y a un caractère spécial
                if ((int)c >= 33 && (int)c <= 47 || (int)c >= 58 && (int)c <= 64 || (int)c >= 91 && (int)c <= 96)
                {
                    caractereSpe = true;
                }
                // Vérifie s'il y a un chiffre
                if ((int)c >= 48 && (int)c <= 57)
                {
                    chiffre = true;
                }
                // vérifie s'il y a une majuscule
                if ((int)c >= 65 && (int)c <= 90)
                {
                    majuscule = true;
                }
                // vérifie s'il y a une minuscule
                if ((int)c >= 97 && (int)c <= 122)
                {

                    minuscule = true;
                }
                // Vérifie si la longueur du mdp est a + de 6 caractères
                if (compteur >= 6)
                {
                    longueur = true;
                }
                compteur++;

            }
            if (!minuscule || !majuscule || !chiffre || !caractereSpe || !longueur)
            {
                return true;
            }

            else
                return false;
        }
       
    }
}
