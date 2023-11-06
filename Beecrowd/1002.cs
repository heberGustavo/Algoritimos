using System; 

class URI {

    static void Main(string[] args)
    {
        const double PI = 3.14159;
        double input = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
        double area = Math.Pow(input, 2) * PI;

        Console.WriteLine("A=" + area.ToString("0.0000"));
    }

}