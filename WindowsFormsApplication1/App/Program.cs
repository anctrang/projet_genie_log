using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace App
{
    static class Program
    {
        public static string identifiantEnregistre = "";
  
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UtilisateurRepository utilisateurRepository = new UtilisateurRepository();
            Accueil accueil = new Accueil(utilisateurRepository);
            Application.Run(accueil);
                
            
        }
    }
}
