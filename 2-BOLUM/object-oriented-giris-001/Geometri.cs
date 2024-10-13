public class Cone
{

    public double ConeArea(double radius, double lateralHeight)
    {
        return Math.Round(Math.PI * Math.Pow(radius, 2) + (Math.PI * radius * lateralHeight));
    }

    public double ConePerimeter(double radius)
    {
        return Math.Round(Math.Tau * radius, 2);
    }
}
public class Trapezoid
{

    public double TrapezoidArea(double sideA, double sideB, double height)
    {
        return Math.Round((sideA + sideB) / 2 * height, 2);
    }

    public double TrapezoidPerimeter(double a, double b, double c, double d)
    {
        return a + b + c + d;
    }
}