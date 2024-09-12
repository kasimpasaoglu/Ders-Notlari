#region ornek1 kosul true ise
/*
bool isOk = true;

Console.WriteLine("A");
if (isOk)
{
    Console.WriteLine("B");
}
Console.WriteLine("C");
*/
#endregion

#region ornek2 kosul false ise
/*
bool isOk = false;

Console.WriteLine("A");
if (isOk)
{
    Console.WriteLine("B");
}
Console.WriteLine("C");
*/
#endregion

#region ornek3 bool yerine mantiksal operator 
/*
Console.WriteLine("Lutfen Bir Sayi Giriniz");

int intDegisken = int.Parse(Console.ReadLine());

bool isOk = intDegisken > 5;

if(isOk)
{
    Console.WriteLine("Girilen Deger 5'ten Buyuk");
}
*/
#endregion

#region daha kisa yontem
/*
Console.WriteLine("Lutfen Bir Sayi Giriniz");

int intDegisken = int.Parse(Console.ReadLine());

if (intDegisken > 5)
{
    Console.WriteLine("Girilen Deger 5'ten Buyuk");
}
*/
#endregion

#region ornek3 sayi tek ya da sayi cift
/*
Console.WriteLine("Lutfen Bir Sayi Giriniz");
int intDegisken = int.Parse(Console.ReadLine());

if (intDegisken % 2 == 0)
{
    Console.WriteLine("Girdiginiz sayi cift");
}
if (intDegisken % 2 != 0)
{
    Console.WriteLine("Girdiginiz sayi tek");
}
*/
#endregion

#region ornek3 un daha dogru yazilisi

// Console.WriteLine("Lutfen Bir Sayi Giriniz");
// int intDegisken = int.Parse(Console.ReadLine());

// if (intDegisken % 2 == 0)
// {
//     Console.WriteLine("Girdiginiz sayi cift");
// }

// else
// {
//     Console.WriteLine("Girdiginiz sayi tek");
// }

#endregion

#region ornek odev ekrandan bir karakter alalim, bu karakter buyuk harf ise ekrana buyuk harf, degilse ekrana kucuk harf yazsin.
/*
// 64 ile 91 araligi buyuk harf
// 96 ile 123 araligi kucuk harf

Console.WriteLine("bir karakter girin");
int input = Convert.ToInt32(char.Parse(Console.ReadLine()));

if (input > 64 && input < 91)
{
    Console.WriteLine("Girdiginiz Harf Buyuk");
}
else
{
    Console.WriteLine("Girdiginiz harf kucuk");
}
*/
#endregion

#region kullanicidan not bilgisini aliniz, Not 50 den dusuk ise kaldi buyuk ise gecti yazin
/*
Console.WriteLine("Notunuzu Yazin :");
int userNote = int.Parse(Console.ReadLine());

if (userNote >= 50)
{
    Console.WriteLine("KALDI");
}
else
{
    Console.WriteLine("GECTI");
}
*/
// farkli bir yontem
// string isUserPassed = Convert.ToString(userNote >= 50);
// string userPassed = isUserPassed.Replace("True", "GECTI").Replace("False", "KALDI");
// Console.WriteLine(userPassed);
#endregion

#region kullanicidan aldigimiz username=wissen ve passworld=1010 esitse giris basarili degilse basarisiz yazsin


// string userNameData = "wissen";
// string userPaswordData = "1010";

// Console.WriteLine("Kullanici Adinizi Girin");
// string userNameInput = Console.ReadLine().Trim();
// Console.WriteLine("Sifrenizi Girin");
// string userPasswordInput = Console.ReadLine().Trim();

// if (userNameInput == userNameData && userPasswordInput == userPaswordData)
// {
//     Console.WriteLine("Giris Basarili");
// }
// else
// {
//     Console.WriteLine("Kullanici Adi || Sifre Hatali");
// }

#endregion

#region ekrandan bir urun fiyati degeri alalim, urun fiyati degeri 100 den buyuk ise %20 kdv ekleyip ekranda gosterelim. 100 den kucuk ise %30 indirim yapip ekrana yazdiralim.
/*
Console.WriteLine("Aldiginiz Urunun Fiyatini Girin");
double initPrice = double.Parse(Console.ReadLine());

if (initPrice > 100)
{
    Console.WriteLine("Sepetteki Tutar => {0}", initPrice * 1.20);
}
else
{
    Console.WriteLine("sepetteki tutar => {0}", initPrice * 0.70);
}
*/
#endregion

#region ic ice if else kullanimi
Console.WriteLine("lutfen notunuzu giriniz");
int note = int.Parse(Console.ReadLine());

if (note < 50)
{
    if (note < 25)
    {
        Console.WriteLine("Kaldi");
    }
    else
    {
        Console.WriteLine("Dusuk Ama Gecti");
    }
}
else
{
    if (note < 75)
    {
        Console.WriteLine("Orta Seviyeli Gecti");
    }
    else
    {
        Console.WriteLine("Cok Iyi Seviyeli Gecti");
    }
}
#endregion