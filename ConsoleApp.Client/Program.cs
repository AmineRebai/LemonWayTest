using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Client
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            try
            {
                localhost.WebService service = new localhost.WebService();
                Fibonacci(service);
                XmlToJson(service);
                log.Info("Terminé avec succés!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error(e.Message);
            }
        }

        public static void Fibonacci(localhost.WebService service)
        {
            int number;
            do
            {
                Console.WriteLine("Entrer un entier entre 1 et 100 :");
            } while (!int.TryParse(Console.ReadLine(), out number));
            Console.WriteLine(service.Fibonacci(number));
            log.Info("Fibonacci de " + number + " est :" + service.Fibonacci(number));
        }

        public static void XmlToJson(localhost.WebService service)
        {
            Console.WriteLine("Entrer xml :");
            string xml = Console.ReadLine();
            string json = service.XmlToJson(xml);
            Console.WriteLine(json);
            log.Info("Format json de " + xml + " est :" + json);
            Console.ReadKey();
        }
    }
}
