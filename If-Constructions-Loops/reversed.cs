string NormalString = Console.ReadLine();
string ReversedString = "";

for (int i = NormalString.Length - 1; i >= 0; i--)
{
    ReversedString += NormalString[i];
}

Console.WriteLine(ReversedString);
