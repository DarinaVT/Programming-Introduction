class NumInArray
{
    static void Main(string[] args)
    {
        int[] ArrayOfNums = UserArray();
        Console.WriteLine("Enter a number you want to check how many times it repeates in an array:");
        int WantedNumber = int.Parse(Console.ReadLine());

        int Duplicates = 0;
        for (int i = 0; i < ArrayOfNums.Length; i++)
        {
            if (ArrayOfNums[i] == WantedNumber)
            {
                Duplicates++;
            }
        }
        Console.WriteLine($"The number {WantedNumber} is met {Duplicates} times in your array");
    }
    static int[] UserArray()
    {
        Console.WriteLine("Enter array length:");
        int ArrayLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array elements:");
        int[] ArrayOfNums = new int[ArrayLength];
        for (int i = 0; i < ArrayLength; i++)
        {
            ArrayOfNums[i] = int.Parse(Console.ReadLine());
        }
        return ArrayOfNums;
    }
}
