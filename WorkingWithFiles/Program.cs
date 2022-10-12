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


            // CreateDirectory();
            CreateFiles();
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
                    var extension = Path.GetExtension(file);
                    if(extension == ".json")
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

        /*Creating files and directories*/
        public static void CreateDirectory()
        {
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "WorkingWithFiles/stores", "201", "newDir"));
        }

        public static void CreateFiles()
        {
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "WorkingWithFiles", "stores", "201", "newDir", "gretting.txt"), "Hello World. this has been writted from a function.");
        }
    }
}
