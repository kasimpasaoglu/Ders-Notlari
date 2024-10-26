public class HazirlikOgrenci : IOgrenci
{
    public string name { get; set; }
    public double AvarageDegree(double[] notes)
    {
        double total = 0;
        foreach (var note in notes)
        {
            total += note;
        }
        return total / notes.Length;
    }
}