# Table Of Contents

- [Lambda Operatoru `=>`](#lambda-operatoru-)
  - [`SingleOrDefault()` && `FirstOrDefault()` Metodlari](#singleordefault--firstordefault-metodlari)
  - [Birden Fazla Kosul Ile Lambda Calistirma](#birden-fazla-kosul-ile-lambda-calistirma)
  - [`OrderBy` Metodlari](#orderby-metodlari)
  - [`Select` Metodu](#select-metodu)

# Lambda Operatoru `=>`

- Temel islevi kolleksiyonlarin icerisinde sorgulama yapabilmektir.

ornek [Personel Classi](/Personel.cs) olusturup bu classtan nesneleri iceren bir kolleksiyon hazirlayalim;

```C#
List<Personel> personels = new List<Personel>();
personels.Add(new Personel() { Id = 1, Name = "Ramazan", Age = 25 });
personels.Add(new Personel() { Id = 2, Name = "Ali", Age = 28 });
personels.Add(new Personel() { Id = 3, Name = "Oguz", Age = 27 });
personels.Add(new Personel() { Id = 4, Name = "Veli", Age = 29 });
personels.Add(new Personel() { Id = 5, Name = "Nur", Age = 30 });
personels.Add(new Personel() { Id = 6, Name = "Hatice", Age = 24 });
personels.Add(new Personel() { Id = 7, Name = "Burak", Age = 23 });
```

- Lambda Operatoru bir metottur.
- Bunu biraz acarsak, aslinda bir delegedir
- *Delege*: Metod isaret eden yapilara denir.
- Func ve Predicate diye iki adet delege vardir.
- `Where` metodu predicate delege alir.
- Predicate generic bir tip alan ve geriye bool deger donduren bir delegedir.
- dolayisiyla `Where` metodu icinden geriye bool deger dondurulmelidir.
- `Where()` kullanildiktan sonra `OrderBy` metodlari kullanilabilir.

```C#
var result = personels.Where(x => x.Name.Contains('e'));
// IEnumareble donecek -> Yani icinde donulebilir

Console.WriteLine("Adinda 'e' harfi olan personel");
foreach (var item in result)
{
    Console.WriteLine(item.Name);
}
```

- :bulb: Bir sinifin icinde dongu ile donebilmek icin **IEnumareble** interface'i gereklidir ve ayni zamanda **yield return** olmasi da gereklidir.
- Bir sinifta [] indexer acabilmek icin o sinifin icerisinde indexer tanimli olmalidir

```C#
var nameLenght = personels.Where(x => x.Name.Length > 3);
Console.WriteLine("Ismi 3 harften fazla olanlar");
foreach (var item in nameLenght)
{
    Console.WriteLine(item.Name);
}
// var asd = nameLenght[0]; // nameLenght indexer'i olmadigi icin kabul etmedi.
```

## `SingleOrDefault()` && `FirstOrDefault()` Metodlari

- `Where()` sonuc tek bir oge bile olsa, her zaman `IEnumarable` doner.
- Sonuc tek bir oge olursa tek bir nesne donmesini istiyorsak
- `SingleOrDefault()` where metodundan gelen sonucun tek bir veri getirecegini biliyorsak IEnumareble olmasi yerine direk o veri tipinden gelmesini saglar, eger veri gelmezse default degeri doner.
- :warning: Kosulu saglayan birden fazla nesne varsa hata verir. Bu yuzden cok kullanisli degildir.
- `FirstOrDefault()` where metodundan gelen sonuclarda kosulu saglayan birden fazla veri varsa ilk sonucu verir.

```C#
Console.WriteLine("Nuray'i bul");
var nuray = personels.Where(x => x.Name == "Nuray").FirstOrDefault();
Console.WriteLine($"{nuray.Id} -> {nuray.Name} -> {nuray.Age}");
Console.WriteLine();
```

## Birden Fazla Kosul Ile Lambda Calistirma

*ornek; Id'si tek olan ve, Ismi 'N' harfi ile baslayan ve yasi 40'tan buyuk olan personeli getir.*

```C#
var multi = personels.Where(x => x.Id % 2 == 1 && x.Name.StartsWith('N') && x.Age > 40).FirstOrDefault();
Console.WriteLine("Coklu arama sonucu");
Console.WriteLine($"{multi.Id} -> {multi.Name} -> {multi.Age}");
```

> Bu kosullara uyan ilk personeli getirmesini istedigimiz icin `FirstOrDefault()` metodunu kullandik.

## `OrderBy` Metodlari

- `Where()` kullanildiktan sonra `OrderBy` metodlari kullanilabilir.
- ornek; id degeri tek sayi olan personelleri siralayalim

```C#
var orderedList = personels.Where(s => s.Id % 2 == 1).OrderBy(s => s.Name);
Console.WriteLine("Id'si tek olan personeller, ada gore siralanmis hali");
foreach (var item in orderedList)
{
    Console.WriteLine($"{item.Id} -> {item.Name} -> {item.Age}");
}
```

- Siralamayi tersten yapmak icin `OrderByDescending()`

```C#
var reverseOrderedList = personels.Where(s => s.Id % 2 == 1).OrderByDescending(s => s.Name);
Console.WriteLine("Id'si tek olan personeller, ada gore tersten siralanmis hali");
foreach (var item in reverseOrderedList)
{
    Console.WriteLine($"{item.Id} -> {item.Name} -> {item.Age}");
}
```

:warning: baska metodlar var yazamadim

## `Select` Metodu

- Sorgulama sonucu gelen sonuc icerisinden istenen alanlari almaya yarar.

> Sadece isimleri aldigimiz bir List Kolleksiyonu olusturalim ve bu listeyi direk yazdiririz.

```C#
var onlyName = personels.Select(s => s.Name).ToList();
foreach (string item in onlyName)
{
    Console.WriteLine(item);
}
```

- Select Metodu ile sonuc olarak donecek tip belirlenir, bazen sinif icerisindeki bir degisken bazen de yeni bir tip donulebilir

> Personel listesini Ogrenci listesine donusturelim

```C#
List<Ogrenci> ogrenciListesi = personels.Select(personel => new Ogrenci()
{
    Id = personel.Id,
    Name = personel.Name
}).ToList();


foreach (Ogrenci o in ogrenciListesi)
{
    Console.WriteLine("Id : {0} Ad : {1} ", o.Id, o.Name);
}
```
