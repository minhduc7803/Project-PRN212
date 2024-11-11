using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IMarkService
    {
        void addMark(Mark mark);
        void updateMark(Mark mark);
        List<Mark>? getMark(int enrollmentId);
    }
}
