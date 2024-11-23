using Fun1;
using System;
using System.IO;

using var context = new ApplicationDBContext();
var lines = File.ReadAllLines("Data.txt");
foreach (var line in lines)
{
    var data = line.Split(' ');
    var student = new Student
    {
        Name = data[0],
        Age = int.Parse(data[1]),
        CGPA = double.Parse(data[2])
    };
    context.Students.Add(student);
}
context.SaveChanges();
