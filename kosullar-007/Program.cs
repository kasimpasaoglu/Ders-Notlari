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
/*

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
*/
#endregion

#region CALISMA => notun harf karsiligi ve kaldi/ gecti bilgisi
/*
Console.WriteLine("Ilk Vize Notunuzu Giriniz :");
double firstMidtermGrade = double.Parse(Console.ReadLine().Replace('.', ',').Trim());

Console.WriteLine("Ikinci Vize Notunuzu Giriniz :");
double secondMidtermGrade = double.Parse(Console.ReadLine().Replace('.', ',').Trim());

Console.WriteLine("Final Notunuzu Giriniz :");
double finalGrade = double.Parse(Console.ReadLine().Replace('.', ',').Trim());

Console.WriteLine("Vize Sinavlarinin Toplam Katsayisini (Agirlik) Giriniz (0-1 arasi) :");
double totalMidtermWeight = double.Parse(Console.ReadLine().Replace('.', ',').Trim());

Console.WriteLine("Final Sinavinin Katsayisini (Agirlik) Giriniz (0-1 arasi):");
double finalWeight = double.Parse(Console.ReadLine().Replace('.', ',').Trim());

DateTime start = DateTime.Now;

double avarageGrade = firstMidtermGrade * totalMidtermWeight / 2 + secondMidtermGrade * totalMidtermWeight / 2 + finalGrade * finalWeight;

bool isGradeInputCorrect =
(firstMidtermGrade >= 0) &&
(firstMidtermGrade <= 100) &&
(secondMidtermGrade >= 0) &&
(secondMidtermGrade <= 100) &&
(finalGrade >= 0) &&
(finalGrade <= 100);

bool isWeightInputCorrect =
(totalMidtermWeight > 0) &&
(totalMidtermWeight <= 1) &&
(finalWeight > 0) &&
(finalWeight <= 1);


if (isGradeInputCorrect)
{
    if (isWeightInputCorrect)
    {
        if (totalMidtermWeight + finalWeight == 1)
        {
            if (avarageGrade > 50)
            {
                Console.WriteLine("Sinifi Gectiniz");
                if (avarageGrade >= 50 && avarageGrade < 56)
                {
                    string mark = "D";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 56 && avarageGrade < 62)
                {
                    string mark = "D+";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 62 && avarageGrade < 70)
                {
                    string mark = "C-";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 70 && avarageGrade < 74)
                {
                    string mark = "C";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 74 && avarageGrade < 78)
                {
                    string mark = "C+";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 78 && avarageGrade < 82)
                {
                    string mark = "B-";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 82 && avarageGrade < 86)
                {
                    string mark = "B";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 86 && avarageGrade < 90)
                {
                    string mark = "B+";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 90 && avarageGrade < 95)
                {
                    string mark = "A-";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 95 && avarageGrade <= 100)
                {
                    string mark = "A";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
            }
            else
            {
                Console.WriteLine("Sinifta Kaldiniz");
                if (avarageGrade >= 40 && avarageGrade < 50)
                {
                    string mark = "F";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade >= 0 && avarageGrade < 40)
                {
                    string mark = "FF";
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
                if (avarageGrade < 0) // bu degere asla dusmez, cunku sorgulamalar sonucu asla negatif cikmayacak zaten
                {
                    string mark = "WTF";
                    Console.WriteLine("Imkansizi Basardiniz :)");
                    Console.WriteLine("Harf Notunuz {0}, not ortalamaniz {1}", mark, avarageGrade);
                }
            }
        }
        else
        {
            Console.WriteLine("Katsayilar Toplami 1 olmalidir.");
        }
    }
    else
    {
        Console.WriteLine("Katsayilar 0-1 araliginda olmalidir");
    }
}

else
{
    Console.WriteLine("Notlar 0-100 araliginda olmalidir");
}

Console.WriteLine();

DateTime end = DateTime.Now;

TimeSpan workTime = end - start;

Console.WriteLine("Hesaplama Suresi {0}ms", Math.Round(workTime.TotalMilliseconds));
*/
#endregion

