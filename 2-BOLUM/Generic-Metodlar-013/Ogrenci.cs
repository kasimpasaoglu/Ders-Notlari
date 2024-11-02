public class Ogrenci : IComparable
{
    public int OgrenciId { get; set; }
    public int CompareTo(object? obj)
    {
        Ogrenci parametreOgrenci = (Ogrenci)obj;
        if (this.OgrenciId > parametreOgrenci.OgrenciId)
        {
            return 1;
        }
        else if (this.OgrenciId < parametreOgrenci.OgrenciId)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}