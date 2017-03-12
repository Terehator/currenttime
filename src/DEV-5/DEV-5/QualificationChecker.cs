using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// Check qualification format
    /// </summary>
    class QualificationChecker
    {
        /// <summary>
        /// Check name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckName(string name)
        {
            return name.All(c => char.IsLetter(c));
        }
        /// <summary>
        /// Check sallary
        /// </summary>
        /// <param name="sallary"></param>
        /// <returns></returns>
        public bool CheckSallary(int sallary)
        {
            return (sallary >= 0);
        }
        /// <summary>
        /// Check productivity
        /// </summary>
        /// <param name="productivity"></param>
        /// <returns></returns>
        public bool CheckProductivity(int productivity)
        {
            return (productivity >= 0);
        }
    }
}
