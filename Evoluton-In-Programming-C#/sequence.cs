using System.Diagnostics.CodeAnalysis;
using System.Numerics;

BigInteger startingNumber = 1;
for (int i = 1; i < 100; i++)
{
startingNumber = i + BigInteger.Pow(2, i) - 2;
Console.WriteLine(startingNumber);
}
