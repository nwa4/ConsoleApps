using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.Codes
{
    public delegate void EventHandler<T>(object sender, EventArgs e);
    public delegate void FakeEventHandler(string value);
    public class FakeEventRaiser
    {
        private FakeEventHandler currentHandler = null;
        public void AddHandler(FakeEventHandler handler)
        {
            currentHandler += handler;
        }

        public void RemoveHandler(FakeEventHandler handler)
        {
            currentHandler -= handler;
        }

        public void DOSomething()
        {
            FakeEventHandler tmp = currentHandler;
            if (tmp != null)
            {
                tmp.Invoke("This is the reason");
            }
        }
    }
}
