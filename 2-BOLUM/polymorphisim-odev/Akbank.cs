public class Akbank : BankBase
{
    public override void Payment(KartBilgileri kart)
    {
        Console.WriteLine("Akbank Odeme");
    }

    public override void Return(KartBilgileri kart)
    {
        Console.WriteLine("Akbank Iade");
    }
}