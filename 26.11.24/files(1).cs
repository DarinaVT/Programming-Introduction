class Program
{
    static void Main()
    {
        string fileName = @"d:\index.html";
        if (File.Exists(fileName))
        {
            Console.WriteLine("exists");
            File.Move(@"d:\index.html", @"d:\index-01.html");
            Console.WriteLine("File was renamed succesfully");

        }
        else
        {
            Console.WriteLine("Doesn't exist");
        }
    }
}
