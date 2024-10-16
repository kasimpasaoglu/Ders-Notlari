Console.WriteLine("CREDIT CARD NUMBER VERIFICATION APPLICATION");
while (true)
{
    System.Threading.Thread.Sleep(400);
    ulong cardNumber = Func.GetCardNumber();
    string cardNumberString = cardNumber.ToString();
    Func.PrintArray(Func.StringToArray(cardNumberString));
    System.Threading.Thread.Sleep(400);
    if (Func.LuhnAlgoritm(cardNumberString))
    {
        Console.WriteLine("The Card Number Entered is VALID");
    }
    else
    {
        Console.WriteLine("The Card Number Entered is NOT VALID");
    }
    Console.WriteLine();
    System.Threading.Thread.Sleep(400);
    if (!Func.IsRepeating())
    {
        break;
    }
}
