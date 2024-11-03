
List<Departman> departmans = new();
departmans.Add(new Departman() { Id = 1, Name = "Bilgi Islem" });
departmans.Add(new Departman() { Id = 2, Name = "Finans" });
departmans.Add(new Departman() { Id = 3, Name = "Satis" });
departmans.Add(new Departman() { Id = 4, Name = "HR" });

List<Personel> personels = new List<Personel>();
personels.Add(new Personel() { Id = 1, departmanId = 1, Name = "Ahmet", Age = 15, Salary = 10 });
personels.Add(new Personel() { Id = 2, departmanId = 1, Name = "Ali", Age = 35, Salary = 20 });
personels.Add(new Personel() { Id = 3, departmanId = 2, Name = "Oguz", Age = 50, Salary = 30 });
personels.Add(new Personel() { Id = 4, departmanId = 3, Name = "Veli", Age = 40, Salary = 50 });
personels.Add(new Personel() { Id = 5, departmanId = 4, Name = "Nur", Age = 30, Salary = 60 });
personels.Add(new Personel() { Id = 7, departmanId = 1, Name = "Nuray", Age = 40, Salary = 50 });
personels.Add(new Personel() { Id = 6, departmanId = 3, Name = "Burak", Age = 20, Salary = 60 });


#region where
/*
var result = personels.Where(x => x.Name.Contains('e'));
Console.WriteLine("Adinda 'e' harfi olan personel");
foreach (var item in result)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();

var ageResults = personels.Where(x => x.Age > 25);
Console.WriteLine("Yasi 25'ten buyuk olanlar");
foreach (var item in ageResults)
{
    Console.WriteLine(item.Name + " " + item.Age);
}
Console.WriteLine();

var nameLenght = personels.Where(x => x.Name.Length > 3);
Console.WriteLine("Ismi 3 harften fazla olanlar");
foreach (var item in nameLenght)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine();
// var asd = nameLenght[0]; // nameLenght indexer'i olmadigi icin kabul etmedi.
*/
#endregion

#region odev 
/*
// adi N ile baslayanlar
var startsWithN = personels.Where(x => x.Name.StartsWith('N'));
Console.WriteLine("Adi 'N' Ile Baslayanlar");
foreach (var item in startsWithN)
{
    Console.WriteLine($"{item.Id} -> {item.Name} -> {item.Age}");
}
Console.WriteLine();

// yasi 30 dan kucuk olanlar
var youngPers = personels.Where(x => x.Age < 30);
Console.WriteLine("Yasi 30'dan kucuk olanlar");
foreach (var item in youngPers)
{
    Console.WriteLine($"{item.Id} -> {item.Name} -> {item.Age}");
}
Console.WriteLine();

// adi nuray olanlar
Console.WriteLine("Nuray'i bul");
var nuray = personels.Where(x => x.Name == "Nuray").FirstOrDefault();
Console.WriteLine($"{nuray.Id} -> {nuray.Name} -> {nuray.Age}");
Console.WriteLine();

// id degeri tek olanlar
var oddIds = personels.Where(x => x.Id % 2 != 0);
Console.WriteLine("Id numarasi tek olanlar");
foreach (var item in oddIds)
{
    Console.WriteLine($"{item.Id} -> {item.Name} -> {item.Age}");
}
Console.WriteLine();

var multi = personels.Where(x => x.Id % 2 == 1 && x.Name.StartsWith('N') && x.Age > 40).FirstOrDefault();
Console.WriteLine("Coklu arama sonucu");
Console.WriteLine($"{multi.Id} -> {multi.Name} -> {multi.Age}");
*/
#endregion

#region orderby
/*
var orderedList = personels.Where(s => s.Id % 2 == 1).OrderBy(s => s.Name);
Console.WriteLine("Id'si tek olan personeller, ada gore siralanmis hali");
foreach (var item in orderedList)
{
    Console.WriteLine($"{item.Id} -> {item.Name} -> {item.Age}");
}

var reverseOrderedList = personels.Where(s => s.Id % 2 == 1).OrderByDescending(s => s.Name);
Console.WriteLine("Id'si tek olan personeller, ada gore tersten siralanmis hali");
foreach (var item in reverseOrderedList)
{
    Console.WriteLine($"{item.Id} -> {item.Name} -> {item.Age}");
}
*/
#endregion

#region Select
/*
var onlyName = personels.Select(s => s.Name).ToList();
foreach (string item in onlyName)
{
    Console.WriteLine(item);
}



List < Ogrenci > ogrenciListesi = personels.Select(personel => new Ogrenci()
{
    Id = personel.Id,
    Name = personel.Name
}).ToList();

foreach (Ogrenci o in ogrenciListesi)
{
    Console.WriteLine($"{o.Id} -- {o.Name}");
}
*/
#endregion

