(int age, string name) x = (5, "Hello");
Console.WriteLine(x.age);
Console.WriteLine(x.name);

(int sum, double average) Calculate(int[] items)
{
    var sum = 0;
    foreach(var item in items)
    {
        sum += item;
    }
    var average = sum / items.Length;
    return (sum, average);
}

(int, string)[] personInfo = [(123, "Hasan"), (124, "Nakib")];