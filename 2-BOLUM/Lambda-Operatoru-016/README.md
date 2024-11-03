# Table Of Contents

- [Lambda Operatoru `=>`](#lambda-operatoru-)
  - [`SingleOrDefault()` && `FirstOrDefault()` Metodlari](#singleordefault--firstordefault-metodlari)
  - [Birden Fazla Kosul Ile Lambda Calistirma](#birden-fazla-kosul-ile-lambda-calistirma)
  - [`OrderBy` Metodlari](#orderby-metodlari)
  - [`ToList` Metodu](#tolist-metodu)
  - [`ToArray` Metodu](#toarray-metodu)
  - [`Select` Metodu](#select-metodu)
  - [Anonim Tip Kavrami](#anonim-tip-kavrami)
  - [`Any` Metodu](#any-metodu)
  - [`Sum` Metodu](#sum-metodu)
  - [`Count` Metodu](#count-metodu)
  - [`GroupBy` Metodu](#groupby-metodu)
  - [`Join` Metodu](#join-metodu)
  - [`GrouopJoin` Metodu](#grouopjoin-metodu)

# Lambda Operatoru `=>`

- Temel islevi kolleksiyonlarin icerisinde sorgulama yapabilmektir.

ornek [Personel Classi](/2-BOLUM/Lambda-Operatoru-016/Personel.cs) olusturup bu classtan nesneleri iceren bir kolleksiyon hazirlayalim;

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

## `ToList` Metodu

Almis oldugumuz sonucu bir List Kolleksiyonuna cevirir. *ToString() gibi dusunulebilir*
`List<Personel> personelListesi = personels.Where(s=>s.Name.StartsWith("a")).ToList();`

## `ToArray` Metodu

Almis oldugumuz sonucu bir diziye cevirir
`Personel[] personelListesiDizi =  personels.Where(s=>s.Name.StartsWith("a")).ToArray();`

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

## Anonim Tip Kavrami

- Select metodu ile database'den sorgular atacagiz. Yapilacak sorgularda butun tabloyu cekmek yerine, sadece ihtiyacimiz olan alani almak icin select kullaniyorduk.
- Gelen sonuclar sadece belli ozellikleri filtreledigimiz icin, farkli bir tipte newleyerek yapiyorduk.
- Ancak burda her sorgu yaptigimizda yeni bir tip mi yazacagiz sorunsalini yasiyoruz.
- Bu sorunu cozmek icin `anonim type` yazariz.
- Asagidaki **anonim bir nesne ornegidir**. Class degildir. Yani anonim adinda bir nesne ornegi newlerken tip sablonunu direk o anda vermis oluyoruz.
- Ortada bir sinif olmadan, nesne ornegi alabilmeyi saglayan anonim tipe bir ornektir.
- `var` keyword kullanilmasi zorunludur, cunku ortada tanimladigimiz bir tip yok
  - Aslinda arka planda *CIL* rasgele karakterle isimlendirilmis bir class yazar ancak calistirma zamaninda rasgele atandigi icin kodlamayi yaparken bilemeyiz bu yuzden `var` kullanilmasi zorunludur.

```C#
var anonim = new
{
    Id = 1,
    Name = "Metin",
    Age = 30
};
```

- Select metodundan geriye farkli bir tip dondurmek istedigimizde, her defasinda yeni bir tip yazmamak icin anonim tip yazabiliriz.
- Anonim tip bir sinif nesne ornegi gibi davranir, ancak sinif yoktur.
- Anonim tiplerde propertyler istenildigi kadar istenildigi tiple yazilabilir

```C#
var liste = personels.Where(s => s.Name.Contains('a')).Select(s => new
{
    Id = s.Id,
    Name = s.Name,
}).ToList();

// erisirken yine `var` keywordu kullanilir

foreach (var item in liste)
{
    Console.WriteLine($"{item.Id} -> {item.Name}");
}
```

## `Any` Metodu

- Where gibi calisir ancak geriye bool deger doner.

> Maasi 58000 olan ve adinda Mehmet olan var mi?

```C#
bool isOk = workers.Any(x => x.Name.Contains("Mehmet") && x.WeeklyWage == 58000);

Console.WriteLine(isOk);
```

## `Sum` Metodu

- Sayisal alanlari toplamak icin kullanilir

> Tum personellerin maas toplami

```C#
double totalWage = workers.Sum(x => x.WeeklyWage);

Console.WriteLine($"Total Salary : {totalWage}");
```

## `Count` Metodu

- Count metodu kayitlari saymak icin kullanilir
- Maasi 50000 tl nin altinda kac kullanici var.
  - iki sekilde yapilabilir
    - Filtre yapip cikan sonucu sayabiliriz
    - Ya da direk kosulu count icine belirtip cikan sonuclarin adetini alabiliriz

```C#
int salaryCount = workers.Where(s => s.WeeklyWage <= 50000).Count();

Console.WriteLine(salaryCount);
```

ve ya

```C#
int salaryCount1 = workers.Count(x => x.WeeklyWage <= 50000);

Console.WriteLine(salaryCount1);
```

## `GroupBy` Metodu

- Gruplanan ogelerdeki grubu olusturacak parametreleri Key olarak yazar.
- 10 elemanli bir Kolleksiyonda gruplamayi yapacak olan parametreye gore kac farkli deger varsa o adette yeni bir kolleksiyon olusturuyor, Bu parametrelerin her birini bir key degeri olarak aliyor, ve her bir keye karsilik gelen value kisminda bu parametreyi karsilayan yeni bir list olustuyor.

```C#
var group = workers.GroupBy(s => s.WeeklyWage).Select(s => new
{
    Salary = s.Key,
    Count = s.Count(),
});

foreach (var item in group)
{
    Console.WriteLine($"Adet : {item.Count} || Maas : {item.Salary}");
}
```

**Iki degere gore gruplama**

```C#
var groupped = personels.GroupBy(s => new { s.Salary, s.Age }).Select(s => new
{
    s.Key.Salary,
    s.Key.Age,
    toplam = s.Count(),
});

foreach (var item in groupped)
{
    Console.WriteLine($"Salary: {item.Salary} - Age: {item.Age} => Count: {item.toplam}");
}
```

> Workers listesini maasa gore gruplandirdik.

## `Join` Metodu

- Iki ya da daha fazla kolleksiyonu tek bir kolleksiyona birlestirmek.

[Yeni bir class yazalim](/2-BOLUM/Lambda-Operatoru-016/Departman.cs)
[Personel classina departmanId ekledik](/2-BOLUM/Lambda-Operatoru-016/Personel.cs)

- Departmanlar listesini olusturlarim

```C#
List<Departman> departmans = new();
departmans.Add(new Departman() { Id = 1, Name = "Bilgi Islem" });
departmans.Add(new Departman() { Id = 2, Name = "Finans" });
departmans.Add(new Departman() { Id = 3, Name = "Satis" });
departmans.Add(new Departman() { Id = 4, Name = "HR" });
```

- Simdi bu iki tabloyu birbirine baglayalim

```C#
var joinResult = personels.Join(    // birinci tablo personels
    departmans,                     // hedef baglanacak tablo departmans
    pers => pers.departmanId,       // iki tabloyu birbirine baglayacak ortak kolon (ilk tablo icin)
    dep => dep.Id,                  // iki tabloyu birbirine baglayacak ortak kolan (ikinci tablo icin)
    (x, y) => new                   // iki tablo birlesiminden ortaya cikacak olan yeni anonim tablo
    {
        // departman ve personel isimlerini alalim
        DepartmanAd = y.Name,
        PersonelAd = x.Name,
    }
);

foreach (var item in joinResult)
{
    Console.WriteLine($"Departman: {item.DepartmanAd} Personel: {item.PersonelAd}");

}
```

## `GrouopJoin` Metodu

- Iki tabloyu birbirine baglayip, ayni zamanda iki tablo uzerinden gruplama yapabilmeyi saglar.

```C#
var groupJoinResult = departmans.GroupJoin(personels,
s => s.Id,
s => s.departmanId,
(x, y) => new
{
    DepartmanAdi = x.Name,
    KacKisi = y.Count(),
});

foreach (var item in groupJoinResult)
{
    Console.WriteLine($"Departman: {item.DepartmanAdi} || Calisan Sayisi: {item.KacKisi}");
}
```

Bu sorguda kac personel oldugu bilgisi var ancak departmanda kimler var sorgusu yapmak icin;

```C#
var groupJoinNameResult = departmans.GroupJoin(personels,
s => s.Id,
s => s.departmanId,
(departman, personel) => new
{
    DepartmanAdi = departman.Name,
    DepartmanYasToplami = personel.Sum(s => s.Age),
    Sayi = personel.Count(),
    Personeller = personel.Select(s => new { s.Name, s.Age }).ToList()
});

foreach (var item in groupJoinNameResult)
{
    Console.WriteLine($"Departman: {item.DepartmanAdi} || Kisi Sayisi: {item.Sayi} || Yas Toplamlari: {item.DepartmanYasToplami}");

    foreach (var pers in item.Personeller)
    {
        Console.WriteLine($" Ad: {pers.Name} || Yas: {pers.Age}");
    }
    Console.WriteLine("------");
}
```
