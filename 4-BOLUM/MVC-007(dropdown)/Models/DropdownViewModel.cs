public class DropdownViewModel
{
    public int SelectedCarId { get; set; }
    public List<Car> Cars { get; set; }
}

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
}