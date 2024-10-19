public class Personel
{
    private int id;
    private string name;
    private int age;

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
}
