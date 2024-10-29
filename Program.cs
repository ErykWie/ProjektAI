using ProjektAI;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Item item = new Item();
        List<Item> list = new List<Item>();
        Reader reader = new Reader();
        list = reader.ReadItems();
        Console.WriteLine(list);                       
    }
}

