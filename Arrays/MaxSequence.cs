Console.WriteLine("Enter array length");
int ArrayLength = int.Parse(Console.ReadLine());
int[] Array = new int[ArrayLength];
Console.WriteLine("Enter the amount of " + ArrayLength + " elements");
for (int i = 0; i < ArrayLength; i++)
{
    Array[i] = int.Parse(Console.ReadLine());
}
int SameElements = 0;
int RepeatedElement = 0;
for (int j = 0; j < ArrayLength; j++)
{
    int Counter = 1;
    for (int k = j + 1; k < ArrayLength; k++)
    {
        if (Array[j] == Array[k])
        {
            Counter++;
        }
    }
    if (Counter > SameElements)
    {
        SameElements = Counter;
        RepeatedElement = Array[j];
    }
}
Console.WriteLine("The element " + RepeatedElement + " is repeated the most: " + SameElements + " times");
