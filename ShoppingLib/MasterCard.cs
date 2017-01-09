using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLib
{
    public class MasterCard : ICreditCard
    {
        public int ChargeCount { get; set; }
        public string Charge()
        {
            ChargeCount++;
            return "Swiping the MasterCard";
        }
    }
}
