using AT_FRAMEWORK.Comands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_FRAMEWORK.CommandBuilders
{
    class ComandCreator
    {
        protected ComandCreator successor;
        public ComandCreator(ComandCreator successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// Return command
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public virtual IComand GetCommand(string line)
        {
            return successor.GetCommand(line);
        }
    }
}
