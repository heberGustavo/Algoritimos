using System;

class URI
{

    static void Main(string[] args)
    {
        var A = Convert.ToInt32(Console.ReadLine());
        var B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("SOMA = " + Sum(A, B));
    }

    private static int Sum(int a, int b)
    {
        return a + b;
    }
}