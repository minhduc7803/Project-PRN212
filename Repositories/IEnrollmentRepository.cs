using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IEnrollmentRepository
    {
        List<Enrollment> getEnrollment();

        void addEnrollment(int studentId, int courseId, int semesterId);
    }
}
