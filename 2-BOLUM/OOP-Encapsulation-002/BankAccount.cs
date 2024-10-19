public class BankAccount
{
    private int accNumber;
    private string name;
    private string surname;
    private decimal balance;
    private string accType;
    private decimal withdrawLimit;

    public int Get_AccNumber()
    {
        return accNumber;
    }
    public string Get_Name()
    {
        return name;
    }
    public string Get_Surname()
    {
        return surname;
    }
    public decimal Get_Balance()
    {
        return Math.Round(balance, 4);
    }
    public string Get_AccType()
    {
        return accType;
    }
    public decimal Get_WithdrawLimit()
    {
        return Math.Round(withdrawLimit, 4);
    }
    public void Set_AccNumber(string value)
    {
        if (value.Length != 9 || !value.All(char.IsDigit))
        {
            accNumber = 0;
        }
        else
        {
            accNumber = int.Parse(value);
        }
    }
    public void Set_Name(string name)
    {
        if (name.Contains(' ') || name.All(char.IsDigit) || name.Length < 3)
        {
            this.name = "";
        }
        else
        {
            this.name = name;
        }
    }
    public void Set_Surname(string surname)
    {
        if (surname.Contains(' ') || surname.All(char.IsDigit) || surname.Length < 3)
        {
            this.surname = "";
        }
        else
        {
            this.surname = surname;
        }

    }
    public void Set_Balance(decimal balance)
    {
        if (balance < 0)
        {
            this.balance = 0;
        }
        else
        {
            this.balance = balance;
        }
    }
    public void Set_AccType(string type)
    {
        type.ToLower();
        if (type != "vadeli" || type != "vadesiz")
        {
            accType = "";
        }
        else
        {
            accType = type;
        }
    }
    public void Set_WithdrawLimit(decimal limit)
    {
        if (limit > 0 && limit < 10000)
        {
            withdrawLimit = limit;
        }
        else
        {
            withdrawLimit = 0;
        }
    }

}