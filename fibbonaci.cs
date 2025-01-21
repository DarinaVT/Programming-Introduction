int[] fibbonaciFirstTwenty = new int[10];
fibbonaciFirstTwenty[0] = 1;
fibbonaciFirstTwenty[1] = 1;
for (int i = 2; i < fibbonaciFirstTwenty.Length; i++)
{
    fibbonaciFirstTwenty[i] = fibbonaciFirstTwenty[i - 1] + fibbonaciFirstTwenty[i - 2];
}

List<int> randomNums = new List<int>();
Random random = new Random();
for (int i = 0; i <= fibbonaciFirstTwenty[9]; i++)
{
    randomNums.Add(random.Next(1, 5));
}

int sum = 0;
for (int i = 0; i < fibbonaciFirstTwenty.Length; i++)
{
    int fibonacciIndex = fibbonaciFirstTwenty[i];
    sum += randomNums[fibonacciIndex];
}

Console.WriteLine(sum);
