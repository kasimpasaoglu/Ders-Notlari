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
/*
string userId = "1234";
string password = "1234";
double accountBalance = 10000.00;

Console.WriteLine("Hesap No Giriniz:");
string userIdInput = Console.ReadLine().Trim();

Console.WriteLine("Sifrenizi Giriniz:");
string userPasswordInput = Console.ReadLine().Trim();
bool isRunning = true;

if (userIdInput != userId)
{
    Console.WriteLine("Hesap No Hatali");
}

else if (userPasswordInput != password)
{
    Console.WriteLine("Sifre Hatali");
}

else if (userIdInput == userId && userPasswordInput == password)
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
            if (accountBalance >= settleAmount && settleAmount > 0)
            {
                accountBalance -= settleAmount;
                Console.WriteLine("Hesabinizdan {0}TL Cektiniz. Kalan Bakiyeniz {1}TL", settleAmount, accountBalance);
            }
            else if (accountBalance < settleAmount)
            {
                Console.WriteLine("Hesap Bakiyeniz Bu Islem Icin Yeterli Degildir...");
            }
            else if (settleAmount <= 0)
            {
                Console.WriteLine("Cekilecek Tutar Hatali");
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

*/
#endregion

#region Gift Karti Vergi Avantaji Hesaplama Ders Disi
/*
// gelir v %20  => 0.20 
// damga v %0.75 => 0.0075
// sgk isci payi %14 => 0.14 -
// sgk isveren payi %20.5 => 0.205 -
// issizlik sig isci payi %1 => 0.01 - 
// issizlik sig isveren %2 => 0.02 -

// bir kisiye yatirilacak tutar verisi al
// kac kisi bilgisini al
// nakit odenirse butun vergileri ekle sonucu goster
// gift ile odenirse sadece gelir ve damga vergisi ekle tutari goster
// gift ile odenirse kisi basi ne kadar vergi avantaji cikacak
// gift ile odenirse toplam ne kadar vergi avantahi cikacak


Console.WriteLine("Hediye (Gift) Tutarini Giriniz :");
double giftAmount = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

Console.WriteLine("Kisi Sayisini Giriniz :");
int workerAmount = int.Parse(Console.ReadLine().Trim());

// Vergi ve Kesinti Oranları
double incomeTaxRate = 0.20;                     // Gelir Vergisi %20
double stampTaxRate = 0.00759;                    // Damga Vergisi %0.759
double workerSocialSecurityRate = 0.14;        // SGK İşçi Payı %14
double employerSocialSecurityRate = 0.205;       // SGK İşveren Payı %20.5
double workerUnemploymentInsuranceRate = 0.01; // İşsizlik Sigortası İşçi Payı %1
double employerUnemploymentInsuranceRate = 0.02; // İşsizlik Sigortası İşveren Payı %2

double gross = giftAmount / (1 - (workerSocialSecurityRate + workerUnemploymentInsuranceRate + incomeTaxRate * (1 - workerSocialSecurityRate - workerUnemploymentInsuranceRate) + stampTaxRate));


double grossTotal = gross + (employerSocialSecurityRate + employerUnemploymentInsuranceRate) * gross;


double workerSSTPerPerson = gross * workerSocialSecurityRate;
double employerSSTPerPerson = gross * employerSocialSecurityRate;
double workerUITPerPerson = gross * workerUnemploymentInsuranceRate;
double employerUITPerPerson = gross * employerUnemploymentInsuranceRate;
double stampTaxPerPerson = gross * stampTaxRate;
double incomeTaxPerPerson = (gross - workerSSTPerPerson - workerUITPerPerson) * incomeTaxRate;

double totalTaxPerPerson = stampTaxPerPerson + workerSSTPerPerson + employerSSTPerPerson + workerUITPerPerson + employerUITPerPerson + incomeTaxPerPerson;

Console.WriteLine("Maasa Ek => {0}", giftAmount);
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Kisi Basi Gelir Vergisi (%20) => {0}", Math.Round(incomeTaxPerPerson, 2));
Console.WriteLine("Kisi Basi Damga Vergisi (%0,759) => {0}", Math.Round(stampTaxPerPerson, 2));
Console.WriteLine();
Console.WriteLine("Kisi Basi SGK Isci Payi (%14) => {0}", Math.Round(workerSSTPerPerson, 2));
Console.WriteLine("Kisi Basi SGK Isveren Payi (%20,5) => {0}", Math.Round(employerSSTPerPerson, 2));
Console.WriteLine("Kisi Basi Issizlik Sigortasi Isci Payi (%1) => {0}", Math.Round(workerUITPerPerson, 2));
Console.WriteLine("Kisi Basi Issizlik Sigortasi Isveren Payi (%2) => {0}", Math.Round(employerUITPerPerson, 2));
Console.WriteLine();
Console.WriteLine("Kisi Basi Toplam Odenecek Toplam Vergi => {0}", Math.Round(totalTaxPerPerson, 2));
Console.WriteLine("Kisi Basi Toplam Maliyet => {0}", Math.Round(grossTotal, 2));
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("{0} Calisan Icin Odenecek Toplam Vergi => {1}", workerAmount, Math.Round(totalTaxPerPerson * workerAmount, 2));
Console.WriteLine("{0} Calisan Icin Toplam Maliyet => {1}", workerAmount, Math.Round(grossTotal * workerAmount, 2));
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Pluxe Avantajlarini Gormek Icin Enter'a Basiniz...");
Console.ReadLine();


double pluxeeWorkerSocialSecurityRate = 0;
double pluxeeEmployerSocialSecurityRate = 0;
double pluxeeWorkerUnemploymentInsuranceRate = 0;
double pluxeeEmployerUnemploymentInsuranceRate = 0;

double pluxeeGross = giftAmount / (1 - (pluxeeWorkerSocialSecurityRate + pluxeeWorkerUnemploymentInsuranceRate + incomeTaxRate * (1 - pluxeeWorkerSocialSecurityRate - pluxeeWorkerUnemploymentInsuranceRate) + stampTaxRate));

double pluxeeGrossTotal = pluxeeGross + (pluxeeEmployerSocialSecurityRate + pluxeeEmployerUnemploymentInsuranceRate) * pluxeeGross;

double workerSSTPerPersonPluxee = pluxeeGross * pluxeeWorkerSocialSecurityRate;
double employerSSTPerPersonPluxee = pluxeeGross * pluxeeEmployerSocialSecurityRate;
double workerUITPerPersonPluxee = pluxeeGross * pluxeeWorkerUnemploymentInsuranceRate;
double employerUITPerPersonPluxee = pluxeeGross * pluxeeEmployerUnemploymentInsuranceRate;
double stampTaxPerPersonPluxee = pluxeeGross * stampTaxRate;
double incomeTaxPerPersonPluxee = (pluxeeGross - workerSSTPerPersonPluxee - workerUITPerPersonPluxee) * incomeTaxRate;

double pluxeeTotalTaxPerPerson = stampTaxPerPersonPluxee + workerSSTPerPersonPluxee + employerSSTPerPersonPluxee + workerUITPerPersonPluxee + employerUITPerPersonPluxee + incomeTaxPerPerson;


Console.WriteLine("Maasa Ek => {0}", giftAmount);
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Kisi Basi Gelir Vergisi (%20) => {0}", Math.Round(incomeTaxPerPersonPluxee, 2));
Console.WriteLine("Kisi Basi Damga Vergisi (%0,759) => {0}", Math.Round(stampTaxPerPersonPluxee, 2));
Console.WriteLine();
Console.WriteLine("Kisi Basi SGK Isci Payi (%14) => {0}", Math.Round(workerSSTPerPersonPluxee, 2));
Console.WriteLine("Kisi Basi SGK Isveren Payi (%20,5) => {0}", Math.Round(employerSSTPerPersonPluxee, 2));
Console.WriteLine("Kisi Basi Issizlik Sigortasi Isci Payi (%1) => {0}", Math.Round(workerUITPerPersonPluxee, 2));
Console.WriteLine("Kisi Basi Issizlik Sigortasi Isveren Payi (%2) => {0}", Math.Round(employerUITPerPersonPluxee, 2));
Console.WriteLine();
Console.WriteLine("Kisi Basi Toplam Odenecek Toplam Vergi => {0}", Math.Round(pluxeeTotalTaxPerPerson, 2));
Console.WriteLine("Kisi Basi Toplam Maliyet => {0}", Math.Round(pluxeeGrossTotal, 2));
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("{0} Calisan Icin Odenecek Toplam Vergi => {1}", workerAmount, Math.Round(pluxeeTotalTaxPerPerson * workerAmount, 2));
Console.WriteLine("{0} Calisan Icin Toplam Maliyet => {1}", workerAmount, Math.Round(pluxeeGrossTotal * workerAmount, 2));
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Toplam Kazancinizi Gormek Icin Enter'a Basiniz...");
Console.ReadLine();
Console.WriteLine("Kisi Basi Toplam Maaliyet Avantaji => {0}", Math.Round(grossTotal - pluxeeGrossTotal, 2));
Console.WriteLine("Toplam Maaliyet Avantaji => {0}", Math.Round((grossTotal - pluxeeGrossTotal) * workerAmount, 2));
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Kapatmak Icin Bir Tusa Basiniz");
Console.ReadLine();
*/
#endregion

