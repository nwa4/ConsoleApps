using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    public delegate void GenericAction<T>(T value);
    [TestFixture]
    public class AnonymousFunctionTest
    {
        private void MethodTakingString(string value)
        {
            Console.WriteLine(value);
        }

        private void MethodTakingString(string value, int value2, bool value3)
        {
            Console.WriteLine("{0} - {1} - {2}", value, value2, value3);
        }

        private double SquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        [Test]
        public void MethodGroupConverson()
        {
            GenericAction<string> action = MethodTakingString;
            action("Hi");
        }

        [Test]
        public void ListConversion()
        {
            List<int> original = new List<int>() {1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(SquareRoot);
            foreach (int value in squareRoots)
            {
                Console.WriteLine(value);
            }
        }

        [Test]
        public void AnonymousMethods()
        {
            List<int> original = new List<int>() { 1, 2, 3 };
            List<double> squareRoots = original.ConvertAll(delegate (int x)
            {
                return Math.Sqrt(x);
            });
            foreach (int value in squareRoots)
            {
                Console.WriteLine(value);
            }
        }

        [Test]
        public void ClosureAnonymousmethods()
        {
            string result=string.Empty; //Square root
            Converter<string, string> converter = x=>{
                return result = "Converted: "+ x;
            };
            converter("Obi");
            Console.WriteLine(result);

            Action<string, int, bool> badAssDelegate = MethodTakingString;

            badAssDelegate("Alawee", 1, false);

            Action doLil = () => Console.WriteLine("The doLil Deligate");
            doLil();
            Func<int, string, bool, Stream> doFunky =
                (int val1, string val2, bool val3) =>
                {
                    return new MemoryStream(new byte[] { 1, 2, 3 });
                };
            doFunky(24, "Obi", false);
        }
    }
}
