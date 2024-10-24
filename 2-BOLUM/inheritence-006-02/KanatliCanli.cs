public class KanatliCanli : Canli
{
    public double WingSpan;
    public bool CanFly;
    public KanatliCanli(string name, string type, double wingSpan, bool canFly) : base(name, type)
    {
        WingSpan = wingSpan;
        CanFly = canFly;
    }

}