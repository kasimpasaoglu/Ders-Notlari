public class Student
{
    private static int idCounter = 1;
    public int Id { get; }
    public string Name { get; set; }
    public Student(string name)
    {
        Id = idCounter++;
        Name = name;
    }

}