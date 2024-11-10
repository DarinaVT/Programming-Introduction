Console.WriteLine("Enter a DNA strand:");
string DnaStrand = Console.ReadLine();
string RnaStrand = " ";

foreach (char nucleotide in DnaStrand)
{
    if (nucleotide == 'A')
    {
        RnaStrand += "U";
    }
    else if (nucleotide == 'C')
    {
        RnaStrand += "G";
    }
    else if (nucleotide == 'G')
    {
        RnaStrand+= "C";
    }
    else if (nucleotide == 'T')
    {
        RnaStrand += "A";
    }
}
Console.WriteLine($"The RNA strand is:" + RnaStrand);
