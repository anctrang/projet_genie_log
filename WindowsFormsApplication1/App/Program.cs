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
            UtilisateurRepository utilisateurRepository = new UtilisateurRepository();
            CourseRepository courseRepository = new CourseRepository();
            ResultatRepository resultatRepository = new ResultatRepository();
            CoureurRepository coureurRepository = new CoureurRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Accueil accueil = new Accueil(utilisateurRepository,courseRepository,resultatRepository, coureurRepository);
            Application.Run(accueil);
                
            
        }
    }
}
