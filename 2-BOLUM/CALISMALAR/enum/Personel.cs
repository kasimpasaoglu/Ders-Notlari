using System.Collections;

public class Personel(string name, Department dep, Title pos)
{
    public string Name { get; set; } = name;
    public Department Department { get; set; } = dep;
    public Title Title { get; set; } = pos;

    public static void AddNewPersonel(ArrayList list)
    {
        string name = GetName();
        Department depInput = GetDepartment();
        Title posInput = GetTitle();
        Personel p = new Personel(name, depInput, posInput);
        list.Add(p);
    }

    private static void PrintDeps()
    {
        string[] enums = typeof(Department).GetEnumNames();
        foreach (var item in enums)
        {
            Console.Write($"|| {item} ||");
        }
        Console.WriteLine();
    }
    private static void PrintTitles()
    {
        string[] enums = typeof(Title).GetEnumNames();
        foreach (var item in enums)
        {
            Console.Write($"|| {item} ||");
        }
        Console.WriteLine();
    }
    private static string GetName()
    {
        Console.WriteLine("Enter Name Surname (Seperate with space)");
        while (true)
        {
            var input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again");
            }
            else if (!input.Contains(' '))
            {
                Console.WriteLine("Please enter both name and surname separated by a space.");
            }
            else if (input.Any(char.IsDigit) || input.Any(char.IsSymbol) || input.Any(char.IsPunctuation))
            {
                Console.WriteLine("Incorrect Name&Surname. Please try again");
            }
            else
            {
                string[] fullName = input.Split(' ');
                string name = char.ToUpper(fullName[0][0]) + fullName[0].Substring(1).ToLower();
                string lastName = char.ToUpper(fullName[1][0]) + fullName[1].Substring(1).ToLower();
                return $"{name} {lastName}";
            }
        }
    }
    private static Department GetDepartment()
    {
        Console.WriteLine("Enter department name. (IT, Accounting, HR, Marketing, Sales)");
        while (true)
        {
            var input = Console.ReadLine().Trim();
            if (input != "IT" && input != "Accounting" && input != "HR" && input != "Marketing" && input != "Sales")
            {
                Console.WriteLine("Input must be one of those: ");
                PrintDeps();
                Console.WriteLine("Please try Again");
            }
            else
            {
                return (Department)Enum.Parse(typeof(Department), input);
            }
        }
    }
    private static Title GetTitle()
    {
        Console.WriteLine("Enter title. (Intern, Junior, Senior, Director)");
        while (true)
        {
            var input = Console.ReadLine().Trim();
            if (input != "Intern" && input != "Junior" && input != "Senior" && input != "Director")
            {
                Console.WriteLine("Input must be one of those: ");
                PrintTitles();
                Console.WriteLine("Please try again.");
            }
            else
            {
                return (Title)Enum.Parse(typeof(Title), input);
            }
        }
    }


}

