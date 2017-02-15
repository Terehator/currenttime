using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// Find oldest users
    /// </summary>
    class ElderUserCounter
    {
        public List<User> getOldestUser(List<User> listOfUsers)
        {
            int max = listOfUsers.Max(user => user.getAge());
            return listOfUsers.Where(user => user.getAge() == max).ToList<User>();
        }
    }
}
