using Enums;
using System.Globalization;

User user = new User();
user.UserName = "Test4";
user.Password = "abc@123";
user.AccoutType = AccountType.Member;

int x = (int)user.AccoutType;
Console.WriteLine(x);

AccountType t = (AccountType)x;
Console.WriteLine(t);