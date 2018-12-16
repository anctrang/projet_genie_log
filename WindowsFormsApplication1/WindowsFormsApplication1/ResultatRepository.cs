using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace DAL
{
    public class ResultatRepository : Repository, IResultatRepository
    {
        public IList<Resultat> GetAll()
        {
            return Session.Query<Resultat>().ToList();
        }

        public void Save(Resultat resultat)
        {
            Session.SaveOrUpdate(resultat);
            Session.Flush();
        }

        public void Delete(Resultat resultat)
        {
            Session.Delete(resultat);
            Session.Flush();
        }

        public IList<Resultat> listeResultat(int idCourse, int numLicence)
        {
            return Session.Query<Resultat>().Where(p => p.LaCourse.Id == idCourse && p.LeCoureur.NumLicence==numLicence).ToList();
        }

        public IList<Resultat> ListeResultatsCourse(int idCourse)
        {
           
           return Session.Query<Resultat>().Where(p => p.LaCourse.Id == idCourse).ToList();
            
        }

        public IList<Resultat> ListeResultatsCoureur(int numLicence)
        {

            return Session.Query<Resultat>().Where(c => c.LeCoureur.NumLicence == numLicence).ToList();

        }

        // public 
    }
}
