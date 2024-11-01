public class Msg
{
    public const string Seperator = "-------------------------";
    public const string Menu1Add = "1 -> Add new book";
    public const string Menu2Remove = "2 -> Remove a book";
    public const string Menu3List = "3 -> Show all books";
    public const string Menu4Borrow = "4 -> Borrow a book";
    public const string Menu5Return = "5 -> Return a book";
    public const string Menu6FindByName = "6 -> Find a book with title";
    public const string Menu7Sort = "7 -> Sort Library";
    public const string Menu8Save = "8 -> Save changes";
    public const string Menu9Exit = "9 -> Exit Program";
    public const string ErrorWrongInput = "Wrong input, please try again.";
    public const string ErrorFileNotFound = "Library file not found. Creating empty library";
    public const string ErrorBookNotFound = "Book can not found in the Library, please try again.";
    public const string ErrorBorrow = "Book is not in stock.";
    public const string ErrorReturn = "Book is allready in stock";
    public const string SuccessFound = "Book found -> ";
    public const string SuccessBorrow = "Book borrowed -> ";
    public const string SuccessReturn = "Book returned -> ";
    public const string SuccessSavedToFile = "Changes saved on file 'data/books.json'";
    public const string SuccessLoadedFile = "Library file loaded successfully";
    public const string SuccessDeletedBook = "Book successfully deleted -> ";
    public const string PromptEnterId = "Enter book's ID :";
    public const string PromptTitle = "Enter book name :";
    public const string PromptAuthor = "Enter author's name :";
    public const string PromptGenre = "Enter book's genre :";
    public const string PromptYear = "Enter publication year :";

    public static string GetFirstLine()
    {
        return $" {"ID",3} || {"Title",25} || {"Author",15}|| {"Genre",10} || {"Year",5} || {"In Stock",8} ";
    }
    public static string GetBookTemplate(Book book)
    {
        return $" {book.Id,3} || {book.Title,25} || {book.Author,15}|| {book.Genre,10} || {book.PublicationYear,5} || {(book.IsAvailable ? "Yes" : "No"),8} ";
    }
}