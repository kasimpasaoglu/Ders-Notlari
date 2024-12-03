public class Helper : IHelper
{
    public string SayHello()
    {
        return "Hello";
    }
}

public interface IHelper
{
    public string SayHello();
}