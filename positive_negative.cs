int count = 1;
int number = 2;

while(count < 100)
{
    Console.WriteLine(number);
    number = number * -1;
    if(count % 2==0)
    {
        number += 1;
    }
    else
    {
        number -= 1;
    }
    count++;
}