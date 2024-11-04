MyCollection<string> mylist = new();


mylist.Add("Ali");
mylist.Add("Ahmet");
mylist.Add("Firat");
mylist.Add("Bora");


for (int i = 0; i < mylist.Count; i++)
{
    Console.WriteLine(mylist[i]);
}
Console.WriteLine("-----");
foreach (var item in mylist)
{
    Console.WriteLine(item);
}


