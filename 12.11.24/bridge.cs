Console.WriteLine("Enter train length in meters:");
int TrainLength = int.Parse(Console.ReadLine());
Console.WriteLine("Enter train speed in meters per second:");
int speed = int.Parse(Console.ReadLine());
Console.WriteLine("Enter train time in seconds:");
int time = int.Parse(Console.ReadLine());

int TotalDistance = speed * time;
int BridgeLength = TotalDistance - TrainLength;
Console.WriteLine("The lenght of the bridge is " + BridgeLength + " meters.");
