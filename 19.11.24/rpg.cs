class Program
{
    static void Main()
    {
        Console.WriteLine("Enter starting XP:");
        int experience = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter threshold:");
        int threshold = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the amount of points you get when you kill a monster");
        int pointsPerKilling = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a command, choosing between yes and no respectively if you killed the monster or not");
        string command = Console.ReadLine();
        string killed = command.ToLower();

        if (killed == "yes" || killed == "no")
        {
            if (killed == "yes")
            {
                bool reachedNextLevel = IfNextLevel(experience, threshold, pointsPerKilling);

                if (reachedNextLevel)
                {
                    Console.WriteLine("You reached the next level");
                }
                else
                {
                    Console.WriteLine("You didn't reach the next level");
                }
            }
            else
            {
                Console.WriteLine("You didn't kill the monster");
            }
        }
        else
        {
            Console.WriteLine("Invalid command");
        }
    }
    static bool IfNextLevel(int experience, int threshold, int pointsPerKilling)
    {
        return experience + pointsPerKilling >= threshold;
    }
}
