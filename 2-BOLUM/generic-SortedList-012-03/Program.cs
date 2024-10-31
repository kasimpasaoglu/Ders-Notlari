


SortedList<int, string> list = new SortedList<int, string>();

list.Add(2, "zzz");
list.Add(1, "abc");

foreach (KeyValuePair<int, string> item in list)
{
    Console.WriteLine($"key: {item.Key} -- value: {item.Value}");
}