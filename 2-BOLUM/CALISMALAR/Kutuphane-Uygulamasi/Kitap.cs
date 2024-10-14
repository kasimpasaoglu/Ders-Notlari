
using System.Collections;
using System.Diagnostics.CodeAnalysis;

public class Kitap
{

    public int bookID;
    public string name;
    public string author;
    public int pageCount;
    public DateTime publicationDate;



    public Kitap(string bookName, string bookAuthor, int bookPageCount, DateTime bookPrintDate)
    {
        Random rnd = new Random();
        bookID = rnd.Next(1000, 2000);
        name = bookName;
        author = bookAuthor;
        pageCount = bookPageCount;
        publicationDate = bookPrintDate;
    }

    public static void AddBook(ArrayList list)
    {
        Console.WriteLine("Kitabin Adini Giriniz");
        var bookinput = Console.ReadLine().Trim();
        Console.WriteLine("Kitabin Yazarini Giriniz");
        var authorInput = Console.ReadLine().Trim();
        Console.WriteLine("Kitabin Sayfa Sayisini Giriniz");
        int bookPageCountInput;
        while ((!int.TryParse(Console.ReadLine().Trim(), out bookPageCountInput)) || bookPageCountInput <= 0)
        {
            Console.WriteLine("Gecerli Bir Sayi Giriniz");
        }
        Console.WriteLine("Kitabin Basim Tarihini Giriniz (gg.aa.yyyy)");
        DateTime printDateInput = DateTime.Parse(Console.ReadLine().Trim());

        list.Add(new Kitap(bookinput, authorInput, bookPageCountInput, printDateInput));
    }

    public static void ShowBooks(ArrayList list)
    {
        Console.WriteLine(" Kitap ID || Kitap Adi || Yazar Adi || Sayfa Sayisi || Basim Yili");
        foreach (Kitap item in list)
        {
            Console.WriteLine($"{item.bookID} || {item.name} || {item.author} || {item.pageCount} || {item.publicationDate.ToLongDateString()}");
        }
    }

    public static void RemoveBook(ArrayList list)
    {
        while (true)
        {

            ShowBooks(list);
            Console.WriteLine();
            Console.WriteLine("Silmek Istediginiz Kitabin ID numarasini giriniz");
            int idInput = int.Parse(Console.ReadLine().Trim());

            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                Kitap currentBook = (Kitap)list[i];
                if (currentBook.bookID == idInput)
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                Kitap bookToDelete = (Kitap)list[index];
                Console.WriteLine($"Silinen Kitap => {bookToDelete.name} || {bookToDelete.author}");
                list.RemoveAt(index);
                Console.WriteLine("Kitap Basariyla Silindi.");
                break;
            }
            else
            {
                Console.WriteLine("Girdiginiz ID Bulunamadi, Tekrar Deneyin");
                Console.WriteLine();
            }
        }
    }

    public static void EditBook(ArrayList list)
    {
        ShowBooks(list);
        Console.WriteLine();
        Console.WriteLine("Silmek Istediginiz Kitabin ID numarasini giriniz");
        int idInput = int.Parse(Console.ReadLine().Trim());

        int index = -1;
        for (int i = 0; i < list.Count; i++)
        {
            Kitap currentBook = (Kitap)list[i];
            if (currentBook.bookID == idInput)
            {
                index = i;
                break;
            }
        }

        // neyi degistimek istiyorsun (1,2,3,4,5)
        // eger kullanici 1 derse 
        // bunu calistir
        // 2 derse 

        if ()
        {
            ChangeID();
        }

        if ()
        {
            ChangeName();
        }

        if ()
        {
            ChangePageCount();
        }

        if ()
        {

        }

        if ()
        {

        }

        if ()
        {

        }

    }

    public static void ChangeID()
    {

    }
    public static void ChangeName()
    {

    }
    public static void ChangeAuthor()
    {

    }
    public static void ChangePageCount()
    {

    }
    public static void ChangeDate()
    {

    }
}



