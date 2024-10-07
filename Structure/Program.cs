using Structure;

Person person = new Person();
person.Name = "Jalal Uddin";
person.Age = 30;
Console.WriteLine("Before change: " + person.Name);
Person person2 = person;
person2.Name = "Nakib Khan";
int x = 5;
int y = x;
y = 10;


Console.WriteLine("After change: " + person.Name);
Console.WriteLine(x);

string Name = "Jalal Uddin";
string m = Name;
m = "Hasan Saheb";
Console.WriteLine(Name);