PizzaStore ankaraPizzaStore = new AnkaraPizzaStore();
PizzaStore istanbulPizzaStore = new IstanbulPizzaStore();
PizzaStore izmirPizzaStore = new IzmirPizzaStore();

ankaraPizzaStore.OrderPizza();
istanbulPizzaStore.OrderPizza();
izmirPizzaStore.OrderPizza();

public interface IPizza
{
    void Prepare();
    void Bake();
    void Cut();
}

public class CheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Bake 20 mins");
    }

    public void Cut()
    {
        Console.WriteLine("Cut 5 pieces");
    }

    public void Prepare()
    {
        Console.WriteLine("Cheese Pizza Prepared");
    }
}

public class VeggiePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Bake 15 mins");
    }

    public void Cut()
    {
        Console.WriteLine("Cut 4 pieces");
    }

    public void Prepare()
    {
        Console.WriteLine("Veggie Pizza Prepared");
    }
}

public class FishPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Bake 25 mins");
    }

    public void Cut()
    {
        Console.WriteLine("Cut 6 pieces");
    }

    public void Prepare()
    {
        Console.WriteLine("Fish Pizza Prepared");
    }
}


public abstract class PizzaStore
{
    // protected cunku sandece PizzaStore'dan kalitilan yerlede cagirilabilir
    // Pizza olusturma islemini alt sinif yapacak.
    // burda sadece hangi yontemin kullanilacagini belirtmis oluyorz.
    // Her magaza kendi createpizza metodunu kullanacak.
    // yani order pizza metodu hepsi icin ayni algoritmayi kullaniyor
    // sirasiyla Prepare/bake/cut islemlerini ypiyor.
    // ancak algoritmanin sonucu her magaza icin farkli gelecek, cunku her biri kendi create pizza metodunu kullanacak, ve kendi create pizza metodunda her magaza farkli bir pizza cesidi uretiyor.
    protected abstract IPizza CreatePizza();

    public IPizza OrderPizza()
    {
        IPizza pizza = CreatePizza();
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        return pizza;
    }
}

public class IstanbulPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza()
    {
        return new CheesePizza();
    }
}

public class AnkaraPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza()
    {
        return new VeggiePizza();
    }
}

public class IzmirPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza()
    {
        return new FishPizza();
    }
}