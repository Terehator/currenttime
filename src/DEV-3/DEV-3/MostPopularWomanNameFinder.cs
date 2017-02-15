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
            return listOfUsers.GroupBy(user => user.getName()).OrderBy(users => users.Count()).Last().Key;
        }
    }
}
