for (int l = 1; l < 4; l++)
{
    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine(" _____________");
        for (int j = 0; j < 1; j++);
        {
            Console.WriteLine("|  _________  |");
        }
    }
    for (int k = 0; k < 13; k++)
    {
        if (k == 1)
        {
            Console.WriteLine("|  |   " + l + "   |  |");
        }
        else if (k == 7)
        {
            Console.WriteLine("|  |_______|  |");
        }
        else if (k == 8 || k == 11)
        {
            Console.WriteLine("|             |");
        }
        else if (k == 9)
        {
            Console.WriteLine("()------------|");
        }
        else if (k == 10)
        {
            Console.WriteLine("|  _________  |");
            for (int m  = 0; m < 6; m++)
            {
                if (m == 5)
                {
                    Console.WriteLine("|  |_______|  |");
                }
                else
                {
                Console.WriteLine("|  |       |  |");
                }
            }
        }
        else if (k == 12)
        {
            Console.WriteLine("|_____________|");
        }
        else
        {
            Console.WriteLine("|  |       |  |");
        }
    }
}
