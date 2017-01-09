using ConsoleApps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebMVCAppIoC.Test
{
   [TestClass]
    public class StartAndStopTest
    {
        [TestMethod]
        public void StartAndStop()
        {
            Dancer dancer = new TapDancer();
            ChainSaw chainsaw = new ChainSaw();

            StartAndStopper test = new StartAndStopper();
            test.StartAndStop(dancer);
            test.StartAndStop(chainsaw);
        }
    }
}
