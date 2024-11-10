using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Factorial();
    }
    public static void Factorial()
    {
        
        for (int i = 1; i <= 100; i++)
        {
            BigInteger Calculation = 1;
            for (int j = 1; j <= i; j++)
            {
                Calculation *= j;
            }
            Console.WriteLine($"The factorial of {i}! is {Calculation}");

        }
    }
}
