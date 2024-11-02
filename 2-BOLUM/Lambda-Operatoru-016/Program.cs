
List<Personel> personels = new List<Personel>();
personels.Add(new Personel() { Id = 1, Name = "Ahmet", Age = 15 });
personels.Add(new Personel() { Id = 2, Name = "Ali", Age = 35 });
personels.Add(new Personel() { Id = 3, Name = "Oguz", Age = 50 });
personels.Add(new Personel() { Id = 4, Name = "Veli", Age = 40 });
personels.Add(new Personel() { Id = 5, Name = "Nur", Age = 30 });
personels.Add(new Personel() { Id = 6, Name = "Burak", Age = 20 });
personels.Add(new Personel() { Id = 7, Name = "Nuray", Age = 41 });


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



#region odev 
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
#endregion


#region orderby
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
#endregion

var onlyName = personels.Select(s => s.Name).ToList();
foreach (string item in onlyName)
{
    Console.WriteLine(item);
}

List<Ogrenci> ogrenciListesi = personels.Select(personel => new Ogrenci()
{
    Id = personel.Id,
    Name = personel.Name
}).ToList();

foreach (Ogrenci o in ogrenciListesi)
{
    Console.WriteLine($"{o.Id} -- {o.Name}");
}



/*
#region odev
List<Mercedes> mercedes = new();
mercedes.Add(new Mercedes(154, "C180", "1.8"));
mercedes.Add(new Mercedes(155, "C200", "2.0"));
mercedes.Add(new Mercedes(156, "A180", "1.8"));
mercedes.Add(new Mercedes(156, "A200", "2.0"));

List<Tofas> tofas = mercedes.Select(x => new Tofas(x.chasisNo, x.model)).ToList();
#endregion
*/