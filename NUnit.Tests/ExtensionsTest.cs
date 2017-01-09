using NUnit.Framework;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApps.Codes;

namespace NUnit.Tests
{
    [TestFixture]
    public class ExtensionsTest
    {
        [Test]
        public void ExtensionString()
        {
            string theString = "LORD";
            Console.WriteLine(theString.Reverse());
        }

        [Test]
        public void MiniLinq()
        {
            string[] names = {"Obi", "Nwafor", "Fab", "Izundu", "Lord" };
            //var query = names.Select(x => x.Length).Where(x => x < 5);
            var query = names.Where(x => x.StartsWith("L")).Select(x => x.ToUpper());

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
