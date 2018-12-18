using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Classe permettant de récupérer les coureurs en bdd
    /// </summary>
    public class CoureurRepository : Repository, ICoureurRepository
    {
        /// <summary>
        /// Fonction récupérant la liste des coureurs en bdd
        /// </summary>
        /// <returns></returns>
        public IList<Coureur> GetAll()
        {
            return Session.Query<Coureur>().ToList();
        }

        /// <summary>
        /// Fonction permettant de récupérer un coureur selon son numéro de licence (ajouter [0] pour le récupérer)
        /// </summary>
        /// <param name="numLicence"></param>
        /// <returns></returns>
        public IList<Coureur> ListeCoureur(int numLicence)
        {

            return Session.Query<Coureur>().Where(c=> c.NumLicence == numLicence).ToList();

        }

        /// <summary>
        /// Fonction permettant de récupérer un coureur grâce à son nom (ajouter [0])
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public IList<Coureur> ListeCoureurAvecNom(string nom)
        {

            return Session.Query<Coureur>().Where(c => c.Nom == nom).ToList();

        }

        /// <summary>
        /// Fonction permettant d'ajouter/modifier un coureur en bdd
        /// </summary>
        /// <param name="coureur"></param>
        public void Save(Coureur coureur)
        {
            Session.SaveOrUpdate(coureur);
            Session.Flush();
        }   
        
        public void Delete(Coureur coureur)
        {

            Session.Delete(coureur);
            Session.Flush();
        }
    }
}
