Console.WriteLine("Enter side a:");
int SideA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter side b:");
int SideB = int.Parse(Console.ReadLine());
Console.WriteLine("Enter side c:");
int SideC = int.Parse(Console.ReadLine());

while (SideA < 0 || SideB < 0 || SideC < 0 || (SideA + SideB < SideC) || (SideA + SideC < SideB) || (SideC + SideB < SideA))
{
    Console.WriteLine("Invalid values. Please enter new numbers:");
    Console.WriteLine("Enter side a:");
    SideA = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side b:");
    SideB = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side c:");
    SideC = int.Parse(Console.ReadLine());
}
if (SideA == SideB && SideB == SideC && SideA == SideC)
{
    Console.WriteLine($"Triangle with sides a = {SideA}, b  = {SideB}, c ={SideC} is equilateral.");
}
else if (SideA == SideB && SideB == SideC && SideA != SideC)
{
    Console.WriteLine($"Triangle with sides a = {SideA}, b = {SideB}, c = {SideC} is isosceles.");
}
else if (SideA != SideB && SideB == SideC && SideA == SideC)
{
    Console.WriteLine($"Triangle with sides a = {SideA}, b = {SideB}, c = {SideC} is isosceles.");
}
else if (SideA == SideB && SideB != SideC && SideA == SideC)
{
    Console.WriteLine($"Triangle with sides a = {SideA}, b = {SideB}, c = {SideC} is isosceles.");
}
else
{
    Console.WriteLine($"Triangle with sides a = {SideA}, b = {SideB}, c = {SideC} is scalene.");
}
