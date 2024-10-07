//Compare string 
using System.Globalization;
using System.Runtime.InteropServices;

Console.WriteLine("Test of string.Compare() method:");
string one = "Nakib Khan";
string two = "Zarip Khan";
string three = "Nakib Khan";
string four = "Abir Khan";
Console.WriteLine(string.Compare(one, two));  // -1, as string one is less then two
Console.WriteLine(string.Compare(one, three)); // 0, as string one is equal to string theree
Console.WriteLine(string.Compare(one, four)); // 1 as string one is grater than string four

Console.WriteLine("Test of string.CompareOrdinal method (Type 1): ");

// This method can be overloaded by passing different parameter to it
// CompareOrdinal(string1, string2)  
// CompareOrdinal(string1, int32, string2, int32, int32)
//Type 1

string str1 = "Nakib Khan";
string str2 = "Zarif Khan";
string str3 = "Nakib Khan";
string str4 = "Abir Khan";
Console.WriteLine(string.CompareOrdinal(str1, str2)); // -12, as str1 is less than str2 (negative value)
Console.WriteLine(string.CompareOrdinal(str1, str3)); // 0, as str1 is equal to str3 (Zero)
Console.WriteLine(string.CompareOrdinal(str1, str4)); // 13, as str1 is grater then str4 (Positive value)

//Type 2
//This method is used to compare the substrings of the two particular string object by calculaing the 
//numeric value of the corresponding cahr object in each substring
//It will take 5 parameter: substringA, lenA (starting index of the A substing), substringB, lenB 
// (starting index of the B substring), length

Console.WriteLine("Test of String.CompareOrdinal() method (tyep 2): ");
string strA = "I love Bangladesh";
string strB = "I love Chattogram";
int lenA = 2;
int lenB = 2;
int len = 7;

Console.WriteLine(string.CompareOrdinal(strA, lenA, strB, lenB, len)); // -1, as it is less


//String.Concat() combine one or more string togeher, even it can concat array of string
Console.WriteLine("Test of String.Concat() method : ");
string firstPart = "Nakib ";
string lastPart = " Khan";
string middlePart = "Uddin";

Console.WriteLine(string.Concat(firstPart, lastPart));
Console.WriteLine(string.Concat(firstPart, middlePart, lastPart));

//string(name of the string variable).EndsWith() returns true if match else return false
Console.WriteLine("Test of string.Endswith() method : ");
string testString = "Nakib Khan";
bool x = testString.EndsWith("Khan");
bool y = testString.EndsWith("Uddin");
Console.WriteLine(x);
Console.WriteLine(y);

//Format() method is used to replaces one or more format items in a string with the string representation of a specified object
Console.WriteLine("Test of Format method (Tyep 1): ");
DateTime date1 = new DateTime(2010, 11, 11);
string s1 = string.Format("{0:D}", date1);
Console.WriteLine(s1);

//IndexOf() medthod returns the index (zero index based) of a specified char in a string if not found return -1
Console.WriteLine("Test of IndexOf() method: ");
Console.WriteLine(firstPart.IndexOf('k'));
Console.WriteLine(firstPart.IndexOf('x'));

//IndexOfAny() it finds the index of any char of char array in the sepecified string
Console.WriteLine("The of IndexOfAny() method: ");
char[] chars = { 'b', 'x' };
Console.WriteLine(firstPart.IndexOfAny(chars));

//Insert() method is c# used to return a new string in which a specified string is inserted at a specified
//Index in the current string instance
Console.WriteLine("Test of insert() method in c#: ");
string newFirstPart = firstPart.Insert(0, "Mr. ");
Console.WriteLine(newFirstPart);

//Join() method is used to concatenates the members of a collection or the elements of the specified array
//using the specified separator between each member or element.
Console.WriteLine("Test of join mehtod(): ");
object[] objects = {"Hello", "Geeks", "I", "Love", "your","Tutorial"};
string s2 = string.Join(" ", objects);
Console.WriteLine(s2);

//LastIndexOf() method is used to find the last matching element in a one dimentional array. It start the search from last element of the array
Console.WriteLine("Test of LastIndexOf() method: ");
int[] arr = { 1, 2, 32, 32, 2, 23, 23, 23, 32, 6, 2324, 3, 423, 2, 423, 3, 6 };
int indx = Array.LastIndexOf(arr, 6);
Console.WriteLine(indx);

//PadLeft() is a string method. This method is used to right-align the cahracters in string by left padding
//with space or specified character on the left for a specified total length
Console.WriteLine("Test of PadLeft method : ");
string info = "Test string ";
string result = info.PadRight(30, '*');
Console.WriteLine(result);

//Remove() is used for removing all the characters from the specified position of a string 
Console.WriteLine("Test remove function : type (1)");
string fullName = "Nazim Uddin Nakib";
string newFullName = fullName.Remove(11);  //Given start index, it will remove all char after the start index
Console.WriteLine(newFullName);
Console.WriteLine("Test remove function : type (2)");
string newFullName2 = fullName.Remove(6, 5); //It will remove uddin, as start index and number of char to be removed are given
Console.WriteLine(newFullName2);


//Replace() is used to replace all the specified unicode character or specified string from the current string object and return a new modified string
Console.WriteLine("Test replace method : type (1)");
newFullName = fullName.Replace('a','o');
Console.WriteLine(newFullName);
Console.WriteLine("Test replace method: type (2)");
newFullName = fullName.Replace("Nakib", "Rakib");
Console.WriteLine(newFullName);

//ReplaceLineEndings   

//Char method
Console.WriteLine("Char Method Practice");
