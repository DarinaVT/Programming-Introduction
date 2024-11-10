class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the height of the triangle:");
        int height = int.Parse(Console.ReadLine());
        if(height <= 0)
        {
            Console.WriteLine("Height can't be zero or negative");
            return;
        }
        Console.WriteLine("Enter triangle alignment:");
        string alignment = Console.ReadLine().ToLower();

        if (alignment == "right")
        {
            Right(height);
        }
        else if (alignment == "left")
        {
            Left(height);
        }
        else
        {
            Console.WriteLine("Alignment must be either left or right");
        }
    }
    static void Right(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int k = 1; k <= height - i; k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                if (j == 1 || j == i || i == height)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }    static void Left(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int k = 1; k <= i; k++)
            {
                if (k == 1 || k == i || i == height)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
