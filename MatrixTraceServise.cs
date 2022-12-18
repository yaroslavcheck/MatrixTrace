using System;

public class MatrixTraceServise
{
    public string[,] CreateMatrix(int length, int width)
    {
        int[] size = new int[] { length, width };
        string[,] matrix = new string[size[0], size[1]];

        for (int i = 0; i < size[0]; i++)
        {
            for (int j = 0; j < size[1]; j++)
            {
                Random elementOfMatrix = new Random();
                int el = elementOfMatrix.Next(1, 100);
                matrix[i, j] = Convert.ToString(el);
            }
        }

        return matrix;
    }
    
    public void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            { 
                if (i == j) 
                { 
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.Write("{0} ", matrix[i, j]);
                }
                else 
                { 
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.Write("{0} ", matrix[i, j]);
                }
            } 
            Console.WriteLine();
        }
    }

    public string MatrixTrace(string[,] matrix)
    {
        int answerMatrixTrace = 0;

        if(matrix.GetLength(0) <= matrix.GetLength(1))
        { 
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                answerMatrixTrace += Convert.ToInt32(matrix[i, i]);
            }
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                answerMatrixTrace += Convert.ToInt32(matrix[i, i]);
            }
        }

        return Convert.ToString(answerMatrixTrace);
    }
}
