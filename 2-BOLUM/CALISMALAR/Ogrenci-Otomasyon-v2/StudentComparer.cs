public class StudentComparer : IComparer<Student>
{
    private readonly bool sortByGrade;
    private readonly bool descending;
    public StudentComparer(bool sortByGrade, bool descending = false)
    {
        this.sortByGrade = sortByGrade;
        this.descending = descending;
    }

    public int Compare(Student? x, Student? y)
    {
        int result;
        if (sortByGrade)
        {
            result = x.AverageGrade.CompareTo(y.AverageGrade);
        }
        else
        {
            result = x.Name.CompareTo(y.Name);
        }
        return descending ? -result : result;
    }
}