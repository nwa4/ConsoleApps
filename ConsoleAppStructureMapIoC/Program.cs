using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using ShoppingLib;


namespace ConsoleAppStructureMapIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(new MyRegistry());
            //var shopper = new Shopper();
            //var container = new Container(x => x.For<ICreditCard>().Singleton().Use<MasterCard>().Named("Master"));
            ////container.Configure(x => x.For<ICreditCard>().Use<MasterCard>());
            //container.Configure(x => x.For<ICreditCard>().Use<Visa>().Named("Visa"));

            var shopper = container.GetInstance<Shopper>();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard());

            var shopper2 = container.GetInstance<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCard());

            Console.WriteLine(container.WhatDoIHave());

            Console.Read();
        }
    }
}
