using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.NullObject
{
    public class Order
    {
        private IDiscount _Discount = null;

        public Order(IDiscount dis)
        {
            _Discount = dis;
        }


        public string ProductName { get; set; }
        public double ProductCost { get; set; }
        
        public double CalculateDiscount()
        {
            return _Discount.CalculateDiscount(ProductCost);
        }
    }
}