#region  Ayrintili Yas Hesapla, dogum gunune ne kadar kaldigini hesapla. Dogum Gununun hangi gune denk gelecegini hesapla
/*
Console.WriteLine("Dogum Tarihinizi Giriniz (gg.aa.yyyy) :");
string userInput = Console.ReadLine();

DateTime startProcess = DateTime.Now; // process baslangic zamanini al (perf. olcumu icin)

// saat bilgisiyle ugrasmak istemedigim icin sadece tarihi aldim (DateOnly). Ancak TimeSpan yaparken tekrar DateTime' a donusturmek gerekiyormus...
DateOnly userBirthDate = DateOnly.Parse(userInput);
DateOnly today = DateOnly.FromDateTime(DateTime.Now);

int age = today.Year - userBirthDate.Year;

DateOnly nextBirthday = userBirthDate.AddYears(age); // dogum tarihine yil farkini(buldugumuz yasi) ekleyip bir sonraki dogum tarihini bul, Bu tarih bu yilki dogum gunudur..


if (today < nextBirthday) // eger dogum gunu bu yilda henuz gelmediyse
{
    age--; // dogum tarihi bu yil icinde heniz gelmedigi icin yastan bir cikar
    Console.WriteLine("Yasiniz {0}", age);
}
else if (today == nextBirthday)
{
    age--;
    int oldAge = age;
    age++;

    Console.WriteLine($"Bu gun dogum gununuz! {oldAge} yasindan {age} yasina girdiniz!");
    nextBirthday = nextBirthday.AddYears(1); // tarihe 1 yil ekleyip onumuzdeki yilin dogum tarihini aliyoruz.
}
else
{
    nextBirthday = nextBirthday.AddYears(1); // dogum gunu bu yil gectigi icin, tarihe 1 yil ekleyip onumuzdeki yilin dogum tarihini aliyoruz.
    Console.WriteLine("Yasiniz {0}", age);
}

TimeSpan remaining = nextBirthday.ToDateTime(TimeOnly.MinValue) - today.ToDateTime(TimeOnly.MinValue); // bir sonraki dogum gunu tarihine olan farki bul

double totalDaysToBirtday = remaining.TotalDays;
// Ay ve gun farkini hesaplamak icin;
double months = totalDaysToBirtday / 30;
double days = totalDaysToBirtday % 30;

int monthsToBirthDay = (int)Math.Floor(months); // kalan ay
int daysToBirthDay = (int)Math.Floor(days); // kalan gun

Console.WriteLine("Bir Sonraki Dogum Gununuz {0}", nextBirthday.ToLongDateString());

if (monthsToBirthDay >= 1) // eger ay farki 1 den buyuk ve ya esitse, Yani dogum gunune bir aydan daha fazla zaman varsa ay ve gun bilgisini paylasiyoruz. 
{
    Console.WriteLine("Bir Sonraki Dogum Gununuze Kalan  => {0} Ay, {1} Gun", monthsToBirthDay, daysToBirthDay);
}
else    // bir aydan az zaman kaldiysa sadece gun bilgisini paylasiyoruz
{
    Console.WriteLine("Bir Sonraki Dogum Gununuze Kalan  => {0} Gun", daysToBirthDay);
}
Console.WriteLine();
DateTime finishProcess = DateTime.Now; // process bitis zamanini al
TimeSpan processLenght = finishProcess - startProcess; // farki al
Console.WriteLine("Islem Suresi {0}ms", Math.Round(processLenght.TotalMilliseconds)); // milisaniye cinsinden yazdir
*/
#endregion

