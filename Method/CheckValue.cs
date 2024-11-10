class CheckValue
{
    static void Main(string[] args)
    {
        Compare();
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
    static void Compare()
    {
        int[] ArrayOfNums = UserArray();
        for (int i = 0; i < ArrayOfNums.Length; i++)
        {
            if (i == 0)
            {
                if (ArrayOfNums[i] == ArrayOfNums[i + 1])
                {
                    Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is equal to its right value {ArrayOfNums[i + 1]} at position {i + 1}");
                }
                else if (ArrayOfNums[i] > ArrayOfNums[i + 1])
                {
                    Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is bigger than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
                }
                else if (ArrayOfNums[i] < ArrayOfNums[i + 1])
                {
                    Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is smaller than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
                }
            }
            else if (i == ArrayOfNums.Length - 1)
            {
                if (ArrayOfNums[i] == ArrayOfNums[i - 1])
                {
                    Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is equal to its left value {ArrayOfNums[i - 1]} at position {i - 1}");
                }
                else if (ArrayOfNums[i] > ArrayOfNums[i - 1])
                {
                    Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is bigger than its left value {ArrayOfNums[i - 1]} at position {i - 1}");
                }
                else if (ArrayOfNums[i] < ArrayOfNums[i - 1])
                {
                    Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is smaller than its left value {ArrayOfNums[i - 1]} at position {i - 1}");
                }
                break;
            }
            else if (ArrayOfNums[i] < ArrayOfNums[i - 1] && ArrayOfNums[i] < ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is smaller than its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] > ArrayOfNums[i - 1] && ArrayOfNums[i] < ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is bigger than its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and smaller than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] < ArrayOfNums[i - 1] && ArrayOfNums[i] > ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is smaller than its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and bigger than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] > ArrayOfNums[i - 1] && ArrayOfNums[i] > ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is bigger than its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and bigger than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] == ArrayOfNums[i - 1] && ArrayOfNums[i] > ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is equal to its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and bigger than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] == ArrayOfNums[i - 1] && ArrayOfNums[i] < ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is equal to its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and smaller than its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] > ArrayOfNums[i - 1] && ArrayOfNums[i] == ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is bigger than its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and equal to its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] < ArrayOfNums[i - 1] && ArrayOfNums[i] == ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is smaller than its left value {ArrayOfNums[i - 1]} at position " +
                    $"{i - 1} and equal to its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            else if (ArrayOfNums[i] == ArrayOfNums[i - 1] && ArrayOfNums[i] == ArrayOfNums[i + 1])
            {
                Console.WriteLine($"The number {ArrayOfNums[i]} at position {i} is equal both to its left value {ArrayOfNums[i - 1]} at position" +
                    $"{i - 1} and to its right value {ArrayOfNums[i + 1]} at position {i + 1}");
            }
            }
        }
    }
