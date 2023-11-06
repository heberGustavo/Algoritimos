using System;

class URI
{

    static void Main(string[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine());
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
        double valorPorHora = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + CalcularSalario(horasTrabalhadas, valorPorHora).ToString("F"));
    }

    private static double CalcularSalario(int horasTrabalhadas, double valorPorHora)
    {
        return horasTrabalhadas * valorPorHora;
    }

}