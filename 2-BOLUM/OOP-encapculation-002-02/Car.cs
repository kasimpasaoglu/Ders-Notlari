public class Car
{
    private int chasisNo;
    private string modelName;
    private int modelYear;
    double cylinderVolume;

    public int ChasisNo
    {
        get { return this.chasisNo; }
        set { this.chasisNo = new Random().Next(100000, 1000000); ; }
    }
    public string ModelName
    {
        get { return modelName; }
        set
        {
            string input = value;
            if (input.Length > 5)
            {
                this.modelName = value;
            }
        }
    }
    public double CylinderVolume
    {
        get { return this.cylinderVolume; }
        set
        {
            if (value > 1 && value < 2.5)
            {
                this.cylinderVolume = value;
            }
        }
    }

}