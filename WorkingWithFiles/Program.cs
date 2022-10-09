using System.IO;
using System.Collections;

namespace WorkingWithFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListingAllDirectories("WorkingWithFiles/stores");
            ListingFiles("WorkingWithFiles/stores");
            ListingAllContent("WorkingWithFiles/stores");
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
