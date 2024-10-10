#region 
/*
int a = 10;

Console.WriteLine(a);
IntDegistir(a);
Console.WriteLine(a);

string[] isimler = { "ayse", "fatma", "ali", "veli", "mustafa" };

Console.WriteLine(isimler[0]);
DiziDegistir(isimler);
Console.WriteLine(isimler[0]);

static void IntDegistir(int degisken)
{
    degisken = 11;
}

static void DiziDegistir(string[] dizi)
{
    dizi[0] = "degistirildi";
}
*/
#endregion

#region 
/*
int a;
DegerAta(out a);

static void DegerAta(out int a)
{
    a = 10;
}
*/
#endregion

#region 
/*
int b;
bool isOk = int.TryParse("abc", out b);

Console.WriteLine(isOk);
Console.WriteLine(b);
*/
#endregion

#region kendi tryparse metodunu yazalim
/*
static bool MyTryParse(string text, out int value)
{
    bool isNumber = true;

    for (int i = 0; i < text.Length; i++)
    {
        if (!char.IsDigit(text[i]))
        {
            isNumber = false;
            break;
        }
    }
    if (isNumber)
    {
        value = Convert.ToInt32(text);
    }
    else
    {
        value = 0;
    }
    return isNumber;
}

int a;

Console.WriteLine(MyTryParse("1234", out a) + " " + a);
*/
/*
int a; // disarda deger almayi bekleyen degisken
static bool SayiMi(string s, out int a) // metod, s adinda bir string alacak, disari a adinda bir int deger gonderecek
{
    a = 0; // bir donusum olmazsa baslangic degeri olarak 0 verdim.
    for (int i = 0; i < s.Length; i++)
    {
        if (!char.IsDigit(s[i])) // metnin icinde geziyoruz, rakam mi diye soruyoruz, rakam degilse bu kod blogu calisacak
        {
            return false;// kod blogu calisirsa direk disari false degerini gonderip metod calismayi sonlandiracak, bu durumda donusum islemi yapilmadigi icin disari gonderdigimiz 'a' degeri basta tanimladigimiz 0 degeri ile gidecek. Yani metod geriye false dondu ve a degiskenini 0 olarak atadi, calismayi bitirdi
        }
    }
    a = int.Parse(s); // yukardaki dongude hic bir sekilde harf bulamaz ise(yani metin sayilardan olusuyorsa), metni inte donusturup a degerine atadik, a degeri out oldugu icin disari gitti
    return true; // ve fonskiyon calismayi bitirmeden once disari true degeri dondurup islemi sonlandirdi
}
Console.WriteLine(SayiMi("1234", out a)); // fonskiyon icine yazdigimiz stringin sayi olup olmadigina bakacak, burda sayi olmadigi icin false donecek , 
Console.WriteLine(a); // ve a degiskenine 0 atayacak
*/
#endregion

#region Metot OverLoading
/*
internal class Program
{
    private static void Main(string[] args)
    {
    }
    static void Deneme(int a)
    {

    }

    static void Deneme(string a, string b)
    {

    }
}
*/

#endregion

#region Params
/*
static void SinirsizParametre(params int[] parameters)
{
    var toplam = 0;
    foreach (var item in parameters)
    {
        toplam += item;
    }
    Console.WriteLine($"Toplam => {toplam} || Ortalama => {toplam / parameters.Length}");
}

SinirsizParametre(10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0);
*/
#endregion

#region 
static void Metod1(int a = 10)
{
    Console.WriteLine(a);
}

Metod1();
static void Metod2(string value = "")
{

}
#endregion