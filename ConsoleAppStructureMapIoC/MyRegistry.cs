using ShoppingLib;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStructureMapIoC
{
    class MyRegistry : Registry
    {
        public MyRegistry()
        {
            For<ICreditCard>().Singleton().Use<MasterCard>().Named("Master");
            For<ICreditCard>().Use<Visa>().Named("Visa");
        }
    }
}
