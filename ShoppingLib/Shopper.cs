using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLib
{
    public class Shopper
    {
        private readonly ICreditCard creditCard;
        public Shopper(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public void Charge()
        {
            var chargeMessage = creditCard.Charge();
            Console.WriteLine(chargeMessage);
        }

        public int ChargesForCurrentCard()
        {
            return creditCard.ChargeCount;
        }
    }
}
