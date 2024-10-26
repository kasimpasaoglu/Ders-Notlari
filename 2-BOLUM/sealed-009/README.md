# `sealed` Keyword

* Kalitim ile gelen bir metodun override edilmesini engellemis olur

```C#
public class A
{
    public virtual void Metod1()
    {
        Console.WriteLine("Metod1 - A");
    }
    public virtual void Metod2()
    {
        Console.WriteLine("Metod2 - A");
    }
}
```

```C#
public class B : A
{
    public sealed override void Metod1()
    {
        base.Metod1();
    }
    public sealed override void Metod2()
    {
        base.Metod2();
    }
}
```

* `sealed` keywordu verildikten sonra artik B sinifindan kalitilan siniflarda override edilemez.. **Yani C sinifinda Bu metodlarin override edilmesi engellendi**
* :warning: C sinifi icinden hala erisilebilir. sadece override edilmesini engeler

* `sealed` keywordu bir classa yazilirsa, bu classin baska bir classa baseClass olmasi engellenmis olur.

```C#

public sealed class C : B
{

}
```

* Yani C classi sealed oldugu icin artik bir C classindan baska bir class kalitilamaz.
