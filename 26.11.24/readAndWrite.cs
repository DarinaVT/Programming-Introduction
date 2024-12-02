using System.Reflection.PortableExecutable;
Console.WriteLine("Enter a file and its directory");
string userFile = Console.ReadLine();
string userFileInfo = @"..\..\..\..\userFileInfo.txt";
int wordsAmount = 0;
int sentencesAmount = 0;
int lineNumber = 0;
string[] firstThreeLines = new string[3];

if (string.IsNullOrEmpty(userFile) || !File.Exists(userFile))
{
    Console.WriteLine("The following file couldn't be found or doesn't exist");
}
else
{
    StreamReader reader = new StreamReader(userFile);

    string line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        wordsAmount += words.Length;

        string[] sentences = line.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        sentencesAmount += sentences.Length;

        if (lineNumber < 3)
        {
            firstThreeLines[lineNumber] = line;
            lineNumber++;
        }
    }

    reader.Close();

    StreamWriter writer = new StreamWriter(userFileInfo);

    writer.WriteLine($"Words: {wordsAmount}");
    writer.WriteLine($"Sentences: {sentencesAmount}");
    writer.WriteLine("First three lines:");
    foreach (string top in firstThreeLines)
    {
        if (!string.IsNullOrEmpty(top))
        {
            writer.WriteLine(top);
        }
    }
    writer.Close();
    Console.WriteLine($"Output saved to: {Path.GetFullPath(userFileInfo)}");
}