#region Sifre Guvenlik Skoru Uygulamasi uzun yontem
/*
Console.WriteLine("Sifrenizi Yaziniz :");
string password = Console.ReadLine().Trim();
int passwordStrenght = 0;
string text;

if (password.Length > 8)
{
    passwordStrenght++;
}
if (password.Any(char.IsUpper))
{
    passwordStrenght++;
}
if (password.Any(char.IsLower))
{
    passwordStrenght++;
}
if (password.Any(char.IsDigit))
{
    passwordStrenght++;
}
if (password.Any(char.IsSymbol))
{
    passwordStrenght++;
}
if (password.Any(char.IsPunctuation))
{
    passwordStrenght++;
}

switch (passwordStrenght)    // BUNUN DAHA KISA YAZILABILECEK YONTEMI VAR!
{
    case 0:
    case 1:
        text = "Zayif Sifre";
        break;
    case 2:
    case 3:
        text = "Orta Sifre";
        break;
    case 4:
    case 5:
        text = "Iyi Sifre";
        break;
    case 6:
        text = "Mukemmel Sifre";
        break;
    default:
        text = "Hatali Giris";
        break;
}


// Format Fonksiyonu icine yazilan string ifadeyi WriteLine icine yazdirir gibi hazirlamamizi sagliyor.
string massage = passwordStrenght >= 0 && passwordStrenght <= 6
? string.Format("{0} ; Skoru {1} / 6", text, passwordStrenght)
: text;

Console.WriteLine(massage);
*/
#endregion

