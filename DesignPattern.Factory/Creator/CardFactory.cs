using DesignPattern.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Creator
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
