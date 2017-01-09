using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApps.Codes;

namespace NUnit.Tests
{
    [TestFixture]
    public class DelegatesTest
    {
        [Test]
        public void SingleMethodInterface()
        {
            IInt32Action action = new Delegates();
            action.DoIt(10);
        }

        [Test]
        public void SimpleDelegateFormMethod()
        {
            Delegates target = new Delegates();
            Int32Action action = new Int32Action(target.RandomRob);

            action.Invoke(5);
            action(6);

            var person = new
            {
                Name = "Obinna",
                EmailAddress = "obi@nwa4.com"
            };
            Console.WriteLine( person.ToString());
        }

        [Test]
        public void DeligateStaticMethod()
        {
            Int32Action action = new Int32Action(Delegates.StaticRob);

            action.Invoke(7);
        }

        [Test]
        public void Musticast()
        {
            Int32Action action = new Int32Action(Delegates.StaticRob);
            Int32Action action2 = new Int32Action(Delegates.StaticRob2);

            Int32Action action3 = action + action2;

            action3(20);
            Int32Action action4 = (Int32Action)Delegate.Combine(action, action2);
            action4(21);
        }
    }
}
