using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculTempsEnSecondes()
        {
            //TimeSpan représentant 1 h -> 3600 secondes
            TimeSpan t = new TimeSpan(1, 0, 0); 
            int temps = t.Seconds + t.Minutes * 60 + t.Hours * 60 * 60;
            Assert.AreEqual(temps, 3600);

            TimeSpan t1 = new TimeSpan(20,14,20); // 20h14min20sec -> 72860
            int temps1 = t1.Seconds + t1.Minutes * 60 + t1.Hours * 60 * 60;
            Console.WriteLine(temps1.ToString());
            Assert.AreEqual(temps1, 72860);


        }

        [TestMethod]
        public void TestCalculVitesseMoyenne()
        {
            int distance = 1000;
            int tempsEnSecondes = 3600;
            double vitesse =  (distance / 1000)/(tempsEnSecondes / 60/60) ; //Doit être 1
            Assert.AreEqual(vitesse, 1);


            distance = 30000;
            tempsEnSecondes = 7200;
            vitesse =   (distance / 1000)/(tempsEnSecondes / 60 / 60); //Doit être 15
            Assert.AreEqual(vitesse, 15);
        }

        [TestMethod]
        public void TestCalculAllureMoyenne()
        {
            int tempsEnSecondes = 60000;
            int distance = 10000;
            double Allure = (tempsEnSecondes / 60) / (distance / 1000);
            Assert.AreEqual(Allure, 100);

            
        }

        [TestMethod]
        public void TestCalculAge()
        {
            DateTime date = new DateTime(1994, 6, 22);
            int age = DateTime.Now.Year - date.Year -
                         (DateTime.Now.Month < date.Month ? 1 :
                         (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day) ? 1 : 0);
            Assert.AreEqual(age, 24);

            date = new DateTime(1996, 12, 14);
            age = DateTime.Now.Year - date.Year -
                         (DateTime.Now.Month < date.Month ? 1 :
                         (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day) ? 1 : 0);
            Assert.AreEqual(age, 22);
        }
    }
}
