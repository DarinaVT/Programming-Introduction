Console.WriteLine("Enter first array's length");
int FirstLength = int.Parse(Console.ReadLine());
int[] FirstArray = new int[FirstLength];
Console.WriteLine("Enter " + FirstLength + " elements for the first array");
for (int i = 0; i < FirstLength; i++)
{
    FirstArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Enter second array's length");
int SecondLength = int.Parse(Console.ReadLine());
if (FirstLength != SecondLength)
{
    Console.WriteLine("Arrays have different lengths");
}
else if (SecondLength == FirstLength)
{
    bool IdenticalArrays = true;
    Console.WriteLine("Enter " + SecondLength + " elements for the second array");
    int[] SecondArray = new int[SecondLength];
    for (int k = 0; k < FirstLength; k++)
    {
        SecondArray[k] = int.Parse(Console.ReadLine());
    }
    for (int l = 0; l < FirstLength; l++)
        {
            if (FirstArray[l] != SecondArray[l])
            {
                IdenticalArrays = false;
                break;
            }
        }
    if (IdenticalArrays)
    {
        Console.WriteLine("Arrays are identical");
    }
    else
    {
        Console.WriteLine("Arrays have different elements");
    }
}
