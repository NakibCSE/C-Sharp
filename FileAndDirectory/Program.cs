using System.Text;
File.Create("Demo.txt");
File.WriteAllText("demo.txt", "Hello World");\
File.WriteAllLines("demo.txt", ["Dhaka", "Chittagong", "Sylhet"]);


FileInfo fileInfo = new FileInfo("demo.txt");
if (fileInfo.Exists)
{
    fileInfo.Delete();
}

using FileStream fileStream = File.Open("Demo.txt", FileMode.OpenOrCreate);
string text = "Hello World";
fileStream.Write(Encoding.UTF8.GetBytes(text));


//Directory
Directory.CreateDirectory("Videos/Training");

string CurrentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(CurrentDirectory);
Console.WriteLine();

Directory.SetCurrentDirectory(Path.Combine(CurrentDirectory, "Videos", "Training"));
CurrentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(CurrentDirectory);
Console.WriteLine();

File.WriteAllText("Sample.txt", "Hello World");

DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(CurrentDirectory, "Videos", "Training"));
if (directoryInfo.Exists)
{
    Directory.Delete(Path.Combine(CurrentDirectory, "Videos", "Training"), true);
}

Directory.Delete(Path.Combine(CurrentDirectory, "Videos", "Training"), true);

var dir2 = new DirectoryInfo(CurrentDirectory);
var dir = dir2.EnumerateDirectories();
foreach (var d in dir)
{
    Console.WriteLine(d.FullName);
}

var files = dir2.EnumerateFiles();
foreach(var x in files)
{
    Console.WriteLine(x.FullName);
}
