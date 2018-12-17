﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Domain
{
    /// <summary>
    /// Clase course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Course()
        {

        }

        /// <summary>
        /// Constructreur
        /// </summary>
        /// <param name="lieu"></param>
        /// <param name="distance"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        public Course(string lieu, double distance, string description, DateTime date)
        {
            this.Lieu = lieu;
            this.Distance = distance;
            this.Description = description;
            this.Date = date;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lieu"></param>
        /// <param name="distance"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        public Course(int id,string lieu, double distance, string description, DateTime date)
        {
            this.Id = id;
            this.Lieu = lieu;
            this.Distance = distance;
            this.Description = description;
            this.Date = date;
        }

        /// <summary>
        /// Attribut lieu d'une course
        /// </summary>
        public virtual string Lieu
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut id d'une course
        /// </summary>
        public virtual int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut Date d'une course
        /// </summary>
        public virtual DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut Description d'une course
        /// </summary>
        public virtual string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut Distance d'une course
        /// </summary>
        public virtual double Distance
        {
            get;
            set;
        }

        /// <summary>
        /// Attribut lesResultats d'une course
        /// </summary>
        public virtual List<Resultat> LesResultats
        {
            get;
            set;
        }
    }
}