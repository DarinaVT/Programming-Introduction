Console.WriteLine("Enter amount of candles.");
int candlesAmount = int.Parse(Console.ReadLine());
Console.WriteLine("Enter amount of leftovers needed for a new candle.");
int makeNew = int.Parse(Console.ReadLine());

int totalCandles = candlesAmount;  
int leftovers = candlesAmount;
int newCandles = 0;
while (leftovers >= makeNew)
{
    newCandles = leftovers / makeNew;
    totalCandles += newCandles;
    leftovers = newCandles + (leftovers % makeNew);  
}

Console.WriteLine(totalCandles);
