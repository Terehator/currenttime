using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// Main class
    /// Show functionality
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            QualificationChecker qc = new QualificationChecker();
            List<Qualification> ql = new List<Qualification>();
            ql.Add(new Qualification(qc, "Junior", 300, 20));
            ql.Add(new Qualification(qc, "Middle", 500, 40));
            ql.Add(new Qualification(qc, "Senior", 900, 80));
            ql.Add(new Qualification(qc, "Lead", 1500, 160));
            CriteriaGetter criteriaGetter = new CriteriaGetter();
            TeamOutputer teamOutputer = new TeamOutputer();
            teamOutputer.OutputTeam(ql, criteriaGetter.getCriteria());
            Console.ReadKey();
        }
    }
}
