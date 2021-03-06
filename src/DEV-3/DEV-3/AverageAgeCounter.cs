﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_3
{
    /// <summary>
    /// Count average age of users
    /// </summary>
    class AverageAgeCounter
    {
        public float countAverageAge(List<User> listOfUsers)
        {
            return listOfUsers.Sum(user => user.getAge()) / listOfUsers.Count;
        }
    }
}
