using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class TeamBuilderByQualification: ICriteria
    {
        int productivity;
        public TeamBuilderByQualification(int productivity)
        {
            if (productivity >= 0)
                this.productivity = productivity;
        }
        public Dictionary<Qualification, int> buildTeam(List<Qualification> ql)
        {
            ql.Sort();
            Dictionary<Qualification, int> team = new Dictionary<Qualification, int>();
            int currentProductivity = 0;
            team.Add(ql[0], 0);
            while (currentProductivity < productivity)
            {
                team[ql[0]]++;
                currentProductivity += ql[0].Productivity;
            }
            return team;
        }
    }
}
