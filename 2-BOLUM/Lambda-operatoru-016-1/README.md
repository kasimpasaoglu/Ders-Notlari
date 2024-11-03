## Anonim Tip Kavrami

* Select metodu ile database'den sorgular atacagiz. Yapilacak sorgularda butun tabloyu cekmek yerine, sadece ihtiyacimiz olan alani almak icin select kullaniyorduk.
* Gelen sonuclar sadece belli ozellikleri filtreledigimiz icin, farkli bir tipte newleyerek yapiyorduk.
* Ancak burda her sorgu yaptigimizda yeni bir tip mi yazacagiz sorunsalini yasiyoruz.
* Bu sorunu cozmek icin `anonim type` yazariz.
* Asagidaki **anonim bir nesne ornegidir**. Class degildir. Yani anonim adinda bir nesne ornegi newlerken tip sablonunu direk o anda vermis oluyoruz.
* Ortada bir sinif olmadan, nesne ornegi alabilmeyi saglayan anonim tipe bir ornektir.
* `var` keyword kullanilmasi zorunludur, cunku ortada tanimladigimiz bir tip yok
  * Aslinda arka planda *CIL* rasgele karakterle isimlendirilmis bir class yazar ancak calistirma zamaninda rasgele atandigi icin kodlamayi yaparken bilemeyiz bu yuzden `var` kullanilmasi zorunludur.

```C#
var anonim = new
{
    Id = 1,
    Name = "Metin",
    Age = 30
};
```

* Select metodundan geriye farkli bir tip dondurmek istedigimizde, her defasinda yeni bir tip yazmamak icin anonim tip yazabiliriz.
* Anonim tip bir sinif nesne ornegi gibi davranir, ancak sinif yoktur.
* Anonim tiplerde propertyler istenildigi kadar istenildigi tiple yazilabilir

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

* Where gibi calisir ancak geriye bool deger doner.

> Maasi 58000 olan ve adinda Mehmet olan var mi?

```C#
bool isOk = workers.Any(x => x.Name.Contains("Mehmet") && x.WeeklyWage == 58000);

Console.WriteLine(isOk);
```

## `Sum` Metodu

* Sayisal alanlari toplamak icin kullanilir

> Tum personellerin maas toplami

```C#
double totalWage = workers.Sum(x => x.WeeklyWage);

Console.WriteLine($"Total Salary : {totalWage}");
```

## `Count` Metodu

* Count metodu kayitlari saymak icin kullanilir
* Maasi 50000 tl nin altinda kac kullanici var.
  * iki sekilde yapilabilir
    * Filtre yapip cikan sonucu sayabiliriz
    * Ya da direk kosulu count icine belirtip cikan sonuclarin adetini alabiliriz

```C#
int salaryCount = workers.Where(s => s.WeeklyWage <= 50000).Count();

Console.WriteLine(salaryCount);
```

```C#
int salaryCount1 = workers.Count(x => x.WeeklyWage <= 50000);

Console.WriteLine(salaryCount1);
```

## `GroupBy` Metodu

* Gruplanan ogelerdeki grubu olusturacak parametreleri Key olarak yazar.
* 10 elemanli bir Kolleksiyonda gruplamayi yapacak olan parametreye gore kac farkli deger varsa o adette yeni bir kolleksiyon olusturuyor, Bu parametrelerin her birini bir key degeri olarak aliyor, ve her bir keye karsilik gelen value kisminda bu parametreyi karsilayan yeni bir list olustuyor.

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

> Workers listesini maasa gore gruplandirdik.

## `Join` Metodu

* Iki ya da daha fazla kolleksiyonu tek bir kolleksiyona birlestirmek.

[Yeni bir class yazalim](/Departman.cs)
[Personel classina departmanId ekledik]()

* Departmanlar listesini olusturlarim

```C#
List<Departman> departmans = new();
departmans.Add(new Departman() { Id = 1, Name = "Bilgi Islem" });
departmans.Add(new Departman() { Id = 2, Name = "Finans" });
departmans.Add(new Departman() { Id = 3, Name = "Satis" });
departmans.Add(new Departman() { Id = 4, Name = "HR" });
```

* Simdi bu iki tabloyu birbirine baglayalim

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

* Iki tabloyu birbirine baglayip, ayni zamanda iki tablo uzerinden gruplama yapabilmeyi saglar.
