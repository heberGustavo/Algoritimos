using System;

class URI
{
    static void Main(string[] args)
    {
        const double myPI = 3.14159;

        var input = Console.ReadLine().Trim();
        var arrayDados = input.Split(new string[] { " " }, StringSplitOptions.None);

        double a = Convert.ToDouble(arrayDados[0]);
        double b = Convert.ToDouble(arrayDados[1]);
        double c = Convert.ToDouble(arrayDados[2]);

        Console.WriteLine("TRIANGULO: " + CalcularAreaTriangulo(a, c).ToString("0.000"));
        Console.WriteLine("CIRCULO: " + CalcularAreaCirculo(c, myPI).ToString("0.000"));
        Console.WriteLine("TRAPEZIO: " + CalcularAreaTrapezio(a, b, c).ToString("0.000"));
        Console.WriteLine("QUADRADO: " + CalcularAreaQuadrado(b).ToString("0.000"));
        Console.WriteLine("RETANGULO: " + CalcularAreaRetangulo(a, b).ToString("0.000"));
    }

    private static double CalcularAreaTriangulo(double Base, double Altura)
        => (Base * Altura) / 2;

    private static double CalcularAreaCirculo(double raio, double PI)
        => Math.Pow(raio, 2) * PI;

    private static double CalcularAreaTrapezio(double base1, double base2, double altura)
        => ((base1 + base2) * altura) / 2;

    private static double CalcularAreaQuadrado(double lado)
        => lado * lado;

    private static double CalcularAreaRetangulo(double Base, double altura)
        => Base * altura;
}