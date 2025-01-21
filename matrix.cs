//Console.Write("Enter a number between 2 and 20: ");
//int number = int.Parse(Console.ReadLine());
//if ((number < 2) && (number > 20))
//{
//    Console.WriteLine("Invalid size for a matrix");
//    return;
//}

//Random random = new Random();
//for (int i = 0; i < number; i++)
//{
//    for (int j = 0; j < number; j++)
//    {
//        matrix[i, j] = random.Next(1, 30);
//    }
//}

//example
int number = 3;
int[,] matrix =
{
    { 2, 7, 6 },
    { 9, 5, 1 },
    { 4, 3, 8 }
};

int[] rows = new int[number];
int[] cols = new int[number];
int firstDiagonal = 0;
int secondDiagonal = 0;
for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        rows[i] += matrix[i, j];
        cols[j] += matrix[i, j];
        if (i == j)
        {
            firstDiagonal += matrix[i, j];
        }
        if (i + j == number - 1)
        {
            secondDiagonal += matrix[i, j];
        }
    }
}

if (firstDiagonal != secondDiagonal)
{
    Console.WriteLine("Diagonals are different sums");
    return;
}
foreach (int row in rows)
{
    if (row != firstDiagonal)
    {
        Console.WriteLine("A row has a different sum");
        return;
    }
}
foreach (int col in cols)
{
    if (col != firstDiagonal)
    {
        Console.WriteLine("A column has a different sum");
        return;
    }
}

for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
