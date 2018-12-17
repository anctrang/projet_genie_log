using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Classe gérant les courses en bdd
    /// </summary>
    public class CourseRepository : Repository, ICourseRepository
    {
        /// <summary>
        /// Récupère la liste des courses en bdd
        /// </summary>
        /// <returns></returns>
        public IList<Course> GetAll()
        {
            return Session.Query<Course>().ToList();
        }
        /// <summary>
        /// Récupère une course en fonction de son id
        /// </summary>
        /// <param name="idCourse"></param>
        /// <returns></returns>
        public Course GetCourse(int idCourse)
        {

            List<Course> LCourse= Session.Query<Course>().Where(c => c.Id == idCourse).ToList();
            return LCourse[0];
        }

        /// <summary>
        /// Récupère une course en fonction de son id
        /// </summary>
        /// <param name="idCourse"></param>
        /// <returns></returns>
        public List<Course> GetListCourse(int idCourse)
        {

            List<Course> LCourse = Session.Query<Course>().Where(c => c.Id == idCourse).ToList();
            return LCourse;
            
        }

        /// <summary>
        /// Fonction permettant de mettre à jour ou sauvegarder une course
        /// </summary>
        /// <param name="course"></param>
        public void Save(Course course)
        {
            Session.SaveOrUpdate(course);
            Session.Flush();
        }

        /// <summary>
        /// Fonction permettant de supprimer une course en bdd
        /// </summary>
        /// <param name="course"></param>
        public void Delete(Course course)
        {
            Session.Delete(course);
            Session.Flush();
        }
    }
}
