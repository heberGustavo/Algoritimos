using System;

class URI
{

    static void Main(string[] args)
    {
        const int PESO_1 = 2;
        const int PESO_2 = 3;
        const int PESO_3 = 5;
        const int PESO_TOTAL = PESO_1 + PESO_2 + PESO_3;

        var nota1 = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
        var nota2 = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
        var nota3 = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);

        var resultadoNota1 = CalcularNotaPorPeso(nota1, PESO_1, PESO_TOTAL);
        var resultadoNota2 = CalcularNotaPorPeso(nota2, PESO_2, PESO_TOTAL);
        var resultadoNota3 = CalcularNotaPorPeso(nota3, PESO_3, PESO_TOTAL);

        Console.WriteLine("MEDIA = " + NotaTotal(resultadoNota1, resultadoNota2, resultadoNota3).ToString("0.0"));
    }

    private static double CalcularNotaPorPeso(double nota, int peso, int pesoTotal)
    {
        return (nota * peso) / pesoTotal;
    }

    private static double NotaTotal(double nota1, double nota2, double nota3)
    {
        return nota1 + nota2 + nota3;
    }

}