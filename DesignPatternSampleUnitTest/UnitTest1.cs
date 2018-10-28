using System;
using DesignPatterns.Facade;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternSampleUnitTest
{
    [TestClass]
    public class UnitTest1
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
    }
}
