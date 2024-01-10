using System;

class URI
{

    static void Main(string[] args)
    {
        const double MY_PI = 3.14159;

        double raio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("VOLUME = " + CalcularVolume(raio, MY_PI).ToString("0.000"));
    }

    private static double CalcularVolume(double raio, double myPI)
    {
        return (4 / 3.0) * myPI * Math.Pow(raio, 3);
    }

}