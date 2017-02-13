using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class LineGetter
    {
        private string numberSymbols = "1234567890,.e+-";
        private string signsSymbols = "*-+/";
        private List<float> numbers = new List<float>();
        private ArrayList signes = new ArrayList();
        public List<float> getNumbers()
        {
            return numbers;
        }
        public ArrayList getSignes()
        {
            return signes;
        }
        private bool symbolIsSign(char symbol)
        {
            return signsSymbols.Contains(symbol);
        }
        private bool symbolIsNumber(char symbol)
        {
            return numberSymbols.Contains(symbol);
        }
        private bool checkSignUsage(string line, int i)
        {
            if ((i != 0) && (i != line.Length - 1))
            {
                return (symbolIsSign(line[i])
                    && !symbolIsSign(line[i - 1])
                    && (line[i - 1] != 'e')
                    && (symbolIsSign(line[i + 1]) || (line[i + 1] == '-'))); 
            }
            else
                return false;
        }
        private bool isParseble(string line) //Parse line to arrays of numbers and signes, and return its parsebality
        {
            numbers.Clear();
            signes.Clear();
            bool flagOfPermit = true;
            line = line.Replace(" ", string.Empty);
            string number = "";
            if (line.Length == 0)
            {
                flagOfPermit = false;
            }
            else
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (checkSignUsage(line, i) == true)
                    {
                        try
                        {
                            numbers.Add(float.Parse(number));
                            number = "";
                            signes.Add(line[i]);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(line[i]);
                            Console.WriteLine("Not parsable numbers!");
                            flagOfPermit = false;
                            break;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Too big numbers!");
                            flagOfPermit = false;
                            break;
                        }
                    }
                    else
                    {
                        if (numberSymbols.Contains(line[i]) == true)
                        {
                            if (line[i] == '.')
                                number += ',';
                            else
                                number += line[i];
                        }
                        else
                        {
                            Console.WriteLine("Expression has unallowable format!");
                            flagOfPermit = false;
                            break;
                        }
                    }
                }
            }
            if (flagOfPermit == true)
            {
                try
                {
                    numbers.Add(float.Parse(number));
                    number = "";
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not parsable numbers!");
                    flagOfPermit = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Too big numbers!");
                    flagOfPermit = false;
                }
            }
            return flagOfPermit;
        }
        public bool isLineGettingSuccesfull(string[] args) //Get line from console and return succes of operation
        {
            string line = "";
            if (args.Length == 0)
            {
                do
                {
                    Console.WriteLine("Input your expression");
                    line = Console.ReadLine();
                }
                while (isParseble(line) == false);
                return true;
            }
            else
            {
                foreach (string arg in args)
                {
                    line = line + arg;
                }
                if (isParseble(line) == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
