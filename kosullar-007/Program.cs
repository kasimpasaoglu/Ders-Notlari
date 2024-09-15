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

#region (Ders) else-if
/*
System.Console.WriteLine("Not Giriniz");
int not = int.Parse(Console.ReadLine());

if (not > 0 && not <= 24)
{
    Console.WriteLine("1 Aldin");
}
else if (not >=25 && not <=44)
{
    Console.WriteLine("2 Aldin");
}
else if (not >= 45 && not <=60 )
{
    Console.WriteLine("3 Aldin");
}
else if (not >= 60 && not <= 84)
{
    Console.WriteLine("4 Aldin");
}
else if ( not >= 85 && not <= 100)
{
    Console.WriteLine("5 Aldin");
}
else
{
    Console.WriteLine("Lutfen Gecerli Bir Not Girin");
}
*/
#endregion

#region (Ders Hesap Mak.) ikinci sayi sifir olamaz.
/*
Console.WriteLine("Ilk Sayiyi Giriniz");
double input1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ikinci Sayiyi Giriniz");
double input2 = double.Parse(Console.ReadLine());

Console.WriteLine("islem Tipini Seciniz '+'-'*'/' :");
char process = char.Parse(Console.ReadLine());

double result;


if (process == '+')
{
    Console.WriteLine(input1 + input2);
}
else if (process == '-')
{
    Console.WriteLine(input1 - input2);
}
else if (process == '*')
{
    Console.WriteLine(input1 * input2);
}
else if (process == '/')
{
    if (input2 != 0)
    {
        Console.WriteLine(input1 / input2);
    }
    else
    {
        Console.WriteLine("Bolen sifir olamaz.");
    }
}
else
{
    Console.WriteLine("Hatali Secim Yaptiniz");
}
*/
#endregion

#region (ders) Ekran ve cevre hesaplama araci.
// oncelikle yapilabilecek seyler ciksin kullanici birini secsin, cevre mi alan mi hesaplanacak
// secime gore degerler kullanicidan alinsin ve sonuc gostersin.
/*
Console.WriteLine("Ucgen icin 'ucgen' yaziniz");
Console.WriteLine("Daire icin 'daire' yaziniz");
string shape = Console.ReadLine().ToLower().Trim();

Console.WriteLine("Cevre / Alan ??");
string userChoice = Console.ReadLine().ToLower().Trim();

if (shape == "ucgen")
{

    if (userChoice == "alan")
    {
        Console.WriteLine("Taban Uzunlugu Girin");
        double bottomLenght = double.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Yukseklik Girin");
        double heightLenght = double.Parse(Console.ReadLine().Trim());

        double area = Math.Round(bottomLenght * heightLenght / 2, 2);
        Console.WriteLine("Ucgenin Alani => {0}", area);
    }
    else if (userChoice == "cevre")
    {
        Console.WriteLine("Taban Uzunlugu Girin");
        double bottomLenght = double.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Komsu Kenar Uzunlugu Girin");
        double heightLenght = double.Parse(Console.ReadLine().Trim());

        double perimeter = Math.Round(bottomLenght + (heightLenght * 2), 2);
        Console.WriteLine("Cevresi : {0}", perimeter);
    }
    else
    {
        Console.WriteLine("Lutfen Gecerli Bir Secim Yapiniz...");
    }
}
else if (shape == "daire")
{

    if (userChoice == "alan")
    {
        Console.WriteLine("Yaricapini giriniz :");
        double radiusHalf = double.Parse(Console.ReadLine().Trim());
        double area = Math.Round(Math.PI * Math.Pow(radiusHalf, 2), 2);
        Console.WriteLine("Alani : {0}", area);
    }
    else if (userChoice == "cevre")
    {
        Console.WriteLine("Yaricapini giriniz :");
        double radiusHalf = double.Parse(Console.ReadLine().Trim());
        double perimeter = Math.Round(2 * Math.PI * radiusHalf, 2);

        Console.WriteLine("Cevresi : {0}", perimeter);
    }
    else
    {
        Console.WriteLine("Lutfen Gecerli Bir Deger Girin");
    }

}
else
{
    Console.WriteLine("Lutfen Gecerli Bir Secim Yapin (Ucgen/Daire)");
}
*/
#endregion

#region Ternary Operatoru Giris
/*
Console.WriteLine("Sayi Giriniz");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Sayi Giriniz");
int sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine("Secim Giriniz");
char secim = char.Parse(Console.ReadLine());

int result = secim == '+' ? sayi1 + sayi2 : 0;
Console.WriteLine(result);
*/
#endregion

#region randomdan girilen karaker sayisi 10 dan fazlaysa cok uzun kisaysa cok kisa yazsin
/*
Random rnd = new Random();
string random = rnd.Next(999999999, 1000000001).ToString();

string result = random.Length >= 10 ? "Cok Uzun" : "Cok Kisa";

Console.WriteLine(random);
Console.WriteLine(result);
*/
#endregion

#region ekrandan almis oldugunuz karakter "A' ile basliyorsa, "karakter "A" ile basliyor yazdir, (tersini de yazdir) 
/*
Console.WriteLine("Bir Metin Giriniz");
string input = Console.ReadLine().ToUpper().Trim();

string result = input.StartsWith('A') ? "Metin 'A' Harfi Ile Basliyor" : "Metin 'A' Harfi Ile Baslamiyor";
Console.WriteLine(result);
*/
#endregion

#region Switch Case Ilk Ornek
/*
Console.WriteLine("Ilk Sayiyi Giriniz");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ikinci Sayiyi Giriniz");
int sayi2 = int.Parse(Console.ReadLine());

Console.WriteLine("Islem Tipini Giriniz");
char tip = char.Parse(Console.ReadLine());
switch (tip) // tip verisini kontrol edecek
{
    case '+': // tip + gelirse asagidaki blogu calistir
        Console.WriteLine(sayi1 + sayi2);
        break; // blok sonu

    case '-':
        Console.WriteLine(sayi1 - sayi2);
        break;

    case '*':
        Console.WriteLine(sayi1 * sayi2);
        break;

    case '/':
        switch (sayi2)
        {
            case 0:
                Console.WriteLine("Bolen Sifir Olamaz");
                break;
            default:
                Console.WriteLine(sayi1 / sayi2);
                break;
        }
        break;



    default: // else
        Console.WriteLine("Gecersiz Islem Tipi");
        break;
}

*/
#endregion

#region ekrandan bir gun al, haftaici mi haftasonu mu onu kontrol edip ekrana yazdir.
/*
Console.WriteLine("Bir Gun Giriniz");
string inputDay = Console.ReadLine().ToLower().Trim();

switch (inputDay)
{
    case "pazartesi":
    case "sali":
    case "carsamba":
    case "persembe":
    case "cuma":
        Console.WriteLine("girdiginiz gun hafta ici");
        break;
    case "cumartesi":
    case "pazar":
        Console.WriteLine("girdiginiz gun hafta sonu");
        break;

}
*/
#endregion

