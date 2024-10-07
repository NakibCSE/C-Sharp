
using System;
using System.Runtime.CompilerServices;
using ValueTypeVsReferenceType;

//Value type
int p = 100;
int q = p;
p = 200;
Console.WriteLine(p);
Console.WriteLine(q);


//Reference type
Student st1 = new Student();
st1.name = "Nakib Khab";
st1.CGPA = 4.8;
st1.ageInYear = 24;

Student st2 = st1;

st2.name = "Jamil";
st2.CGPA = 3.6;
st2.ageInYear = 25;

Console.WriteLine(st1.name);
Console.WriteLine(st1.CGPA);
Console.WriteLine(st1.ageInYear);
Console.WriteLine("--------------");
Console.WriteLine(st2.name);
Console.WriteLine(st2.CGPA);
Console.WriteLine(st2.ageInYear);

Console.WriteLine("Another Value and reference test: ");
Console.WriteLine("Value Type");
int a = 100;
Console.WriteLine("Before: "+a);
ChangeTheNumber(a);
Console.WriteLine("After: "+a);

void ChangeTheNumber(int aNumber)
{
    aNumber = 200;
}

Console.WriteLine("Reference type:");
Student st3 = new Student();
st3.name = "Nakif";
st3.CGPA = 2.78;
st3.ageInYear = 26;
Console.WriteLine("Before: "+st3.name+" "+st3.CGPA+" "+st3.ageInYear);
ChangeTheSudent(st3);
Console.WriteLine("After: "+st3.name+" "+st3.CGPA+" "+st3.ageInYear);

void ChangeTheSudent(Student aStudent)
{
    aStudent.name = "Latif";
    aStudent.CGPA = 3.78;
    aStudent.ageInYear = 28;
}


//Passing reference of value type
Console.WriteLine("Passing reference of value type test:");
int aa = 100;
int bb = 200;
Console.WriteLine("a = "+aa+", b = "+bb);
Swap(ref aa, ref bb);
Console.WriteLine("a = " + aa + ", b = " + bb);

void Swap(ref int a, ref int b)
{
    int temp = aa;
    aa = bb;
    bb = temp;
}