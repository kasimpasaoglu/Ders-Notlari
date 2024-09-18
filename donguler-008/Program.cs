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