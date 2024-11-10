Console.WriteLine("Enter size of the array: ");
int ArrayLength = int.Parse(Console.ReadLine());
int[] Array = new int[ArrayLength];

Console.WriteLine("Enter " + ArrayLength + " elements to the array: ");
for (int i = 0; i < ArrayLength; i++)
{
    Array[i] = int.Parse(Console.ReadLine());
}

List<int> TempSequence = new List<int>();
List<int> MaxSequence = new List<int>();

for (int k = 0; k < ArrayLength; k++)
{
    TempSequence.Add(Array[k]);

    if (k == ArrayLength - 1 || Array[k + 1] != Array[k] + 1)
    {
        if (TempSequence.Count > MaxSequence.Count)
        {
            MaxSequence = new List<int>(TempSequence);
        }
        TempSequence.Clear();
    }
}

if (TempSequence.Count > 0)
{
    if (TempSequence.Count > MaxSequence.Count)
    {
        MaxSequence = new List<int>(TempSequence);
    }
}

Console.WriteLine("The maximal sequence of consecutively placed increasing integers is: " + string.Join(", ", MaxSequence));
