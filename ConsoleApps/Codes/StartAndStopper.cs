using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    public class StartAndStopper
    {
        public void StartAndStop(IControllable controller)
        {
            controller.Start();
            controller.Stop();
        }
    }
}
