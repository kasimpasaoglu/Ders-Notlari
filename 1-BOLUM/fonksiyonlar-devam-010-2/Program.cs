
#region Metot OverLoading
/*
internal class Program
{
    private static void Main(string[] args)
    {
    }
    static void Deneme(int a)
    {

    }

    static void Deneme(string a, string b)
    {

    }
}
*/

#endregion

#region Params
/*
static void SinirsizParametre(params int[] parameters)
{
    var toplam = 0;
    foreach (var item in parameters)
    {
        toplam += item;
    }
    Console.WriteLine($"Toplam => {toplam} || Ortalama => {toplam / parameters.Length}");
}

SinirsizParametre(10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0);
*/
#endregion

#region Default Parameters
/*
static void Metod1(int a = 10)
{
    Console.WriteLine(a);
}

Metod1();
static void Metod2(string value = "")
{

}
*/
#endregion

#region ornek
/*
static void Cevre(int yariCap, double pi = Math.PI)
{
    Console.WriteLine(2 * pi * Math.Pow(yariCap, 2));
}
// eger kullanici PI degerini manuel girmek istemezse, default olarak Math.PI degeri verildi. 
*/
#endregion

