public class KanatliEvcilCanli : KanatliCanli
{
    public string OwnerName;
    public KanatliEvcilCanli(string name, string type, double wingSpan, bool canFly, string ownerName) : base(name, type, wingSpan, canFly)
    {
        OwnerName = ownerName;
    }
}