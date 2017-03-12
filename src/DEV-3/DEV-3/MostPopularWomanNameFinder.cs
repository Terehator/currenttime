using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_3
{
    /// <summary>
    /// Find most popular female name 
    /// </summary>
    class MostPopularWomanNameFinder
    {
        public string findMostPopularWomanName(List<User> listOfUsers)
        {
            List<User> females = listOfUsers.Where(user => user.getGender() == "female").ToList();
            UserOutputer o = new UserOutputer();
            o.outputListOfUsers(females);
            if (females.Count == 0)
                return "no females";
            else
                return females.GroupBy(user => user.getName()).OrderBy(users => users.Count()).Last().Key;
        }
    }
}
