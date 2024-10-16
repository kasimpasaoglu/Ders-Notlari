public class Func
{
    public static ulong GetCardNumber()
    {
        Console.WriteLine("Enter the 16-digit card number");
        ulong cardNumber;
        while (!ulong.TryParse(Console.ReadLine().Trim(), out cardNumber) || cardNumber.ToString().Length != 16)
        {
            Console.WriteLine("Card Number must be 16 digits and consist of numbers.");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Please try again...");
        }
        return cardNumber;
    }
    public static void PrintArray(int[] array)
    {
        Console.Write("Card Number : ");
        System.Threading.Thread.Sleep(400);
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0 && i % 4 == 0)
            {
                Console.Write(" ");
            }
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
    public static int[] StringToArray(string text)
    {
        int[] numbers = new int[text.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(text[i].ToString());
        }
        return numbers;
    }
    public static bool LuhnAlgorithm(string numberString)
    {
        int total = 0;
        bool digit = false;
        for (int i = numberString.Length - 1; i >= 0; i--) // sondan baslayip sayilari tek tek isleme al
        {
            int currentNumber = int.Parse(numberString[i].ToString()); // ilk sayiyi al
            if (digit) // baslangic degeri false cunku ilk sayi oldugu gibi kalacak
            {
                currentNumber *= 2; // iki katini al
                if (currentNumber > 9) // sonuc 9 dan buyukse
                {
                    currentNumber -= 9; // 10-19 arasi sayilarin rakamlari toplamini bulmak icin 9 cikarmak yeterli.
                }
            }
            total += currentNumber; // toplama ekle
            digit = !digit; // her dongude degil, iki dongude bir if bloguna girmesi icin her dongunun sonunda digit degerini tersine cevirme islemi 
        }
        return total % 10 == 0;
    }
    public static bool IsRepeating()
    {
        Console.WriteLine("Type 'y' to make a new verification and 'n' to exit.");
        char input;
        while (!char.TryParse(Console.ReadLine().Trim(), out input) || (input != 'y' && input != 'n'))
        {
            Console.WriteLine("Command not found, Please try again (y/n ?)");
        }
        return input == 'y';
    }
}