using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public void CreateCourse(Course course) => CourseDAO.CreateCourse(course);

        public void DeleteCourse(Course course) => CourseDAO.DeleteCourse(course);        

        public Course GetCourseById(int id) => CourseDAO.GetCourseById(id);

        public List<Course> GetCourses() => CourseDAO.GetCourses();

        public List<int> GetCredits() => CourseDAO.GetCredits();

        public void UpdateCourse(Course course) => CourseDAO.UpdateCourse(course);
    }
}
