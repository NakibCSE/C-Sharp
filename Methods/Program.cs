void PrintMax(int a, int b)
{
    int c = a;
    if(b>a)
        c = b;
    Console.WriteLine(c);
}

PrintMax(10, 111);
PrintMax(20, 2);
PrintMax(30, 5);

int GetMax(int a, int b)
{
    int c = a;
    if (b>a)
        c = b;
    return c;
}

GetMax(10, 732);
GetMax(20, 2);
GetMax(30, 5);