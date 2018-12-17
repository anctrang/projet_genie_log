using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CoureurRepository : Repository, ICoureurRepository
    {
        public IList<Coureur> GetAll()
        {
            return Session.Query<Coureur>().ToList();
        }

        public IList<Coureur> ListeCoureur(int numLicence)
        {

            return Session.Query<Coureur>().Where(c=> c.NumLicence == numLicence).ToList();

        }

        public IList<Coureur> ListeCoureurAvecNom(string nom)
        {

            return Session.Query<Coureur>().Where(c => c.Nom == nom).ToList();

        }

        public void Save(Coureur coureur)
        {
            Session.SaveOrUpdate(coureur);
            Session.Flush();
        }

       
    }
}
