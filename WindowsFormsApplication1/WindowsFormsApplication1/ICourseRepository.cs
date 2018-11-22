using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface ICourseRepository
    {
        IList<Course> GetAll();
        void Save(Course course);
    }
}
