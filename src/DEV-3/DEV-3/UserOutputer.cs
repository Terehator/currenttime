using System;
using System.Collections.Generic;

namespace DEV_3
{
    //Class for outputing
    class UserOutputer
    {
        public void outputUser(User user)
        {
            Console.WriteLine("Name: " + user.getName());
            Console.WriteLine("Surname: " + user.getSurname());
            Console.WriteLine("Gender: " + user.getGender());
            Console.WriteLine("Age: " + user.getAge());
        }
        
        
        public void outputListOfUsers(List<User> listOfUsers)
        {
            foreach (User user in listOfUsers)
            {
                outputUser(user);
            }
        }
    }
}
