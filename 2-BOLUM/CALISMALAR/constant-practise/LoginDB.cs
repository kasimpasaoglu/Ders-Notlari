public class LoginDB
{
    public const string username = "wissenBesiktas";
    public const string password = "Bright**";


    public static bool isLoggedIn()
    {
        Console.Write("Kullanici Adi : ");
        var idInput = Console.ReadLine().Trim();
        Console.Write("Sifre : ");
        var pwInput = Console.ReadLine().Trim();
        if (idInput == username && pwInput == password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}