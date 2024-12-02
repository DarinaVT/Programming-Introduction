string firstFile = Console.ReadLine();
byte[] firstFileBytes = File.ReadAllBytes(firstFile);
string hexString = Convert.ToHexString(firstFileBytes);
File.WriteAllText(firstFile, hexString);
Console.WriteLine("File was encoded to the hexadecimal system");

StreamReader reader = new StreamReader(firstFile);
string fileRead = reader.ReadToEnd();
Console.WriteLine(fileRead);
reader.Close();
