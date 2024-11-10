int NameCounter = 0;
string FirstName = " ";
string SecondName = " ";

while (true)
{
    Console.WriteLine("Enter the name of a person that has liked your post or press Enter if there is no such person.");
    string name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        break;
    }

    NameCounter++;

    if (NameCounter == 1)
    {
        FirstName = name;
        Console.WriteLine($"{FirstName} liked your post.");
    }
    else if (NameCounter == 2)
    {
        SecondName = name;
        Console.WriteLine($"{FirstName} and {SecondName} liked your post.");
    }
    else if (NameCounter >= 3)
    {
        Console.WriteLine($"{FirstName}, {SecondName} and {NameCounter - 2} more liked your post.");
    }
}
