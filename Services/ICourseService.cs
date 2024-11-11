using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICourseService
    {
        List<Course> GetCourses();
        void DeleteCourse(Course course);
        void UpdateCourse(Course course);
        void CreateCourse(Course course);
        List<int> GetCredits();
        Course GetCourseById(int id);
    }
}
