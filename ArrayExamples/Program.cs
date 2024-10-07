//One dimentional array
int[] x = new int[20];
x[0] = 0;
x[1] = 1;
x[2] = 2;

bool[] is_married = new bool[20];

string[] s = new string[5];

DateTime[] dt = new DateTime[5];

char[] c = new char[] {'A', '6', '#', 'D'};

//Two dimensional array
int[,] grid = new int[3, 4];
grid[0, 0] = 1;
grid[1, 0] = 2;
grid[2, 0] = 3;
grid[0, 1] = 4;
grid[1, 1] = 5;
grid[2, 1] = 6;
grid[0, 2] = 7;

// .........
//..........

grid[2, 3] = 80;



//Three dimensional array
int[,,] threeD= new int[2,3,3];

//Four dimensional array
int[,,,] fourD = new int[2,3,3, 4];



//Jagged array : Array's array

/*
 [0,0,0,0,0]
 [0,0]
 [0,0,0]
 */

int[][] ja = new int[3][];
ja[0] = new int[4];
ja[1] = new int[5];
ja[2] = new int[6];


//Jagged array's array
int[][][] ja2 = new int[6][][];

ja2[0] = new int[2][];
ja2[0][0] = new int[5];

ja2[1] = new int[2][];
ja2[2] = new int[2][];

ja2[1][0] = new int[3];
ja2[1][1] = new int[3];
