#region syntax
/*
try
{
    // hata olmasi beklenen kod blogu buraya yazilir
    // burdaki kod blogunda bir runtime hatasi olursa catch blogunun icindeki kod calisir
}
catch (System.Exception)
{
    // try icindeki blokta bir hata olursa derleyici otomatik olarak, catch blogu icine gelir.
    throw;
}
*/
#endregion

#region sifira bolunme durumda hata verecek, biz bu hatayi try catch ile yakalayalim
/*
Console.WriteLine("1. Sayiyi Giriniz");
int sayi1 = int.Parse(Console.ReadLine().Trim());

Console.WriteLine("2. Sayiyi Giriniz");
int sayi2 = int.Parse(Console.ReadLine().Trim());

try
{
    // bolme isleminde 0'a bolunmeme kurali oldugu icin, sayi 2 degerine 0 gelirse burda hata meydana gelebilir
    int sonuc = sayi1 / sayi2;
    Console.WriteLine(sonuc);

}
catch
{
    Console.WriteLine("Bolen Sifir Olamaz");
}
*/
#endregion

#region 
/*
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
*/
#endregion

#region catch bloklarini ozellestirmek
/*
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
*/
#endregion

#region throw new Exception()
/*
int deger = 0;
try
{
    string veri = Console.ReadLine().Trim();
    bool isLetter = false;
    for (int i = 0; i < veri.Length; i++)
    {
        if (char.IsLetter(veri[i]))
        {
            isLetter = true;
            break;
        }
    }

    if (isLetter)
    {
        throw new InvalidOperationException("Girdigin verinin icerisinde harf var");
        // kendi exceptionumuzu firtlattik, derleyici bu satira gelince uygulama bir exception firlatacak
    }
    else
    {
        deger = int.Parse(veri);
    }

    if (deger < 50)
    {
        throw new Exception("Degeriniz 50 den Kucuk");
        // kendi exceptionumuzu firtlattik, derleyici bu satira gelince uygulama bir exception firlatacak
    }


}
catch (Exception ex) // firlatilan exceptionu yakalayacak
{
    Console.WriteLine(ex.Message);
}
*/
#endregion

#region olusan hatayi log dosyasina kaydetmek
/*
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
*/
#endregion

#region ic ice try catch
/*
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
*/
#endregion

#region 

#endregion