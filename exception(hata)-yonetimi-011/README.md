# HATA YONETIMI

.Net icinde iki turlu hata vardir
1. Derleme Zamani Hatasi
2. Calisma Zamani Hatasi (RunTime Error)

* Derleme zamani hatasi zaten kodu yazarken gordugumuz hatalardir. Bu konuyu daha once konusmustuk
* Calisma zamani hatasi yazilimi icerisinde bir mantik hatasi yapildiginda, ya da veri kaynaklarindan gelen verilerin duzgun kontrol edilmemesinden, yada bazi degiskenlerin vb. null kontrolu yapilmamasinindan kaynakli hatalardir.
* Bir uygulmanin calisma hatasi vermesi, uygulamayi kullanan(musteri/kullanici) acisindan kotu bir deneyimdir. 
* Yazilimci olarak bizim amacimiz olusabilecek hatalari ongorup, bunlarin onune gecmektir. Ornegin kullanicidan gelen bir girdiyi programimiz sayi olarak beklerken, kullanicinin string olarak input yapmasi durumunda olusacak hatayi ongorup, calisma zamani hatasi vermeden, bir cozum uretmektir. Girilen degerdeki harfleri cikarmak, ve ya kullaniciya tekrar giris yapmasi gerektigini soylemek gibi.
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

* `try` bloklari daha yavas okunur, bu yuzden gereksiz kullanimi programin performansini yavaslatir.
* `Exception` hata yonetim hiyerasisindeki en tepedeki tiptir. Butun hatalari yakalar.
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
* Yukaridaki ornekte `Exception` sinifi, hata degiskenine hatanin turunu yaziyor, daha sonra catch blogu icinde `.Message` ile hata mesajina ulastik
* `.stackTrace` ile hatanin nerde oldugunu yazar
* Yukaridaki ornekte iki tur hata gelebilir, biri **DivideByZero Exception** digeri **Format Exception**
* kod blogunda olusacak her turlu hata icin buradaki catch blogu calisacaktir, peki catch bloklari ozellestirilebilir mi?
* catch bloklarini sadece belirli exceptionlari yakalamak icin ozellestirebiliriz. 
* Catch keywordunun yanina yakalamak istedigimiz exception'u yazmamiz yeterlidir.
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
* `Catch` bloklarini istediginiz kadar cogaltabilirsiniz
* Yukarida iki farkli case icin `Catch` yazdik, Hic Dusunmedigimiz bir hata meydana gelmesi durumunda `Exception` kullanip, geri kalan butun hatalari yakalamis olur