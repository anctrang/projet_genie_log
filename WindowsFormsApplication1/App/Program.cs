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
            CourseRepository courseRepository = new CourseRepository();
            ResultatRepository resultatRepository = new ResultatRepository();
            Accueil accueil = new Accueil(utilisateurRepository,courseRepository,resultatRepository);
            Application.Run(accueil);
                
            
        }
    }
}
