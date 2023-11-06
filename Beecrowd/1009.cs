using System;

class URI
{

    static void Main(string[] args)
    {
        const double COMISSAO = 15;

        string nome = Console.ReadLine();
        double salarioFixo = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
        double totalVendas = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

        Console.WriteLine("TOTAL = R$ " + CalcularSalarioComComissao(salarioFixo, totalVendas, COMISSAO).ToString("0.00"));
    }

    private static double CalcularSalarioComComissao(double salarioFixo, double totalVendas, double comissao)
    {
        return (totalVendas * (comissao / 100)) + salarioFixo;
    }
}