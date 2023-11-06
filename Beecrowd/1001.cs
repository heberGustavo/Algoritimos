using System; 

class URI {

    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("X = " + Sum(a, b));

    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

}