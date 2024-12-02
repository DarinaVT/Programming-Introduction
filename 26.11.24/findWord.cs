Console.WriteLine("Enter the file you want to check:");
string userInputFile = Console.ReadLine();
Console.WriteLine("Enter the keyword you are looking for:");
string keyword = Console.ReadLine();
string userOutputFile = "output.txt";

StreamReader reader = new StreamReader(userInputFile);
StreamWriter writer = new StreamWriter(userOutputFile);
bool ifKeyword = false;
string line;
while ((line = reader.ReadLine()) != null)
{
    if (line.Contains(keyword, StringComparison.OrdinalIgnoreCase))
    {
        writer.WriteLine(line);
        ifKeyword = true;
    }
}
writer.Close();
reader.Close();
if (ifKeyword)
{
    Console.WriteLine($"Your file with the needed information was saved in output.txt which can be found here: {Path.GetFullPath(userOutputFile)}");
}
else
{
    Console.WriteLine($"The word '{keyword}' couldn't be found");
}
