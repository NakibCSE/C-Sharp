using System.Collections.Concurrent;

int x = 5;
int z = x + 5;
int a = x - 5;
int b = x / 5;
int c = x % 5;
int d = x * 5;

x++; // x = x + 1;
++x; // x = x + 1;
x--; // x = x - 1;
--x; // x = x - 1;

int m = 5;
int t = ++m;

x += 5; // x = x + 5;
x *= 5;


bool v = x > 5.54985039485034859043805930958093589850m;
v = x < 5;
v = x >= 5;
v = x <= 5;
v = x == 5;
v = x != 5;

bool v2 = x > 5 && x < 10;
bool v3 = x > 5 || x < 10;

Console.WriteLine(-(-4));


//Bitwise operator
int s = 5; // 0101
int s2 = 9; //1001

int s3 = s2 & s;  // 0001
int s4 = s2 | s;  // 1101

Console.WriteLine("S2 ANd S = " + s3);
Console.WriteLine("S2 OR S = " + s4);

int s5 = 0b_0110_1100_0010; // A binary number declaration
int s6 = 0x_19AF_20FB; // A Hexa decimal number declaration

Console.WriteLine(s5);  // will print a integer number
Console.WriteLine(Convert.ToString(s5, toBase: 2));  // will print binary


// One bit shift 
s5 = s5 << 1;
Console.WriteLine(Convert.ToString(s5, toBase: 2));

//Two bit shift
s5 = s5 >> 2;
Console.WriteLine(Convert.ToString(s5, toBase: 2));

#region Example of Complement operator
uint tt = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint tb = ~tt;
Console.WriteLine(Convert.ToString(b, toBase: 2));  // 1111_0000_1111_0000_1111_0000_1111_0011
#endregion


#region Example shifts operator

//Left shift
uint m1 = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
Console.WriteLine($"Before conversion: {Convert.ToString(m, toBase: 2)}");
uint b1 = m1 << 4;
Console.WriteLine($"After conversion:  {Convert.ToString(b, toBase: 2)}");

//Right shift
uint n = 0b_1001;
Console.WriteLine($"Before conversion: {Convert.ToString(n, toBase: 2)}");
uint n2 = n >> 2;
Console.WriteLine($"After Conversion:  {Convert.ToString(n2, toBase: 2)}");

//Output:
//Before: 1001
 //After:   10

#endregion

#region Example Logical operator

//Bitwise and
uint a1 = 0b_1111_1000;
uint b2 = 0b_1001_1101;
uint c1 = a1 & b2;

Console.WriteLine(Convert.ToString(c1, toBase: 2));

//Bitwise or
uint p = 0b_1111_1000;
uint q = 0b_1001_1101;

uint r = p | q;

Console.WriteLine(Convert.ToString(r, toBase: 2));

#endregion

