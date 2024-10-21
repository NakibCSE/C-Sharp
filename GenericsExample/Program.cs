using GenericsExample;

Coordinate<string, float> c = new Coordinate<string, float>();
c.X = "Test";
c.Y = 8.5f;

Coordinate<int, double> c2= new Coordinate<int, double>();
c2.X = 8;
c2.Y = 7.3;


BubleSort<double> bublesort = new BubleSort<double>();
var result = bublesort.Sort(new double[] { 3.4, 9.4, 5.3, 7.2 });

foreach (var i in result)
    Console.WriteLine(i);