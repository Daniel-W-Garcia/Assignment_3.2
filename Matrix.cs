namespace Assignment_3._2;

public class Matrix
{
    private void IterateMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("| ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} | ");
            }
            Console.WriteLine();
        }
    }
    
    private int[,] SumMatrix(int[,] matrix1, int[,] matrix2)
    {
        int[,] sumArray = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                sumArray[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return sumArray;
    }
    public void DisplaySumMatrix(int[,] matrix1, int[,] matrix2)
    {
        Console.WriteLine("Matrix 1:");
        IterateMatrix(matrix1);
        Console.WriteLine("Matrix 2:");
        IterateMatrix(matrix2);
        int[,] sumResult = SumMatrix(matrix1, matrix2);
        
        Console.WriteLine("Sum of matrices:");
        for (int i = 0; i < sumResult.GetLength(0); i++)
        {
            Console.Write("| ");
            for (int j = 0; j < sumResult.GetLength(1); j++)
            {
                Console.Write($"{sumResult[i, j]} | ");
            }
            Console.WriteLine();
        }
    }
}