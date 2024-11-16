Console.WriteLine("Enter boxes amount:");
int BoxesAmount = int.Parse(Console.ReadLine());
int RedApples = 0;
int YellowApples = 0;

for (int i = 1; i < BoxesAmount + 1; i++)
{
    if (i % 2 == 0)
    {
        RedApples += i * i;
    }
    else
    {
        YellowApples += i * i;
    }
}
int difference = Math.Abs(YellowApples - RedApples);
Console.WriteLine($"The difference between the yellow apples amount and the red apples amount is {difference}.");
