using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    [TestFixture]
    public class AllKindOfTest
    {
        [Test]
        public void ArrayIteration()
        {
            int[] array = new int[] {3, 5, 10 };
            DisplayContents(array);
        }

        [Test]
        public void ListIteration()
        {
            List<string> list = new List<string> {"a","b","c" };
            DisplayContents(list);
        }

        private void DisplayContents<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> iterator = collection.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }
            }
        }
    }

  
}
