class Numbers
{
    static int FirstToCompare;
    static void GetMax(int FirstNumber, int SecondNumber)
    {
        if (FirstNumber >= SecondNumber)
        {
            FirstToCompare = FirstNumber;
        }
        else if (SecondNumber >= FirstNumber)
        {
            FirstToCompare = SecondNumber;
        }
    }
    static void Main(string[] Args)
    {
        Console.WriteLine("Enter first number: ");
        FirstToCompare = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int SecondToCompare = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int ThirdToCompare = int.Parse(Console.ReadLine());

        GetMax(FirstToCompare, SecondToCompare);
        GetMax(FirstToCompare, ThirdToCompare);

        Console.WriteLine($"Biggest number of all three is: {FirstToCompare}.");
    }
}
