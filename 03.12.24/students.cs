public class Student
{
    public string StudentName { get; }
    public int StudentAge { get; }
    public long StudentID { get; }

    private static int _studentCount = 0;
    public Student(string studentName, int studentAge)
    {
        StudentName = studentName;
        StudentAge = studentAge;
        _studentCount++;
        StudentID = _studentCount;
    }

    public void GetInfo()
    {
        Console.WriteLine(StudentName);
        Console.WriteLine(StudentAge);
        Console.WriteLine(StudentID);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the amount of students:");
        int amountOfStudents = int.Parse(Console.ReadLine());
        for (int i = 0; i < amountOfStudents; i++)
        {
            Console.WriteLine("Enter a student's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a student's age:");
            int age = int.Parse(Console.ReadLine());

            Student student = new Student(name, age);
            student.GetInfo();
            Console.WriteLine();
        }
    }
}
