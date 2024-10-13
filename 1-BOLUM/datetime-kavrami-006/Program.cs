

#region bu gunun tarihi
// string nowDate = DateTime.Now;

// Console.WriteLine(nowDate);


// Console.WriteLine("to long date string " + DateTime.Now.ToLongDateString());
// Console.WriteLine("to long time string " + DateTime.Now.ToLongTimeString());
#endregion

#region  tarih ve ya zamana ekleme yapilabilir.
// Console.WriteLine("Tarihe yil ekleme " + DateTime.Now.AddYears(17));
// Console.WriteLine("10 gun onceki tarih " + DateTime.Now.AddDays(-10));
#endregion

#region  custom tarih
// DateTime date = new DateTime(2000, 12, 1);
// Console.WriteLine("custom tarih " + date.ToLongDateString());


// Console.WriteLine("sadece gun degeri :" + date.Day);
// Console.WriteLine("sadece haftanin gunu :" + date.DayOfWeek);

// Console.WriteLine("Nano Saniyeyi alalim :" + DateTime.Now.Nanosecond);
// Console.WriteLine("Mikro Saniyeyi alalim :" + DateTime.Now.Microsecond);
#endregion

#region  iki tarihi birbirinden cikarma, iki tarih arasi fark. (TimeSpan)

// DateTime firstDate = new DateTime(1923, 10, 29);
// DateTime now = DateTime.Now;

// TimeSpan fark = now - firstDate;

// Console.WriteLine("Gun farki " + fark.TotalDays);

// Console.WriteLine("Saat farki " + fark.TotalHours);
#endregion

#region ayri ayri yil, gun, ay girdisi alip bu bilgiler ile bir datetime tanimlayip, bu gun ile farkini bulmak

/*
Console.WriteLine("Yil Girin :");
int yearInput = int.Parse(Console.ReadLine());

Console.WriteLine("Ay Girin :");
int mouthInput = int.Parse(Console.ReadLine());

Console.WriteLine("Gun Girin :");
int dayInput = int.Parse(Console.ReadLine());

DateTime userDate = new DateTime(yearInput, mouthInput, dayInput);

TimeSpan diff = DateTime.Now - userDate;

double totalDay = diff.TotalDays;
double roundedDay = Math.Round(totalDay, 2);
double hoursDecimal = totalDay - Math.Truncate(totalDay);
double hours = Math.Round(hoursDecimal * 24, 2);



Console.WriteLine("Fark : {0} Gun ve {1} saat", roundedDay, hours);
*/
#endregion


#region tek seferde tarih girdisi alip fark bulmak
/*
Console.WriteLine("Lutfen Tarih giriniz (gg.aa.yyyy) :");
string birthDayString = Console.ReadLine();
int day = int.Parse(birthDayString.Substring(0, 2));
int mouth = int.Parse(birthDayString.Substring(3, 2));
int year = int.Parse(birthDayString.Substring(6, 4));

DateTime userdate = new DateTime(year, mouth, day);

TimeSpan diff = DateTime.Now - userdate;

Console.WriteLine("{0} yildir dunyadasiniz", diff.TotalDays / 365);
*/
#endregion
#region ODEV kac yil kac gun ve kac saat yasadiginizi hesaplayan kodu yaziniz. (Vazgecti)
/*

Console.WriteLine("Lutfen Dogum Tarihinizi Giriniz (gg.aa.yyyy) :");
string userInput = Console.ReadLine();
int day = int.Parse(userInput.Substring(0, 2));
int month = int.Parse(userInput.Substring(3, 2));
int year = int.Parse(userInput.Substring(6, 4));

DateTime userDate = new DateTime(year, month, day);

TimeSpan diff = DateTime.Now - userDate;

// yil farkini aldik, ondalikli bir deger donuyor
double yearDiff = diff.TotalDays / 365;
// sayinin kendisinden, rasyonel kismi cikartarak sadece ondalik kismi aldik. onu 12 ye carpip ay farklini bulduk
double monthDiff = (yearDiff - Math.Truncate(yearDiff)) * 12;
// kalan adimlarda ay farkinin ondalik kismindan gun farkini
double dayDiff = (monthDiff - Math.Truncate(monthDiff)) * 30;
// gun farkinin ondalik kismindan saat farkini
double hoursDiff = (dayDiff - Math.Truncate(dayDiff)) * 24;
// saat farkinin ondalik kismindan dakika farkini aldik
double minutesDiff = (hoursDiff - Math.Truncate(hoursDiff)) * 60;

// ondaliklari yuvarlayip veri tipini int cevirdik
int yearRounded = (int)Math.Floor(yearDiff);
int mouthRounded = (int)Math.Floor(monthDiff);
int dayRounded = (int)Math.Floor(dayDiff);
int hourRounded = (int)Math.Floor(hoursDiff);
int minuteRounded = (int)Math.Floor(minutesDiff);

Console.WriteLine("{0} yil, {1} ay, {2} gun, {3} saat, {4} dakikadir dunyadasiniz...", yearRounded, mouthRounded, dayRounded, hourRounded, minuteRounded);
*/
#endregion

