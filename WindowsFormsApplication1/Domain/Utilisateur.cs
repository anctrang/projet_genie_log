using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {

        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Pseudo
        {
            get;
            set;
        }

        public virtual string MotDePasse
        {
            get;
            set;
        }

       
    }
}
