public class Car
{
    private int chasisNo;
    private string modelName;
    private int modelYear;
    private double cylinderVolume;
    private double price;

    public Car()
    {
        this.chasisNo = new Random().Next(100000, 1000000);
    }
    public int ChasisNo
    {
        get { return this.chasisNo; }
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
            else
            {
                throw new ArgumentException("Model Name Must be over 5 chars");
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
            else
            {
                throw new ArgumentException("Cylinder Volume must be between 1, 2.5");
            }
        }
    }

    public double Price
    {
        set { this.price = value; }
    }
    public double SalesPrice
    {
        get { return price * 1.20; }
    }

}