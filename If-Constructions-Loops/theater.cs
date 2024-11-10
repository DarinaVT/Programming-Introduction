Console.WriteLine("Enter the total columns amount in the theater:");
int TotalCols = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the total rows amount in the theater:");
int TotalRows = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your column number in the theater:");
int MyCol = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your row number in the theater:");
int MyRow = int.Parse(Console.ReadLine());

int BlockedRows = TotalRows - (MyRow - 1);
int TotalBlocked = (BlockedRows * MyCol) - 1;

Console.WriteLine("You will block a total of " + TotalBlocked + " people.");
