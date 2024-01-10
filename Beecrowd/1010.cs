using System;

class URI
{

    static void Main(string[] args)
    {
        string produto1 = Console.ReadLine().Trim();
        string produto2 = Console.ReadLine().Trim();

        string[] arrayProduto1 = produto1.Split(new string[] { " " }, StringSplitOptions.None);
        int cod1 = Convert.ToInt32(arrayProduto1[0]);
        int pecas1 = Convert.ToInt32(arrayProduto1[1]);
        double valorUnitario1 = Math.Round(Convert.ToDouble(arrayProduto1[2]), 2);
        double totalPagar1 = ValorPagar(pecas1, valorUnitario1);

        string[] arrayProduto2 = produto2.Split(new string[] { " " }, StringSplitOptions.None);
        int cod2 = Convert.ToInt32(arrayProduto2[0]);
        int peca2 = Convert.ToInt32(arrayProduto2[1]);
        double valorUnitario2 = Math.Round(Convert.ToDouble(arrayProduto2[2]), 2);
        double totalPagar2 = ValorPagar(peca2, valorUnitario2);

        Console.WriteLine("VALOR A PAGAR: R$ " + (totalPagar1 + totalPagar2).ToString("F"));
    }

    private static double ValorPagar(int quantPecas, double valorUnitario)
    {
        return quantPecas * valorUnitario;
    }

}