#region odev
/*
List<Mercedes> mercedes = new();
mercedes.Add(new Mercedes(154, "C180", "1.8"));
mercedes.Add(new Mercedes(155, "C200", "2.0"));
mercedes.Add(new Mercedes(156, "A180", "1.8"));
mercedes.Add(new Mercedes(156, "A200", "2.0"));

List<Tofas> tofas = mercedes.Select(x => new Tofas(x.chasisNo, x.model)).ToList();
*/
#endregion

#region anonim
/*
var anonim = new
{
    Id = 1,
    Name = "Metin",
    Age = 30
};


var liste = personels.Where(s => s.Name.Contains('a')).Select(s => new
{
    Id = s.Id,
    Name = s.Name,
}).ToList();


foreach (var item in liste)
{
    Console.WriteLine($"{item.Id} -> {item.Name}");
}
*/
#endregion

#region bir kolleksiyon olsuturup anonim tip ile bazi sorgular yapiniz. Maasi 50'nin altinda kalan personele %18 zam yapilmis halde yazdir gibi

List<Workers> workers = new();
workers.Add(new Workers(1, "Selcuk Yavuz", 70000, "Sales"));
workers.Add(new Workers(2, "Ayse Demir", 68000, "Accounting"));
workers.Add(new Workers(3, "Mehmet Yildiz", 68000, "Finance"));
workers.Add(new Workers(4, "Fatma Celik", 76000, "IT"));
workers.Add(new Workers(5, "Ali Ozkan", 68000, "Marketing"));
workers.Add(new Workers(6, "Emre Yalcin", 70000, "Sales"));
workers.Add(new Workers(7, "Esra Gunes", 70000, "Sales"));
workers.Add(new Workers(8, "Huseyin Korkmaz", 76000, "HR"));
workers.Add(new Workers(9, "Deniz Karaca", 76000, "HR"));
workers.Add(new Workers(10, "Seda Sahin", 76000, "IT"));
/*
var salaryIncrease = workers.Where(x => x.Wage < 840000).Select(y => new
{
    Id = y.Id,
    Name = y.Name,
    OldWeeklyWage = y.WeeklyWage,
    WeeklyWage = y.WeeklyWage * 1.50,
    NewWage = y.Wage * 1.50,
}).OrderByDescending(z => z.NewWage);

foreach (var item in salaryIncrease)
{
    Console.WriteLine($"{item.Id} || {item.Name} || Eski Maas => {item.OldWeeklyWage} || Yeni Maas => {item.WeeklyWage} * 12 = Yillik: {item.NewWage}");
}
*/
#endregion


#region any
/*
bool isOk = workers.Any(x => x.Name.Contains("Mehmet") && x.WeeklyWage == 58000);
Console.WriteLine(isOk);
*/
#endregion

#region sum
/*
double totalWage = workers.Sum(x => x.WeeklyWage);

Console.WriteLine($"Total Salary : {totalWage}");
*/
#endregion

#region count
/*
int salaryCount = workers.Where(s => s.WeeklyWage <= 50000).Count();

Console.WriteLine(salaryCount);


int salaryCount1 = workers.Count(x => x.WeeklyWage <= 50000);

Console.WriteLine(salaryCount1);
*/
#endregion

#region GroupBy Gruplama ornegi, hangi maastan kac tane var
/*
var group = workers.GroupBy(s => s.WeeklyWage).Select(s => new
{
    Salary = s.Key,
    Count = s.Count(),
});

foreach (var item in group)
{
    Console.WriteLine($"Adet : {item.Count} || Maas : {item.Salary}");
}
*/
#endregion

#region iki degere gore gruplama
/*
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
*/
#endregion

#region Join iki tabloyu birbirine baglama
/*
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
*/
#endregion

#region grupjoin
#region 1.ornek
/*
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
*/
#endregion
// Bu sorguda kac personel oldugu bilgisi var ancak departmanda kimler var sorgusu yapmak icin;
#region 2.ornek
/*
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
*/
#endregion
// her departmanda en yaşlı personelleri getirelim
#region ornek3 
/*
var groupJoinResult2 = departmans.GroupJoin(personels // bağlanacak tablo
, departman => departman.Id                           // ilk tablodaki ortak alan
, personel => personel.departmanId                  // ikinci tablodaki ortak alan
, (departman, personel) => new
{
    DepartmanAd = departman.Name,
    EnYasliPersonel = personel.OrderByDescending(x => x.Age).FirstOrDefault(),
    Sayi = personel.Count(),
    DepartmanYastoplam = personel.Sum(s => s.Age)
});
foreach (var item in groupJoinResult2)
{
    Console.WriteLine("{0}---{1}", item.DepartmanAd, item.EnYasliPersonel.Name);

    Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-");
}
*/
#endregion
#endregion