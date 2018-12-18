using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculTempsEnSecondes()
        {
            TimeSpan t = new TimeSpan(1, 0, 0);
            Resultat resultat = new Resultat();
            int temps = resultat.CalculTempsEnSeconde(t);
            //TimeSpan représentant 1 h -> 3600 secondes

            //int temps = t.Seconds + t.Minutes * 60 + t.Hours * 60 * 60;
            Assert.AreEqual(temps, 3600);

            TimeSpan t1 = new TimeSpan(20,14,20); // 20h14min20sec -> 72860
            int temps1 = resultat.CalculTempsEnSeconde(t1);
            Console.WriteLine(temps1.ToString());
            Assert.AreEqual(temps1, 72860);


        }

        [TestMethod]
        public void TestCalculVitesseMoyenne()
        {
            Resultat resultat = new Resultat();
            resultat.TempsEnSecondes = 3600;
            int distance = 1000;           
            double vitesse =  resultat.CalculVitesseMoyenne(distance) ; //Doit être 1
            Assert.AreEqual(vitesse, 1);


            distance = 30000;
            resultat.TempsEnSecondes = 7200;
            vitesse = resultat.CalculVitesseMoyenne(distance); //Doit être 15
            Assert.AreEqual(vitesse, 15);
        }

        [TestMethod]
        public void TestCalculAllureMoyenne()
        {
            Resultat resultat = new Resultat();
            resultat.TempsEnSecondes = 60000;
            int distance = 10000;
            double Allure = resultat.CalculAllureMoyenne(distance);
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
