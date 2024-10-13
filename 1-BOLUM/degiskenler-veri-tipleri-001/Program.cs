

Console.WriteLine("ADINIZI :");
string firstName = Console.ReadLine();

//------------------------

Console.WriteLine("SOYADINIZ :");
string lastName = Console.ReadLine();

//------------------------

Console.WriteLine("DOGUM YILINIZ (yyyy) :");
short birthYear = short.Parse(Console.ReadLine());

//------------------------

Console.WriteLine("CINSIYETINIZ (K/E) :");
char gender = char.Parse(Console.ReadLine());

//------------------------

Console.WriteLine("BOYUNUZ (*.** m)");
float height = float.Parse(Console.ReadLine());

//------------------------

Console.WriteLine("KILONUZ (kg)");
short weight = short.Parse(Console.ReadLine());

//------------------------

int age = 2024 - birthYear;
//short kabul etmedi neden???

float bodyMassIndex = (weight / (height * height));

//------------------------

Console.WriteLine("ISIM & SOYISIM: " + firstName + " " + lastName);
Console.WriteLine("CINSIYET: " + gender);
Console.WriteLine("YAS: " + age);
Console.WriteLine("VUCUT KITLE ENDEKSI: " + bodyMassIndex);