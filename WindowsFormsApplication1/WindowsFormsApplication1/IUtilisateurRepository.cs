﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IUtilisateurRepository
    {
       IList<Utilisateur> GetAll();
       void Save(Utilisateur utilisateur);
       
    }
}
