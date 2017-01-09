using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    public abstract class Dancer : IControllable
    {
        readonly string name;

        public string Name { get { return name; } }

        protected Dancer(string name)
        {
            this.name = name;
        }

        public abstract void Dance();

        public void Start()
        {
            Console.WriteLine("Starting Dancing!!!");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Dancing!!!");
        }

        public void DanceTwice()
        {
            Dance();
            Dance();
        }
    }
}
