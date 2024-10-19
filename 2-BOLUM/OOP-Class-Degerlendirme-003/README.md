# Class Degerlendirme

:warning: Her class referans tiplidir. Ancak string bir class olmasina ragmen deger tipli davranisi sergiler.
:warning: String tipi referans tipli olmasina ragmen deger atama ve metotlara parametre gecme islem

```C#
Ogrenci o = new Ogrenci();
Console.WriteLine($"ID => {o.Id} || Name => {o.Ad}");

Degistir(o);
Console.WriteLine($"ID => {o.Id} || Name => {o.Ad}");


static void Degistir(Ogrenci o)
{
    o.Id = 10;
    o.Ad = "Kemalettin";
}
```

> Ogrenci bir class oldugu icin, referans tiplidir, ve referans tipte bellekte aslinda pointer kopyalandigi icin, metod ile bir degisiklik yaptigimizda bellegin heap bolgesinde i pointere karsilik gelen degeri degistirmis oluruz.
Yani yukardaki ornekte baslandigcta bos gelecekken, Degistir(o) metodundan sonra "o" nesnesinin bellekte isaret ettigi yeri gidip degistirip gelmis oluyoruz, sonra tekrar baktigimizda artik degerin degistigini gorebiliyoruz.

> [**INDEX'e DON**](/README.md)
