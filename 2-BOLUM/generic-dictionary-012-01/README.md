# Dictionary

Dictionary Kolleksiyonu generic bir kolleksiyondir. List kolleksiyonundan farki key ve value aliyor olmasidir.

- key olarak int value olarak string  olan bir Dictionary;
syntax => `Dictionary<int, string> liste = new Dictionary<int, string>();`

- eleman eklenirken yine key ve value sirasiyla yazilir

```C#
liste.Add(1, "Ahmet");
liste.Add(2, "Mehmet");
liste.Add(3, "Ayse");
liste.Add(4, "Fatma");
liste.Add(5, "Melek");
```

- Kendi yazdigimiz tipleri verebiliriz

```C#
Dictionary<int, Ogrenci> ogrenciler = new Dictionary<int, Ogrenci>();

Ogrenci o = new Ogrenci();
o.id=1;
o.name="Banu";
ogrenciler.Add(1,o);
```

- Direk add icinde new'leye biliriz;

```C#
ogrenciler.Add(2, new Ogrenci() { id = 2, name = "Faruk" });
```

## Dictionary Kolleksiyonu icinde dongu

- Dongude cagiriken `KeyValuePair<int, Ogrenci>` seklinde item,in tipini belirtmek gerekecektir.

```C#
foreach (KeyValuePair<int, Ogrenci> item in ogrenciler)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value.id);
    Console.WriteLine(item.Value.name);
}
```

> dongu icindeki item degiskeni key ve value degerleri tasidigi icin bu sekilde yazdik.
> `var` keyword'u de kullanilabilir.

:warning: `Dictionary` kolleksiyonu tipki `SortedList` gibi icine aldigi ogelerin hepsinin `key` degerinin birbirinden farkli olmasi gerekmektedir.
