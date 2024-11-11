using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MarkService : IMarkService
    {
        private readonly IMarkRepository markRepository;
        public MarkService()
        {
            markRepository = new MarkRepository();
        }
        public void addMark(Mark mark)
        {
            markRepository.addMark(mark);
        }

        public List<Mark>? getMark(int enrollmentId)
        {
            return markRepository.getMark(enrollmentId);
        }

        public void updateMark(Mark mark)
        {
            markRepository.updateMark(mark);
        }
    }
}
