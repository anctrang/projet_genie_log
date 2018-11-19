using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public IList<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }
    }
}
