using System;

class URI
{

    static void Main(string[] args)
    {
        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("PROD = " + Prod(a, b));
    }

    private static int Prod(int a, int b)
    {
        return a * b;
    }
}