using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Coureur
    {
        public virtual int NumLicence
        {
            get;
            set;
        }

        public virtual DateTime DateDeNaissance
        {
            get;
            set;
        }

        public virtual string Prenom
        {
            get;
            set;
        }

        public virtual string Nom
        {
            get;
            set;
        }

        public virtual string Sexe
        {
            get;
            set;
        }

        public virtual string Courriel
        {
            get;
            set;
        }

        public virtual List<Resultat> LesResultats
        {
            get;
            set;
        }

    }
}
