using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    public class Fred<T>
    {
        T greeting;

        public Fred(T greeting)
        {
            this.greeting = greeting;
        }

        public T Foo()
        {
            return greeting;
        }
    }
}
