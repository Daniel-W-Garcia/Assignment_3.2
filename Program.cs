using Assignment_3._2;

Circle circle = new Circle(0);
TotalAndAverage t = new TotalAndAverage();
FindIndex f = new FindIndex();
Matrix matrix = new Matrix();

int[,] array1 = { {10, 2, 3}, {4, 5, 6} };
int[,] array2 = {{20, 4, 6}, {1, 3, 6}};
matrix.DisplaySumMatrix(array1, array2);