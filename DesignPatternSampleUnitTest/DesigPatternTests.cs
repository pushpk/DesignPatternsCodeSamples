using System;
using DesignPattern.Factory.ConcreteCreator;
using DesignPattern.Factory.Creator;
using DesignPattern.Factory.Product;
using AbstractConcreteCreator =  DesignPattern.AbstractFactory.ConcreteCreator;
using AbstractCreator  = DesignPattern.AbstractFactory.Creator;
using AbstractProduct = DesignPattern.AbstractFactory.Product;

using DesignPatterns.Facade;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternSampleUnitTest
{
    [TestClass]
    public class DesigPatternTests
    {
        [TestMethod]
        public void Facade_pattern_test()
        {
            Mortgage mrtg = new Mortgage();
            Customer cst = new Customer("Mark Joey");


            //mortgage class is facade class  that creates classes and simplifies complex subsytem
            bool eligible = mrtg.IsEligible(cst, 125000);

            Assert.IsTrue(eligible);

        }

        [TestMethod]

        public void Factory_pattern_test()
        {
            CardFactory factory = null;
            string cardType = "moneyback";

            switch (cardType.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard card = factory.GetCreditCard();
            Assert.AreEqual("MoneyBack", card.CardType);
            Assert.AreEqual(50000, card.CreditLimit);
            Assert.AreEqual(0, card.AnnualCharge);

        }
        [TestMethod]
        public void Abstract_Factory_pattern_test()
        {


            AbstractCreator.CardFactory factory = null;
            string cardType = "moneyback";

            switch (cardType.ToLower())
            {
                case "moneyback":
                   factory = new AbstractConcreteCreator.MoneyBackFactory(5000,"chase",0000);
                    break;
                case "titanium":
                    factory = new AbstractConcreteCreator.TitaniumFactory(5000, "chase",1111);
                    break;
                case "platinum":
                    factory = new AbstractConcreteCreator.PlatinumFactory(5000, "chase",1212);
                    break;
                default:
                    break;
            }

            AbstractProduct.DebitCard card = factory.GetDebitCard();
            Assert.AreEqual("MoneyBack", card.CardType);
            Assert.AreEqual(5000, card.WithdrawLimit);
            Assert.AreEqual(0000, card.Pin);

        }
    }
}