#region Sifre Guvenlik Skoru Uygulamasi Kisa yontem

/*


Console.WriteLine("Sifrenizi Yaziniz :");
string password = Console.ReadLine().Trim();

int passwordStrenght = 0;

passwordStrenght += password.Length > 8 ? 1 : 0;   // ternary operatoru ile skor verisine 1 ekle ve ya 0 ekle diyerek skoru belirliyoruz
passwordStrenght += password.Any(char.IsUpper) ? 1 : 0;
passwordStrenght += password.Any(char.IsLower) ? 1 : 0;
passwordStrenght += password.Any(char.IsDigit) ? 1 : 0;
passwordStrenght += password.Any(char.IsSymbol) ? 1 : 0;
passwordStrenght += password.Any(char.IsPunctuation) ? 1 : 0;

string text = passwordStrenght switch  // text degiskeninin icini switch case ile belirlenen kosullara gore yaziyoruz
{
    0 or 1 => "Zayif Sifre",   // => isaretini henuz ogrenmedik, ancak sanirim ternary deki ? isaretine benzer bir anlami var 
    2 or 3 => "Orta Sifre",
    4 or 5 => "Iyi Sifre",
    6 => "Mukemmel Sifre",
    _ => "Hatali Islem"
};
string massage = string.Format("{0} ; Skoru {1} / 6 ", text, passwordStrenght);
Console.WriteLine(massage);
*/
#endregion

