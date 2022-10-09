using System.IO;
using System.Collections.Generic;

namespace WorkingWithFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ListingAllDirectories("WorkingWithFiles/stores");
            // ListingFiles("WorkingWithFiles/stores");
            // ListingAllContent("WorkingWithFiles/stores");

            // var salesFiles = FindFiles("WorkingWithFiles/stores");
            // foreach (var file in salesFiles)
            // {
            //     Console.WriteLine(file);
            // }
            Console.WriteLine($"The current directory is: {Directory.GetCurrentDirectory()}");
            
            // special directories
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine($"The Home path is: {docPath}");

            /*
            SPECIAL PATH CHARACTERS

            Depending to the operating system we use different characters to separate directory levels
            * Windows uses the backslash \
            * macOS and Linux uses the forward slash /
            .Net has a class called Path and we can use it to use the correct character depending to the SO.
            The Path class contains the DirectorySeparatorChar field to help us with this task.
            */
            char separator = Path.DirectorySeparatorChar;
            Console.WriteLine($"WorkingWithFiles{separator}stores{separator}201");

            /*
            JOIN PATHS
            */
            Console.WriteLine(Path.Combine("WorkingWithFiles", "stores", "201"));

            /*Determinate the filename extensions*/
            Console.WriteLine(Path.GetExtension("sales.json"));

            /*Getting everything to know about a file or path*/
            string fileName = $"WorkingWithFiles{separator}stores{separator}sales{separator}sales.json";
            FileInfo info = new(fileName);
            Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extention: {info.Extension}{Environment.NewLine}Create date: {info.CreationTime}");
        }

        // Function to find the sales.json files
        public static IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();
            try
            {
                var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
            
                foreach (var file in foundFiles)
                {
                    if (file.EndsWith("sales.json"))
                    {
                        salesFiles.Add(file);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return salesFiles;
        }


        // To read through and list the names of the top-level directories, use the Directory.EnumerateDirectories function
        public static void ListingAllDirectories(string directory)
        {   
            Console.WriteLine("Listing all the directories from a given directory");
            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(directory);
            foreach (var dir in listOfDirectories)
            {
                Console.WriteLine($"* {dir}");
            }
        }

        public static void ListingFiles(string directory)
        {
            Console.WriteLine("Listing all the files from a given directory");
            IEnumerable<string> files = Directory.EnumerateFiles(directory);

            foreach (var file in files)
            {
                Console.WriteLine($"* {file}");
            }
        }

        // Listing all content in a directory and all subdirectories.
        public static void ListingAllContent(string directory)
        {
            // Find all +.txt files in the stores folder and its subfolders
            Console.WriteLine("Listing all txt files in the stores folder and its folders");
            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(directory, "*.txt", SearchOption.AllDirectories);
            foreach (var file in allFilesInAllFolders)
            {
                Console.WriteLine($"* {file}");
            }
        }
    }
}
