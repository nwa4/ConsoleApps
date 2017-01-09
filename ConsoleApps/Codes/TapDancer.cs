using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    public class TapDancer : Dancer
    {
        public TapDancer() : base("Tap Dancer")
        {
        }

        public override void Dance()
        {
            Console.WriteLine("Drip drip!!");
        }
    }
}
