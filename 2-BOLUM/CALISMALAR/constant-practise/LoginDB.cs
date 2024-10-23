public class LoginDB
{
    private const string username = "wissenBesiktas";
    private const string password = "Bright**";


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