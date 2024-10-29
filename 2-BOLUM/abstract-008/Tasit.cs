public abstract class Tasit
{
    public string name;
    public string engine;
    public abstract void MotorGucu();
    public virtual void Sunroof()
    {
        Console.WriteLine("Tasit classi icindeki metod");
    }
}
