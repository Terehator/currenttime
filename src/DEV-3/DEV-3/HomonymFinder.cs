using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// Find homonym users
    /// </summary>
    class HomonymFinder
    {
        public List<User> findHomonyUsers(List<User> listOfUsers)
        {
            List<IGrouping<string, User>> homonymUsers = listOfUsers.GroupBy(user => user.getSurname()).Where(users => users.Count() > 1).ToList();
            return homonymUsers.SelectMany(user => user).ToList();
        }
    }
}
