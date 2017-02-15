using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Input users fields
    /// </summary>
    class UserInputer
    {
        private string inputName(Checker checker)
        {
            string temp;
            do
            {
                Console.WriteLine("Input name(only letters are allowed)");
                temp = Console.ReadLine();
            }
            while (!checker.isNameCorrect(temp));
            return temp;
        }


        private string inputSurname(Checker checker)
        {
            string temp;
            do
            {
                Console.WriteLine("Input surname(only letters are allowed)");
                temp = Console.ReadLine();
            }
            while (!checker.isNameCorrect(temp));
            return temp;
        }
        
        
        private string inputGender(Checker checker)
        {
            string temp;
            do
            {
                Console.WriteLine("Input gender(only male or female are allowed)");
                temp = Console.ReadLine();
            }
            while (!checker.isGenderCorrect(temp)); //Checking rules for name and surname are the same
            return temp;
        }
        
        
        private int inputAge(Checker checker)
        {
            string temp;
            do
            {
                Console.WriteLine("Input age(only number beetween 0 and 100 are allowed)");
                temp = Console.ReadLine();
            }
            while (!checker.isAgeCorrect(int.Parse(temp))); //Checking rules for name and surname are the same
            return int.Parse(temp);
        }
        
        
        private User inputUser(Checker checker)
        {
            User user = new User();
            user.setName(inputName(checker));
            user.setSurname(inputSurname(checker));
            user.setGender(inputGender(checker));
            user.setAge(inputAge(checker));
            return user;
        }
        
        
        public List<User> inputListOfUsers(Checker checker)
        {
            List<User> usersList = new List<User>();
            string answer;
            do
            {
                usersList.Add(inputUser(checker));
                Console.WriteLine("To finish the input type 'exit', else type any key");
                answer = Console.ReadLine();
            } while (answer != "exit");
            return usersList;
        }
    }
}
