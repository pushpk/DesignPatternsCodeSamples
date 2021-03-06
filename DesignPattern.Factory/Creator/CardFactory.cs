﻿using DesignPattern.Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Creator
{
    public abstract class CardFactory
    {
        public CreditCard CreditCard
        {
            get => default(CreditCard);
            set
            {
            }
        }

        public abstract CreditCard GetCreditCard();
    }
}
