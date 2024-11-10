Console.WriteLine("Enter array length: ");
int ArrayLength = int.Parse(Console.ReadLine());
int[] NormalArray = new int[ArrayLength];
Console.WriteLine("Enter the amount of" + ArrayLength + " array elements: ");
for (int i = 0; i < NormalArray.Length; i++)
{
    NormalArray[i] = int.Parse(Console.ReadLine());
}
int[] NoRepeatingValues = new int[ArrayLength];
int NoDuplicates  = 0;

for (int i = 0; i < ArrayLength; i++)
{
    bool Repeating = false;
    for (int j = 0; j < ArrayLength; j++)
    {
        if (i != j && NormalArray[i] == NormalArray[j])
        {
            Repeating = true;
            break;
        }
    }
    if (!Repeating)
    {
        NoRepeatingValues[NoDuplicates] = NormalArray[i];
        NoDuplicates++;
    }
}
int[] ResultArray = new int[NoDuplicates];
for (int i = 0; i < NoDuplicates; i++)
{
  ResultArray[i] = NoRepeatingValues[i];
}
Console.WriteLine("Array with the unique elements included only is: " + string.Join(", ", ResultArray));
