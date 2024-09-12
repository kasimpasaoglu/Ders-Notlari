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
// Console.WriteLine("lutfen notunuzu giriniz");
// int note = int.Parse(Console.ReadLine());

// if (note < 50)
// {
//     if (note < 25)
//     {
//         Console.WriteLine("Kaldi");
//     }
//     else
//     {
//         Console.WriteLine("Dusuk Ama Gecti");
//     }
// }
// else
// {
//     if (note < 75)
//     {
//         Console.WriteLine("Orta Seviyeli Gecti");
//     }
//     else
//     {
//         Console.WriteLine("Cok Iyi Seviyeli Gecti");
//     }
// }
#endregion

#region hesap makinesi
/*
Console.WriteLine("Ilk Sayiyi Girin :");
double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Ikinci Sayiyi Girin:");
double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Yapilacak Islemi Giriniz => (+)(-)(/)(*)");
string islem = Console.ReadLine();


if ((islem == "+") || (islem == "-") || (islem == "/") || (islem == "*"))
{
    if (islem == "+")
    {
        Console.WriteLine("Sonuc = {0}", firstNumber + secondNumber);
    }

    if (islem == "-")
    {
        Console.WriteLine("Sonuc = {0}", firstNumber - secondNumber);
    }

    if (islem == "*")
    {
        Console.WriteLine("Sonuc = {0}", firstNumber * secondNumber);
    }

    if (islem == "/")
    {
        Console.WriteLine("Sonuc = {0}", firstNumber / secondNumber);
    }
}
else
{
    Console.WriteLine("Lutfen Gecerli Bir Islem Giriniz");
}
*/
#endregion

#region iki farkli urun fiyati al(veri kontrolu yap: negatif degeri kabul etme) indirim oranini al (0 ile 1 araliginda degilse kabul etme), iki urun toplami 1000 tl den fazlaysa, ucuz olan urune verilen oranda indirim yap. toplam tutara KDV ekle.


Console.WriteLine("Birinci Urun Fiyatini Giriniz :");
double price1 = double.Parse(Console.ReadLine().Replace('.', ',').Trim());

Console.WriteLine("Ikinci Urun Fiyatini Giriniz :");
double price2 = double.Parse(Console.ReadLine().Replace('.', ',').Trim());

Console.WriteLine("Indirim Oranini Giriniz :");
double discount = double.Parse(Console.ReadLine().Replace('.', ',').Trim());


if ((price1 > 0) && (price2 > 0) && (discount > 0) && (discount < 1))
{
    if (price1 + price2 >= 1000)
    {
        double totalPrice = (Math.Min(price1, price2) * (1 - discount) + Math.Max(price1, price2)) * 1.20;
        Console.WriteLine("Toplam odemeniz gereken tutar => {0} tl", totalPrice);
    }
    else
    {
        Console.WriteLine("Toplam odemeniz gereken tutar => {0} tl", (price1 + price2) * 1.20);
    }

}
else
{
    Console.WriteLine("Lutfen Degerleri Kontrol Edip Tekrar Deneyiniz");
}

#endregion

