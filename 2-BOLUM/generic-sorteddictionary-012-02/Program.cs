

SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();

dictionary.Add(5, "Ahmet");
dictionary.Add(2, "Hasan");
dictionary.Add(-2, "Ali");


foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine($"Key : {item.Key} --- Value:{item.Value}");
}
