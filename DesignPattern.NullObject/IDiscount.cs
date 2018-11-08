namespace DesignPattern.NullObject
{
    public interface IDiscount
    {
        double CalculateDiscount(double productCost);
    }

    public class PremiumDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return (productCost * 0.5);
        }
    }
    public class FestivalDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return (productCost * 0.2);
        }
    }

    public class NullDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return 0;
        }
    }
}