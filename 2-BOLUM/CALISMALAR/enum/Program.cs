﻿using System.Collections;

ArrayList personelList = new();

while (true)
{
    Console.Write("Enter 'y' for Add new personel, 'n' for stop adding: ");
    char input;
    while (!char.TryParse(Console.ReadLine().Trim(), out input))
    {
        Console.WriteLine("Incorrect format. Please try again.");
    }
    if (input == 'y')
    {
        Personel.AddNewPersonel(personelList);
    }
    else if (input == 'n')
    {
        break;
    }
    else
    {
        Console.WriteLine("Incorrect input. Please try again.");
    }
}
foreach (Personel p in personelList)
{
    Console.WriteLine($"Name => {p.Name} || Department => {p.Department} || Title => {p.Title}");
}