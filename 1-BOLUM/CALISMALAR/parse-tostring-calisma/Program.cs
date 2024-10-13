
#region Ucgen Cozumleme;
/*
Console.WriteLine("A Kenari Uzunlugunu Girin :");
double sideA = double.Parse(Console.ReadLine().Replace('.', ','));
Console.WriteLine();

Console.WriteLine("B Kenari Uzunlugunu Girin :");
double sideB = double.Parse(Console.ReadLine().Replace('.', ','));
Console.WriteLine();

Console.WriteLine("c Acisi Derecesini Girin :");
double angleC = double.Parse(Console.ReadLine().Replace('.', ','));
Console.WriteLine();

double radianC = angleC * Math.PI / 180;

double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - (2 * sideA * sideB * Math.Cos(radianC)));

double radianA = Math.Asin(sideA * Math.Sin(radianC) / sideC);
double radianB = Math.Asin(sideB * Math.Sin(radianC) / sideC);

double angleA = radianA * 180 / Math.PI;
double angleB = radianB * 180 / Math.PI;

// ondaliklari yuvarladiktan sonrasinda stringe donusturmeye gerek yok ama pratik amacli yaptim
string roundedSideA = Math.Round(sideA, 2).ToString();
string roundedSideB = Math.Round(sideB, 2).ToString();
string roundedSideC = Math.Round(sideC, 2).ToString();

string roundedAngleA = Math.Round(angleA, 2).ToString();
string roundedAngleB = Math.Round(angleB, 2).ToString();
string roundedAngleC = Math.Round(angleC, 2).ToString();

string interiorAngleSum = Math.Round(angleA + angleB + angleC, 2).ToString();
string perimeter = Math.Round(sideA + sideB + sideC, 2).ToString();
string area = Math.Round(sideA * sideB * Math.Sin(radianC) / 2, 2).ToString();


Console.WriteLine($"Ucgenin Kenar Uzunluklari => A:{roundedSideA} , B:{roundedSideB}, C:{roundedSideC}");
Console.WriteLine();
Console.WriteLine($"Ucgenin Ic Acilari => a: {roundedAngleA} , b: {roundedAngleB}, c: {roundedAngleC}, Toplami = {interiorAngleSum}");
Console.WriteLine();
Console.WriteLine($"Ucgenin Cevresi => {perimeter}");
Console.WriteLine();
Console.WriteLine($"Ucgenin Alani => {area}");
*/
#endregion

#region Kullanici Bilgileri ve Faiz Hesaplama
/*
Console.WriteLine("Ad & Soyad Girin :");
string fullName = Console.ReadLine().Trim();

Console.WriteLine("Dogum Yilinizi Girin :");
int birthYear = int.Parse(Console.ReadLine());


int index = fullName.LastIndexOf(' ');

string name = fullName.Substring(0, index).ToUpper();
string lastName = fullName.Substring(index + 1).ToUpper();

int age = DateTime.Now.Year - birthYear;
string account = (age > 18).ToString().Replace("True", "Yetkili").Replace("False", "Ebeveyn Denetimi Gerekli");

string userName = (name.Substring(0, 1) + '.' + lastName).ToLower();

Random rnd = new Random();
string intRandom = rnd.Next(10000, 99999).ToString();

string userID = intRandom.Substring(0, 1) + name.Substring(0, 1).ToLower() + intRandom.Substring(2) + lastName.Substring(0, 1).ToLower();

double accBalance = Math.Round(rnd.NextDouble() * 10000, 2);

Console.WriteLine();
Console.WriteLine("Adiniz : {0}", name);
Console.WriteLine("Soyadiniz : {0}", lastName);
Console.WriteLine("Kullanici Adi : {0}", userName);
Console.WriteLine("Kullanici Kodu : {0}", userID);
Console.WriteLine("Yasiniz : {0}", age);
Console.WriteLine("Hesap : {0}", account);
Console.WriteLine("Hesap Bakiyesi : {0}", accBalance);
Console.WriteLine();

Console.WriteLine("Vade Baslangic Bakiyesini Girin (En Dusuk Tutar 10000 TL):");
double principalRequested = double.Parse(Console.ReadLine());

double reqAmount = principalRequested - accBalance;
Console.WriteLine("Bu islem icin Vadeli Hesabiniza {0} TL aktarilacaktir.", reqAmount);
accBalance = accBalance + reqAmount;

Console.WriteLine();
Console.WriteLine("Transfer Tamamlandi... Yeni Hesap Bakiyesi: {0}", accBalance);
Console.WriteLine();

Console.WriteLine("Hesaplanacak faiz oranini giriniz :");
double interestRate = double.Parse(Console.ReadLine().Replace('.', ','));

Console.WriteLine("Vade sayisi giriniz (YIL) :");
double years = double.Parse(Console.ReadLine());

Console.WriteLine("Vade Periodu Giriniz (AY) :");
double compoundingPeriods = double.Parse(Console.ReadLine());

double finalAmount = Math.Round(accBalance * Math.Pow(1 + interestRate / compoundingPeriods, compoundingPeriods * years), 3);

Console.WriteLine("Anapara => {0} TL", accBalance);
Console.WriteLine("Faiz Orani => %{0}", interestRate * 100);
Console.WriteLine("Vade Sayisi => {0} Yil", years);
Console.WriteLine("Vade Periodu => {0} Ay", compoundingPeriods);
Console.WriteLine("Vade Sonu Hesaplanan Tutar => {0}", finalAmount);
*/
#endregion

#region Not Sistemi
// Random rnd = new Random();

// Console.WriteLine("1 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName1 = Console.ReadLine().Trim();
// Console.WriteLine("1 . Ogrencinin Notunu Giriniz :");
// double studentNote1 = double.Parse(Console.ReadLine());
// int studentID1 = rnd.Next(1000, 2000);

