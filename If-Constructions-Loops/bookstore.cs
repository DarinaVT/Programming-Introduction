using System.ComponentModel.Design;

int A = 0;
int B = 0;
int C = 0;
int D = 0;
int E = 0;
int BookCounter = 0;
double TotalCost = 0.0;
double PricePerBook = 8.0;
int BookName = 0;

Console.WriteLine("Enter amount of books");
int AmountOfBooks = int.Parse(Console.ReadLine());

for (int i = 0; i < AmountOfBooks; i++) 
{
    Console.WriteLine("Enter book number from 1 to 5"); 
    BookName = int.Parse(Console.ReadLine());
    while (BookName > 5 || BookName <= 0)
    {
        Console.WriteLine("Please enter a valid book number");
        BookName = int.Parse(Console.ReadLine());
    }
    if (BookName == 1)
    {
        A += 1;
    }
    if (BookName == 2)
    {
        B += 1;
    }
    if (BookName == 3)
    {
        C += 1;
    }
    if (BookName == 4)
    {
        D += 1;
    }
    if (BookName == 5)
    {
        E += 1;
    }
    BookCounter += 1;
}


for (; A > 0 || B > 0 || C > 0 || D > 0 || E > 0;)
{
    int differentBooks = 0;

    if (A > 0) { differentBooks++; A--; }
    if (B > 0) { differentBooks++; B--; }
    if (C > 0) { differentBooks++; C--; }
    if (D > 0) { differentBooks++; D--; }
    if (E > 0 && differentBooks < 4) { differentBooks++; E--; }

    switch (differentBooks)
    {
        case 5:
            TotalCost += 5 * (PricePerBook * 0.75);
            break;
        case 4:
            TotalCost += 4 * (PricePerBook * 0.80);
            break;
        case 3:
            TotalCost += 3 * (PricePerBook * 0.90);
            break;
        case 2:
            TotalCost += 2 * (PricePerBook * 0.95);
            break;
        case 1:
            TotalCost += 1 * PricePerBook;
            break;
    }
   
}
Console.WriteLine($"Total cost: ${TotalCost:F2}");
