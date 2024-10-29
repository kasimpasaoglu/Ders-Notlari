BankAccount account = new();

account.Set_AccNumber("123456789");
account.Set_Name("Kasim");
account.Set_Surname("Pasaoglu");
account.Set_Balance(245678);
account.Set_AccType("Vadeli");
account.Set_WithdrawLimit(5000);

Console.WriteLine(account.Get_AccNumber());
Console.Write(account.Get_Name());
Console.Write(" ");
Console.WriteLine(account.Get_Surname());
Console.WriteLine(account.Get_Balance());
Console.WriteLine(account.Get_AccType());
Console.WriteLine(account.Get_WithdrawLimit());



