using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEnrollmentService
    {
        List<Enrollment> getEnrollment();
        void addEnrollment(int studentId, int courseId, int semesterId);
    }
}
