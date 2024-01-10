using System;

class URI
{

    static void Main(string[] args)
    {
        int horaEmMinutos = 60;
        int distanciaEntreCarros = 30;
        int distancia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalcularDistancia(distancia, distanciaEntreCarros, horaEmMinutos) + " minutos");
    }

    private static int CalcularDistancia(int distancia, int distanciaEntreCarro, int horasEmMinutos)
        => (horasEmMinutos * distancia) / distanciaEntreCarro;
}