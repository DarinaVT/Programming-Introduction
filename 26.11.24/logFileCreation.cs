Console.WriteLine("Choose any operation of the following or close the program:");
Console.WriteLine("1. Factoriel");
Console.WriteLine("2. Print length of a provided text file");
Console.WriteLine("3. Close the program");

string outputFile = "loginfo.txt";
int option = int.Parse(Console.ReadLine());
DateTime dateTime;

StreamWriter writer = new StreamWriter(outputFile);

if (option == 1)
{
    Console.WriteLine("Please provide a number you want to solve the factoriel for:");
    int number = int.Parse(Console.ReadLine());
    writer.WriteLine($"Input: {number}");
    if (number == 0)
    {
        writer.WriteLine("Result: 0");
    }
    else if (number < 0)
    {
        writer.WriteLine("Number has to be positive");
    }
    else
    {
        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        writer.WriteLine($"Result: {result}");
    }
    writer.WriteLine(dateTime = DateTime.Now);
}
else if (option == 2)
{
    Console.WriteLine("Provide a text file that you want the information printed about");
    string file = Console.ReadLine();
    writer.WriteLine($"Input: {file}");
    if (file == null || !File.Exists(file))
    {
        writer.WriteLine("File couldn't be found, doesn't exist or is empty");
    }
    else
    {
        StreamReader sr = new StreamReader(file);
        string text = sr.ReadToEnd();
        writer.WriteLine($"File text length: {text.Length}");
        sr.Close();
    }
    writer.WriteLine(dateTime = DateTime.Now);
}
else if (option == 3)
{
    writer.WriteLine("You chose to close the program");
    writer.WriteLine(dateTime = DateTime.Now);
}
else
{
    writer.WriteLine("Invalid number option");
    writer.WriteLine(dateTime = DateTime.Now);
}
writer.Close();
Console.WriteLine($"Your file with the log output was saved to: {Path.GetFullPath(outputFile)}");
