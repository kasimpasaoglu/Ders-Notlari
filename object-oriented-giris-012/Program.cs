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
/*
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
*/
#endregion

#region product sinifi yazip 5 degisken tanimla, sonra product sinifindan 5 adet nesne ornegi alip ekrana yazdirin
/*
Product[] productsArray = new Product[5];


productsArray[0] = new Product()
{
    name = "Gozluk",
    image = "http://www.google.com",
    details = "Gunes Gozlugu",
    price = 999.99,
    discount = 0.10
};
productsArray[1] = new Product()
{
    name = "Telefon",
    image = "http://www.google.com",
    details = "IPhone",
    price = 53488.55,
    discount = 0.5
};
productsArray[2] = new Product()
{
    name = "Laptop",
    image = "http://www.google.com",
    details = "HP",
    price = 5500,
    discount = 0.30
};
productsArray[3] = new Product()
{
    name = "Kiyafet",
    image = "http://www.google.com",
    details = "Gomlek",
    price = 655.99,
    discount = 0.20
};
productsArray[4] = new Product()
{
    name = "Araba",
    image = "http://www.google.com",
    details = "Tesla",
    price = 2150000.99,
    discount = 0.10
};

foreach (Product item in productsArray)
{
    Console.WriteLine($"BASLIK => {item.name}");
    Console.WriteLine($"Aciklama => {item.details}");
    Console.WriteLine($"Resim => {item.image}");
    Console.WriteLine($"Liste Fiyati => {item.price}");
    Console.WriteLine($"Indirim Orani => {item.discount}");
    Console.WriteLine($"Sepetteki Tutar => {Math.Round(item.price * (1 - item.discount), 2)}");
    Console.WriteLine("---------------------------------------------------------");
}
*/
#endregion

#region 
Cone cone = new();
double coneArea = cone.ConeArea(5, 4);
double conePerimeter = cone.ConePerimeter(5);
Console.WriteLine($"Koninin Alani => {coneArea}");
Console.WriteLine($"Koninin Cevresi => {coneArea}");

Trapezoid trapezoid = new();
double trapezoidArea = trapezoid.TrapezoidArea(10, 12, 7);
double trapezoidPerimeter = trapezoid.TrapezoidPerimeter(10, 12, 14, 13);
Console.WriteLine($"Yamugun Alani => {trapezoidArea}");
Console.WriteLine($"Yamugun Cevresi => {trapezoidPerimeter}");

Personel p1 = new Personel("Muhittin", "Yilmaz", 30);
#endregion