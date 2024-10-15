public class Ogrenci
{
    public int id;
    public string name;
    public string surname;
    public int age;
    public Ogrenci(int id)
    {
        this.id = id;
    }
    public Ogrenci(int id, string name) : this(id)
    {
        this.name = name;
    }
    public Ogrenci(int id, string name, string surname) : this(id, name)
    {
        this.surname = surname;
    }
    public Ogrenci(int id, string name, string surname, int age) : this(id, name, surname)
    {
        this.age = age;
    }
}