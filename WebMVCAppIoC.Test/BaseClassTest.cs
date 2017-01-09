using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApps;

namespace WebMVCAppIoC.Test
{
    [TestClass]
    public class BaseClassTest
    {
        [TestMethod]
        public void CalculateResultDoublesInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(16, test.CalculateResult(8));
        }

        [TestMethod]
        public void TrebleInputTrebleInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(15, test.TrebleInput(5));
        }

        [TestMethod]
        public void NameDefaultsToDefault()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual("default", test.Name);
        }

        [TestMethod]
        public void SimplifiedNameIsPropagated()
        {
            BaseClass test = new BaseClass("obi");
            Assert.AreEqual("obi", test.Name);
        }
    }
}
