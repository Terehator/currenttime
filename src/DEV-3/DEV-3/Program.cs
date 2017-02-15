using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    /// <summary>
    /// Main class 
    /// Show work of the program
    /// </summary>
    class Program
    {
        private static void printAverageAge(List<User> usersList)
        {
            AverageAgeCounter counter = new AverageAgeCounter();
            Console.WriteLine("Average age: " + counter.countAverageAge(usersList));
        }
        private static void printOldestUsers(List<User> usersList, UserOutputer userOutputer)
        {
            ElderUserCounter elderUserCounter = new ElderUserCounter();
            Console.WriteLine("User with max age:");
            userOutputer.outputListOfUsers(elderUserCounter.getOldestUser(usersList)); //Output users with max age
        }
        private static void printMostPopularWomanName(List<User> usersList)
        {
            MostPopularWomanNameFinder mostPopularWomanNameFinder = new MostPopularWomanNameFinder();
            Console.WriteLine("Most popular woman name: " + mostPopularWomanNameFinder.findMostPopularWomanName(usersList));
        }
        private static void printHomonyms(List<User> usersList, UserOutputer userOutputer)
        {
            HomonymFinder homonymFinder = new HomonymFinder();
            Console.WriteLine("Homonyms: ");
            userOutputer.outputListOfUsers(homonymFinder.findHomonyUsers(usersList));
        }
        static void Main(string[] args)
        {
            UserInputer userInputer = new UserInputer();
            UserOutputer userOutputer = new UserOutputer();
            Checker checker = new Checker();
            List<User> usersList = userInputer.inputListOfUsers(checker);
            printAverageAge(usersList);
            printOldestUsers(usersList, userOutputer);
            printMostPopularWomanName(usersList);
            printHomonyms(usersList, userOutputer);
            Console.ReadKey();
        }
    }
}