#region BMI Hesaplama
/*
Console.WriteLine("Boyunuzu Girin : (metre)");
double lenght = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

if (lenght > 0)
{
    Console.WriteLine("Kilonuzu Girin : (kilogram)");
    double weight = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

    if (weight > 0)
    {
        double bodyMassIndex = weight / Math.Pow(lenght, 2);

        string text = bodyMassIndex switch
        {
            <= 18.5 => "Zayif", // kucuk esit ise 18.5 ten
            > 18.5 and <= 24.9 => "Normal Kilolu", // buyukse 18.5 ve kucuk esit ise 24.9
            > 24.9 and <= 29.9 => "Fazla Kilolu",
            > 29.9 => "Obez",
            _ => "Hesaplamada Bir Hata Olustu"
        };

        string massage = (bodyMassIndex > 0) ? string.Format("BMI = {0} => {1}", Math.Round(bodyMassIndex, 2), text) : text;
        Console.WriteLine(massage);
    }
    else
    {
        Console.WriteLine("Kilonuz Sifirdan Buyuk Olmalidir");
    }
}
else
{
    Console.WriteLine("Boyunuz Sifirdan Buyuk Olmalidir");
}
*/
#endregion

#region Sayi Tahmin Oyunu
/*
Random rnd = new Random();
int result = rnd.Next(1, 5);

Console.WriteLine("Zar Atildi! 1-5 Arasi Tahmin Girin!(2 Tahmin Hakkiniz Var)");
Console.WriteLine("Ilk Tahmin :");
int userInput = int.Parse(Console.ReadLine());

if (result != userInput)
{
    if (userInput > result)
    {
        Console.WriteLine("Daha Kucuk Bir Sayi Deneyiniz (Son Tahmin Hakkiniz)");
        userInput = int.Parse(Console.ReadLine());
        if (result == userInput)
        {
            Console.WriteLine("Tebrikler! Zar {0}, Son Tahmininiz {1}", result, userInput);
        }
        else
        {
            Console.WriteLine("Malesef Bilemediniz, Zar {0} Son Tahminiz {1}", result, userInput);
        }
    }
    else
    {
        Console.WriteLine("Daha Buyuk Bir Sayi Deneyiniz (Son Tahmin Hakkiniz)");
        userInput = int.Parse(Console.ReadLine());
        if (result == userInput)
        {
            Console.WriteLine("Tebrikler! Zar {0}, Son Tahmininiz {1}", result, userInput);
        }
        else
        {
            Console.WriteLine("Malesef Bilemediniz, Zar {0} Son Tahminiz {1}", result, userInput);
        }
    }
}
else
{
    Console.WriteLine("Tebrikler! Ilk Seferde Bildiniz! Zar {0}, Tahmininiz {1}", result, userInput);
}
*/
#endregion

