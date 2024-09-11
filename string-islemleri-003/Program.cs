Console.WriteLine("Bir Metin Yaz");

string metin = Console.ReadLine();

/*
metin = metin.ToUpper();

metin = metin.ToLower();

metin = metin.Replace("x", ""); 

bool isContains = metin.Contains("a");

Console.WriteLine(isContains);

bool isStartsWith = metin.StartsWith("a");
System.Console.WriteLine(isStartsWith);

bool isEndsWith = metin.EndsWith("n");
Console.WriteLine(isEndsWith);

int lastIndex = metin.LastIndexOf("a");
Console.WriteLine(lastIndex);

string insertedText = metin.Insert(2, "wissen");
Console.WriteLine(insertedText);

string paddedLeft = metin.PadLeft(20, '0');
Console.WriteLine(paddedLeft);

string removed = metin.Remove(5);
Console.WriteLine(removed);

string subString = metin.Substring(7, 20);
Console.WriteLine(subString);
*/
string trimmedString = metin.Trim();
Console.WriteLine(trimmedString);