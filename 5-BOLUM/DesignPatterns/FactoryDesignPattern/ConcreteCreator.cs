// SandwichStore'dan tureyen bu siniflar ilgili sandwich turunu olusturan factory metodu (override edilen createSancwih'i) uyguluyor

public class VeggieStore : SandwichStore
{
    public override ISandwich CreateSandwich()
    {
        return new VeggieSandwich();
    }
}

public class TurkishStore : SandwichStore
{
    public override ISandwich CreateSandwich()
    {
        return new TurkishSandwich();
    }
}