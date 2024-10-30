public static class StudentHelper
{
    public static int Menu()
    {
        Console.WriteLine(Messages.SEPERATOR);
        Console.WriteLine(Messages.MENU_1_LIST_STUDENT);
        Console.WriteLine(Messages.MENU_2_DELETE_STUDENT);
        Console.WriteLine(Messages.MENU_3_ADD_STUDENT);
        Console.WriteLine(Messages.MENU_4_UPDATE_STUDENT);
        Console.WriteLine(Messages.MENU_5_EXIT);
        Console.WriteLine(Messages.SEPERATOR);
        int input;
        while (!(int.TryParse(Console.ReadLine().Trim(), out input) && (input == 1 || input == 2 || input == 3 || input == 4 || input == 5)))
        {
            Console.WriteLine(Messages.ERROR_WRONG_INPUT);
        }
        return input;
    }

    public static Student GetStudent()
    {
        string name;
        do
        {
            Console.WriteLine(Messages.PROMPT_ENTER_STUDENT_NAME);
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

    public static void AddStudent(Student std, List<Student> array)
    {
        array.Add(std);
        Console.WriteLine(Messages.GetStudentAddedMessage(std));

    }
}