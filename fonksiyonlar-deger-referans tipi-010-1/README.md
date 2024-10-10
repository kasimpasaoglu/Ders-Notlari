# Deger Tip ve Referans Tip Kavrami
.Net icerisinde bazi tipler deger tiplidir, bazi tipler ise referans tiplidir. Bu iki tip bellekte durus sekli bakimindan birbirlerinden ayrilirlar.

* **Deger** tipli degiskenler bellegin **stack** bolgesinde yer alirlar
* **Referans** tipli degiskenler bellegin **heap** bolgesinde yer alir.
* **Deger** tipli degiskenler bir metoda parametre gecerken ve ya atama yapilirken, her zaman kopyalanirlar. Orjinal deger degismez
* **Referans** tipinde ise degerin kendisi kopyalanmaz, degeri isaret eden pointer kopyalanir. Boylece bir fonksiyonda ve ya baska bir bilesende gonderildigi zaman, islem yapildiginda deger degistirilmis olur
* Genelde referans tipler, agir veriler icerir, deger tipler ise daha hafif veriler icerdiginden dolayi bu sekilde bir ayrim vardir. Yani daha agir veri tasiyacak tipler kopyalanmaz, sadece referansi(pointer) ' i kopyalanir. Ancak daha hafif veri tasiyan deger tipler direk kopyalanir.
* Daha sonra gorecegimiz konularda su iki kavram ile karsilacagiz
    * Deger Tip : *Struct*
    * Referans Tip : *Class*
```C#
int a = 10;

Console.WriteLine(a); // 10 geldi
IntDegistir(a); // degistirme islemini yaptik
Console.WriteLine(a); // ancak yine 10 geldi

string[] isimler = { "ayse", "fatma", "ali", "veli", "mustafa" };

Console.WriteLine(isimler[0]); // ayse geldi
DiziDegistir(isimler); // degistrime islemini yaptik
Console.WriteLine(isimler[0]); // degistirildi geldi
// yani int deger tip oldugu icin degismedi, ama string[] icindeki string degisken referans tip oldugu icin degisti.

static void IntDegistir(int degisken)
{
    degisken = 11;
}

static void DiziDegistir(string[] dizi)
{
    dizi[0] = "degistirildi";
}
```
* Burda simdilik deger tip ve referans tipin birbirine gore farkliliklarini ve bellekte nasil durduklarini gorduk.
# ref ve out
* `ref` keywordu deger tipli degiskenleri referans tipli gibi davranmaya zorlar.
```C#
int a = 10;
Console.WriteLine(a); // 10
IntDegistir(ref a); // degisiklik yapildi
Console.WriteLine(a); // 11 yazar, cunku ref ile bellektegi veriyi degistirmis olduk

static void IntDegistir(ref int degisken)
{
    degisken = 11;
}
```
* `ref` keywordu referans tipli degiskenlerde bir ise yaramiyor(simdilik)
* `out` keywordu bir metod icinden deger cikarabilmek icin kullanilan bir yontemdir.
```C#
int a;  // baslangic degeri vermedik
DegerAta(out a); // deger atamasi yapildi
Console.WriteLine(a); // metodun icindeki degeri yazdirdi

static void DegerAta(out int a)
{
    a = 10;
}
```
* `out` ta baslangic degeri verilmeyebilir ancak `ref` te baslangic degeri girilmesi zorunludur.
**ORNEK `TryParse()` metodu**
* TryParse metodu, strign'i int'e dondurmeye calisir, ancak donusturebiliyorsa donusum yapar, donusmuyorsa bool deger olarak false verir. Eger donusum yapilamazsa tanimlanmis degiskene bir deger atamasi yapmaz
```C#
int b;
bool isOk = int.TryParse("abc", out b);

Console.WriteLine(isOk);
Console.WriteLine(b);
```

# Metod OverLoading -> Metodlari Asiri Yuklemek
* Ayni isimde iki metod yazdigimizda bu iki metodun adi cakisacagi icin C# izin vermez. 
* Ancak bazi durumlarda ayni isimde birden fazla metod yazilmasina izin verir. 
* Birden fazla metodunun ayni ismi almasina **Metod Overloading** denir.
* Metod Overloading C# icinde cok fazla kullanilan bir yontemdir
* `Console.Writeline()` metodu alabilecegi parametrelere baktimizda 17 farkli overload'i oldugunu goruruz. Yani verdigimiz parametrelere gore farkli metodlari cagiriyoruz. 
* Bir metodun overload olabilmesi icin, parametre sayisi, ve ya parametre tipi farkli olmalidir.
* Geri donus degerinin bir onemi yoktur. Ayni olsa da olur.
* C#' ta Program.cs dosyasina yazilan kodlar aslinda bir `Main()` metodu icine yazilir. Bu metod derleyiciye kodlari okumaya nerden baslayacagini gostermeye yariyor. 
* Kendi yazdigimiz metolari overloading yapmak istiyorsak, bu `Main()` metodu disina yazilmalidir. `Main()` metodu icine overloading yapilamaz. 
* Ilerleyen konularda kendi sinifinimizi olusturunca orda `Main()` metodu olmayacagi icin, overloading yapabilecegiz. 
```C#
internal class Program
{
    private static void Main(string[] args)
    {
        // aslinda yazdigimiz butun kodlar buraya geliyor
    }
    static void Deneme(int a)
    {
    }
    static void Deneme(string a, string b)
    {
    }
}
``` 

# Metodlar - Params
Metodlar belli sayilarda parametre alirlar. Bu parametreleri bir keyword ile sinirsiz hale getirmek mumkundur
```C#
static void SinirsizParametre(params int[] parameters)
{
    // kod blogu
}

SinirsizParametre(10,20,30,40,50,60,70,80,90,100,1,2,3,4,5,6,7,8,9,0);
```
* `params` keyword'u bir metodun sinirsiz adet parametre almasini sagar. 
* `params` ile alinan sinirsiz adet parametreler metod icinde dizi uzerinden yakalanabilir.

# Metodlar - Default Parameters
Bir fonskiyonda istege bagli parametre atamasi yapmak icin o parametreye default (baslangic) degeri atamasi yapilabilir.

```C#
static void Metod1(int a = 10)
{
    Console.WriteLine(a);
}

Metod1();

```
* Bu ornekte a degiskenin default degeri 10'dur.
* Metod cagirilirken a degiskenine deger atamasi yapilmazsa, default degeri alarak islem yapar,
* Deger atamasi yapilirsa verilen degeri kullanir.
