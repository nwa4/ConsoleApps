﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLib
{
    public interface ICreditCard
    {
        int ChargeCount { get; }
        string Charge();
    }
}
