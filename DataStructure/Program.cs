//List 
using System.Globalization;

List<string> nameList = new List<string>();
nameList.Add("Nakib Khan");
nameList.Add("Sayeed Khan");
nameList.Add("Rhat Khan");

Console.WriteLine("Before operation: ");
foreach (string name in nameList)
{
    Console.WriteLine(name);
}

string name1 = nameList[2];
nameList.Remove("Rhat Khan");
nameList[0] = "Rakib Rafsan";

Console.WriteLine("After Operation:");
foreach (string name in nameList)
{
    Console.WriteLine(name);
}


//Hash set: can keep unique data only
Console.WriteLine("Experiment of hash set");
HashSet<string> allRegistrationNumber = new HashSet<string>();
allRegistrationNumber.Add("11-00-01");
allRegistrationNumber.Add("11-00-05");
allRegistrationNumber.Add("11-00-12");
allRegistrationNumber.Add("11-00-12");

foreach (string registrationNumber in allRegistrationNumber)
{ Console.WriteLine(registrationNumber); }

//Dictonary : Can keep key value pair with unique key only
Console.WriteLine("Examine dictonary:");
Dictionary<string, double> salary = new Dictionary<string, double>();
salary.Add("emp-098", 25000);
salary.Add("emp-012", 34000);
salary.Add("emp-342", 11000);
salary.Add("emp-111", 25000);

Console.WriteLine("Employee code || Salary Amount");
foreach (KeyValuePair <string, double> codeSalary in salary)
{
    Console.WriteLine(codeSalary.Key+" || "+codeSalary.Value);
}

