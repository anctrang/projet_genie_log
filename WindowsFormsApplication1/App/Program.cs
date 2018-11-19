using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Accueil accueil = new Accueil();
            Application.Run(accueil);
                
            
        }
    }
}
