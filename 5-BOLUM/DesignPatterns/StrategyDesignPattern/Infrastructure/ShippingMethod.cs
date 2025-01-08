// bir sinifin davranisini yapilan secime gore dinamk olarak degistirmek?
// Content -> Strategy <- ConcreteStrategies
// content stratejiyi kullanir ve belirlenen stratejiye gore calisir
// strateji farkli algoritmalari tanimlayan ortak bir interface
// concratestrategy, somut strateji, strateji interfaceini kullanan fakat icerdigi metodlari her biri kendine gore farkli sonuc veren siniflar

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

