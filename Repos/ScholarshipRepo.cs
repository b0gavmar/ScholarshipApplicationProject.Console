using ScholarshipApplicationProject.Console.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipApplicationProject.Console.Repos
{
    public class ScholarshipRepo
    {
        private readonly ScholarshipContext _context = new();

        public int GetNumberOfScholarships()
        {
            return _context.Scholarships.Count();
        }


    }
}
