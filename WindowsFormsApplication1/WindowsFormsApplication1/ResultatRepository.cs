using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace DAL
{
    /// <summary>
    /// Classe permettant de gérer les résultats en bdd
    /// </summary>
    public class ResultatRepository : Repository, IResultatRepository
    {
        /// <summary>
        /// Fonction permettant de récupérer la liste des résultats en bdd
        /// </summary>
        /// <returns></returns>
        public IList<Resultat> GetAll()
        {
            return Session.Query<Resultat>().ToList();
        }

        /// <summary>
        /// Fonction permettant de mettre à jour ou ajouter un résultat en bdd
        /// </summary>
        /// <param name="resultat"></param>
        public void Save(Resultat resultat)
        {
            Session.SaveOrUpdate(resultat);
            Session.Flush();
        }

        /// <summary>
        /// Fonction permettant de supprimer un résultat en bdd
        /// </summary>
        /// <param name="resultat"></param>
        public void Delete(Resultat resultat)
        {
            Session.Delete(resultat);
            Session.Flush();
        }

        /// <summary>
        /// Fonction permettant de récupérer un résultat selon l'id de sa course et le numLicence de son coureur (ajouter [0])
        /// </summary>
        /// <param name="idCourse"></param>
        /// <param name="numLicence"></param>
        /// <returns></returns>
        public IList<Resultat> listeResultat(int idCourse, int numLicence)
        {
            return Session.Query<Resultat>().Where(p => p.LaCourse.Id == idCourse && p.LeCoureur.NumLicence==numLicence).ToList();
        }

        /// <summary>
        /// Fonction permettant de récupérer un résultat selon l'id de sa course et le numDossard de son coureur (ajouter [0])
        /// </summary>
        /// <param name="numDossard"></param>
        /// <param name="idCourse"></param>
        /// <returns></returns>
        public IList<Resultat> ListeResultatAvecDossard(int numDossard, int idCourse)
        {

            return Session.Query<Resultat>().Where(p => p.NumDossard == numDossard && p.LaCourse.Id==idCourse).ToList();

        }

        /// <summary>
        /// Fonction permettant de récupérer la liste des résultats d'une course grâce à l'id de la course
        /// </summary>
        /// <param name="idCourse"></param>
        /// <returns></returns>
        public IList<Resultat> ListeResultatsCourse(int idCourse)
        {
           
           return Session.Query<Resultat>().Where(p => p.LaCourse.Id == idCourse).ToList();
            
        }

        /// <summary>
        /// Fonction permettant de récupérer la liste des résultat d'un coureur grâce à son numLicence
        /// </summary>
        /// <param name="numLicence"></param>
        /// <returns></returns>
        public IList<Resultat> ListeResultatsCoureur(int numLicence)
        {
            return Session.Query<Resultat>().Where(c => c.LeCoureur.NumLicence == numLicence).ToList();
        }
    }
}
