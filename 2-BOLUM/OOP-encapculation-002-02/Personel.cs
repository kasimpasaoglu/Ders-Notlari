public class Personel
{
    private int id;
    private string name;
    private int age;
    private int maas;

    // public int Id
    // {
    //     get { return this.id; }
    //     set { this.id = value; }
    // }    
    public int Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public int Maas
    {
        get { return this.maas; }
        set { this.maas = value; }
    }
    public double ZamliMaas
    {
        get { return this.maas * 1.7; }
    }
}
