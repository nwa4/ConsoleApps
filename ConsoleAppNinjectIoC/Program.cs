using Ninject;
using ShoppingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNinjectIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new MyModule());
            ////kernel.Bind<ICreditCard>().To<MasterCard>().InSingletonScope();
            //kernel.Bind<ICreditCard>().ToMethod(context => {
            //                                                    Console.WriteLine("Creating a new card!");
            //                                                    return new MasterCard();
            //                                                }).InSingletonScope();
            //kernel.Bind<ICreditCard>().To<Visa>();

            var shopper = kernel.Get<Shopper>();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard());

            var shopper2 = kernel.Get<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCard());

            Console.Read();
        }
    }
}
