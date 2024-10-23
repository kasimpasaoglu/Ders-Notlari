# Table Of Contents

- [HATA YONETIMI](#hata-yonetimi)
  - [Throw](#throw)
  - [Hatayi Bir Dosyaya Yazma](#hatayi-bir-dosyaya-yazma)
  - [Ic Ice Try Catch Kullanimi](#ic-ice-try-catch-kullanimi)

# HATA YONETIMI

.Net icinde iki turlu hata vardir

1. Derleme Zamani Hatasi
2. Calisma Zamani Hatasi (RunTime Error)

- Derleme zamani hatasi zaten kodu yazarken gordugumuz hatalardir. Bu konuyu daha once konusmustuk
- Calisma zamani hatasi yazilimi icerisinde bir mantik hatasi yapildiginda, ya da veri kaynaklarindan gelen verilerin duzgun kontrol edilmemesinden, yada bazi degiskenlerin vb. null kontrolu yapilmamasinindan kaynakli hatalardir.
- Bir uygulmanin calisma hatasi vermesi, uygulamayi kullanan(musteri/kullanici) acisindan kotu bir deneyimdir.
- Yazilimci olarak bizim amacimiz olusabilecek hatalari ongorup, bunlarin onune gecmektir. Ornegin kullanicidan gelen bir girdiyi programimiz sayi olarak beklerken, kullanicinin string olarak input yapmasi durumunda olusacak hatayi ongorup, calisma zamani hatasi vermeden, bir cozum uretmektir. Girilen degerdeki harfleri cikarmak, ve ya kullaniciya tekrar giris yapmasi gerektigini soylemek gibi.

```C#
try
{
    // hata olmasi beklenen kod blogu buraya yazilir
    // burdaki kod blogunda bir runtime hatasi olursa catch blogunun icindeki kod calisir
}
catch
{
    // try icindeki blokta bir hata olursa derleyici otomatik olarak, catch blogu icine gelir.
    throw;
}
```

- `try` bloklari daha yavas okunur, bu yuzden gereksiz kullanimi programin performansini yavaslatir.
- `Exception` hata yonetim hiyerasisindeki en tepedeki tiptir. Butun hatalari yakalar.

```C#
try
{
    Console.WriteLine("1.Sayiyi Girininiz");
    int sayi1 = int.Parse(Console.ReadLine().Trim());
    Console.WriteLine("2.Sayiyi Girininiz");
    int sayi2 = int.Parse(Console.ReadLine().Trim());

    int sonuc = sayi1 / sayi2;
}
catch (Exception hata)
{
// exceptionlarin sebeplerini ekrana yazdiralim
Console.WriteLine(hata.Message);

}
```

- Yukaridaki ornekte `Exception` sinifi, hata degiskenine hatanin turunu yaziyor, daha sonra catch blogu icinde `.Message` ile hata mesajina ulastik
- `.stackTrace` ile hatanin nerde oldugunu yazar
- Yukaridaki ornekte iki tur hata gelebilir, biri **DivideByZero Exception** digeri **Format Exception**
- kod blogunda olusacak her turlu hata icin buradaki catch blogu calisacaktir, peki catch bloklari ozellestirilebilir mi?
- catch bloklarini sadece belirli exceptionlari yakalamak icin ozellestirebiliriz.
- Catch keywordunun yanina yakalamak istedigimiz exception'u yazmamiz yeterlidir.

```C#
try
{
    Console.WriteLine("1.Sayiyi Girininiz");
    int sayi1 = int.Parse(Console.ReadLine().Trim());
    Console.WriteLine("2.Sayiyi Girininiz");
    int sayi2 = int.Parse(Console.ReadLine().Trim());

    int sonuc = sayi1 / sayi2;
}
catch (DivideByZeroException hata) // bu blok sadece dividebyzero hatasini yakalayacak 
{
    Console.WriteLine("Bolen Sifir Olamaz");
}
catch (FormatException hata) // bu blok sadece formatexception hatasini yakalayacak
{
    Console.WriteLine("Gecersiz Sayi Degeri");
}
```

- `Catch` bloklarini istediginiz kadar cogaltabilirsiniz
- Yukarida iki farkli case icin `Catch` yazdik, Hic Dusunmedigimiz bir hata meydana gelmesi durumunda `Exception` kullanip, geri kalan butun hatalari yakalamis olur

## Throw

- Bazi durumlarda kendimiz de bir `Exception` uretebiliriz.
- `throw new Exception()` ile bir exception firlatabiliriz.
- Firlatilan bu exceptionu catch ile yakalayabiliriz.

```C#
try
{
    int deger = int.Parse(Console.ReadLine().Trim());
    if (deger < 50)
    {
        // kendi exceptionumuzu firtlattik, derleyici bu satira gelince uygulama bir exception firlatacak
        throw new Exception("Degeriniz 50 den Kucuk");
    }
}
catch (Exception ex) // firlatilan exceptionu yakalayacak
{
Console.WriteLine(ex.Message);
}
```

## Hatayi Bir Dosyaya Yazma

- Bu hatalari bir dosyaya kaydedebiliriz `File.AppendAllText("Dosya yolu", Yazilacak mesaj)`

```C#
try
{
    Console.WriteLine("Lutfen Bir Deger Giriniz");
    int deger = int.Parse(Console.ReadLine().Trim());
    Console.WriteLine(deger);
}
catch (Exception ex)
{

    DateTime errorTime = DateTime.Now;
    File.AppendAllText("C:/Users/BRIGHT.DESKTOP-5789TGK/Downloads/Ders-Notlari/exception(hata)-yonetimi-011/LOGS.txt", "\n" + errorTime.ToLongDateString() + " --" + ex.Message);
}
```

## Ic Ice Try Catch Kullanimi

```C#
Console.WriteLine("Bir Deger Giriniz");
try
{
    int value = Cevir(Console.ReadLine().Trim());
    int result = value / 0;
}
catch (DivideByZeroException ex)
{
    // disardaki try-catch'in bekledigimiz hatasini yaklayacak
}
catch (UnauthorizedAccessException ex)
{
    // icerdeki try-carch'in yollayacagi exception'u yakalayacak.
}
catch (Exception ex)
{
    // beklemedgimiz baska bir expection olursa onu burasi yakalayacak
}

static int Cevir(string deger)
{
    int value = 0;
    try
    {
        value = int.Parse(deger);
    }
    catch (Exception ex)
    {
        throw new UnauthorizedAccessException(ex.Message); // burda yakaladigimiz exception'u bir ust seviyedeki try catch yakalamasi icin, disari firlattik.
        // bunu yaparken icerdeki expectionun hata mesajini Baska bir Exception tipine yazdik, 

        //throw ex; 
        // bu sekilde yazarsak burda yakaladigimiz exceptionu dogrudan bir degisiklik yapmadan bir ust try-catch'e gonderdik
    }
    return value;
}
```

> [**INDEX'e DON**](/README.md)
