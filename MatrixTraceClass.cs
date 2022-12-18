using System;

public class MatrixTraceClass
{
    public int MatrixTrace(int[,] matrix)
    {
        int answerMatrixTrace = 0;

        if(matrix.GetLength(0) <= matrix.GetLength(1))
        { 
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                answerMatrixTrace += matrix[i, i];
            }
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                answerMatrixTrace += matrix[i, i];
            }
        }

        return answerMatrixTrace;
    }
}