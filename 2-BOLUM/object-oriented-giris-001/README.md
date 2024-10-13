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
* Bir nesne olustururken `degisken = new Nesne(){ name = "asd", price = 10};` syntaxi kullanilabilir.
    * degisken array icindeki bir index'te olabilir.  
```C#
productsArray[0] = new Product()
{
    name = "Gozluk",
    image = "http://www.google.com",
    details = "Gunes Gozlugu",
    price = 999.99,
    discount = 0.10
};
```
:warning: Bu sekilde sadece nesnenin degiskenlerine erisilebilir, class icinde bir metod varsa bu sekilde erisilemez.

C# ta katmanlama asagidaki sekilde yapilir
```C#
namespace Ornek{
    // class ya da struct olabiir
    public class ClassOrnek
    {
        //degiskenler olabilir
        int a;
        //metodlar olabilir
        public static void Metod(){

        }
    }
    public struct StructOrnek
    {

    }
}
```
* Classta yazilmis bir metodu cagirmak icin once classi bir degiskene atiyoruz, tipki `Random rnd = new Random()` da oldugu gibi
```C#
ClassOrnek ornek = new ClassOrnek();
```
Daha sonra bu degiskeni kullanarak icine yazili metoda ulsabiliriz
```C#
ornek.Metod();
```
# OOP Constructor
Yukaridaki orneklerde olusturdugunmuz nesnelirn icine veri yazarken, her veri icin heap bolgesine gidip geliyoruz. *Constructor (Ctor)* Ile biz nesneyi bellege cikarirken icindeki degiskenleri de beraberinde  gondermemizi saglar.
* Ctor : Metoda benzer ancak geri donus degeri yoktur
* Ctorun adi sinifin adi ile ayni olmak zorundadur
* Ilerde gorecegimiz, farkli parametreler alan ctrolar olabilir.
```C#
public class Personel
{
    public string ad;
    public string soyad;
    public string yas;

    public Personel()
    {
        //ctor
    }
}
```
* Defaut Ctro: Nesne heap alanina giderken bu ctoru calistirir, bu ctor bizim tarafimizdan yazilmasa derleyici bir tane ctor otomatik olarak yazar/
* Biz bir ctor yazdigimiz anda artik derleyici bizim yazdigimiz ctoru kullanir. 
**Ctor'un amaci nedir**
* Nesne bellege cikarken nesneye ait verilerinde bellege goturulmesini saglar.
    * boylece nesne icerisindeki her bir degiskenin degerini tek tek heap anlanina git-gel yapmadan tek seferde yazdirmis oluruz. 
* Ornek olarak yukaridaki ornekte ctor icerisine bir baslangic degeri verelim;

```C#
public class Personel
{
    public string ad;
    public string soyad;
    public string yas;

    public Personel()
    {
        ad = "Muhittin";
        soyad = "Kemal";
        yas = 70;
    }
}
```
* Bu sekilde bir baslangic degeri atamasi yaparsak, nesneyi bellege ilk cikardigimiz anda, yani; `Personel p1 = new Personel();` komutu ile birlikte p1 nesnesinin icine ad soyad ve yas bilgisini de Ctor icine yazdigimiz gibi gondermis oluruz.
:bulb: Burda default ctor icinde bir deger tanimlamasi yapildigi icin her nesne o tanimlarla bellge gidecektir. Ancak biz bellege cikacak degerleri nesneyi olusturuken vermek istiyoruz, Bunun icin bir ctor daha yazmamiz lazim
## Parametre Alan Ctor
* Aslinda default Ctor' a overload yaparak, parametre alan bir ctor yaziyoruz
```C#
    public Personel(string a, string b, int c)
    {
        // burada atamalari yapiyoruz tipki metod gibi
        ad = a;
        soyad = b;
        yas = c;
    }
```

* Bu parametreli ctor'u kullanmak icin `Personel p1 = new Personel("Muhittin", "Yilmaz", 30);` seklinde cagiriyoruz.
:bulb: nesne ornegi alinirken gonderilen parametreler nesne icindeki degiskenlere aktarilir, nesne bu degiskenlerle bellege cikar. Dolayisiyla nesne uretilirken degerlerde yanlarinda gitmis olurlar.