using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use CsvLoader
            XxxConfigLoader xxxConfigLoader = new CsvConfigLoader();
            Worker worker = new Worker(xxxConfigLoader);

            //Use IniLoader
            xxxConfigLoader = new IniConfigLoader();
            worker = new Worker(xxxConfigLoader);

            Console.Read();
        }
    }
}
