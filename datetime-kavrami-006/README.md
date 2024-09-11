# DateTime Fonksiyonu

* Bu gunun tarihini alabiliriz
```C#
    string nowDate = DateTime.Now.ToString();
    Console.WriteLine(nowDate);
```
* Uzun ve ya kisa tarih alinmak icin sonuna metod cagirabiliriz
```C#
    Console.WriteLine("to long date string " + DateTime.Now.ToLongDateString());
    Console.WriteLine("to long time string " + DateTime.Now.ToLongTimeString());
```
* Ekleme ve ya cikarma yapilabilir
```C#
    Console.WriteLine("Tarihe yil ekleme " + DateTime.Now.AddYears(17));
    Console.WriteLine("10 gun onceki tarih " + DateTime.Now.AddDays(-10));
```
* ozel bir tarih olusturulabilir, (Yil, Ay, Gun) siralamasi ile
```C#
    DateTime date = new DateTime(2000, 12, 1);
    Console.WriteLine("custom tarih " + date.ToLongDateString());
```
* sadece gun, ay , yil , saniye, nano saniye gibi degerler alinabilir
```C#
    Console.WriteLine("sadece gun degeri :" + date.Day);
    Console.WriteLine("sadece haftanin gunu :" + date.DayOfWeek);
    Console.WriteLine("Nano Saniyeyi alalim :" + DateTime.Now.Nanosecond);
    Console.WriteLine("Mikro Saniyeyi alalim :" + DateTime.Now.Microsecond);
```
* Iki tarih arasindaki farki almak icin `TimeSpan` kullanilir
```C#
    DateTime firstDate = new DateTime(1923, 10, 29);
    DateTime now = DateTime.Now;
    TimeSpan diff = now - firstDate;

    // bu iki tarih arasindaki fark diff degiskenine atandi, simdi cagirabiliriz
    Console.WriteLine("Gun farki " + diff.TotalDays);

    Console.WriteLine("Saat farki " + diff.TotalHours);
```
* Ornek Uygulama
```C#
    Console.WriteLine("Lutfen Tarih giriniz (gg.aa.yyyy) :");
    string birthDayString = Console.ReadLine();
    int day = int.Parse(birthDayString.Substring(0, 2));
    int mouth = int.Parse(birthDayString.Substring(3, 2));
    int year = int.Parse(birthDayString.Substring(6, 4));
    
    DateTime userdate = new DateTime(year, mouth, day);
    
    TimeSpan diff = DateTime.Now - userdate;
    
    Console.WriteLine("{0} yildir dunyadasiniz", diff.TotalDays / 365);
```
