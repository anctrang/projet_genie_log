using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {

        public Utilisateur() { }

        public Utilisateur(string pseudo, string mdp)
        {
            this.Pseudo = pseudo;
            this.MotDePasse = mdp;
        }

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