#region Alisveris Sepeti
/*
using System.Text.RegularExpressions; // Regex i kullanmak icin gereken namespace'i cagirir. 

Console.WriteLine("Sepetinize Eklemek Istediginiz Urunleri Yaziniz");
Console.WriteLine("Ayni Urunu Birden Fazla Yazabilirsiniz...");
Console.WriteLine("Yumurta / Ekmek / Sut / Peynir / Yogurt / Makarna");
string userInput = Console.ReadLine().Trim().ToLower();

if (userInput.Contains("yumurta") || userInput.Contains("ekmek") || userInput.Contains("sut") || userInput.Contains("peynir") || userInput.Contains("yogurt") || userInput.Contains("makarna"))
{
    // Regex.Macthes() fonksiyonu belirtilen stringte, yazilan sub-string'leri bulur, devamindaki .Count metodu ile bu eslestirmelerin sayisini verir. 
    // henuz derste islenmedi
    int eggCount = Regex.Matches(userInput, "yumurta").Count;
    int breadCount = Regex.Matches(userInput, "ekmek").Count;
    int milkCount = Regex.Matches(userInput, "sut").Count;
    int cheeseCount = Regex.Matches(userInput, "peynir").Count;
    int yogurtCount = Regex.Matches(userInput, "yogurt").Count;
    int pastaCount = Regex.Matches(userInput, "makarna").Count;

    double eggTotal = 192.45 * eggCount * 1.20;
    double breadTotal = 5.91 * breadCount * 1.20;
    double milkTotal = 29.75 * milkCount * 1.20;
    double cheeseTotal = 212.145 * cheeseCount * 1.20;
    double yogurtTotal = 48.50 * yogurtCount * 1.20;
    double pastaTotal = 20.48 * pastaCount * 1.20;

    double total = eggTotal + breadTotal + milkTotal + cheeseTotal + yogurtTotal + pastaTotal;

    if (eggCount > 0)
    {
        Console.WriteLine("{0} Koli Yumurta => {1} TL", eggCount, Math.Round(eggTotal, 2));
    }
    if (breadCount > 0)
    {
        Console.WriteLine("{0} Adet Ekmek => {1} TL", breadCount, Math.Round(breadTotal, 2));
    }
    if (milkCount > 0)
    {
        Console.WriteLine("{0} Litre Sut => {1} TL", milkCount, Math.Round(milkTotal, 2));
    }
    if (cheeseCount > 0)
    {
        Console.WriteLine("{0} Kilo Peynir => {1} TL", cheeseCount, Math.Round(cheeseTotal, 2));
    }
    if (yogurtCount > 0)
    {
        Console.WriteLine("{0} Kilo Yogurt => {1} TL", yogurtCount, Math.Round(yogurtTotal, 2));
    }
    if (pastaCount > 0)
    {
        Console.WriteLine("{0} Paket Makarna => {1} TL", pastaCount, Math.Round(pastaTotal, 2));
    }

    Console.WriteLine("Toplam => {0} TL", Math.Round(total, 2));
}
else
{
    Console.WriteLine("Gecersiz Giris Yaptiniz");
}
*/
#endregion

#region Sicaklik Birimi Donusturucu
/*
Console.WriteLine("Sicaklik Birimini giriniz:");
Console.WriteLine("(C)elcius || (F)ahrenheit || (K)elvin");
char unit = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine("Donusturulecek Sicaklik Birimini giriniz:");
Console.WriteLine("(C)elcius || (F)ahrenheit || (K)elvin");
char unitTarget = char.Parse(Console.ReadLine().ToUpper());

if (unit != 'C' && unit != 'F' && unit != 'K')
{
    Console.WriteLine("Ilk Birim C, F ve ya K olmalidir");
}
else if (unitTarget != 'C' && unitTarget != 'F' && unitTarget != 'K')
{
    Console.WriteLine("Hedef Birim C, F ve ya K olmalidir");
}
else if (unit == unitTarget)
{
    Console.WriteLine("Donusturulmek istenen birimler farkli olmalidir...");
}
else if (unit != unitTarget)
{
    Console.WriteLine("'{0}' degerini giriniz", unit);
    double unitValue = double.Parse(Console.ReadLine());
    double resultValue = 0;


    switch (unit)
    {
        case 'C':

            switch (unitTarget)
            {
                case 'F':
                    resultValue = (unitValue * 9 / 5) + 32;
                    break;
                case 'K':
                    resultValue = unitValue + 273.15;
                    break;
            }

            break;

        case 'F':

            switch (unitTarget)
            {
                case 'C':
                    resultValue = (unitValue - 32) * 5 / 9;
                    break;
                case 'K':
                    resultValue = (unitValue - 32) * 5 / 9 + 273.15;
                    break;
            }
            break;

        case 'K':

            switch (unitTarget)
            {
                case 'C':
                    resultValue = unitValue - 273.15;
                    break;
                case 'F':
                    resultValue = (unitValue - 273.15) * 9 / 5 + 32;
                    break;
            }
            break;
    }
    Console.WriteLine("{0} '{1}' ==> {2} '{3}'", unitValue, unit, Math.Round(resultValue, 2), unitTarget);
}
*/
#endregion

