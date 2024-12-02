public class Main
{
    public User User { get; set; }
    public int LastSavedUserId { get; set; }
    public int SelectedCarId { get; set; }
    public List<Car> CarsList { get; set; }
    public int? RequestedUserId { get; set; }
    public bool IsIdFound { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Car SelectedCar { get; set; }
    public DateOnly SalesDate { get; set; }
}

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }

}