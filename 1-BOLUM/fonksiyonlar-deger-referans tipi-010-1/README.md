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

## ref ve out

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

> [**INDEX'e DON**](/README.md)
