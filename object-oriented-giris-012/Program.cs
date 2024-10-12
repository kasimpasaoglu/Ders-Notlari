// Nesne ornegi almak :
/*
Ogrenci o1 = new Ogrenci();
o1.name = "Kasim";
o1.lastname = "Pasaoglu";
o1.age = 32;
*/

#region 4 adet ogrenci nesnesi retip dizi icine yerlestirelim
/*
Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.name = "Pinar";
ogrenci1.lastname = "Demirtas";
ogrenci1.age = 23;

Ogrenci ogrenci2 = new Ogrenci();
ogrenci2.name = "Murat";
ogrenci2.lastname = "Ayaz";
ogrenci2.age = 33;

Ogrenci ogrenci3 = new Ogrenci();
ogrenci3.name = "Leyla";
ogrenci3.lastname = "Kanat";
ogrenci3.age = 25;

Ogrenci ogrenci4 = new Ogrenci();
ogrenci4.name = "Leyla";
ogrenci4.lastname = "Kanat";
ogrenci4.age = 25;
// bu 4 ogrenci nesnesini bir dizi icine yerlestirlerim

Ogrenci[] ogrenciler = new Ogrenci[4];

// diziyi olusturduktan sonra simdi nesneleri yerlestirelim
ogrenciler[0] = ogrenci1;
ogrenciler[1] = ogrenci2;
ogrenciler[2] = ogrenci3;
ogrenciler[3] = ogrenci4;

foreach (Ogrenci item in ogrenciler)
{
    Console.WriteLine($"{item.name} {item.lastname} {item.age}");
}

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine($"{ogrenciler[i].name} {ogrenciler[i].lastname} {ogrenciler[i].age}");
}
*/
#endregion

#region yukaridaki ogrenci isimli ogrencileri bir Sorted List Kolleksiyopnu icine yerlestirip for each ile ekrana yazdiriniz

using System.Collections;

Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.name = "Pinar";
ogrenci1.lastname = "Demirtas";
ogrenci1.age = 23;

Ogrenci ogrenci2 = new Ogrenci();
ogrenci2.name = "Murat";
ogrenci2.lastname = "Ayaz";
ogrenci2.age = 33;

Ogrenci ogrenci3 = new Ogrenci();
ogrenci3.name = "Leyla";
ogrenci3.lastname = "Kanat";
ogrenci3.age = 25;

Ogrenci ogrenci4 = new Ogrenci();
ogrenci4.name = "Leyla";
ogrenci4.lastname = "Kara";
ogrenci4.age = 28;

Ogrenci[] array = new Ogrenci[4];
array[0] = ogrenci1;
array[1] = ogrenci2;
array[2] = ogrenci3;
array[3] = ogrenci4;

SortedList ogrenciler = new();
var rnd = new Random();

for (int i = 0; i < 4; i++)
{
    var idNo = rnd.Next(100, 200);

    ogrenciler.Add(idNo, array[i]);
}

foreach (DictionaryEntry item in ogrenciler)
{
    Ogrenci ogrenci = (Ogrenci)item.Value;
    Console.WriteLine($"Ogrenci no: {item.Key} || Ogrenci Ad&Soyad => {ogrenci.name} {ogrenci.lastname} || Yas {ogrenci.age}");
}
#endregion