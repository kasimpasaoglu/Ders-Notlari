#region Bolme islemi tryParse ile birlikte
/*
Console.WriteLine("Bolunecek Sayiyi Giriniz");
double number;
while (!double.TryParse(Console.ReadLine().Trim(), out number))
{
    Console.WriteLine("Lutfen Gecerli Bir Sayi Giriniz");
}

Console.WriteLine("Bolen'i giriniz");
double divider;
while (true)
{
    if (!double.TryParse(Console.ReadLine().Trim(), out divider))
    {
        Console.WriteLine("Lutfen Gecerli Bir Sayi Giriniz");
    }
    else if (divider == 0)
    {
        Console.WriteLine("Bolen Sifir Olamaz, Lutfen Tekrar Deneyin");
    }
    else
    {
        break;
    }
}

double result = number / divider;

Console.WriteLine(Math.Round(result, 2));
*/
#endregion

#region Hata Yonetimli Gelismis Hesap Makinesi

while (true)
{
    Console.WriteLine("Birinci Sayiyi Giriniz");
    double firstNumber = GetNumber();
    Console.WriteLine("Ikinci Sayiyi Giriniz");
    double secondNumber = GetNumber();

    int process = GetProcess();

    if (process == 6)
    {
        GetRoot(ref firstNumber, ref secondNumber);
    }
    else
    {
        SimpleProcess(firstNumber, ref secondNumber, process);
    }

    if (isExiting())
    {
        break;
    }

}

static int GetProcess()
{
    Console.WriteLine("Yapmak Istediginiz Islemi Seciniz");
    Console.WriteLine("1. Toplama");
    Console.WriteLine("2. Cikarma");
    Console.WriteLine("3. Carpma");
    Console.WriteLine("4. Bolme");
    Console.WriteLine("5. Kuvvetini Alma");
    Console.WriteLine("6. Kok Alma");

    int process;

    while (!int.TryParse(Console.ReadLine().Trim(), out process) || process > 6 || process < 1)
    {
        Console.WriteLine("Lutfen Gecerli Bir Secim Yapiniz");
    }
    return process;

}

static double GetNumber()
{
    double number;
    while (!double.TryParse(Console.ReadLine().Trim(), out number))
    {
        Console.WriteLine("Lutfen Gecerli Bir Sayi Giriniz");
    }
    return number;
}

static void SimpleProcess(double a, ref double b, int process)
{
    if (process == 1)
    {
        try
        {
            Console.WriteLine($"{a} + {b} = {Math.Round(a + b, 2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Beklenmedik Bir Hata Olustu =>> " + ex.Message);
        }
    }
    else if (process == 2)
    {
        try
        {
            Console.WriteLine($"{a} - {b} = {Math.Round(a - b, 2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Beklenmedik Bir Hata Olustu =>> " + ex.Message);
        }
    }
    else if (process == 3)
    {
        try
        {
            Console.WriteLine($"{a} * {b} = {Math.Round(a * b, 2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Beklenmedik Bir Hata Olustu =>> " + ex.Message);
        }
    }
    else if (process == 4)
    {
        while (b == 0)
        {
            Console.WriteLine("Bolme Isleminde Bolen Sifir Olamaz, Lutfen Ikinci Sayiyi Tekrar Girin");
            b = GetNumber();
        }
        try
        {
            Console.WriteLine($"{a} / {b} = {Math.Round(a / b, 2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Beklenmedik Bir Hata Olustu =>> " + ex.Message);
        }
    }
    else if (process == 5)
    {
        try
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Round(Math.Pow(a, b), 2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Beklenmedik Bir Hata Olustu =>> " + ex.Message);
        }
    }
}

static void GetRoot(ref double a, ref double b)
{
    while (true)
    {
        if (b == 0)
        {
            Console.WriteLine("Kok Alma Isleminde Kok Derecesi Sifir Olamaz, Lutfen Ikinci Sayiyi Tekrar Girin");
            b = GetNumber();
        }
        else if (b % 2 == 0 && a < 0)
        {
            Console.WriteLine("Negatif Sayilarin Cift Derece Koku Alinmaz, Lutfen Sayilari Tekrar Girin");
            Console.WriteLine("Birinci Sayiyi Girin");
            a = GetNumber();
            Console.WriteLine("Ikinci Sayiyi Girin");
            b = GetNumber();
        }
        else
        {
            break;
        }
    }
    try
    {
        double result;
        if (b % 2 != 0 && a < 0)
        {
            result = -Math.Pow(Math.Abs(a), 1 / b);
        }
        else
        {
            result = Math.Pow(a, 1 / b);
        }
        Console.WriteLine($" {b} √ {a}  = {Math.Round(result, 2)}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Beklenmedik Bir Hata Olustu =>> " + ex.Message);
    }
}

static bool isExiting()
{
    Console.WriteLine("Baska Bir Islem Yapmak Icin Enter'a Basiniz");
    Console.WriteLine("Cikmak Icin 'exit' Yaziniz");
    var input = Console.ReadLine().Trim().ToLower();
    while (input != "" && input != "exit")
    {
        Console.WriteLine("Girilen Komut Bulunamadi");
        input = Console.ReadLine().Trim().ToLower();
    }
    if (input == "exit")
    {
        return true;
    }
    return false;
}

#endregion

