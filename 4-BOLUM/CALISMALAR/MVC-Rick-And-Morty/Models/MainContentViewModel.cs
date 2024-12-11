// model olusturulurken api den gelecek json formatina uygun bir model yazilmasi gerekiyor, boylece maplemeyi tek tek elle yapmayip newtonsoft paketi ile otomatik maplemesini saglar

public class MainContentViewModel
{
    public Info Info { get; set; }
    public List<Character> Results { get; set; }
}

public class Info
{
    public int Count { get; set; }
    public int Pages { get; set; }
    public string Next { get; set; }
    public string Prev { get; set; }
}

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string Species { get; set; }
    public string Type { get; set; }
    public string Gender { get; set; }
    public Origin Origin { get; set; }
    public Location Location { get; set; }
    public string Image { get; set; }
    public List<string> Episode { get; set; }
    public string Url { get; set; }
    public DateTime Created { get; set; }
}

public class Origin
{
    public string Name { get; set; }
    public string Url { get; set; }
}

public class Location
{
    public string Name { get; set; }
    public string Url { get; set; }
}
