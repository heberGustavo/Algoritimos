using System;

class URI
{

    static void Main(string[] args)
    {
        double distancia = Convert.ToDouble(Console.ReadLine());
        double combustivelGastoLitros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(CalcularConsumeMedio(distancia, combustivelGastoLitros).ToString("0.000") + " km/l");
    }

    private static double CalcularConsumeMedio(double distancia, double combustivelGastoLitros)
        => distancia / combustivelGastoLitros;

}