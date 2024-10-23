using System.Collections;

SortedList orders = new();
while (true)
{
    Cafe.PrintMenu();
    Cafe.GetOrder(orders);

    if (Cafe.IsExiting())
    {
        Cafe.CheckOut(orders);
        Cafe.SaveOrders(orders);
        break;
    }
}