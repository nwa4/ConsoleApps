using System;
using Ninject.Modules;
using ShoppingLib;

namespace ConsoleAppNinjectIoC
{
    internal class MyModule : NinjectModule
    {
        public MyModule()
        {
        }

        public override void Load()
        {
            //kernel.Bind<ICreditCard>().To<MasterCard>().InSingletonScope();
            Bind<ICreditCard>().ToMethod(context => {
                Console.WriteLine("Creating a new card!");
                return new MasterCard();
            }).InSingletonScope();
        }
    }
}