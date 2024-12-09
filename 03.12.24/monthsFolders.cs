using System;
using System.IO;

class FileOrganiser
{
    public void CheckDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine($"The directory '{path}' has been created");
        }
        else
        {
            Console.WriteLine($"The directory '{path}' already exists");
        }
    }

    public void CreateFolders(string path)
    {
        for (int i = 1; i <= 12; i++)
        {
            string folderName = i.ToString();
            string newFolderPath = Path.Combine(path, folderName);

            Directory.CreateDirectory(newFolderPath);
            Console.WriteLine($"The folder '{folderName}' has been created here: {newFolderPath}");
        }
    }

    public void FilesForMonth(string path, int maxFilesPerFolder)
    {
        string[] files = Directory.GetFiles(path);
        int fileCount = files.Length;

        if (fileCount == 0)
        {
            Console.WriteLine("There are no files in this directory");
            return;
        }

        int currentMonthNumber = DateTime.Now.Month;
        string currentMonthName = DateTime.Now.ToString("MMMM");

        string monthFolderPath = Path.Combine(path, currentMonthNumber.ToString());
        if (!Directory.Exists(monthFolderPath))
        {
            Directory.CreateDirectory(monthFolderPath);
        }

        int subfolderIndex = 1;
        int filesMoved = 0;

        while (filesMoved < fileCount)
        {
            string subfolderName = $"{currentMonthName}-{subfolderIndex:D2}";
            string subfolderPath = Path.Combine(monthFolderPath, subfolderName);

            if (!Directory.Exists(subfolderPath))
            {
                Directory.CreateDirectory(subfolderPath);
            }

            for (int i = 0; i < maxFilesPerFolder && filesMoved < fileCount; i++, filesMoved++)
            {
                string fileName = Path.GetFileName(files[filesMoved]);
                string destinationPath = Path.Combine(subfolderPath, fileName);

                File.Move(files[filesMoved], destinationPath);
                Console.WriteLine($"'{fileName}' was moved to '{subfolderName}'");
            }
            subfolderIndex++;
        }
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your desired path:");
        string path = Console.ReadLine();

        FileOrganiser fileOrganiser = new FileOrganiser();
        fileOrganiser.CheckDirectory(path);
        fileOrganiser.CreateFolders(path);

        Console.WriteLine("Enter the maximum number of files per subfolder:");
        if (int.TryParse(Console.ReadLine(), out int maxFilesPerFolder) && maxFilesPerFolder > 0)
        {
            fileOrganiser.FilesForMonth(path, maxFilesPerFolder);
        }
        else
        {
            Console.WriteLine("Please enter a positive number indicating the maximum amount of files.");
        }
    }
}
