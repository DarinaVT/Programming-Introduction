Console.WriteLine("Enter starting position:");
int StartingPosition = int.Parse(Console.ReadLine());
Console.WriteLine("Enter target position:");
int TargetPosition = int.Parse(Console.ReadLine());
Console.WriteLine("Enter distance per jump:");
int DistancePerJump  = int.Parse(Console.ReadLine());

int DistanceToJump = (TargetPosition - StartingPosition) + 1;
int JumpedDistance = 0;
int jumps = 0;

while (JumpedDistance <= DistanceToJump)
{
    JumpedDistance += DistancePerJump;
    jumps++;
}
Console.WriteLine("Jumps needed: " + jumps);
