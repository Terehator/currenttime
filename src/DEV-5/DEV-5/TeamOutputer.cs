using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class TeamOutputer
    {
        public void OutputTeam(List<Qualification> ql, ICriteria builder)
        {
            if (builder == null)
            {
                Console.WriteLine("Nothing has been choosen");
            }
            else
            {
                Console.WriteLine("Team is:");
                int productivity = 0;
                int salary = 0;
                foreach (KeyValuePair<Qualification, int> qualificationTeam in builder.buildTeam(ql))
                {
                    Console.Write("{0}: {1}; ", qualificationTeam.Key.Name, qualificationTeam.Value);
                    productivity += qualificationTeam.Key.Productivity * qualificationTeam.Value;
                    salary += qualificationTeam.Key.Sallary * qualificationTeam.Value;
                }
                Console.WriteLine("Salary is {0}, productivity is {1};", salary, productivity);
            }
        }
    }
}
