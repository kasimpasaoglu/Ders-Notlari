public class Personel
{
    private int id;
    private string name;

    public int Get_Id()
    {
        return id;
    }
    public string Get_Name()
    {
        return name;
    }

    public void Set_Id(int id)
    {
        this.id = id;
    }

    public void Set_Name(string name)
    {
        this.name = name;
    }
    public Personel(int id, string name)
    {
        this.Set_Id(id);
        this.Set_Name(name);
    }

}
