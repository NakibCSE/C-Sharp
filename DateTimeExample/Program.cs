DateTime dateOfBirth = new DateTime(2000, 6, 23, 12, 30, 0, 30);
DateTime registrationTime = DateTime.Now;
DateTime registrationTime2= DateTime.UtcNow;

string x = dateOfBirth.Ticks.ToString();
Console.WriteLine(x);