using System.Collections;

public class Cafe
{
    public static void PrintMenu()
    {
        string[] menu = typeof(Menu).GetEnumNames();
        foreach (var item in menu)
        {
            int itemPrice = (int)Enum.Parse(typeof(Menu), item);
            Console.WriteLine($"{item,6} = {itemPrice,5}");
        }
    }

    public static void GetOrder(SortedList orders)
    {
        Console.Write("Siparis vermek istediginiz urunu giriniz: ");
        object i;
        while (true)
        {
            string input = Console.ReadLine().Trim();
            try
            {
                i = Enum.Parse(typeof(Menu), input, true);
                break;
            }
            catch
            {
                Console.WriteLine("Hatali Secim. Lutfen Tekrar Deneyiniz");
            }
        }
        Console.Write($"Kac adet {i} istiyorsunuz?: ");
        int count;
        while (!int.TryParse(Console.ReadLine().Trim(), out count))
        {
            Console.WriteLine("Hatali Secim. Lutfen Tekrar Deneyiniz.");
        }
        if (orders.ContainsKey(i))
        {
            orders[i] = (int)orders[i] + count;
        }
        else
        {
            orders.Add(i, count);
        }
        PrintOrders(orders);
    }
    public static void PrintOrders(SortedList orders)
    {
        foreach (DictionaryEntry item in orders)
        {
            Console.WriteLine($"{item.Key} -> {item.Value} adet");
        }
    }
    public static bool IsExiting()
    {
        Console.Write("Siparis Eklemek icin 'e', cikmak icin 'h' giriniz: ");
        char input;
        while (!char.TryParse(Console.ReadLine().Trim(), out input) || (input != 'e' && input != 'h'))
        {
            Console.WriteLine("Hatali secim. Lutfen Tekrar Deneyiniz.");
        }
        if (input == 'e')
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    public static void CheckOut(SortedList orders)
    {
        int total = 0;
        foreach (DictionaryEntry order in orders)
        {
            Menu p = (Menu)order.Key;
            int price = (int)p;
            Console.WriteLine($"{order.Key} = {order.Value} adet => {price * (int)order.Value}tl");
            total += price * (int)order.Value;
        }
        Console.WriteLine($"TOPLAM ===> {total}tl");
    }
    public static void SaveOrders(SortedList orders)
    {
        DateTime now = DateTime.Now;
        File.AppendAllText("D:/GIT/Ders-Notlari/2-BOLUM/CALISMALAR/enum-2/Orders.txt", $"\n SIPARIS TARIHI ====> {now.ToLongDateString()} // {now.ToLongTimeString()} ");
        int total = 0;
        foreach (DictionaryEntry item in orders)
        {
            Menu menuItem = (Menu)item.Key;
            int price = (int)menuItem;
            int quantity = (int)item.Value;
            File.AppendAllText("D:/GIT/Ders-Notlari/2-BOLUM/CALISMALAR/enum-2/Orders.txt", $"\n {menuItem} = {quantity} adet => {price * quantity} TL");
            total += price * quantity;
        }
        File.AppendAllText("D:/GIT/Ders-Notlari/2-BOLUM/CALISMALAR/enum-2/Orders.txt", $"\n TOPLAM ====> {total} TL");
        File.AppendAllText("D:/GIT/Ders-Notlari/2-BOLUM/CALISMALAR/enum-2/Orders.txt", $"\n ------------------------------------------------------------");
        Console.WriteLine("Siparisler 'Orders.txt' dosyasina kaydedildi!");
    }
}