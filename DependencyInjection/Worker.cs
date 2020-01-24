using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Worker
    {
        private XxxConfigLoader xxxConfigLoader = null;
        private XxxConfig xxxConfig = null;

        public Worker(XxxConfigLoader xxxConfigLoader)
        {
            this.xxxConfigLoader = xxxConfigLoader;
            Setup();
        }

        private void Setup()
        {
            xxxConfig = xxxConfigLoader.GetXxxConfig();
        }
    }
}
