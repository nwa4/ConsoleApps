using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApps;

namespace WebMVCAppIoC.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TapDancerTest
    {
        

        [TestMethod]
        public void NameDefaults()
        {
            Dancer dancer = new TapDancer();
            Assert.AreEqual("Tap Dancer", dancer.Name);
        }

        [TestMethod]
        public void DanceBabyDance()
        {
            Dancer dancer = new TapDancer();
            dancer.Dance();
        }

        [TestMethod]
        public void DanceTwice()
        {
            Dancer dancer = new TapDancer();
            dancer.DanceTwice();
        }
    }
}
