using System;

public class MatrixConsoleUtils
{
    public void PrintMatrix(int[,] matrix)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{matrix[i, j]} ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{matrix[i, j]} ");
                }
            }

            Console.WriteLine();
        }
    }
}