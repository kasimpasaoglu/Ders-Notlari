#region ornek1
/*
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/
#endregion

#region ornek 1- 1000 arasi 5 er yazdiralim
/*
for (int i = 0; i < 1000; i+= 5)
{
    Console.WriteLine(i);
}
*/
#endregion

#region ters siralama
/*
for (int i = 1000; i >= 0; i--)
{
    Console.WriteLine(i);
}
*/
#endregion

#region sonsuz dongu
/*
int a = 10;
for (; ; )
{
    a++;
    Console.WriteLine(a);
}
*/
#endregion

#region Donguyu durdurma, kosulu bozarak 
/*
for (int i = 10; i < 100; i++)
{
    // dongu 50 ye ulasinca sonlandiralim
    Console.WriteLine(i);
    if (i == 50) // i = 50 oldugunda
    {
        i = 101; // kosulu bozduk
    }
}
*/
#endregion

#region Caprim Tablosu Yazdirma
/*
for (int i = 1; i <= 10; i++)  // bu dongu her dondugunde icerdeki dongu 10 kere donecek. 
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
    }
    Console.WriteLine("-----------------------");
}
*/
#endregion

#region ornek => 1000 adet random sayi cekip bu sayilardan kac tanesi tek kac tanesi cift
/*
Random rnd = new Random();
int oddCount = 0, evenCount = 0;

for (int i = 0; i < 1000; i++)
{
    int number = rnd.Next();

    if (number % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        oddCount++;
    }
}
Console.WriteLine("{0} adet tek sayi", oddCount);
Console.WriteLine("{0} adet cift sayi", evenCount);
*/
#endregion

#region Ekrana 10 karakterli random bir kelime yazdirin
/*
string text = "";
Random rnd = new Random();

for (int i = 0; i < 10; i++)
{
    char letter = Convert.ToChar(rnd.Next('a', 'z'));
    text += letter;
}
Console.WriteLine("Random Text => {0}", text);
*/
#endregion