#region Iki Tarih Arasi Fark Alma
/*
Console.WriteLine("Ilk Tarihi Giriniz");
Console.WriteLine("Format (gg.aa.yyyy sa:dk:sn)");
DateTime firstDate = DateTime.Parse(Console.ReadLine().Trim());

Console.WriteLine("Ikinci Tarihi Giriniz");
Console.WriteLine("Format (gg.aa.yyyy sa:dk:sn)");
DateTime secondDate = DateTime.Parse(Console.ReadLine().Trim());
int yearDiff, monthDiff, dayDiff, hourDiff, minuteDiff, secondDiff;
TimeSpan diff;

if (firstDate > secondDate)
{
    yearDiff = firstDate.Year - secondDate.Year;   // yil farkini al
    monthDiff = firstDate.Month - secondDate.Month; // ay farkini al
    diff = firstDate - secondDate;
    hourDiff = diff.Hours;
    minuteDiff = diff.Minutes;
    secondDiff = diff.Seconds;

    if (monthDiff < 0)   // ay farki 0 dan kucuk cikarsa
    {
        yearDiff--;   // yil farkindan 1 cikar
        monthDiff += 12; // ay farkina 12 ekle
    }

    dayDiff = firstDate.Day - secondDate.Day;  // gun farkini al
    if (dayDiff < 0) // gun farki 0 dan kucuk cikarsa
    {
        monthDiff--;  // ay farkindan 1 cikar
                      // bu islem neticesinde
        if (monthDiff < 0) // ay farki 0 dan kucuk olursa
        {
            yearDiff--;   // yil farkindan 1 cikar
            monthDiff += 12; // ay farkina 1 ekle
        }
        dayDiff += DateTime.DaysInMonth(firstDate.Year, firstDate.Month); // gun farkina son yilin o ayindaki gun sayisi kadar gun ekle.
    }
}
else
{
    yearDiff = secondDate.Year - firstDate.Year;
    monthDiff = secondDate.Month - firstDate.Month;
    diff = secondDate - firstDate;
    hourDiff = diff.Hours;
    minuteDiff = diff.Minutes;
    secondDiff = diff.Seconds;

    if (monthDiff < 0)
    {
        yearDiff--;
        monthDiff += 12;
    }

    dayDiff = secondDate.Day - firstDate.Day;
    if (dayDiff < 0)
    {
        monthDiff--;

        if (monthDiff < 0)
        {
            yearDiff--;
            monthDiff += 12;
        }
        dayDiff += DateTime.DaysInMonth(secondDate.Year, secondDate.Month);
    }
}

Console.WriteLine("{0} Tarihi Ile {1} Tarihi Arasindaki Fark :", firstDate, secondDate);
Console.WriteLine("{0} Yil, {1} Ay, {2} Gun, {3} Saat, {4} Dakika, {5} Saniyedir", yearDiff, monthDiff, dayDiff, hourDiff, minuteDiff, secondDiff);
*/
#endregion

#region Ucgen Hesaplamalari
/*
Console.WriteLine("a Kenari Uzunlugunu Giriniz");
double sideA = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

Console.WriteLine("b Kenari Uzunlugunu Giriniz");
double sideB = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

Console.WriteLine("C Acisi Derecesini Giriniz");
double angleC = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

double radianC = angleC * Math.PI / 180;

double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(radianC)); // c kenari bulundu

double areaCalc = sideA * sideB * Math.Sin(radianC) / 2; // alan bulundu

double perimeterCalc = sideA + sideB + sideC; // cevresi bulundu

double angleA = Math.Asin(sideA * Math.Sin(radianC) / sideC) * 180 / Math.PI; // a acisi bulundu
double angleB = Math.Asin(sideB * Math.Sin(radianC) / sideC) * 180 / Math.PI; // b acisi bulundu

// yuvarlama islemi

double aSide = Math.Round(sideA, 2);
double bSide = Math.Round(sideB, 2);
double cSide = Math.Round(sideC, 2);

double aAngle = Math.Round(angleA, 2);
double bAngle = Math.Round(angleB, 2);
double cAngle = Math.Round(angleC, 2);

double area = Math.Round(areaCalc, 2);
double perimeter = Math.Round(perimeterCalc, 2);

double totalAngle = Math.Round(angleA + angleB + angleC, 2);



if (sideA == sideB && sideB == sideC)
{
    Console.WriteLine("***Eskenar Ucgen***");
}
else if (sideA == sideB || sideA == sideC || sideB == sideC)
{
    Console.WriteLine("***Ikizkenar Ucgen***");
}
else
{
    Console.WriteLine("***Cesitkenar Ucgen***");
}

if (Math.Round(angleA) == 90 || Math.Round(angleB) == 90 || Math.Round(angleC) == 90) // 
{
    Console.WriteLine("***Dik Ucgen***");
}

Console.WriteLine($"A Kenari => {aSide} , B Kenari => {bSide}, C Kenari => {cSide}");
Console.WriteLine($"a Acisi => {aAngle} , b Acisi => {bAngle}, c Acisi => {cAngle}, Toplami {totalAngle}");
Console.WriteLine($"Alani => {area}");
Console.WriteLine($"Cevresi => {perimeter}");
*/
#endregion

