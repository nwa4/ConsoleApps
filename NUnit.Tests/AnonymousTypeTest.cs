﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    [TestFixture]
    public class AnonymousTypeTest
    {
        [Test]
        public void Demo()
        {
            var person = new { FirstName="Obi", LastNAme ="Nwafor" };
        }
    }
}
