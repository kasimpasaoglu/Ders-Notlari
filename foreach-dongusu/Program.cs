
#region ArrayList icinde donecek bir foreach dongusu olusturalim
/*
using System.Collections;

ArrayList list = new ArrayList();
list.Add("Istanbul");
list.Add("Ankara");
list.Add("Rize");
list.Add("Mugla");
list.Add("Izmir");
list.Add("Ordu");
list.Add("Agri");
list.Add("Antalya");
list.Add("Hatay");
list.Add("Maras");

foreach (object item in list)
{
    Console.WriteLine(item);
}
*/
#endregion

#region SortedList ile foreach kullanimi

using System.Collections;

SortedList sortedList = new SortedList();

sortedList.Add(1, "Ankara");
sortedList.Add(2, "Istanbul");
sortedList.Add(3, "Izmir");

foreach (DictionaryEntry i in sortedList)
{
    Console.WriteLine(i.Key + " -- " + i.Value);
}

#endregion