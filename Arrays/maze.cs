using System;
class MazeGame
{
    static void Main()
    {
        Console.SetWindowSize(36, 18);

        int startX = 1;
        int startY = 1;
        char player = 'P';
        Console.CursorVisible = false;

        DrawBorders();
        ObstaclesAndPoints();

        Console.SetCursorPosition(startX, startY);
        Console.Write(player);

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            Console.SetCursorPosition(startX, startY);
            Console.Write(' ');

            if (key.Key == ConsoleKey.LeftArrow && startX > 1)
            {
                startX--;
            }
            else if (key.Key == ConsoleKey.RightArrow && startX < Console.WindowWidth - 2)
            {
                startX++;
            }
            else if (key.Key == ConsoleKey.UpArrow && startY > 1)
            {
                startY--;
            }
            else if (key.Key == ConsoleKey.DownArrow && startY < Console.WindowHeight - 2)
            {
                startY++;
            }


            Console.SetCursorPosition(startX, startY);
            Console.Write(player);
        }
    }

    static void DrawBorders()
    {
        for (int i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        for (int j = 0; j < Console.WindowHeight - 2; j++)
        {
            Console.Write('¦');
            Console.Write(new string(' ', Console.WindowWidth - 2));
            Console.WriteLine('¦');
        }

        for (int i = 0; i < (Console.WindowWidth / 2 - 1); i++)
        {
            Console.Write("-");
        }
        Console.Write('E');
        for (int i = 0; i < (Console.WindowWidth / 2); i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
    static void ObstaclesAndPoints()
    {
        Random random = new Random();
        int numberOfObstacles = 100;
        int numberOfPoints = 100;

        for (int i = 0; i < numberOfObstacles; i++)
        {
            int x = random.Next(1, Console.WindowWidth - 1);
            int y = random.Next(1, Console.WindowHeight - 1);
            Console.SetCursorPosition(x, y);
            Console.Write('#');

        }

        for (int i = 0; i < numberOfPoints; i++)
        {
            int x = random.Next(1, Console.WindowWidth - 1);
            int y = random.Next(1, Console.WindowHeight - 1);
            Console.SetCursorPosition(x, y);
            Console.Write('@');
        }
    }

}
