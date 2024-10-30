public static class StudentHelper
{
    public static List<Student> List { get; set; }
    private static int input;

    static StudentHelper()
    {
        List = new List<Student>();
    }
    public static int Menu()
    {
        Console.WriteLine(Messages.SEPERATOR);
        Console.WriteLine(Messages.MENU_1_LIST_STUDENT);
        Console.WriteLine(Messages.MENU_2_DELETE_STUDENT);
        Console.WriteLine(Messages.MENU_3_ADD_STUDENT);
        Console.WriteLine(Messages.MENU_4_UPDATE_STUDENT);
        Console.WriteLine(Messages.MENU_5_EXIT);
        Console.WriteLine(Messages.SEPERATOR);

        while (!(int.TryParse(Console.ReadLine().Trim(), out input) && (input == 1 || input == 2 || input == 3 || input == 4 || input == 5)))
        {
            Console.WriteLine(Messages.ERROR_WRONG_INPUT);
        }
        return input;
    }
    private static Student GetStudent()
    {
        string name;
        do
        {
            if (input == 3) Console.WriteLine(Messages.PROMPT_ENTER_STUDENT_NAME);
            else if (input == 4) Console.WriteLine(Messages.PROMPT_ENTER_NEW_NAME);
            name = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit) || name.Any(char.IsSymbol))
            {
                Console.WriteLine(Messages.ERROR_WRONG_NAME);
                Console.WriteLine(Messages.SEPERATOR);
            }
            else
            {
                break;
            }

        } while (true);
        return new Student(name);
    }
    public static void AddStudent()
    {
        var std = GetStudent();
        List.Add(std);
        Console.WriteLine(Messages.SUCCES_ADDED + Messages.GetStudentMessage(std));
    }
    public static void PrintStudents()
    {
        if (List.Count < 1)
        {
            Console.WriteLine(Messages.ERROR_EMPTY_COLLECTION);
        }
        else
        {
            foreach (var std in List)
            {
                Console.WriteLine(Messages.GetStudentMessage(std));
            }
        }
    }
    private static int FindIndex()
    {
        int index = -1;
        while (index == -1)
        {
            if (input == 2)
            {
                Console.WriteLine(Messages.PROMPT_ENTER_ID_TO_DELETE);
            }
            else if (input == 4)
            {
                Console.WriteLine(Messages.PROMPT_ENTER_ID_TO_UPDATE);
            }
            int id;
            while (!int.TryParse(Console.ReadLine().Trim(), out id))
            {
                Console.WriteLine(Messages.ERROR_WRONG_INPUT);
            }
            foreach (var std in List)
            {
                if (std.Id == id)
                {
                    index = List.IndexOf(std);
                    break;
                }
            }
            if (index == -1) Console.WriteLine(Messages.ERROR_NOT_FOUND);
        }
        return index;
    }
    public static void DeleteStudent()
    {
        int index = FindIndex();
        Console.WriteLine(Messages.SUCCES_DELETED + Messages.GetStudentMessage(List[index]));
        List.RemoveAt(index);
    }
    public static void UpdateStudent()
    {
        int index = FindIndex();
        Console.WriteLine(Messages.UPDATING + Messages.GetStudentMessage(List[index]));
        List[index] = GetStudent();
        Console.WriteLine(Messages.SUCCES_UPDATED + Messages.GetStudentMessage(List[index]));
    }
    public static bool IsExiting()
    {
        if (input == 5)
        {
            return true;
        }
        return false;
    }
}