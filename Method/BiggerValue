
class BiggerValue
{
    static void Main(string[] args)
    {
        CheckValue();
    }
    static int[] UserArray()
    {
        Console.WriteLine("Enter array elements amount:");
        int ArrayLength = int.Parse(Console.ReadLine());
        int[] ArrayOfNums = new int[ArrayLength];
        Console.WriteLine($"Enter {ArrayLength} elements in array:");
        for (int i = 0; i < ArrayLength; i++)
        {
            ArrayOfNums[i] = int.Parse(Console.ReadLine());
        }
        return ArrayOfNums;
    }
    static void CheckValue()
    {
        int[] ArrayOfNums = UserArray();
        if (ArrayOfNums.Length < 3)
        {
             Console.WriteLine("Array is too small to have a middle element with both left and right values.");
            return;
        }
        for (int i = 1; i < ArrayOfNums.Length - 1; i++)
        {
            if (ArrayOfNums[i] > ArrayOfNums[i + 1] && ArrayOfNums[i] > ArrayOfNums[i - 1])
            {
                Console.WriteLine($"The first number in your array that is bigger than both its left and right values is {ArrayOfNums[i]}.");
                return;
            }
        }
        Console.WriteLine("-1");
    }
}
