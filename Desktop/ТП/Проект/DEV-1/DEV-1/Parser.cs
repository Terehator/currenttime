using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Parser
    {
        public static ArrayList parseArrayToArrayList(string[] options)
        {
            ArrayList result = new ArrayList();
            foreach(string option in options)
            {
                result.Add(option);
            }
            return result;
        }
    }
}
