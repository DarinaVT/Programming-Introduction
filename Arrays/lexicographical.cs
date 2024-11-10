while (true)
{
    bool IfEqual = true;
    Console.WriteLine("Determine the size of the first array");
    int FirstArrayLength = int.Parse(Console.ReadLine());
    Console.WriteLine("Determine the size of the second array");
    int SecondArrayLength = int.Parse(Console.ReadLine());
    char[] FirstArray = new char[FirstArrayLength];
    char[] SecondArray = new char[SecondArrayLength];

    if (FirstArrayLength < SecondArrayLength)
    {
        Console.WriteLine("First array comes in first lexicographically");
        break;
    }

    else if (SecondArrayLength < FirstArrayLength)
    {
        Console.WriteLine("Second array comes in first lexicographically");
        break;
    }

    else
    {
        Console.WriteLine("Add " + FirstArrayLength + " elements to the first array");
        for (int i = 0; i < FirstArrayLength; i++)
        {
            string element = Console.ReadLine();
            FirstArray[i] = element[0];
        }
        Console.WriteLine();

        Console.WriteLine("Add " + SecondArrayLength + " elements to the second array");
        for (int j = 0; j < SecondArrayLength; j++)
        {
            string element = Console.ReadLine();
            SecondArray[j] = element[0];
        }
        Console.WriteLine();

        for (int k = 0; k < FirstArrayLength; k++)
        {
            if (FirstArray[k] < SecondArray[k])
            {
                Console.WriteLine("First array comes in first lexicographically");
                IfEqual = false;
                break;
            }
            if (SecondArray[k] < FirstArray[k])
            {
                Console.WriteLine("Second array comes in first lexicographically");
                IfEqual = false;
                break;
            }
        }
        if (IfEqual)
        {
            Console.WriteLine("First and second array are lexicographically identical");
            break;
        }
        else
        {
            break;
        }
    }
}
