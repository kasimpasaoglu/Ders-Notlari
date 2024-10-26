public class Garanti : BankBase
{
    public override void Payment(KartBilgileri kart)
    {
        Console.WriteLine("Garanti Odeme");
    }

    public override void Return(KartBilgileri kart)
    {
        Console.WriteLine("Garanti Iade");
    }
    public override void Bonus(KartBilgileri kart)
    {
        Console.WriteLine("Garanti Kart Bilgileri");
    }
}