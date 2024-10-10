> [**INDEX'e DON**](/README.md)

# Foreach

* Foreach dongusu for we while dongusunden farkli olarak bir dongu degiskenine ihtiyac duymazlar, 
* Arttirim ifadesine de ihtiyac duymazlar
* while dongusunu gibi kosula bagli donmezler
```C#
ArrayList list = new ArrayList();
list.Add("Istanbul");
list.Add("Ankara");
list.Add("Rize");
list.Add("Mugla");
list.Add("Izmir");
list.Add("Ordu");
list.Add("Agri");
list.Add("Antalya");
list.Add("Hatay");
list.Add("Maras");

foreach (object item in list)
{
    Console.WriteLine(item);
}
```
* ACIKLAMA;
    * object : kolleksiyonun icindeki eleman tipi neyse o tipi yaziyoruz (ornekte object oldugu icin object yazdik)
    * item : Dongu her tur dondugunde dongu icindeki o anki elemandir (bir nevi 'i' degiskeninin yerine geciyor, her defasinda arttirma ve ya azaltma islemi yapmadigimiz icin her dongune, calistirildigi array'in hangi ogesindeyse o ogeyi tanimlamis oluyoruz.) Istedigimiz ismi verebiliriz,
    * in : bir keyword'tur. Hangi kolleksiyonun icinde gezilecegini isaret etmek icindir.
    * list : icinde donecegimiz kolleksiyonun adini giriyoruz
* Basi ve sonu belli olan kolleksiyonlarda, kolleksiyonun sonuna kadar donuyor. Sarta ihtiyac duymuyor.
* Foreach her zaman (bir istisna haric) ileri yonlu iterasyon yapar, yani ters dongu yapmaz. (yapilabilir ancak oyle bir ihtiyacta for kullanmak daha pratik)
* `break` ve `continue` gibi atlama ve kacis ifadeleri bu dongude kullanilabilir. 
* `SortedList` gibi *key* ve *value* degeri olan kolleksiyonlarda 
```C#
SortedList sortedList = new SortedList();

sortedList.Add(1, "Ankara");
sortedList.Add(2, "Istanbul");
sortedList.Add(3, "Izmir");

foreach (DictionaryEntry item in sortedList)
{
    Console.WriteLine(item.Key + " -- " + item.Value);
}
```
:bulb: `DictionaryEntry` bir veri tipi dusunebiliriz. Burda SortedList arrayinden gelen key ve valuelara erisebilmek icin item'i DictionaryEntry olarak tanimlamak gerekir. DictionaryEntry yerine `var` kullanilirsa, casting ile veri tipi donusumu yapip, sonucu `DictionaryEntry` olarak cevirmemiz lazim. item ogesini DictionaryEntry olarak tanimlarsak `.Key` ve `.Value` gibi metodlari cagirabiliriz. 
* Sadece kolleksiyon degil diziler icinde de donebiliriz
```C#
string[] teknoloji = { "HTML", "CSS", "JavaScript", "C#", "React", " Java", "TypeScript", " Rust", };

foreach (string tech in teknoloji)
{
    Console.WriteLine(tech);
}
```

> [**INDEX'e DON**](/README.md)