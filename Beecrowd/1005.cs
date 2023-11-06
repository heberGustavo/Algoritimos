using System;

class URI
{

    static void Main(string[] args)
    {
        const double PESO_1 = 3.5;
        const double PESO_2 = 7.5;

        double a = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
        double b = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);

        var resultadoNota1 = CalcularNotaPorPeso(a, PESO_1, PESO_1 + PESO_2);
        var resultadoNota2 = CalcularNotaPorPeso(b, PESO_2, PESO_1 + PESO_2);

        Console.WriteLine("MEDIA = " + (resultadoNota1 + resultadoNota2).ToString("0.00000"));
    }

    private static double CalcularNotaPorPeso(double nota, double peso, double pesoTotal)
    {
        return (nota * peso) / pesoTotal;
    }

}