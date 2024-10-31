public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double AverageGrade { get; set; }
    private static int IdCounter = 10;
    public Student()
    {

    }
    public Student(string name, double grade)
    {
        Id = IdCounter++;
        Name = name;
        AverageGrade = grade;
    }

    public static void UpdateIdCounter(int newCounterValue)
    {
        IdCounter = newCounterValue;
    }
}