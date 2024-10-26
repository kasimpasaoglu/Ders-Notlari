public abstract class Tasit
{
    // iki tur metod yazilabilir
    // abstract metod, tasit abstract classini kullananan bir sinifin mecburen implement etmesi gereken metodtur.
    // override edilmesi zorunludur.
    // BaseClass icinde yazilirken govde yazilmaz cunku absttracttir. (soyut)
    public abstract void MotorGucu();

    // virtual metot, tasit abstract classini kullanan bir sinifin istege bagli implement edebilecegi metodtur
    // override elimek zorunda degildir.
    // virtural metodlarin govdesi yazilmalidir.
    public virtual void Sunroof()
    {
        Console.WriteLine("Tasit classi icindeki metod");
    }
}

// eger class icinde bir adet bile abstract uye varsa class abstract olarak isaretlenmelidir. 