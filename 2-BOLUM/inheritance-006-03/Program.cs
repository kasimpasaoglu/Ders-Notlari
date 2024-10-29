// bir tane metod yazalim ve bu kalitim yapisi icindeki her sinif bu metoda parametre olarak gecebilsin

static void TasitMetod(Tasit tasit)
{
    Mercedes merco = new();
    Bmw bmw = new();
    if (tasit is Mercedes)
    {
        merco = (Mercedes)tasit;
    }
    if (tasit is Bmw)
    {
        bmw = (Bmw)tasit;
    }

    Console.WriteLine(merco.Konfor);
    Console.WriteLine(bmw.Performans);
}


// eger metodlara parametre alacagimiz sinifilar arasinda bir kalitim hiyerarsisi var ise siniflari tek tek parametre almaniza gerek yoktur. sadece Base Class'i parametre olarak aldigimiz taktirde, ondan tureyen tum siniflar bu metoda parametre olarak gecebilir.

// ornegin mercedes sinifini yukaridaki metoda parametre olarak gonderelim.

Mercedes m = new();
m.Konfor = "konfor100";
m.Metod();

Bmw bmw = new();
bmw.Performans = "performans100";

// TasitMetod(bmw);
// TasitMetod(m);


// mercedes sinifi Tasit sinifindan turetildigi icin, parametre olarak Tasit verdigimiz metoda Mercedes classini gonderebiliriz.
// ancak burda sadece BaseClassi kullanarak metod yazdigimiz icin sadece Base Class olan Tasit classinin fieldlarina metodun icinden ulasabiliriz. 
// tureyen siniflar tasit parametresi alan metoda parametre olarak gonderilirse, aslinda boxing islemi yapilir. 
// dolayisiyla mercedes sinifi bu metoda parametre olarak gonderilirse tasit pointer'i uzerinden mercedes nesnesine bakildigi icin sadece Enerji isimli proplar gorunur.
// Mercedes nesnesine ait proplari gormek icin tasit sinifini mercedes sinifina cast (unboxing) yapmamiz gerekir.
// bu islemden sonra artik mercedes sinifina ait proplari gorebilecegiz.
/*
static void TasitMetod(Tasit tasit)
{
    Mercedes merc = (Mercedes)tasit;
}
*/
// ancak bu da baska bir sorunu ortaya cikariyor. Ya gelen parametre mercedes degil de bmw ise??

// `is` keyword

// kosul yapisi olusturup tasit mercedes ise mercedes unboxingi yapilabilir
/*
static void TasitMetod(Tasit tasit)
{
    if (tasit is Mercedes)
    {
        Mercedes merc = (Mercedes)tasit;
    }
    else if (tasit is Bmw)
    {
        Bmw merc = (Bmw)tasit;
    }
    else if (tasit is Peugeot)
    {
        Peugeot merc = (Peugeot)tasit;
    }
}
*/
// `is` keywordu iki tipi birbiri ile kiyaslar. 
// Aslinda sordugu soru, "tasit degiskenin icinde bir Mercedes var mi?" seklindedir. bool doner. 