#region Tam kare mi kontrolu
/*
Console.WriteLine("Bir sayi girin");
double input = double.Parse(Console.ReadLine());

if (input < 0)
{
    Console.WriteLine("Negatif Sayilar Tam Kare Olamaz");
}
else
{
    double sqrt = Math.Sqrt(input);
    double check = sqrt - Math.Truncate(sqrt);
    if (check == 0)
    {
        Console.WriteLine("{0} sayisi {1} sayisinin tam karesidir.", input, sqrt);
    }
    else
    {
        Console.WriteLine("{0} sayisi tam kare degildir.", input);
    }
}
*/
#endregion

#region Gelismis Hesap Makinesi
/*
Console.WriteLine("Bir Sayi Girin");
double input1 = double.Parse(Console.ReadLine());

Console.WriteLine("Bir Islem Seciniz:");
Console.WriteLine("Topla (+), Cikar(-), Carp(*), Bol(/), Kuvvetini Al(Pow), Kokunu Al (Root)");
string process = Console.ReadLine().Trim().ToLower();
double input2, result = 0;

switch (process)
{
    case "+":
    case "-":
    case "*":
        Console.WriteLine("Ikinci Sayiyi Giriniz");
        input2 = double.Parse(Console.ReadLine());
        result = process == "+" ? input1 + input2 : process == "-" ? input1 - input2 : process == "*" ? input1 * input2 : 0; // + - * islemleri hangisi gelirse onu yap
        break;

    case "/":
        Console.WriteLine("Boleni Giriniz");
        input2 = double.Parse(Console.ReadLine());
        if (input2 != 0) // bolen sifir degilse islemi yap,
        {
            result = input1 / input2;
        }
        else
        {
            Console.WriteLine("Bolen 0 olamaz");
            return;
        }
        break;

    case "pow":
        Console.WriteLine("Kuvveti giriniz");
        input2 = double.Parse(Console.ReadLine());
        if (input1 == 0 && input2 < 0) // sifirin negatif kuvveti sorgusu
        {
            Console.WriteLine("{0} in negatif kuvveti alinamaz");
            return;
        }
        else
        {
            result = Math.Pow(input1, input2);
        }
        break;

    case "root":
        Console.WriteLine("Koku giriniz");
        input2 = double.Parse(Console.ReadLine());
        // kok alma isleminde kullanicinin 2. kokten baska kok girmesi durumu icin  sayi1 ussu 1/kok sayisi formulu ile kok alacagiz.

        if (input1 < 0 && input2 % 2 == 0)
        {
            Console.WriteLine("Negatif Sayilarin Cift Kokleri Alinamaz");
            return;
        }
        else if (input1 < 0 && input2 % 2 == 1)
        {
            result = -Math.Pow(Math.Abs(input1), 1.0 / Math.Abs(input2)); // Math.Pow fonksiyonu negatif deger kabul etmedigi icin mutlak degerini alip islem sonunda - koyarak negatife donduruyorz. 
        }
        else if (input1 < 0 && input2 < 0 && Math.Abs(input2 % 2) == 1) // negatif sayinin negatif ussunu alirken, pozitif ussunu alip terse ceviriyoruz. Ve negatife ceviriyoruz
        {
            result = -1 / Math.Pow(Math.Abs(input1), Math.Abs(1.0 / input2));
        }
        else if (input1 > 0 && input2 < 0) // pozitif sayida ayni seyi yapiyoruz sadece negatife cevirmiyoruz
        {
            result = 1 / Math.Pow(input1, 1.0 / Math.Abs(input2));
        }
        else // iki sayi da pozitifse
        {
            result = Math.Pow(input1, 1.0 / input2);
        }
        break;

    default:
        Console.WriteLine("Gecerli Bir Islem Seciniz");
        return;
}
Console.WriteLine("{0} {1} {2} => {3}", input1, process, input2, Math.Round(result, 4));
*/
#endregion

