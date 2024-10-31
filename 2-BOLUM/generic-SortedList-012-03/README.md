# SortedList Generic Kolleksiyonu

Kullanimi `SortedDictionary` kolleksiyonun aynisidir

```C#

SortedList<int, string> list = new SortedList<int, string>();

list.Add(2, "zzz");
list.Add(1, "abc");

foreach (KeyValuePair<int, string> item in list)
{
    Console.WriteLine($"key: {item.Key} -- value: {item.Value}");
}
```

:bulb: Bunlar disinda, `stack` `queue` `hashset` kolleksiyonlarini kendiniz deneyiniz.

Hashset kolleksiyonu verileri hasleyerek tutar(sifreleme)
bu kolleksiyona girilen veriler unique olmalidir.
