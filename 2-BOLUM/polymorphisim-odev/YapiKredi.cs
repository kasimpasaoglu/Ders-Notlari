public class YapiKredi : BankBase
{
    public override void Payment(KartBilgileri kart)
    {
        Console.WriteLine("YKB Odeme");
    }

    public override void Return(KartBilgileri kart)
    {
        Console.WriteLine("YKB Iade");
    }
    public override void Wage(KartBilgileri kart)
    {
        Console.WriteLine("YKB Maas Bilgileri");
    }
}