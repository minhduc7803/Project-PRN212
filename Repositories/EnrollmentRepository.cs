using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        public void addEnrollment(int studentId, int courseId, int semesterId) => EnrollmentDAO.addEnrollment(studentId, courseId, semesterId);        

        public List<Enrollment> getEnrollment() => EnrollmentDAO.getEnrollment();  
    }
}
