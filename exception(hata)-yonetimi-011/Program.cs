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

#endregion