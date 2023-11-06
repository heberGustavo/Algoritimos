using System;

class URI
{

    static void Main(string[] args)
    {
        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());
        var c = Convert.ToInt32(Console.ReadLine());
        var d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("DIFERENCA = " + CalcularDiferencas(a, b, c, d));
    }

    private static int CalcularDiferencas(int a, int b, int c, int d)
    {
        return (a * b) - (c * d);
    }

}