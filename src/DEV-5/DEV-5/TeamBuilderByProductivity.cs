using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class TeamBuilderByProductivity: ICriteria
    {
        private int productivity;
        public TeamBuilderByProductivity(int productivity)
        {
            if (productivity >= 0)
                this.productivity = productivity;
        }
        /// <summary>
        /// Make new list with only usefull qulifications
        /// Usefull - if we can't find equivalent
        /// </summary>
        /// <param name="ql"></param>
        /// <returns></returns>
        private List<Qualification> removeBadQualifications(List<Qualification> ql)
        {
            List<Qualification> newQl = new List<Qualification>();
            newQl.Add(ql[0]);
            for (int i = 1; i < ql.Count; i++)
            {
                if (ql[i].Sallary < (ql[i].Productivity / newQl.Last().Productivity) * newQl.Last().Sallary)
                    newQl.Add(ql[i]);
            }
            return newQl;
        }
        public Dictionary<Qualification, int> buildTeam(List<Qualification> ql)
        {
            ql.Sort();
            List<Qualification> newQl = removeBadQualifications(ql);
            Dictionary<Qualification, int> team = new Dictionary<Qualification, int>();
            int currentProductivity = 0;
            for (int i = newQl.Count - 1; i >= 0; i--)
            {
                team.Add(newQl[i], 0);
                while (productivity - currentProductivity >= 0)
                {
                    team[newQl[i]]++;
                    currentProductivity += newQl[i].Productivity;
                }
            }
            return team;
        }
    }
}
