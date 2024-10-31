


static void GenericMetod<T, K>(T value1, K value2)
{

}

GenericMetod<int, string>(1, "String Parametre");

static void GenericMetod1<T, K, L>(T value1, K value2, L value3)
{

}

GenericMetod1<string, char, Personel>("String Parametre", 'c', new Personel());


static K GenericMetod2<K, L>(K value)
{
    // T tipi bu asamada bilinmedigi icin nasil geriye deger dondururuz?
    return default(K);
    // default(T) keywordu t tipi yerine gelecek olan tipin default degerini donecektir
}

// T, K gibi ifadeler metod yazim esnasinda kullanir
// T,K gibi ifadeler metodun kullanim esnasinda developer tarafindan verilecek olan tiplerin yerine gecer
// metod yazim asamasinda generic metod oldugu icin, tipi bu asamada belli degildir.
// bu sebeple tip yazilmak yerine tip yerine gecebilecek kisaltmalar kullanilmaktadir.
// bu kisaltmalar genelde T,K,L,M,N gibi kisaltmalar tavsiye edilir.
// ancak buralara verilecek olan kisaltma isimlerinde bir sinirlama yoktur.
// bazi kaynaklarda T,K,L,M,N kisaltmalarda sektor standardtidir.
// bazi kaynaklarda ise TKey, KValue gibi ifadelerde verilebilir.
// `dynamic` keywordu

//toplama yapan ve deger donen metod
static L Toplama<T, K, L>(T value1, K value2)
{
    dynamic birinciSayi = value1;
    dynamic ikinciSayi = value2;
    return birinciSayi + ikinciSayi;
}

Console.WriteLine(Toplama<int, int, double>(10, 2));
// int parametre alip double donsun dedik.

Console.WriteLine(Toplama<string, string, string>("Merhaba ", "Dunya"));
// iki string verirsek bu metod yine calisacaktir

// Kisitlamalar `where` keyword
// bu tarz kisitlanmamis metodlarda icerde yapabilecegimiz islem cok kisitlaniyor.
// Ancak metoda gelebilecek parametrelerde bir kisitlama yaparsak daha rahat hareket edebiliriz

// Interface kisitlamasi.
// Asagidaki ornekte T tipi IComparable interface implementasyonu olan tipleri alacak demis istiyoruz. 

static T EnBuyuk<T>(T a, T b) where T : IComparable
{
    if (a.CompareTo(b) == -1)
    {
        return b;
    }
    else if (a.CompareTo(b) == 1)
    {
        return a;
    }
    else
    {
        return a;
    }
    // a buyukse 1, b buyukse -1, ikisi esitse 0 donuyor.
}

// kontrol
Console.WriteLine(EnBuyuk<int>(20, 10));
// string te IComparable interface implementasyonu icerdigi icin string ile de calistirabiliriz
Console.WriteLine(EnBuyuk<string>("Ahmet", "Zeynep"));


// ODEV: Bir liste alip bu listedeki en buyuk sayiyi veren bir generic metod.



