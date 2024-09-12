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

Console.WriteLine("Lutfen Bir Sayi Giriniz");
int intDegisken = int.Parse(Console.ReadLine());

if (intDegisken % 2 == 0)
{
    Console.WriteLine("Girdiginiz sayi cift");
}

else
{
    Console.WriteLine("Girdiginiz sayi tek");
}

#endregion