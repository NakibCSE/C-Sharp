//File.Create("Demo.txt");
//File.WriteAllText("demo.txt", "Hello World");\
//File.WriteAllLines("demo.txt", ["Dhaka", "Chittagong", "Sylhet"]);

using System.Text;

FileInfo fileInfo = new FileInfo("demo.txt");
if(fileInfo.Exists)
{
    fileInfo.Delete();
}

using FileStream fileStream = File.Open("Demo.txt", FileMode.OpenOrCreate);
string text = "Hello World";
fileStream.Write(Encoding.UTF8.GetBytes(text));