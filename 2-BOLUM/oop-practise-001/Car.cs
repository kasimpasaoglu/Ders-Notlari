public class Car
{
    public int chassisNo;
    public string modelName;
    public int modelYear;
    public string engineName;
    public double price;
    public Car()
    {
        chassisNo = new Random().Next(10000, 100000);
    }
    public Car(string modelName) : this()
    {
        this.modelName = modelName;
    }
    public Car(string modelName, int modelYear) : this(modelName)
    {
        this.modelYear = modelYear;
    }
    public Car(string modelName, int modelYear, string engineName) : this(modelName, modelYear)
    {
        this.engineName = engineName;
    }
    public Car(string modelName, int modelYear, string engineName, double price) : this(modelName, modelYear, engineName)
    {
        this.price = price;
    }
}