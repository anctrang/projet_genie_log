using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CourseRepository : Repository, ICourseRepository
    {

        public IList<Course> GetAll()
        {
            return Session.Query<Course>().ToList();
        }

        public Course GetCourse(int idCourse)
        {

            List<Course> LCourse= Session.Query<Course>().Where(c => c.Id == idCourse).ToList();
            return LCourse[0];
        }

        public List<Course> GetListCourse(int idCourse)
        {

            List<Course> LCourse = Session.Query<Course>().Where(c => c.Id == idCourse).ToList();
            return LCourse;
            
        }

        public void Save(Course course)
        {
            Session.SaveOrUpdate(course);
            Session.Flush();
        }

        public void Delete(Course course)
        {
            Session.Delete(course);
            Session.Flush();
        }
    }
}
