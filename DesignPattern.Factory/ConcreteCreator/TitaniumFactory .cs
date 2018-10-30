using DesignPattern.Factory.ConcreteProduct;
using DesignPattern.Factory.Creator;
using DesignPattern.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.ConcreteCreator
{
    class TitaniumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
