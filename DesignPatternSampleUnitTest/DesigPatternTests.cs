using System;
using DesignPattern.Factory.ConcreteCreator;
using DesignPattern.Factory.Creator;
using DesignPattern.Factory.Product;
using AbstractConcreteCreator = DesignPattern.AbstractFactory.ConcreteCreator;
using AbstractCreator = DesignPattern.AbstractFactory.Creator;
using AbstractProduct = DesignPattern.AbstractFactory.Product;
using DesignPatterns.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPattern.Adapter;
using DessignPattern.Singleton;
using DesignPattern.Strategy.Context;
using DesignPattern.Strategy.Strategy;
using DesignPattern.Strategy.Concrete;
using DesignPattern.Decorator.Component;
using DesignPattern.Decorator.ConcreteComponent;
using DesignPattern.Decorator.ConcreteDecorator;
using DeisgnPattern.Command.Invoker;
using DeisgnPattern.Command.Receiver;
using DeisgnPattern.Command.ConcreteCommands;
using DesignPattern.Proxy;
using DesignPattern.TemplateMethod;
using DesignPattern.Composite.Composite;
using DesignPattern.Composite.Leaf;
using DesignPattern.Iterator.ConcreteAggregate;
using DesignPattern.Iterator;
using DesignPattern.Iterator.ConcreteIterator;
using DesignPattern.Builder.Builder;
using DesignPattern.Builder.Director;
using DesignPattern.Builder.ConcreteBuilders;
using DesignPattern.Builder.Product;
using DesignPattern.NullObject;
using DesignPattern.State;

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
                    factory = new AbstractConcreteCreator.MoneyBackFactory(5000, "chase", 0000);
                    break;
                case "titanium":
                    factory = new AbstractConcreteCreator.TitaniumFactory(5000, "chase", 1111);
                    break;
                case "platinum":
                    factory = new AbstractConcreteCreator.PlatinumFactory(5000, "chase", 1212);
                    break;
                default:
                    break;
            }

            AbstractProduct.DebitCard card = factory.GetDebitCard();
            Assert.AreEqual("MoneyBack", card.CardType);
            Assert.AreEqual(5000, card.WithdrawLimit);
            Assert.AreEqual(0000, card.Pin);

        }

        [TestMethod]
        public void Adapter_pattern()
        {
            ITarget target = new Adapter();
            var emps = target.request();

            Assert.AreEqual(4, emps.Count);

        }

        [TestMethod]
        public void Singleton_pattern_test()
        {
            Singleton obj = Singleton.Instance;
            string actualResult = obj.GetMessage();

            Assert.AreEqual("Hello World from Singleton", actualResult);
        }

        [TestMethod]
        public void Strategy_pattern_test()
        {

            IJumpBehavior highjump = new HighJump();
            IJumpBehavior longjump = new LongJump();
            IKickBehavior tornadokick = new TornadoKick();

            // Make a fighter with desired behaviors 
            Fighter ryu = new Ryu(tornadokick, longjump);

            // Test behaviors 
            string jumpText = ryu.jump();
            string kickText = ryu.kick();
            string punchText = ryu.punch();

            Assert.AreEqual("Long Jump", jumpText);
            Assert.AreEqual("Tornado Kick", kickText);
            Assert.AreEqual("Default punch", punchText);

            // Change behavior dynamically (algorithms are 
            // interchangeable) 
            ryu.setjump(highjump);
            ryu.jump();

            Assert.AreEqual("Long Jump", jumpText);
        }

        [TestMethod]
        public void Decorator_pattern_test()
        {
            Pizza largePizza = new LargePizza();
            largePizza = new CheeseTopping(largePizza);
            largePizza = new HamTopping(largePizza);
            largePizza = new PappersTopping(largePizza);

            string desc = largePizza.GetDescription();

            Assert.AreEqual("Large pizza with cheese with Ham with pappers", desc);
        }

        [TestMethod]
        public void Command_pattern_test()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            Stereo stereo = new Stereo();

            //we can change command dynamically
            remote.SetCommand(new LightOnCommand(light));
            string actualValueLight = remote.ButtonWasPressed();

            remote.SetCommand(new StereoOnWithDVDCommand(stereo));
            string actualValueStereo = remote.ButtonWasPressed();

            Assert.AreEqual(actualValueLight, "Light is on");
            Assert.AreEqual(actualValueStereo, "Stereo is on All set to set DVD");
        }

        [TestMethod]
        public void Proxy_pattern_test()
        {
            IInternet internet = new ProxyInternet();

            var actualConResult =    internet.connectTo("a.com");

            Assert.AreEqual("access to a.com is denied", actualConResult);

        }

        [TestMethod]
        public void TemplateMethod_test()
        {
            SourDough sourDoughtBread = new SourDough();
            string a =  sourDoughtBread.Make();

            Assert.AreEqual(" Gathering Ingredients for sour dough  Baking the sour dough Slicing the SourDough bread!", a);

        }

        [TestMethod]
        public void Composite_pattern_test()
        {
            var colas = new Cola(210);
            colas.Flavors.Add(new VanillaCola(215));
            colas.Flavors.Add(new CherryCola(220));

            //var lemonLime = new LemonLime(185);

            //var rootBeers = new RootBeer(195);
            //rootBeers.Flavors.Add(new VanillaRootBeer(200));
            //rootBeers.Flavors.Add(new StrawberryRootBeer(200));

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.Flavors.Add(colas);

            //sodaWater.Flavors.Add(lemonLime);
            //sodaWater.Flavors.Add(rootBeers);

          var actValue =   sodaWater.DisplayCalories();

            Assert.AreEqual("SodaWater: 180 caloriesCola: 210 caloriesVanillaCola: 215 caloriesCherryCola: 220 calories", actValue);

        }

        [TestMethod]
        public void Iterator_pattern_test()
        {
            JellyBeanCollection collection = new JellyBeanCollection();
            collection[0] = new JellyBean("Cherry");
            collection[1] = new JellyBean("Bubble Gum");
            collection[2] = new JellyBean("Root Beer");
            collection[3] = new JellyBean("French Vanilla");
            collection[4] = new JellyBean("Licorice");
            collection[5] = new JellyBean("Buttered Popcorn");
            collection[6] = new JellyBean("Juicy Pear");
            collection[7] = new JellyBean("Cinnamon");
            collection[8] = new JellyBean("Coconut");

            //Create Interator
            JellyBeanIterator iterator = collection.CreateIterator();

             JellyBean firstJellyBean  = iterator.First();
            Assert.AreEqual("Cherry",firstJellyBean.Flavor);

            JellyBean lastJellyBean = iterator.Last();
            Assert.AreEqual("Coconut", lastJellyBean.Flavor);

        }

        [TestMethod]
        public void Builder_pattern_test()
        {
            HouseBuilder iglooBuilder = new IglooHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(iglooBuilder);
            engineer.constructHouse();
            House house = engineer.getHouse();
           
            Assert.AreEqual("Ice Bars", house.basement);
           
        }
        
        [TestMethod]
        public void NullObject_pattern_test()
        {
            Order NoDiscountOrder = new Order(new NullDiscount());
           double zeroDiscount =  NoDiscountOrder.CalculateDiscount();

            Assert.AreEqual(0, zeroDiscount);
        }

        [TestMethod]
        public void State_pattern_test()
        {
             string TEST_POLICY_NUMBER = "007";
            var testPolicy = new Policy(TEST_POLICY_NUMBER);

           var testCancelledState = new CancelledState(testPolicy);
           var testClosedState = new ClosedState(testPolicy);
           var testOpenState = new OpenState(testPolicy);
           var testUnwrittenState = new UnwrittenState(testPolicy);
            var testVoidState = new VoidState(testPolicy);

            //closing open policy
            testOpenState.Close(DateTime.Now);

            Assert.IsInstanceOfType(testPolicy.State, typeof(ClosedState));


        }



    }
}
