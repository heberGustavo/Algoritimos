using System;
using System.Collections.Generic;
using System.Linq;

class URI
{

    static void Main(string[] args)
    {
        string input = Console.ReadLine().Trim();
        string[] arrayValores = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        var listaInt = new List<int>();
        foreach (var item in arrayValores)
            listaInt.Add(Convert.ToInt32(item));

        Console.WriteLine(listaInt.Max() + " eh o maior");
    }

}