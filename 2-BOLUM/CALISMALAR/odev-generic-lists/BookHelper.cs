using System.Text.Json;

public class BookHelper
{
    public static Dictionary<int, Book> Library { get; set; }
    public static int Input;

    static BookHelper()
    {
        Library = new Dictionary<int, Book>();
    }

    public static void LoadBookLists()
    {
        var filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "data", "books.json");
        if (!File.Exists(filePath))
        {
            Console.WriteLine(Msg.ErrorFileNotFound);
        }
        else
        {
            string json = File.ReadAllText(filePath);
            Library = JsonSerializer.Deserialize<Dictionary<int, Book>>(json);
            Console.WriteLine(Msg.SuccessLoadedFile);
        }
    }
    public static int FindNewId()
    {
        int newId = 0;
        for (int i = 10; i < Library.Count + 11; i++)
        {
            if (!Library.ContainsKey(i))
            {
                newId = i;
                break;
            }
        }
        return newId;
    }
    private static string FormatString(string input)
    {
        string[] inputArray = input.Split(' ');
        string newInput = "";
        foreach (var item in inputArray)
        {
            newInput += char.ToUpper(item[0]) + item.Substring(1).ToLower() + " ";
        }
        return newInput.Trim();
    }
    private static string GetCheckedStringValue()
    {
        string input;
        while (true)
        {
            input = Console.ReadLine().Trim();
            if (input.Any(char.IsDigit) || input.Any(char.IsSymbol))
            {
                Console.WriteLine(Msg.ErrorWrongInput);
            }
            else
            {
                break;
            }
        }
        return FormatString(input);
    }
    private static string GetTitle()
    {
        Console.Write(Msg.PromptTitle);
        return FormatString(Console.ReadLine().Trim());
    }
    private static string GetAuthor()
    {
        Console.Write(Msg.PromptAuthor);
        return GetCheckedStringValue();
    }
    private static string GetGenre()
    {
        Console.Write(Msg.PromptGenre);
        return GetCheckedStringValue();
    }
    private static int GetPublicationYear()
    {
        Console.Write(Msg.PromptYear);
        int publication;
        while (!int.TryParse(Console.ReadLine().Trim(), out publication) || publication > DateTime.Now.Year || publication < 1900)
        {
            Console.WriteLine(Msg.ErrorWrongInput);
        }
        return publication;
    }
    private static int GetIntInput(int minValue = 1, int maxValue = 9)
    {
        int input = 0;
        while (!int.TryParse(Console.ReadLine().Trim(), out input) || input < minValue || input > maxValue)
        {
            Console.WriteLine(Msg.ErrorWrongInput);
        }
        return input;

    }
    private static int FindKeyById()
    {
        Console.WriteLine(Msg.PromptEnterId);
        int input = GetIntInput(10, Library.Count + 11);
        while (!Library.ContainsKey(input))
        {
            Console.WriteLine(Msg.ErrorBookNotFound);
        }
        return input;
    }
    private static int FindKeyByName()
    {
        int bookKey = 0;
        bool isFound = false;
        while (!isFound)
        {
            string title = GetTitle();
            foreach (var item in Library)
            {
                if (item.Value.Title == title)
                {
                    bookKey = item.Key;
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine(Msg.ErrorBookNotFound);
            }
        }
        return bookKey;
    }

    public static int Menu()
    {
        Console.WriteLine(Msg.Seperator);
        Console.WriteLine(Msg.Menu1Add);
        Console.WriteLine(Msg.Menu2Remove);
        Console.WriteLine(Msg.Menu3List);
        Console.WriteLine(Msg.Menu4Borrow);
        Console.WriteLine(Msg.Menu5Return);
        Console.WriteLine(Msg.Menu6FindByName);
        Console.WriteLine(Msg.Menu7Sort);
        Console.WriteLine(Msg.Menu8Save);
        Console.WriteLine(Msg.Menu9Exit);
        Console.WriteLine(Msg.Seperator);

        Input = GetIntInput();
        return Input;
    }

    public static void AddBook()
    {
        Book newBook = new Book(GetTitle(), GetAuthor(), GetGenre(), GetPublicationYear());
        Library.Add(newBook.Id, newBook);
        Console.WriteLine(Msg.GetBookTemplate(newBook));
    }

    public static void RemoveBook()
    {
        int keyToDelete = FindKeyById();
        Console.WriteLine(Msg.SuccessDeletedBook + Msg.GetBookTemplate(Library.GetValueOrDefault(keyToDelete)));
        Library.Remove(keyToDelete);
    }

    public static void PrintBooks()
    {
        Console.WriteLine(Msg.GetFirstLine());
        foreach (var item in Library)
        {
            Console.WriteLine(Msg.GetBookTemplate(item.Value));
        }
    }

    public static void BorrowBook()
    {
        Book requestedBook = Library.GetValueOrDefault(FindKeyById());
        if (requestedBook.IsAvailable)
        {
            requestedBook.IsAvailable = false;
            Console.WriteLine(Msg.SuccessBorrow + Msg.GetBookTemplate(requestedBook));
        }
        else
        {
            Console.WriteLine(Msg.ErrorBorrow);
        }
    }

    public static void ReturnBook()
    {
        Book returningBook = Library.GetValueOrDefault(FindKeyById());
        if (returningBook.IsAvailable)
        {
            Console.WriteLine(Msg.ErrorReturn);
        }
        else
        {
            returningBook.IsAvailable = true;
            Console.WriteLine(Msg.SuccessReturn + Msg.GetBookTemplate(returningBook));
        }
    }

    public static void FindBook()
    {
        int key = FindKeyByName();
        Console.WriteLine(Msg.SuccessFound + Msg.GetBookTemplate(Library.GetValueOrDefault(key)));
    }

    public static void SaveLibrary()
    {
        var filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "data", "books.json");
        string json = JsonSerializer.Serialize(Library);
        File.WriteAllText(filePath, json);
        Console.WriteLine(Msg.SuccessSavedToFile);

    }
}