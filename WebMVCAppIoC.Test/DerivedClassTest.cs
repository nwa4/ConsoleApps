using ConsoleApps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WebMVCAppIoC.Test
{
    [TestClass]
    public class DerivedClassTest
    {
        [TestMethod]
        public void DefaultName()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual("derived default", test.Name);
        }

        [TestMethod]
        public void SpecifiedtName()
        {
            BaseClass test = new DerivedClass("obi");
            Assert.AreEqual("derived obi", test.Name);
        }

        [TestMethod]
        public void QuadrupleInputQuadruplesInput()
        {
            DerivedClass test = new DerivedClass();
            Assert.AreEqual(20, test.QuadrupleInput(5));
        }

        [TestMethod]
        public void TrebleInputTreblesInput()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual(15, test.TrebleInput(5));
        }

        [TestMethod]
        public void CalculateResultHalvesInput()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual(4, test.CalculateResult(8));
        }
    }
}
