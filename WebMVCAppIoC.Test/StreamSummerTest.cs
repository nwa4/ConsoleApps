using ConsoleApps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVCAppIoC.Test
{
    [TestClass]
    public class StreamSummerTest
    {
        [TestMethod]
        public void SumMemoryStream()
        {
            byte[] data = new byte[] {3, 8, 13 };
            using (MemoryStream stream = new MemoryStream(data))
            {
                StreamSummer test = new StreamSummer();
                Assert.AreEqual(24, test.Sum(stream));
            }
        }
    }
}