// Console.WriteLine("2 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName2 = Console.ReadLine().Trim();
// Console.WriteLine("2 . Ogrencinin Notunu Giriniz :");
// double studentNote2 = double.Parse(Console.ReadLine());
// int studentID2 = rnd.Next(1000, 2000);

// Console.WriteLine("3 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName3 = Console.ReadLine().Trim();
// Console.WriteLine("3 . Ogrencinin Notunu Giriniz :");
// double studentNote3 = double.Parse(Console.ReadLine());
// int studentID3 = rnd.Next(1000, 2000);

// Console.WriteLine("4 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName4 = Console.ReadLine().Trim();
// Console.WriteLine("4 . Ogrencinin Notunu Giriniz :");
// double studentNote4 = double.Parse(Console.ReadLine());
// int studentID4 = rnd.Next(1000, 2000);

// Console.WriteLine("5 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName5 = Console.ReadLine().Trim();
// Console.WriteLine("5 . Ogrencinin Notunu Giriniz :");
// double studentNote5 = double.Parse(Console.ReadLine());
// int studentID5 = rnd.Next(1000, 2000);

// Console.WriteLine("6 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName6 = Console.ReadLine().Trim();
// Console.WriteLine("6 . Ogrencinin Notunu Giriniz :");
// double studentNote6 = double.Parse(Console.ReadLine());
// int studentID6 = rnd.Next(1000, 2000);

// Console.WriteLine("7 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName7 = Console.ReadLine().Trim();
// Console.WriteLine("7 . Ogrencinin Notunu Giriniz :");
// double studentNote7 = double.Parse(Console.ReadLine());
// int studentID7 = rnd.Next(1000, 2000);

// Console.WriteLine("8 . Ogrencinin Adini/Soyadini Giriniz :");
// string studentName8 = Console.ReadLine().Trim();
// Console.WriteLine("8 . Ogrencinin Notunu Giriniz :");
// double studentNote8 = double.Parse(Console.ReadLine());
// int studentID8 = rnd.Next(1000, 2000);

// double maxNote = Math.Max(studentNote1, Math.Max(studentNote2, Math.Max(studentNote3, Math.Max(studentNote4, Math.Max(studentNote5, Math.Max(studentNote6, Math.Max(studentNote7, studentNote8)))))));

// double minNote = Math.Min(studentNote1, Math.Min(studentNote2, Math.Min(studentNote3, Math.Min(studentNote4, Math.Min(studentNote5, Math.Min(studentNote6, Math.Min(studentNote7, studentNote8)))))));

// string isStudentPassed1 = (studentNote1 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");
// string isStudentPassed2 = (studentNote2 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");
// string isStudentPassed3 = (studentNote3 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");
// string isStudentPassed4 = (studentNote4 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");
// string isStudentPassed5 = (studentNote5 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");
// string isStudentPassed6 = (studentNote6 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");
// string isStudentPassed7 = (studentNote7 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");
// string isStudentPassed8 = (studentNote8 >= 70).ToString().Replace("True", "Gecti").Replace("False", "Kaldi");

// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName1, isStudentPassed1, studentID1, studentNote1);
// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName2, isStudentPassed2, studentID2, studentNote2);
// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName3, isStudentPassed3, studentID3, studentNote3);
// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName4, isStudentPassed4, studentID4, studentNote4);
// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName5, isStudentPassed5, studentID5, studentNote5);
// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName6, isStudentPassed6, studentID6, studentNote6);
// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName7, isStudentPassed7, studentID7, studentNote7);
// Console.WriteLine("Ogrenci No:{2} = {0} = {3} => {1}", studentName8, isStudentPassed8, studentID8, studentNote8);
// Console.WriteLine();
// Console.WriteLine("Sinifin Not Ortalamasi ==> {0}", (studentNote1 + studentNote2 + studentNote3 + studentNote4 + studentNote5 + studentNote6 + studentNote7 + studentNote8) / 8);
// Console.WriteLine("En Yuksek Not => {0} ; En Dusuk Not => {1}", maxNote, minNote);

#endregion

#region Uzunluk Birimi Donusturucu

// Console.WriteLine("Olcuyu Giriniz");

// double userInputMeter = double.Parse(Console.ReadLine().Trim());

// double decimeter = userInputMeter * 10;
// double centimeter = userInputMeter * 100;
// double milimeter = userInputMeter * 1000;
// double kilometer = Math.Round(userInputMeter / 1000, 2);
// double mile = Math.Round(userInputMeter / 1609.34, 2);
// double yard = Math.Round(userInputMeter / 0.9144, 2);
// double foot = Math.Round(userInputMeter / 0.3048, 2);
// double inch = Math.Round(userInputMeter / 0.0254, 2);

// Console.WriteLine("{0} Metre => {1}dm = {2}cm = {3}mm = {4}km = {5}mile = {6}yard = {7}foot = {8}inch", userInputMeter, decimeter, centimeter, milimeter, kilometer, mile, yard, foot, inch);

// Console.WriteLine();

#endregion

#region Cember, Daire, Silindir Cozumleme

Console.WriteLine("Yaricapi olcusunu girin :");
double radius = double.Parse(Console.ReadLine());

Console.WriteLine("Yuksekligini girin :");
double height = double.Parse(Console.ReadLine());

double perimeter = Math.Round(2 * Math.PI * radius, 2);

double area = Math.Round(Math.PI * Math.Pow(radius, 2), 2);

double volume = Math.Round(Math.PI * Math.Pow(radius, 2) * height, 2);

Console.WriteLine("Cevresi = {0} , Alani = {1}, Silindirin Hacmi = {2}", perimeter, area, volume);


#endregion