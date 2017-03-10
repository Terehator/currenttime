using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DEV_10
{
    class Program
    {
        const string CONF_FILEPATH = "config.json";
        static void Main(string[] args)
        {
            ConfigReader confReader = new ConfigReader();
            JSONParser parser = new JSONParser();
            string inputFilepath = string.Empty;
            string outputFilepath = string.Empty;
            try
            {
                confReader.getFilepathes(CONF_FILEPATH, parser, ref inputFilepath, ref outputFilepath);
                OrderReader reader = new OrderReader();
                List<Order> list = reader.Read(inputFilepath, parser);
                JSONBuilder builder = new JSONBuilder();
                OrderWriter writer = new OrderWriter();
                writer.Write(list, outputFilepath, builder);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
