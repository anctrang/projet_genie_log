using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IResultatRepository
    {
        IList<Resultat> GetAll();
        void Save(Resultat resultat);
    }
}
