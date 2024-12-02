using static Program;

class Program
{
    public class Person
    {
        public string personName;
        public int personAge;
        public string personEmail;

        public Person(string name, int age, string email)
        {
            personName = name;
            personAge = age;
            personEmail = email;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the amount of people you want to save information for:");
        List<Person> people = new List<Person>();
        int amountOfPeople = int.Parse(Console.ReadLine());

        if (amountOfPeople <= 0)
        {
            Console.WriteLine("Please enter a positive number indicating the amount of people");
            return;
        }

        for (int i = 0; i < amountOfPeople; i++)
        {
            Console.WriteLine("Enter the person's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the person's age:");
            int age = int.Parse(Console.ReadLine());
            if (age <= 0)
            {
                Console.WriteLine("Please enter a positive number indicating the age");
                return;
            }
            Console.WriteLine("Enter the person's email:");
            string email = Console.ReadLine();

            people.Add(new Person(name, age, email));
            Console.WriteLine();
        }

        string personTextFile = "person.txt";
        string personBinaryFile = "binary.bin";
        string binaryStringFile = "binary.txt";

        StreamWriter writer = new StreamWriter(personTextFile);
        foreach (var person in people)
        {
            writer.WriteLine($"{person.personName} {person.personAge} {person.personEmail}");
        }
        writer.Close();

        string textFileContent = File.ReadAllText(personTextFile);
        byte[] binaryFileContent = System.Text.Encoding.UTF8.GetBytes(textFileContent);
        File.WriteAllBytes(personBinaryFile, binaryFileContent);

        byte[] binaryContent = File.ReadAllBytes(personBinaryFile);
        StreamWriter binaryWriter = new StreamWriter(binaryStringFile);
        foreach (byte b in binaryContent)
        {
            binaryWriter.Write(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
        }
        binaryWriter.Close();

        string binaryTextContent = File.ReadAllText(binaryStringFile);
        Console.WriteLine("\nContent of binary.txt:");
        Console.WriteLine(binaryTextContent);

        Console.WriteLine($"\nText file saved to: {Path.GetFullPath(personTextFile)}");
        Console.WriteLine($"Binary file saved to: {Path.GetFullPath(personBinaryFile)}");
        Console.WriteLine($"Binary string representation saved to: {Path.GetFullPath(binaryStringFile)}");
    }
}
