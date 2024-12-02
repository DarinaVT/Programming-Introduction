using System.Reflection.PortableExecutable;
Console.WriteLine("Enter input file and its directory:");
string inputFile = Console.ReadLine();
if (string.IsNullOrEmpty(inputFile) || !File.Exists(inputFile))
{
    Console.WriteLine("The following file couldn't be found or doesn't exist");
    return;
}
Console.WriteLine("Enter the output file and its directory in which you want to copy input file's content");
string outputFile = Console.ReadLine();
if (string.IsNullOrEmpty(outputFile) || !File.Exists(outputFile))
{
    Console.WriteLine("The following file couldn't be found or doesn't exist");
    return;
}
StreamReader reader = new StreamReader(inputFile);
StreamWriter writer = new StreamWriter(outputFile);
writer.Write(reader.ReadToEnd());
reader.Close();
writer.Close();
Console.WriteLine("Input file's content was successfully copied in the output file");
