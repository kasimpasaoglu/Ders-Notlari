// Yazilan bir sinifi kullanmak iki cesittir
// 1. daha once ogrendigimiz o siniftan bir nesne uretmek ve nesne uzerinden sinifi kullanmak
// 2. hic nesne uretmeye gerek kalmadan o sifini kullanmak.
// Static kavrami ikinci yol olarak karsimiza cikmaktadir. 
// Static kavrami icerisinde sinifia ait nesne uretilmez
// ornek `Math.Cos()`
// Static classtan nesne uretilemez
///Math m = new Math(); // uretilemez. 
// Daha once kullandigimiz static classlar
///int.Parse();
///Console
///ToString();
// Static class neden kullanilir?
/// Cok hizli bir sekilde erisilmek istenen metod, prop, ya da const lar icin static classlar daha kullanislidir. 
/// --- class yazildi ---
// Static class icindeki ogeye , su sekilde erisilir;
var liste = Personel.Liste;


///--2 - Static Constructor ---
// --Personel2 classi--
/// --3 Non-Static sinif icinde Static Uye--- Ogrenci classi
/// Non static bi class icine static bir uye yazilabilir. 
/// non-static uyeye erisim icin nesne uretilir
Ogrenci o = new Ogrenci();
o.DersCalis();
/// Static uyeye erisim dogrudan yapilir.
Ogrenci.OkulaGit();
/// 
Ogrenci o1 = new Ogrenci();
Ogrenci o2 = new Ogrenci();

Console.WriteLine(Ogrenci.StaticNesneSayisi);
Console.WriteLine(o2.NonStaticNesneSayisi);