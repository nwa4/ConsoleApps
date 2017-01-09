using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLib
{
    public class Visa : ICreditCard
    {
        public int ChargeCount { get; set; }

        public string Charge()
        {
            ChargeCount++;
            return "Chaaaaaarging Visa Card!";
        }
    }
}
