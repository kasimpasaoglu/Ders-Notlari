// Interface; tum sandvicler icin ortak bir metod tanimliyor
public interface ISandwich
{
    string GetIngredients();
}


public class VeggieSandwich : ISandwich
{
    public string GetIngredients()
    {
        return "Tomatoes, lettuce, Cheese";
    }
}

public class TurkishSandwich : ISandwich
{
    public string GetIngredients()
    {
        return "Bacon, Sausage, Cheese";
    }
}


// Isandwicg interfaceinden turetilen iki farkli sandvic turu