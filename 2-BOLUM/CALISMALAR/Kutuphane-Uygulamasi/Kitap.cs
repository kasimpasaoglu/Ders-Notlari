
using System.Collections;

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
        DateTime printDateInput;
        try
        {
            printDateInput = DateTime.Parse(Console.ReadLine().Trim());

        }
        catch (Exception)
        {
            Console.WriteLine("Basim Tarihi Gecersiz Formatta. Bugunun Tarihi Otomatik Atandi");
            printDateInput = DateTime.Now;
        }

        list.Add(new Kitap(bookinput, authorInput, bookPageCountInput, printDateInput));
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"{bookinput} || {authorInput} || {bookPageCountInput} || {printDateInput.ToLongDateString()}");
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("Kitap Eklendi");

    }

    public static void ShowBooks(ArrayList list)
    {
        Console.WriteLine($"{"KITAP ID",-8} || {"KITAP ADI",-25} || {"YAZAR ADI",-25} || {"SAYFA SAYISI",-12} || BASIM TARIHI");
        System.Threading.Thread.Sleep(500);
        foreach (Kitap item in list)
        {
            Console.WriteLine($"{item.bookID,-8} || {item.name,-25} || {item.author,-25} || {item.pageCount,-12} || {item.publicationDate.ToLongDateString()}");
            System.Threading.Thread.Sleep(100);
        }
    }

    public static void RemoveBook(ArrayList list)
    {
        ShowBooks(list);
        Console.WriteLine();
        int index = FindIndexById(list);

        Kitap bookToDelete = (Kitap)list[index];
        Console.WriteLine($"Silinen Kitap => {bookToDelete.name} || {bookToDelete.author}");
        System.Threading.Thread.Sleep(500);
        list.RemoveAt(index);
        Console.WriteLine("Kitap Basariyla Silindi.");
        System.Threading.Thread.Sleep(500);
    }
    public static int FindIndexById(ArrayList list)
    {
        while (true)
        {
            ShowBooks(list);
            Console.WriteLine();
            Console.WriteLine("Lutfen Kitabin ID numarasini giriniz");
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
                return index;
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
        int index = FindIndexById(list);
        while (true)
        {
            Console.WriteLine();
            Kitap bookToEdit = (Kitap)list[index];
            Console.WriteLine($" 1 => {bookToEdit.bookID} || 2 => {bookToEdit.name} || 3 => {bookToEdit.author} || 4 => {bookToEdit.pageCount} || 5 => {bookToEdit.publicationDate.ToShortDateString()}");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Degistirmek Istediginiz Alani Seciniz (1-2-3-4-5)");
            System.Threading.Thread.Sleep(500);
            int input;
            while ((!int.TryParse(Console.ReadLine().Trim(), out input)) || input < 1 || input > 5)
            {
                Console.WriteLine("Gecerli Bir Secim Yapiniz");
            }

            if (input == 1)
            {
                ChangeID(bookToEdit);
            }
            else if (input == 2)
            {
                ChangeName(bookToEdit);
            }
            else if (input == 3)
            {
                ChangeAuthor(bookToEdit);
            }
            else if (input == 4)
            {
                ChangePageCount(bookToEdit);
            }
            else if (input == 5)
            {
                ChangeDate(bookToEdit);
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Ana Menuye Donmek icin 'exit' yaziniz, devam etmek icin Enter'a basiniz");
            var contiune = Console.ReadLine().Trim();
            if (contiune == "exit")
            {
                Console.WriteLine("Yaptiginiz Degisiklikler Kaydediliyor");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($" ID => {bookToEdit.bookID} || KITAP ADI => {bookToEdit.name} || YAZAR => {bookToEdit.author} || SAYFA SAYISI => {bookToEdit.pageCount} || BASIM TARIHI => {bookToEdit.publicationDate.ToShortDateString()}");
                System.Threading.Thread.Sleep(500);
                break;
            }
        }
    }

    public static void ChangeID(Kitap book)
    {
        Console.WriteLine("Yeni ID No Giriniz");
        while (!int.TryParse(Console.ReadLine().Trim(), out book.bookID) || book.bookID < 1000 || book.bookID > 2000)
        {
            Console.WriteLine("Id Numarasi 1000-2000 arasi Pozitif Tamsayi Olmalidir");
            Console.WriteLine("Lutfen Tekrar Deneyiniz");
        }
        Console.WriteLine("Guncelleme Basarili");
        System.Threading.Thread.Sleep(500);
    }
    public static void ChangeName(Kitap book)
    {
        Console.WriteLine("Yeni Isim Giriniz");
        book.name = Console.ReadLine().Trim();
        Console.WriteLine("Guncelleme Basarili");
        System.Threading.Thread.Sleep(500);
    }
    public static void ChangeAuthor(Kitap book)
    {
        Console.WriteLine("Yeni Yazar Giriniz");
        book.author = Console.ReadLine().Trim();
        Console.WriteLine("Guncelleme Basarili");
        System.Threading.Thread.Sleep(500);
    }
    public static void ChangePageCount(Kitap book)
    {
        Console.WriteLine("Yeni Sayfa Sayisi Giriniz");
        while (!int.TryParse(Console.ReadLine().Trim(), out book.pageCount) || book.pageCount < 1)
        {
            Console.WriteLine("Sayfa Sayisi Pozitif Tamsayi Olmalidir");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Lutfen Tekrar Deneyiniz");
        }
        Console.WriteLine("Guncelleme Basarili");
        System.Threading.Thread.Sleep(500);
    }
    public static void ChangeDate(Kitap book)
    {
        Console.WriteLine("Yeni Basim Tarihi Giriniz");
        try
        {
            DateTime newDate = DateTime.Parse(Console.ReadLine().Trim());
            book.publicationDate = newDate;
            Console.WriteLine("Guncelleme Basarili");
            System.Threading.Thread.Sleep(500);
        }
        catch (Exception)
        {
            Console.WriteLine("Gecersiz Tarih Formati, Degisiklik Yapilamadi");
            System.Threading.Thread.Sleep(500);
        }
    }
    public static void ShowMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("ANA MENU");
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("Bir Secim Yapiniz");
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("1 => Kitaplari Listele");
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("2 => Kitap Ekle");
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("3 => Kitap Sil");
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("4 => Kitap Bilgilerini Degistir");
        System.Threading.Thread.Sleep(100);
        Console.WriteLine("5 => Cikis");
        System.Threading.Thread.Sleep(100);
    }
}
