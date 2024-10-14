
using System.Collections;
ArrayList kutuphane = new();
kutuphane.Add(new Kitap("1984", "George Orwell", 328, new DateTime(1949, 6, 8)));
kutuphane.Add(new Kitap("To Kill a Mockingbird", "Harper Lee", 281, new DateTime(1960, 7, 11)));
kutuphane.Add(new Kitap("The Great Gatsby", "F. Scott Fitzgerald", 180, new DateTime(1925, 4, 10)));
kutuphane.Add(new Kitap("Pride and Prejudice", "Jane Austen", 279, new DateTime(1813, 1, 28)));
kutuphane.Add(new Kitap("The Catcher in the Rye", "J.D. Salinger", 214, new DateTime(1951, 7, 16)));
kutuphane.Add(new Kitap("Moby Dick", "Herman Melville", 635, new DateTime(1851, 10, 18)));
kutuphane.Add(new Kitap("War and Peace", "Leo Tolstoy", 1225, new DateTime(1869, 1, 1)));
kutuphane.Add(new Kitap("The Hobbit", "J.R.R. Tolkien", 310, new DateTime(1937, 9, 21)));
kutuphane.Add(new Kitap("The Lord of the Rings", "J.R.R. Tolkien", 1137, new DateTime(1954, 7, 29)));
kutuphane.Add(new Kitap("Brave New World", "Aldous Huxley", 268, new DateTime(1932, 8, 31)));

while (true)
{
    Kitap.ShowMainMenu();

    int input;
    while (!int.TryParse(Console.ReadLine().Trim(), out input) || input <= 0 || input > 5)
    {
        Console.WriteLine("Gecersiz Secim, Tekrar Deneyin");
    }

    if (input == 1)
    {
        Kitap.ShowBooks(kutuphane);
    }
    if (input == 2)
    {
        Kitap.AddBook(kutuphane);
    }
    if (input == 3)
    {
        Kitap.RemoveBook(kutuphane);
    }
    if (input == 4)
    {
        Kitap.EditBook(kutuphane);
    }
    if (input == 5)
    {
        break;
    }
}


