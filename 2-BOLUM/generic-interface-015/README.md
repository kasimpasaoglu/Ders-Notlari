# Generic Interface

Yazilis olarak classtan bir farki yoktur.

```C#
public interface IListe<T>
{
    public void Add(T value);
    public void Delete(T value);
}
```

- Baska bir interface implemente edilebilir.

```C#
public interface IListe<T> : IComparable<T>
{
    public void Add(T value);
    public void Delete(T value);
}
```

Interface implementasyonu yaparken yine generic bir interface implement edilmedilir. yoksa generic olmasinin anlami olmaz. Cunku olusturulan interface generic yani her tipi alabilirken onun kalitildigi yer generic olmazsa yazdigimiz interface tip bakimindan kisitlanmis olur ve generic olmasinin bir anlami kalmaz.

Simdi bu interface'i bir classa implement edelim

```C#
public class MyCollection<T> : IListe<T>
{
    // bizim yazdigimiz interfaceden geldi
    public void Add(T value)
    {
        throw new NotImplementedException();
    }
    // bizim yazdigimiz interfaceden geldi
    public void Delete(T value)
    {
        throw new NotImplementedException();
    }
    // IComparable interface'inden geldi
    public int CompareTo(T? other)
    {
        throw new NotImplementedException();
    }
}
```
