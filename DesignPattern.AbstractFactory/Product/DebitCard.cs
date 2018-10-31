using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Product
{
    public abstract class DebitCard
    {
        public abstract string CardType { get; }
        public abstract int WithdrawLimit { get; set; }
        public abstract string BankName { get; set; }

        public abstract int Pin{ get; set; }

    }
}
