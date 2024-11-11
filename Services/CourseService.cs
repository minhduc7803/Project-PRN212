using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        public CourseService()
        {
            courseRepository = new CourseRepository();
        }
        public void CreateCourse(Course course)
        {
            courseRepository.CreateCourse(course);
        }

        public void DeleteCourse(Course course)
        {
            courseRepository.DeleteCourse(course);
        }

        public Course GetCourseById(int id)
        {
            return courseRepository.GetCourseById(id);
        }

        public List<Course> GetCourses()
        {
            return courseRepository.GetCourses();
        }

        public List<int> GetCredits()
        {
            return courseRepository.GetCredits();
        }

        public void UpdateCourse(Course course)
        {
            courseRepository.UpdateCourse(course);
        }
    }
}
