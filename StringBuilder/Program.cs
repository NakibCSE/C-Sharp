using System.Globalization;
using System.Text;

StringBuilder stringBuilder = new StringBuilder("I am from Chittagong");
stringBuilder.Append(" and I love programming");
stringBuilder = stringBuilder.Replace('a', 'x');
stringBuilder = stringBuilder.Insert(10, "wwww");
stringBuilder = stringBuilder.Remove(15, 5);
for (int i = 0; i < stringBuilder.Length; i++)
{
    stringBuilder[i] = 'M';
}
Console.WriteLine(stringBuilder);