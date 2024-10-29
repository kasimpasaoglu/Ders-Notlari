// terminal ekraninda `dotnet build`
// dll icindeki siniflari kullanmak icin namespace'i eklemek gerekmektedir


using AgeCalculator;

using AgeCalculator.Extensions;

DateTime birth = new(1992, 05, 31, 19, 30, 50);
DateTime now = DateTime.Now;
// Age age = new Age(birth, now, true);
Age age = birth.CalculateAge(birth, true);

Console.WriteLine(age.Years);
// Console.WriteLine(age.Months);
// Console.WriteLine(age.Days);
// Console.WriteLine(age.Time);