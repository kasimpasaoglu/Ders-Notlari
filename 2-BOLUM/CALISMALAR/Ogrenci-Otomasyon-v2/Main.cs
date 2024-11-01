using System.Text.Json;

public class Main
{
    public static List<Student> list;
    public static int Input;
    static Main()
    {
        list = new List<Student>();
    }


    private static string GetName()
    {
        string nameInput;
        while (true)
        {
            Console.Write(Messages.PromptEnterStudentName);
            nameInput = Console.ReadLine().Trim();
            if (nameInput.Any(char.IsDigit) || nameInput.Any(char.IsPunctuation) || nameInput.Any(char.IsSymbol))
            {
                Console.WriteLine(Messages.ErrorWrongInput);
                Console.WriteLine(Messages.Separator);
                Thread.Sleep(300);
            }
            else
            {
                break;
            }
        }

        string[] fullNameArray = nameInput.ToLower().Split(' ');
        string fullName = "";
        foreach (string item in fullNameArray)
        {
            string segment = char.ToUpper(item[0]) + item.Substring(1);
            fullName += segment + ' ';
        }
        return fullName.TrimEnd();
    }
    private static double GetGrade()
    {
        Console.Write(Messages.PromptEnterStudentGrade);
        double gradeInput;
        while (!double.TryParse(Console.ReadLine().Trim().Replace('.', ','), out gradeInput))
        {
            Console.WriteLine(Messages.ErrorWrongInput);
        }
        return gradeInput;
    }
    private static int GetId()
    {
        int idInput;
        Console.WriteLine(Messages.PromptEnterId);
        while (!int.TryParse(Console.ReadLine().Trim(), out idInput))
        {
            Console.WriteLine(Messages.ErrorWrongInput);
        }
        return idInput;
    }
    private static Student CreateStudent()
    {
        return new Student(GetName(), GetGrade());
    }
    private static int FindIndex()
    {
        int index = -1;
        while (index == -1)
        {
            if (Input == 3 || Input == 4)
            {
                int id = GetId();
                foreach (Student item in list)
                {
                    if (item.Id == id)
                    {
                        index = list.IndexOf(item);
                    }
                }
                if (index == -1)
                {
                    Console.WriteLine(Messages.ErrorCannotFindId);
                }
            }
            else if (Input == 7)
            {
                string name = GetName();
                foreach (Student item in list)
                {
                    if (item.Name == name)
                    {
                        index = list.IndexOf(item);
                    }
                }
                if (index == -1)
                {
                    Console.WriteLine(Messages.ErrorCannotFindName);
                }
            }
        }
        return index;
    }
    private static void SetCounter()
    {
        int maxId = 0;

        if (list.Count > 0)
        {
            foreach (var item in list)
            {
                if (item.Id > maxId)
                {
                    maxId = item.Id;
                }
            }
        }
        Student.UpdateIdCounter(maxId + 1);
    }
    public static int Menu()
    {
        Console.WriteLine(Messages.Separator);
        Console.WriteLine(Messages.PromptMakeChoice);
        Console.WriteLine(Messages.Menu1PrintStudents);
        Console.WriteLine(Messages.Menu2AddStudent);
        Console.WriteLine(Messages.Menu3DeleteStudent);
        Console.WriteLine(Messages.Menu4UpdateStudent);
        Console.WriteLine(Messages.Menu5SaveStudents);
        Console.WriteLine(Messages.Menu6GetStudents);
        Console.WriteLine(Messages.Menu7FindStudent);
        Console.WriteLine(Messages.Menu8SortStudents);
        Console.WriteLine(Messages.Menu9Exit);
        Console.WriteLine(Messages.Separator);

        while (!int.TryParse(Console.ReadLine().Trim(), out Input) || Input < 1 || Input > 9)
        {
            Console.WriteLine(Messages.ErrorWrongInput);
        }
        return Input;
    }
    public static void AddStudent()
    {
        list.Add(CreateStudent());
        Console.WriteLine(Messages.SuccessAdded + Messages.GetStudentMessage(list[list.Count - 1]));
    }
    public static void PrintStudents()
    {
        if (list.Count == 0)
        {
            Console.WriteLine(Messages.ErrorCollectionEmpty);
        }
        else
        {
            Console.WriteLine(Messages.GetTemplate());
            foreach (Student std in list)
            {
                Console.WriteLine(Messages.GetStudentMessage(std));
                Thread.Sleep(100);
            }
        }
    }
    public static void DeleteStudent()
    {
        int index = FindIndex();
        Console.WriteLine(Messages.SuccessDeleted + Messages.GetStudentMessage(list[index]));
        list.RemoveAt(index);
    }
    public static void UpdateStudent()
    {
        int index = FindIndex();
        Console.WriteLine(Messages.SuccessFound + Messages.GetStudentMessage(list[index]));
        string newName = GetName();
        double newGrade = GetGrade();
        list[index] = new Student(newName, newGrade);
        Console.WriteLine(Messages.SuccessUpdated + Messages.GetStudentMessage(list[index]));
    }
    public static void SaveStudentsList()
    {
        string json = JsonSerializer.Serialize(list);
        File.WriteAllText(Messages.JsonPath, json);
        Console.WriteLine(Messages.SuccessSavedToFile());
    }
    public static void LoadStudentsFromPath()
    {
        if (!File.Exists(Messages.JsonPath))
        {
            Console.WriteLine(Messages.ErrorFileNotFound);
        }
        else
        {
            string json = File.ReadAllText(Messages.JsonPath);
            list = JsonSerializer.Deserialize<List<Student>>(json);
            Console.WriteLine(Messages.SuccessLoadToFile());
            PrintStudents();
        }
        SetCounter();
    }
    public static void FindStudent()
    {
        int index = FindIndex();
        Console.WriteLine(Messages.SuccessFound + Messages.GetStudentMessage(list[index]));
    }
    public static void SortStudents()
    {
        Console.WriteLine(Messages.Separator);
        Console.WriteLine(Messages.PromptMakeChoice);
        Console.WriteLine(Messages.PromtSort1ByGrade);
        Console.WriteLine(Messages.PromtSort2ByName);
        Console.WriteLine(Messages.Separator);
        int sortInput;
        while (!int.TryParse(Console.ReadLine().Trim(), out sortInput) && Input <= 0 && Input >= 3)
        {
            Console.WriteLine(Messages.ErrorWrongInput);
        }

        if (sortInput == 1)
        {
            SortList(list, sortByGrade: true, descending: true);
            Console.WriteLine(Messages.SuccessSortedByGrade);
        }
        else if (sortInput == 2)
        {
            SortList(list, sortByGrade: false);
            Console.WriteLine(Messages.SuccessSortedByName);
        }
    }

    private static void SortList(List<Student> list, bool sortByGrade, bool descending = false)
    {
        var comparer = new StudentComparer(sortByGrade, descending);
        list.Sort(comparer);
    }

}