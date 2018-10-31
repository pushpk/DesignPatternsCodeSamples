using DesignPattern.AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class PlatinumDebitCard : DebitCard
    {
        private readonly string _cardType;
        private int _withdrawLimit;
        private string _bankName;
        private int _pin;

        public PlatinumDebitCard(int withdrawLimit, string bankName, int pin)
        {
            _cardType = "Platinum";
            _withdrawLimit = withdrawLimit;
            _bankName = bankName;
            _pin = pin;
        }

        public override string CardType
        {
            get { return _cardType; }
        }

        public override int WithdrawLimit
        {
            get { return _withdrawLimit; }
            set { _withdrawLimit = value; }
        }
        public override string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }
        public override int Pin
        {
            get { return _pin; }
            set { _pin = value; }
        }
    }
}
