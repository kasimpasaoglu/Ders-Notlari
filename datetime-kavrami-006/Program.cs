

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


#endregion