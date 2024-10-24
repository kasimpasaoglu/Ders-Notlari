// `base` Keyword
// Driven (tureyen) class icinde bir ctor olusturuldugu zaman, Base Class (turetilen) siniftaki fieldlara erismek icin `base` anahtar kelimesini kullanabiliriz.
// syntax base."fieldAdi"
// `:base:` Keyword ise kalitim hiyerarsisinde, base class'in ctoruna yonlendirme yapilmak icin kullanilir.
// `this` keywordune benzerdir, ancak this ayni class icinde calisir. Kalitim hiyerarsisi icinde `base` keywordu kullanilir.
// yani alt sinifin ctorundan ust sinifin ctoruna yonlendirmek icin `:base` keywordu kullanilir.
// Neden bunu yapariz?
// Cunku alt sinif nesne uretirken, her zaman once ust siniftaki ctoru bellege gonderir. sonra geri gelip, alt sinifi olustururken verdigimiz degerleri bellege gonderir.
// Bu da 2 defa bellege gidip gelmeye sebep olur. 
// Burdaki amac, alt siniftan bir nesne olusturuyor olsak bile verecegimiz degerleri bereaberinde alip bellege bir kere gidip yazmasini saglamaktir. 
// Yani base anahtar kelimesi ile, base classin ctoruna yonlendirme islemi yapmis olmak.
//----------
// 3 kusakli bir kalitim yapisi olusturup ctor base classlara ctor yonlendirmesi yapiniz.

KanatliEvcilCanli x = new("Papagan", "Kus", 20, false, "Kasim");
Console.WriteLine(x.Name);
Console.WriteLine(x.Type);
Console.WriteLine(x.WingSpan);
Console.WriteLine(x.CanFly);
Console.WriteLine(x.OwnerName);