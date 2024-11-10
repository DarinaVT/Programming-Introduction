using System;

class LastNumberName
{
    public static void CheckLastNum(int LastDigit)
    {
        if (LastDigit == 0)
        {
            Console.WriteLine("Zero");
        }
        if (LastDigit == 1)
        {
            Console.WriteLine("One");
        }
        if (LastDigit == 2)
        {
            Console.WriteLine("Two");
        }
        if (LastDigit == 3)
        {
            Console.WriteLine("Three");
        }
        if (LastDigit == 4)
        {
            Console.WriteLine("Four");
        }
        if (LastDigit == 5)
        {
            Console.WriteLine("Five");
        }
        if (LastDigit == 6)
        {
            Console.WriteLine("Six");
        }
        if (LastDigit == 7)
        {
            Console.WriteLine("Seven");
        }
        if (LastDigit == 8)
        {
            Console.WriteLine("Eight");
        }
        if (LastDigit == 9)
        {
            Console.WriteLine("Nine");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int GetLastDigit = number % 10;
        CheckLastNum(GetLastDigit);
    }
  
}
