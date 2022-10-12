# Working with files in c# language

## Getting the current directory
The class Directory has a function called GetCurrentDirectory that returns the project current directory.

` Console.WriteLine($"The current directory is: {Directory.GetCurrentDirectory()}"); `

## Getting a special directory depending to the SO
Depending to the SO we can obtain a diferent path, if you uses windows you can get "c:\User\UserName\"
but if you use linux or macOS you can get "home/username/"

with the GetFolderPath from the class Environ we can get the especial folder no matter what SO you use.

`string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);`
`Console.WriteLine($"The Home path is: {docPath}");`

## Special paths characters
Depending to the OS, we have to use diferent characters to separate directory levels

* Windows uses the backslash character "\\"
* Linux and macOS uses the forward slash character "/"

.Net has a class called Path and we can use it to use the correct character depending to the SO.
The Path class contains the DirectorySeparatorChar field to help us with this task.

` char separator = Path.DirectorySeparatorChar; `
` Console.WriteLine($"WorkingWithFiles{separator}stores{separator}201"); `

## Joining paths
We can join diferent parts of a path to form a full path, to do this we can use the Combine function from the Path class and put the directory names into double quotes and separate then with a coma as shown below.


` Console.WriteLine(Path.Combine("WorkingWithFiles", "stores", "201")); `

## Determinating the filename extension
To get the extension from a file, we can use the function GetExtension from the class Path.

` Console.WriteLine(Path.GetExtension("sales.json")); `

This going to return .json

## Getting everything to know about a file or path

` string fileName = $"WorkingWithFiles{separator}stores{separator}sales{separator}sales.json"; `
` FileInfo info = new(fileName); ` 
` Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extention: {info.Extension}{Environment.NewLine}Create date: {info.CreationTime}"); `


## Using the current directory and combining paths

` var currentDirectory = Directory.GetCurrentDirectory(); `

` var storesDirectory = Path.Combine(currentDirectory, "WorkingWithFiles/stores"); `

` var salesFiles = FindFiles(storesDirectory); `

`
foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
`

## Creating files and directories

### Creating a new directory

To create a directory we can use the Directory.CreateDirectory method.

` Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir")); `

### Creating a new file

We can create a file using the File.WriteAllText method, this method takes in a path to the file and the data you want to write to the file.

`File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Message"); `