#region saat ve dakika bilgisi ile tekrar
/*
Console.WriteLine("Write Date & Time (dd.mm.yyyy hh.mm.ss):");
string userInput = Console.ReadLine().Trim();

DateTime processStartTime = DateTime.Now; // hesaplamaya baslangic zamani

int day = int.Parse(userInput.Substring(0, 2));
int month = int.Parse(userInput.Substring(3, 2));
int year = int.Parse(userInput.Substring(6, 4));
int hour = int.Parse(userInput.Substring(11, 2));
int minute = int.Parse(userInput.Substring(14, 2));
int second = int.Parse(userInput.Substring(17, 2));

DateTime userDate = new DateTime(year, month, day, hour, minute, second);

TimeSpan diff = DateTime.Now - userDate;

double yearDiff = diff.TotalDays / 365;
double monthDiff = (yearDiff - Math.Truncate(yearDiff)) * 12;
double dayDiff = (monthDiff - Math.Truncate(monthDiff)) * 30;
double hourDiff = (dayDiff - Math.Truncate(dayDiff)) * 24;
double minuteDiff = (hourDiff - Math.Truncate(hourDiff)) * 60;
double secondDiff = (minuteDiff - Math.Truncate(minuteDiff)) * 60;

int yearRounded = (int)Math.Floor(yearDiff);
int monthRounded = (int)Math.Floor(monthDiff);
int dayRounded = (int)Math.Floor(dayDiff);
int hourRounded = (int)Math.Floor(hourDiff);
int minuteRounded = (int)Math.Floor(minuteDiff);
int secondRounded = (int)Math.Floor(secondDiff);

DateTime processEndTime = DateTime.Now; // hesaplama bitis zamani

TimeSpan processTime = processEndTime - processStartTime; // hesaplama ne kadar surdu...

Console.WriteLine("Hesaplama {0} milisaniye(ms) surdu...", processTime.TotalMilliseconds);
Console.WriteLine($"{yearRounded} Yil, {monthRounded} Ay, {dayRounded} gun, {hourRounded} saat, {minuteRounded} dakika, {secondRounded} saniyedir hayattasiniz...");
*/
#endregion

#region dogum gunun hangi gune geldigini hesaplama
/*
Console.WriteLine("Dogum Tarihinizi Girin (gg.aa.yyyy sa:dk:sn) :");
DateTime userDate = DateTime.Parse(Console.ReadLine().Trim());

TimeSpan diff = DateTime.Now - userDate;
int age = Convert.ToInt32(Math.Floor(diff.TotalDays / 365));

DateTime thisYearBirthDate = new DateTime(DateTime.Now.Year, userDate.Month, userDate.Day);
DateTime nextYearBirthDate = new DateTime(DateTime.Now.AddYears(1).Year, userDate.Month, userDate.Day);

Console.WriteLine($"Yasiniz -> {age}");
Console.WriteLine($"{thisYearBirthDate.Year} Yilinda dogum gununuz -> {thisYearBirthDate.DayOfWeek}");
Console.WriteLine($"{nextYearBirthDate.Year} Yilinda dogum gununuz -> {nextYearBirthDate.DayOfWeek}");
Console.WriteLine();
*/
#endregion

#region Tarihler Arasi Fark
/*
Console.WriteLine("Ilk Tarihi gg.aa.yyyy sa:dk:sn Formatinda Giriniz :");
DateTime firstDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Ikinci Tarihi gg.aa.yyyy sa:dk:sn Formatinda Giriniz :");
DateTime secondDate = DateTime.Parse(Console.ReadLine());

TimeSpan diff = (firstDate - secondDate).Duration();

double yearDiff = diff.TotalDays / 365;
double monthDiff = (yearDiff - Math.Truncate(yearDiff)) * 12;
double dayDiff = (monthDiff - Math.Truncate(monthDiff)) * 30;
double hourDiff = (dayDiff - Math.Truncate(dayDiff)) * 24;
double minuteDiff = (hourDiff - Math.Truncate(hourDiff)) * 60;
double secondDiff = (minuteDiff - Math.Truncate(minuteDiff)) * 60;

int year = Convert.ToInt32(Math.Floor(yearDiff));
int month = Convert.ToInt32(Math.Floor(monthDiff));
int day = Convert.ToInt32(Math.Floor(dayDiff));
int hour = Convert.ToInt32(Math.Floor(hourDiff));
int minute = Convert.ToInt32(Math.Floor(minuteDiff));
int second = Convert.ToInt32(Math.Floor(secondDiff));

Console.WriteLine($"{firstDate} ile {secondDate} arasindaki fark -> {year} yil, {month} ay, {day} gun, {hour} saat, {minute} dakika, {second} saniyedir");
*/
#endregion

#region Bu Gunun tarihine Ekleme Cikarma Yapmak
/*
Console.WriteLine("Kac Yil Eklenecek :");
int yearInput = int.Parse(Console.ReadLine());

Console.WriteLine("Kac Ay Eklenecek :");
int monthInput = int.Parse(Console.ReadLine());

Console.WriteLine("Kac Gun Eklenecek :");
int dayInput = int.Parse(Console.ReadLine());

Console.WriteLine("Kac Saat Eklenecek :");
int hourInput = int.Parse(Console.ReadLine());

Console.WriteLine("Kac Dakika Eklenecek :");
int minuteIntput = int.Parse(Console.ReadLine());

Console.WriteLine("Kac Saniye Eklenecek :");
int secondsInput = int.Parse(Console.ReadLine());

DateTime start = DateTime.Now; // isleme baslangic

DateTime userDate = DateTime.Now.AddYears(yearInput).AddMonths(monthInput).AddDays(dayInput).AddHours(hourInput).AddMinutes(minuteIntput).AddSeconds(secondsInput);

DateTime end = DateTime.Now; // islem tamamlandiktan sonra

TimeSpan diff = end - start; // islem suresi ne kadar surdu


Console.WriteLine("Hesaplama {0} milisaniye(ms) surdu... ", diff.TotalMilliseconds);
Console.WriteLine(userDate.ToLongDateString());
*/
#endregion

double totalDays = 125.65121;
int intDegisken = Convert.ToInt32(totalDays);

System.Console.WriteLine(intDegisken);