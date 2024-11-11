using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MarkRepository : IMarkRepository
    {
        public void addMark(Mark mark) => MarksDAO.addMark(mark);        

        public List<Mark>? getMark(int enrollmentId) => MarksDAO.getMark(enrollmentId);

        public void updateMark(Mark mark) => MarksDAO.updateMark(mark);  
    }
}
