class Number
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Reverse(number);
    }

    static void Reverse(int ReversedNumber)
    {
        foreach (char digit in ReversedNumber.ToString().Reverse())
        {
            Console.Write(digit);
        }

    }
}
