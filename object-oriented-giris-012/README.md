# OOP (Objcet Oriented Programming)
Dunyadaki her seye object olarak bakan bir bakis acisidir. (**Nesne Yonelimli Programlama**) OOP'nin en tepedeki tipi `object` tipidir
* OOP 3 ana basliktan olusur
1. Kalitim : `Inheritance` : Bir nesneye ait olan butun ozelliklerin tipki bir DNA gibi baska objelere tasinmasidir 
    * ust soydan ozellik aktarimi
2. Kapsullemek : `Encapsulation` : Bir nesnenin ana ozelliklerinin disaridan erisilmesinin engellenmesidir. Bu ozelliklerin disardan okunup degistirilmesini kontrollu bir sekilde yapmak (ornegin yetki kontrolu) 
    * ozelliklerin kapsullenerek dis dunyaya acilmasi
3. Cok Bicimlilik : `Polymorphism` : Miras yolu ile gelen ozelliklerin *must* olup, *must* olmamasiyla ilgili bir durumdur. Yani hangi ozelliklerin miras olarak alinmasini hangilerinin alinmamasini, hangilerinin degistirlecegi belirlemektir. Kalitim konusunun icindedir 
    * ozelliklerin nasil kullanilacagi (zorunlu ? opsiyonel ? zorunlu ise davranisi degistirmek vb.)
* Bu Bolumdeki ilk Konumuz **Nesne Olusturma**
# Class
:warning: Erisim belirtecleri konusuna gelene kadar yazilan tum class ve tum struct ve metodlarda public erisim belirtecini kullanacagiz

Class olusturuken syntax:

```C#
erisim belirtec + class keywordu + class'in adi(PascalCasing)


// yani

public class Ogrenci{
    
}
```
* Clasi'i urettik simdi icine degerleri girleim
* class icerisinde degiskenler tanimlanir ve bu degiskenler classin uyesi olur

```C#
public class Ogrenci{
    public string name; //(simdilik name kucuk harf - kapsulleme icin)
    public string lastname; 
    public int age;
}
```
> * Ogrenci.cs isimli dosyada bir Ogrenci isimli class yazdik. 
> * Program.cs dosyasindan ogrenci sinifindan nesneler olusturacagiz

:bulb: **Sinif (Class)** => Nesne icerisinde olmasi gereken ozelliklerin tanimli oldugu sablondur.
:bulb: **Sinif (Class)** => Insaat ornegindeki mimarin cizimidir, yani ozelliklerin durmus oldugu sablondur, Nesne ise sinif icerisinde duran sablondan uretilmis ogelerdir.
* Yani bu siniftan uretilecek nesnelerin hangi ozellikleri olacagini class ile belirtiryoruz.
* simdi yukarda olusturdugmuz ogrenci classindan bir kac nesne uretelim
`Ogrenci o1 = new Ogrenci();`
* bu esitligin sol tarafi bellekte stack bolgesinde bir pointer olusturur
* esitligin sag tarafin, stack bolgesinde olusan pointerin isaret ettigi heap bolgesindeki alanda bir bellek allocation'u yapar. Ayni zamanda bu nesnenin tasimis oldugu degiskenlerin baskalngic degerlerini bellege yazar.
```C#
Ogrenci o1 = new Ogrenci();
o1.name = "Kasim";
o1.lastname = "Pasaoglu";
o1.age = 32;
```
:bulb: Bu islemi yaparken aslinda bellege 3 defa gidip geldik. Ileride bunu tek seferde yapmayi ogrenecegiz. 

Ornek;
```C#
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
```

* Ogrenciler adinda olusturulan array sadece ogrenci classina ait nesneleri alir. Baska tipte bir deger alamazsiniz.

```C#
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
```