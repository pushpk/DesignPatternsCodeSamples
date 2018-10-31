using DesignPattern.AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Creator
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

        public DebitCard DebitCard
        {
            get => default(DebitCard);
            set
            {
            }
        }

        public abstract CreditCard GetCreditCard();
        public abstract DebitCard GetDebitCard();
        
    }
}
