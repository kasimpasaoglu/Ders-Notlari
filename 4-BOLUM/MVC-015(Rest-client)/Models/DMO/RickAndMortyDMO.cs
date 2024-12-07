public class RickAndMortyDMO
{
    public Info Info { get; set; }
    public List<Detail> Results { get; set; }
}

public class Info
{
    public int Count { get; set; }
    public int Pages { get; set; }
    public string Next { get; set; }
    public string Prev { get; set; }
}

public class Detail
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string Species { get; set; }
    public string Type { get; set; }
    public string Gender { get; set; }
    public Location Location { get; set; }
    public string Image { get; set; }
}

public class Location
{
    public string Name { get; set; }
}