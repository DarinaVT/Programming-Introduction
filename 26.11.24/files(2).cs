string firstFile = @"D:\filetoread - Copy.txt";
string secondFile = @"D:\filetoread.txt";

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
