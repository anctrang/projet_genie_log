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
       
    }
}
