using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    class Program
    {
        static void Main(string[] args)
        {
            IniFileExplorer iniExplorer;
            Inputer inputer = new Inputer();
            if (args.Length != 0) 
                iniExplorer = new IniFileExplorer(args[0]);
            else
                iniExplorer = new IniFileExplorer(inputer.InputUntillNotEmpty("Enter filepath"));
            string section = inputer.InputUntillNotEmpty("Enter section");
            string key = inputer.InputUntillNotEmpty("Enter key");
            try
            {
                Console.WriteLine(iniExplorer.GetValueBySectionAndKey(section, key));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Incorrect name of file");
            }
            catch (SectionNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
