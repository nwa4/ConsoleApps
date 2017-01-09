using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.Codes
{
    public sealed class ChainSaw : IControllable
    {
        public void Start()
        {
            Console.WriteLine("Starting Dancing!!!");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Dancing!!!");
        }
        
    }
}
