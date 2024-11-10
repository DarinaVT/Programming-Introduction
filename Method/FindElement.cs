// 9
using System.Reflection.Metadata;

class FindElement
{
    public static void UserArray()
    {
        Console.WriteLine("Enter array length:");
        int ArrayLength = int.Parse(Console.ReadLine());
        int[] UserArray = new int[ArrayLength];
        Console.WriteLine($"Enter {ArrayLength} amount of elements:");
        for (int i = 0; i < ArrayLength; i++)
        {
            UserArray[i] = int.Parse(Console.ReadLine());
        }
        FindBiggestElement(UserArray);
        AscArray(UserArray);
        DescArray(UserArray);
    }
    public static void FindBiggestElement(int[] Array)
    {
        int BiggestNumber = Array[0];
        for (int i = 1;i < Array.Length; i++)
        {
            if (Array[i] > BiggestNumber)
            {
                BiggestNumber = Array[i];
            }
        }
        BiggestElement(BiggestNumber);
    }
    public static void BiggestElement(int BiggestElement)
    {
        Console.WriteLine($"Biggest element in the given array is {BiggestElement}");
        Console.WriteLine();
    }
    public static void AscArray(int[] AscArray)
    {
        Array.Sort(AscArray);
        Console.WriteLine("Array in ascending order is: ");
        for (int i = 0;i < AscArray.Length; i++)
        {
            Console.Write(AscArray[i] + ", ");
        }
        Console.WriteLine();
    }
    public static void DescArray(int[] DescArray)
    {
        Array.Reverse(DescArray);
        Console.WriteLine("Array in descending order is: ");
        for (int i = 0; i < DescArray.Length; i++)
        {
            Console.Write(DescArray[i] + ", ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        UserArray();
    }
}
