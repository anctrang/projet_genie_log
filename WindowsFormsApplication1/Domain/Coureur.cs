using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Classe coureur
    /// </summary>
   public class Coureur
    {
        /// <summary>
        /// Attribut NumLicence d'un coureur
        /// </summary>
        public virtual int NumLicence
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut date de naissance d'un coureur
        /// </summary>
        public virtual DateTime DateDeNaissance
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut prenom d'un coureur
        /// </summary>
        public virtual string Prenom
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut Nom d'un coureur
        /// </summary>
        public virtual string Nom
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut sexe d'un coureur
        /// </summary>
        public virtual string Sexe
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut courriel d'un coureur
        /// </summary>
        public virtual string Courriel
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut lesRésultats (liste de résultats) d'un coureur
        /// </summary>
        public virtual List<Resultat> LesResultats
        {
            get;
            set;
        }

        /// <summary>
        /// Fonction permettant de calculer l'age d'un joueur
        /// </summary>
        /// <param name="coureur"></param>
        /// <returns></returns>
        public virtual int CalculAge(Coureur coureur)
        {
            return  DateTime.Now.Year - coureur.DateDeNaissance.Year -
                         (DateTime.Now.Month < coureur.DateDeNaissance.Month ? 1 :
                         (DateTime.Now.Month == coureur.DateDeNaissance.Month && DateTime.Now.Day < coureur.DateDeNaissance.Day) ? 1 : 0);
        }

    }
}
