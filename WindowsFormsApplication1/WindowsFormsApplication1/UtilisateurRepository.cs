using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Classe permettant de gérer les utilisateurs de la bdd
    /// </summary>
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        /// <summary>
        /// FOnction permettant de récupérer tous les utilisateurs de la bdd
        /// </summary>
        /// <returns></returns>
        public IList<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        /// <summary>
        /// Fonction permettant de mettre à jour ou de sauvegarder un utilisateur en bdd
        /// </summary>
        /// <param name="utilisateur"></param>
        public void Save (Utilisateur utilisateur)
        {
            Session.SaveOrUpdate(utilisateur);
            Session.Flush();
        }
    }
}
