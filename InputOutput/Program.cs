////Console.WriteLine("Hello World");   //Print the next to the next line
////Console.Write("I am from Chittagong");  //Print the next to the same line
////Console.WriteLine("My Name is Nazim Uddin Nakib");

//ConsoleKeyInfo c = Console.ReadKey();
//Console.WriteLine(c.KeyChar);

using System.Security.Cryptography.X509Certificates;

void InputProcess1()
{
    string line = Console.ReadLine();

    string[] lineParts = line.Split(',', ' ');

    for (int i = 0; i < lineParts.Length; i++)
    {
        lineParts[i] = lineParts[i].Trim();
    }

    int[] numbers = new int[lineParts.Length];
    int counter = 0;
    foreach (string linepart in lineParts)
    {
        if (!string.IsNullOrWhiteSpace(linepart))
        {
            numbers[counter++] = int.Parse(linepart);
        }
    }

    int sum = 0;
    for (int i = 0; i < counter; i++)
    {
        sum += numbers[i];
    }
    Console.WriteLine(sum);
}

void InputProcess2()
{
    string countLine = Console.ReadLine();
    int count = int.Parse(countLine);

    int[] numbers = new int[count];
    for(int i = 0; i<count; i++)
    {
        string numLine = Console.ReadLine();
        numbers[i] = int.Parse(numLine);
    }
    int sum = 0;
    foreach(var number in numbers)
    {
        sum += number;
    }
    Console.WriteLine(sum);
}


InputProcess2(); 