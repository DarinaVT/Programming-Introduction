Console.WriteLine("Please enter distance in meters:");
float distance = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter time in hours:");
int hours = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter time in minutes:");
int minutes = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter time in seconds:");
int seconds = int.Parse(Console.ReadLine());

int HoursToSeconds = hours * 3600;
int MinsToSeconds = minutes * 60;
int TotalSeconds = seconds + HoursToSeconds + MinsToSeconds;
double MetersSeconds = distance / TotalSeconds;
double KmHours = MetersSeconds * 3.6;
double MilesHours = MetersSeconds * 2.236936;

Console.WriteLine($"Meters per second: {MetersSeconds}");
Console.WriteLine($"Kilometeres per hours: {KmHours}");
Console.WriteLine($"Miles per hour: {MilesHours}");
