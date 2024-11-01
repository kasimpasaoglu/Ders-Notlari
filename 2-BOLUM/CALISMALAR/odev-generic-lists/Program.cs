BookHelper Library = new();
BookHelper.LoadBookLists();

while (true)
{
    int input = BookHelper.Menu();
    switch (input)
    {
        case 1:
            BookHelper.AddBook();
            break;
        case 2:
            BookHelper.RemoveBook();
            break;
        case 3:
            BookHelper.PrintBooks();
            break;
        case 4:
            BookHelper.BorrowBook();
            break;
        case 5:
            BookHelper.ReturnBook();
            break;
        case 6:
            BookHelper.FindBook();
            break;
        case 7:
            Console.WriteLine("Work In Progress");
            break;
        case 8:
            BookHelper.SaveLibrary();
            break;
        case 9:
            return;

    }
}