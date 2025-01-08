public abstract class SandwichStore
{
    //factory metod
    public abstract ISandwich CreateSandwich();

    public string OrderSandwich()
    {
        var sandwich = CreateSandwich();
        return $"Sandwich Ingredients : {sandwich.GetIngredients()}";
    }
}
// abstract sinif; Factory metod olan Create sandwich i tanimliyor
// ayrica ordersanwich metodu ile nesne olusturma sureci kontrol ediliyor
// Yani bu sinif soyut bir sablon sagliyor, ve tureyen siniflara kendi CreateSandwich metodunu yazmasini zorluyor.