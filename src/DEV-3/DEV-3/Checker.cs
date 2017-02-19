using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_3
{
    class Checker
    {
        public bool isNameCorrect(string name)
        {
            if (name.All(c => char.IsLetter(c)))
                return true;
            else
                return false;
        }


        public bool isGenderCorrect(string gender)
        {
            if (gender == "male" || gender == "female")
                return true;
            else
                return false;
        }
        
        
        public bool isAgeCorrect(int age)
        {
            if (age >= 0 && age <= 100)
                return true;
            else
                return false;
        }
    }
}