#region Pizza Fiyati Hesaplama
/*
Console.WriteLine("Boyut seciniz : (kucuk / orta / buyuk)");
string size = Console.ReadLine().ToLower().Trim();

int pizzaPrice = 75;

string orderMassage = "Pizza Ucreti 75tl. Siparis Detaylariniz: ";

if (size == "kucuk")
{
    pizzaPrice += 50;
    orderMassage += "Kucuk Boy Farki (+50), ";
}

else if (size == "orta")
{
    pizzaPrice += 100;
    orderMassage += "Orta Boy Farki (+100), ";
}

else if (size == "buyuk")
{
    pizzaPrice += 150;
    orderMassage += "Buyuk Boy Farki (+150)";
}
else
{
    Console.WriteLine("Girdiginiz Boyut Hatali...");
}

Console.WriteLine("Ekstra Malzemeleri Yaziniz : (Peynir / Mantar / Sucuk / Misir / Sosis)");
string extra = Console.ReadLine().ToLower().Trim();

bool isExtraCorrect = false;
string extraMassage = "Ekstra Malzemeler: ";

if (extra.Contains("peynir"))
{
    pizzaPrice += 20;
    extraMassage += "Peynir (+20), ";
    isExtraCorrect = true;
}

if (extra.Contains("mantar"))
{
    pizzaPrice += 20;
    extraMassage += "Mantar (+20), ";
    isExtraCorrect = true;
}

if (extra.Contains("sucuk"))
{
    pizzaPrice += 30;
    extraMassage += "Sucuk (+30), ";
    isExtraCorrect = true;
}

if (extra.Contains("misir"))
{
    pizzaPrice += 20;
    extraMassage += "Misir (+20), ";
    isExtraCorrect = true;
}

if (extra.Contains("sosis"))
{
    pizzaPrice += 30;
    extraMassage += "Sosis (+30)";
    isExtraCorrect = true;
}
if (!isExtraCorrect)
{
    Console.WriteLine("Ekstra Malzeme Secimi Yapilmadi...");
}

double totalVat = Math.Round(pizzaPrice * 0.20, 2);
double totalPrice = Math.Round(pizzaPrice * 1.20, 2);
Console.WriteLine();
Console.WriteLine(orderMassage);
Console.WriteLine(extraMassage);
Console.WriteLine();
Console.WriteLine("Tutar = {0}tl + Hesaplanan KDV {1} tl", pizzaPrice, totalVat);
Console.WriteLine("Toplam = {0}tl", totalPrice);
*/
#endregion

#region Atm Simulasyonu (while Denemesi)

string userId = "1234";
string password = "1234";
double accountBalance = 10000.00;

Console.WriteLine("Hesap No Giriniz:");
string userIdInput = Console.ReadLine().Trim();

Console.WriteLine("Sifrenizi Giriniz:");
string userPasswordInput = Console.ReadLine().Trim();
bool isRunning = true;

if (userIdInput == userId && userPasswordInput == password)
{
    Console.WriteLine("Giris Basarili");
    Console.WriteLine();
    while (isRunning)
    {
        Console.WriteLine();
        Console.WriteLine("Yapmak Istediginiz Islemi Seciniz :");
        Console.WriteLine("1. Bakiye Goruntule");
        Console.WriteLine("2. Para Cekme");
        Console.WriteLine("3. Para Yatirma");
        Console.WriteLine("4. Cikis");
        char userInput = char.Parse(Console.ReadLine().Trim());

        if (userInput == '1')
        {
            Console.WriteLine("Hesap Bakiyeniz : {0}TL", accountBalance);
        }
        else if (userInput == '2')
        {
            Console.WriteLine("Hesap Bakiyeniz : {0}TL. Cekmek Istediginiz Tutari Giriniz", accountBalance);
            double settleAmount = double.Parse(Console.ReadLine());
            if (accountBalance >= settleAmount)
            {
                accountBalance -= settleAmount;
                Console.WriteLine("Hesabinizdan {0}TL Cektiniz. Kalan Bakiyeniz {1}TL", settleAmount, accountBalance);
            }
            else if (accountBalance < settleAmount)
            {
                Console.WriteLine("Hesap Bakiyeniz Bu Islem Icin Yeterli Degildir...");
            }
            else
            {
                Console.WriteLine("Hatali Islem Yaptiniz");
            }

        }
        else if (userInput == '3')
        {
            Console.WriteLine("Hesap Bakiyeniz : {0}TL. Yatirmak Istediginiz Tutari Giriniz", accountBalance);
            double depositAmount = double.Parse(Console.ReadLine());
            if (depositAmount > 0)
            {
                accountBalance += depositAmount;
                Console.WriteLine("Hesabiniza {0}TL Yatirdiniz. Toplam Bakiyeniz {1}TL", depositAmount, accountBalance);
            }
            else
            {
                Console.WriteLine("Yatirilacak Tutar Hatali Girildi...");
            }
        }
        else if (userInput == '4')
        {
            Console.WriteLine("Cikis Yapiliyor");
            isRunning = false;
        }
        else
        {
            Console.WriteLine("Hatali Secim Yaptiniz");
        }
    }
}

if (userIdInput != userId)
{
    Console.WriteLine("Hesap No Hatali");
}

if (userPasswordInput != password)
{
    Console.WriteLine("Sifre Hatali");
}

#endregion