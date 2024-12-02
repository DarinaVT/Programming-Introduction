Console.WriteLine("Enter a csv file:");
string inputFile = Console.ReadLine();
if (inputFile == null || !File.Exists(inputFile))
{
    Console.WriteLine("File couldn't be found, doesn't exist or is empty");
    return;
}
string outputFile = "csvinfo.txt";

double currentPrice = 0;
string highestPriced = "";
double sum = 0;
string[] rows = File.ReadAllLines(inputFile);

if (rows.Length < 2)
{
    Console.WriteLine("Not enough data to show information");
    return;
}

for (int i = 1; i < rows.Length; i++)
{
    string[] table = rows[i].Split(',');
    string product = table[0];
    int amount = int.Parse(table[1]);
    double price = double.Parse(table[2]);

    sum += amount * price;

    if (price > currentPrice)
    {
        currentPrice = price;
        highestPriced = product;
    }
}

StreamWriter output = new StreamWriter(outputFile);
output.WriteLine($"The total price is {Math.Round(sum, 2)}");
output.WriteLine($"The most expensive product is {highestPriced} priced {Math.Round(currentPrice, 2)}");
output.Close();

Console.WriteLine($"Your information was saved to: {Path.GetFullPath(outputFile)}");
