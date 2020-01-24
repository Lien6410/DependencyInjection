using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface XxxConfigLoader
    {
        XxxConfig GetXxxConfig();
    }    

    public class CsvConfigLoader : XxxConfigLoader
    {
        public XxxConfig GetXxxConfig()
        {
            XxxConfig xxxConfig = new XxxConfig();
            //Do some load file
            Console.WriteLine("Load a xxx config from csv file.");
            return xxxConfig;
        }
    }

    public class IniConfigLoader : XxxConfigLoader
    {
        public XxxConfig GetXxxConfig()
        {
            XxxConfig xxxConfig = new XxxConfig();
            //Do some load file
            Console.WriteLine("Load a xxx config from ini file.");
            return xxxConfig;
        }
    }
}
