using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    class Inputer
    {
        /// <summary>
        /// Input untill not empty line showing a message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string InputUntillNotEmpty(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            while (result == string.Empty)
            {
                Console.WriteLine(message);
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
