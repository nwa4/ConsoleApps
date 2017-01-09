using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.Codes
{
    public delegate void Int32Action(int value);
    
    public interface IInt32Action
    {
        void DoIt(int value);
    }
    public class Delegates : IInt32Action
    {
        string name;

        public Delegates(string name)
        {
            this.name = name;
        }

        public Delegates():this("unknown")
        {

        }
        public static void StaticRob(int value)
        {
            Console.WriteLine("Static Method {0}", value);
        }

        public void DoIt(int value)
        {
            Console.WriteLine("{0} Interface Implementation {1}", value, name);
        }

        public void RandomRob(int value)
        {
            Console.WriteLine("Multicast Implementation No. 1 receiving: {0}", value);
        }

        public static void StaticRob2(int value)
        {
            Console.WriteLine("Multicast Implementation No. 2 receiving: {0}", value);
        }
    }
}
