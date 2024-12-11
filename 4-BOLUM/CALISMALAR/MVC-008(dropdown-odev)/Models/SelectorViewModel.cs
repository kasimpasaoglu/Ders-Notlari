public class SelectorViewModel
{
    public int SelCityId { get; set; }
    public int SelDisrictId { get; set; }
    public int SelNbhoodId { get; set; }

    public List<City> Cities { get; set; }
    public List<Disrict> Disricts { get; set; }
    public List<Neighborhood> Neighborhoods { get; set; }
}

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }

}

public class Disrict
{
    public int Id { get; set; }
    public int CityId { get; set; }
    public string Name { get; set; }
}

public class Neighborhood
{
    public int Id { get; set; }
    public int DisrictId { get; set; }
    public string Name { get; set; }
}