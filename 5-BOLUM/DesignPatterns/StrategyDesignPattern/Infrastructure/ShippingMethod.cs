public interface IShippingMethod
{
    double CalculateShippingCost(double orderAmount);
}

// shipping metod ile ilgili 3 stratejim var
public class StandardShipping : IShippingMethod
{
    public double CalculateShippingCost(double orderAmount)
    {
        return orderAmount * 0.1;
    }
}

public class ExpressShipping : IShippingMethod
{
    public double CalculateShippingCost(double orderAmount)
    {
        return orderAmount * 0.2;
    }
}

public class FreeShipping : IShippingMethod
{
    public double CalculateShippingCost(double orderAmount)
    {
        return 0.0;
    }
}

