using System.Numerics;

BigInteger TotalGrains = 0;
BigInteger GrainsAmount = 1;
BigInteger SquareNumber = 0;
BigInteger GrainsOnSquare = 0;
for (int i = 1; i <= 64; i++)
{
    SquareNumber = i;
    if (SquareNumber == 1)
    {
        Console.WriteLine($"On square " + SquareNumber + " there is 1 grain.");
        TotalGrains ++;
    }
    else
    {
        GrainsOnSquare = GrainsAmount * 2;
        GrainsAmount = GrainsOnSquare;
        TotalGrains += GrainsOnSquare;
        Console.WriteLine($"On square " + SquareNumber + " there are " + GrainsOnSquare + " grains.");
    }
}
Console.WriteLine($"Total amount of grains on the board is " +  TotalGrains);