#region bilet fiyati hesapla
/*
Console.WriteLine("Dogum Tarihinizi Giriniz (gg.aa.yyyy)");
DateTime userBirthDate = DateTime.Parse(Console.ReadLine().Trim());
DateTime now = DateTime.Now;

double age = now.Year - userBirthDate.Year;
if (userBirthDate.Month > now.Month || (userBirthDate.Month == now.Month && userBirthDate.Day > now.Day))
{
    age--;
}
Console.WriteLine("Mesafeyi Giriniz (km)");
double distance = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

double subTotal = distance * 20;
double total = subTotal;

if (age <= 12)
{
    total = subTotal * 0.50;
}
else if (age > 12 && age <= 24)
{
    total = subTotal * 0.10;
}
else if (age >= 65)
{
    total = subTotal * 0.30;
}
Console.WriteLine("Bilet Fiyatiniz => {0}", total);
*/
#endregion

#region arac yakit tuketim hesaplama depo kapasitesinden
/*
Console.WriteLine("1 Depo Yakit Fiyatini Giriniz");
double fullTankPrice = double.Parse(Console.ReadLine().Trim());

Console.WriteLine("Ortalama Hizinizi Yaziniz (km/sa)");
double avarageSpeed = double.Parse(Console.ReadLine().Trim());

double pricePerLiter = 41.52;
double fuelTankCap = fullTankPrice / pricePerLiter;
double consumption = 0;

if (avarageSpeed < 60)
{
    consumption = 4.5;
}
else if (avarageSpeed >= 60 && avarageSpeed < 100)
{
    consumption = 5.5;
}
else if (avarageSpeed >= 100 && avarageSpeed < 140)
{
    consumption = 7.5;
}
else if (avarageSpeed >= 140)
{
    consumption = 9.5;
}

double distance = fuelTankCap * 100 / consumption;
double time = distance / avarageSpeed;
double minutes = (time - Math.Truncate(time)) * 60;
Console.WriteLine($"Ortalama {avarageSpeed} km/s hiz, yaklasik {consumption} yakit tuketimi, {Math.Round(fuelTankCap, 2)} litre yakitiniz ile, {Math.Round(distance, 2)} km yolu, molalar haric {Math.Round(time)} saat {Math.Round(minutes)} dakikada kat edersiniz... ");
*/
#endregion

#region arac yakit yuketimi hesaplama

Console.WriteLine("Mesafe Giriniz (km)");
double distance = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

Console.WriteLine("Ortalama Yakit Tuketimi Giriniz (L/100km)");
double consumptionAvg = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

Console.WriteLine("Yakit Fiyatini Giriniz (tl)");
double pricePerLiter = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

Console.WriteLine("Ortalama Hizinizi Giriniz (km/sa)");
double speedAvg = double.Parse(Console.ReadLine().Trim().Replace('.', ','));

double consumptionLiters = distance * consumptionAvg / 100;
double totalPrice = consumptionLiters * pricePerLiter;
double time = distance / speedAvg;
double timeHours = Math.Floor(time);
double timeMinutes = Math.Round((time - Math.Truncate(time)) * 60);

Console.WriteLine("Ortalama Yakit Tuketimi => {0} L/100km ", consumptionAvg);
Console.WriteLine("Mesafe => {0} kilometre ", distance);
Console.WriteLine("Ortalama Hiz => {0} km/sa ", speedAvg);
Console.WriteLine();
Console.WriteLine("Yakit Litre Fiyati => {0} tl/L", pricePerLiter);
Console.WriteLine("Toplam Harcanacak Yakit => {0} liters", Math.Round(consumptionLiters, 2));
Console.WriteLine("Toplam Yakit Maliyeti => {0} tl", Math.Round(totalPrice), 2);
Console.WriteLine("Seyehat Suresi => {0} Saat, {1} Dakika", timeHours, timeMinutes);

#endregion