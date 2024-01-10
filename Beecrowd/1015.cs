using System;

class URI
{

    static void Main(string[] args)
    {
        string p1 = Console.ReadLine().Trim();
        string p2 = Console.ReadLine().Trim();

        string[] arrayP1 = p1.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        string[] arrayP2 = p2.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        double x1 = Convert.ToDouble(arrayP1[0]);
        double x2 = Convert.ToDouble(arrayP2[0]);
        double y1 = Convert.ToDouble(arrayP1[1]);
        double y2 = Convert.ToDouble(arrayP2[1]);

        Console.WriteLine(CalcularDistanciaEntrePontos(x1, x2, y1, y2).ToString("0.0000"));
    }

    private static double CalcularDistanciaEntrePontos(double x1, double x2, double y1, double y2)
    {
        double resultadoX = Math.Pow((x2 - x1), 2);
        double resultadoY = Math.Pow((y2 - y1), 2);

        return Math.Sqrt(resultadoX + resultadoY);
    }

}