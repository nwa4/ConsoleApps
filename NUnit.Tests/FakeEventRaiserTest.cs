using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    [TestFixture]
    public class FakeEventRaiserTest
    {
        private void ReportToConsole(string text)
        {
            Console.WriteLine("Called: {0}", text);
        }

        [Test]
        public void RaiseEvent()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
