public abstract class BankBase
{
    public abstract void Payment(KartBilgileri kart);
    public abstract void Return(KartBilgileri kart);
    public virtual void Bonus(KartBilgileri kart)
    {
        Console.WriteLine("Puan durumunu gosteren fonskiyon");
    }
    public virtual void Wage(KartBilgileri kart)
    {
        Console.WriteLine("Maas bilgisi gosteren fonskiyon");
    }
}