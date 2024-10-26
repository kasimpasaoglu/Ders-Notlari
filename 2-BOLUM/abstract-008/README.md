# Abstract

* Abstract intarface gibidir, yani diger classlara sablonluk yapar. Ancak Interface'den farki sablonluk yaparken zorunlu kosulan ya da kosulmayan metodlarin olmasidir.
* Zorunlu olan metodlar `abstract` keywordunu alirken zorunlu olmayan metodlara `virtual` keywordu verilir.

```C#
public abstract class Tasit
{

    public abstract void MotorGucu();
    // override edilmesi zorunludur.
    // BaseClass icinde yazilirken govde yazilmaz cunku absttracttir. (soyut)

    public virtual void Sunroof()
    {
    // override elimek zorunda degildir.
    // virtural metodlarin govdesi yazilmalidir.
        Console.WriteLine("Tasit classi icindeki metod");
    }
}
```

:warning: eger class icinde bir adet bile abstract uye varsa class abstract olarak isaretlenmelidir.

```C#
public class Mercedes : Tasit
{
    public override void MotorGucu()
    {
        throw new NotImplementedException();
    }
    public override void Sunroof()
    {
        Console.WriteLine("Mercedes classi icindeki metod");
    }
}
```

```C#
//Program.cs
Mercedes merco = new Mercedes();
merco.Sunroof();
```

* `Sunroof()`,  Mercedes classi icinde override edildigi icin, Mercedes classi icindeki `Sunroof()` calisacak.
* Override edilmeseydi Tasit baseclass'i icindeki `Sunroof()` calisacakti.
:warning: Abstract classlarin nesne ornegi alinamaz.
* Abstract classlar baska classlara yardimci olmak icin vardir.
