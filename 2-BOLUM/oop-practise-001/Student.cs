public class Student
{
    public int id;
    public string name;
    public int schoolNo;
    private Student()
    {
        schoolNo = 5;
    }
    public Student(int id, string name) : this()
    {
        this.id = id;
        this.name = name;
    }
}