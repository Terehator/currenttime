using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    /// <summary>
    /// Get a criteria
    /// </summary>
    class CriteriaGetter
    {
        string[] criterias = { "by salary", "by productivity", "by minimum elder employees" };
        public ICriteria getCriteria()
        {
            Console.WriteLine("Choose your criteria(input a number):");
            for (int i = 0; i < criterias.Length; i++)
            {
                Console.WriteLine("{0} - {1};", i, criterias[i]);
            }
            switch (Console.ReadLine())
            {
                case "0": 
                {
                    Console.WriteLine("Input salary");
                    string input = Console.ReadLine();
                    int salary = 0;
                    while (!int.TryParse(input, out salary) || salary < 0)
                    {
                        Console.WriteLine("Not allowed format");
                        input = Console.ReadLine();
                    }
                    return new TeamBuilderBySalary(salary);
                }
                case "1": 
                {
                    Console.WriteLine("Input productivity");
                    string input = Console.ReadLine();
                    int productivity = 0;
                    while (!int.TryParse(input, out productivity) || productivity < 0)
                    {
                        Console.WriteLine("Not allowed format");
                        input = Console.ReadLine();
                    }
                    return new TeamBuilderByProductivity(productivity);
                }
                case "2": 
                {
                    Console.WriteLine("Input productivity");
                    string input = Console.ReadLine();
                    int productivity = 0;
                    while (!int.TryParse(input, out productivity) || productivity < 0)
                    {
                        Console.WriteLine("Not allowed format");
                        input = Console.ReadLine();
                    } 
                    return new TeamBuilderByQualification(productivity);
                }
                default:
                {
                    return null;
                }
            }
        }
    }
}
