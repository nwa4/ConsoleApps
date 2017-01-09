using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApps;

namespace WebMVCAppIoC.Test
{
    [TestClass]
    public class AllKindOfTests
    {
        [TestMethod]
        public void TestGenerics()
        {
            Fred<string> gString = new Fred<string>("hello");
            Assert.AreEqual("hello", gString.Foo());

            Fred<int> gInt = new Fred<int>(100);
            Assert.AreEqual(int.Parse("100"), gInt.Foo());

            //Assert.AreSame(gString, gInt);
            //Assert.AreEqual(gString, gInt);
        }

    }

    
}
