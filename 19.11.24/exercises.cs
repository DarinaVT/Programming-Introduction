Console.WriteLine("This program can be used to manipulate information about exercises");
Console.WriteLine("1. Add an exercise");
Console.WriteLine("2. Remove last added exercise");
Console.WriteLine("3. Check last added exercise");
Console.WriteLine("4. Check amount of exercises");
Console.WriteLine("5. Check if the exercise you enter is in this list");
Console.WriteLine("6. Check full list of exercises");
Console.WriteLine("7. Clear the list of exercises");
Console.WriteLine("8. Close program");
Stack<string> exercises = new Stack<string>();

while (true)
{
    Console.WriteLine("You can choose from the following options by entering the option's number:");
    int option = int.Parse(Console.ReadLine());
    if (option < 1 || option > 8)
    {
        Console.WriteLine("Invalid option");
        continue;
    }
    else if (option == 1)
    {
        Console.WriteLine("Enter the name of an exercise you want to add");
        string exerciseName = Console.ReadLine();
        exercises.Push(exerciseName);
    }
    else if (option == 2)
    {
        string removed = exercises.Pop();
        Console.WriteLine($"You removed {removed}");
    }
    else if (option == 3)
    {
        Console.WriteLine($"Last added exercise is {exercises.Peek()}");
    }
    else if (option == 4)
    {
        if (exercises.Count > 0)
        {
            Console.WriteLine($"Amount of exercises is {exercises.Count}");
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }
    else if (option == 5)
    {
        Console.WriteLine("Enter the exercise name you want to check if it's present:");
        string name = Console.ReadLine();
        bool Consists = true;
        if (exercises.Contains(name))
        {
            Console.WriteLine("The entered exercise is present in this list");
        }
        else
        {
            Console.WriteLine("The entered exercise is not present in this list");
        }
    }
    else if (option == 6)
    {
        if (exercises.Count > 0)
        {
            string[] allExercises = exercises.ToArray();
            foreach (string exercise in allExercises)
            {
                Console.WriteLine(exercise);
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }
    else if (option == 7)
    {
        exercises.Clear();
        Console.WriteLine("List has been cleared");
    }
    else
    {
        Console.WriteLine("You chose to close the program");
        break;
    }
    Console.WriteLine();
}
