string firstFile = Console.ReadLine();
string secondFile = Console.ReadLine();

byte[] firstFileBytes = File.ReadAllBytes(firstFile);
byte[] secondFileBytes = File.ReadAllBytes(secondFile);

bool areEqual = firstFileBytes.SequenceEqual(secondFileBytes);
if (areEqual)
{
    Console.WriteLine("Files are identical");
}
else
{
    Console.WriteLine("Files are not identical");
}
