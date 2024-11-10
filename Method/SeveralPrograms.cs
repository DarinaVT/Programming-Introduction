class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose the task you want solved by entering its number:");
        Console.WriteLine("1. Number Reversing");
        Console.WriteLine("2. Average sum of a number sequence");
        Console.WriteLine("3. Linear equation");
        int ChosenTask = int.Parse(Console.ReadLine());
        if (ChosenTask == 1)
        {
            NumberReversing();
        }
        else if (ChosenTask == 2)
        {
            AverageSum();
        }
        else if (ChosenTask == 3)
        {
            LinearEquation();
        }
        else
        {
            Console.WriteLine("There is no task listed under this number.");
            return;
        }
    }
    public static void NumberReversing()
    {
        Console.WriteLine("Enter the number you want to get reversed:");
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Number has to be positive");
            return;
        }
        foreach (char digit in number.ToString().Reverse())
        {
            Console.Write(digit);
        }
    }
    public static void AverageSum()
    {
        Console.WriteLine("Enter the size of the sequence:");
        int number = int.Parse(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Sequence can't be empty or determined with a negative number.");
            return;
        }
        double TotalSum = 0;
        Console.WriteLine($"Enter {number} elements for the sequence:");
        for (int i = 0; i < number; i++)
        {
            TotalSum += int.Parse(Console.ReadLine()); 
        }
        Console.WriteLine($"The average sum of the given sequence is {TotalSum / number}");
    }
    public static void LinearEquation()
    {
        Console.WriteLine("Enter a number for coeficient a:");
        int a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("The coeficient a can't be 0");
            return;
        }
        Console.WriteLine("Enter a number for x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for coeficient b:");
        int b = int.Parse(Console.ReadLine());
        int LinearEquation = a * x + b;
        Console.WriteLine($"The solution for the linear equation a * x + b = 0 is {LinearEquation}");
    }

}
