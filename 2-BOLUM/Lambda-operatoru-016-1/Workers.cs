public class Workers
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double WeeklyWage { get; set; }
    public double Wage { get; }
    public string Department { get; set; }
    public Workers(int id, string name, double weeklyWage, string department)
    {
        Id = id;
        Name = name;
        WeeklyWage = weeklyWage;
        Wage = weeklyWage * 12;
        Department = department;
    }
}