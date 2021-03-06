﻿using DesignPattern.AbstractFactory.ConcreteProduct;
using DesignPattern.AbstractFactory.Creator;
using DesignPattern.AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.ConcreteCreator
{
   public class MoneyBackFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        private int _withDrawLimit;
        private string _bankName;
        private int _pin;

        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
            
        }

        public MoneyBackFactory(int withDrawLimit, string bankName, int pin)
        {
            _withDrawLimit = withDrawLimit;
            _bankName = bankName;
            _pin = pin;
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }

        public override DebitCard GetDebitCard()
        {
            return new MoneyBackDebitCard(_withDrawLimit, _bankName, _pin);
        }
    }
}
