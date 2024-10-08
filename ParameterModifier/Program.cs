using ParameterModifier;

Geometry geometry = new Geometry();

double avg1 = geometry.CalculateAverage([1.2,23.2,2.2,2.3,2.3,7.4,2.3,23.2]);
double avg2 = geometry.CalculateAverage(1.45, 1.23, 232.2);

Console.WriteLine(avg1);
Console.WriteLine(avg2);

int m = 5;
geometry.Calculate(ref m);
Console.WriteLine(m);


int x;
int y;
int z;

geometry.Calculate3(out x, out y, out z);
Console.WriteLine($"x = {x}, y = {y}, z = {z}");