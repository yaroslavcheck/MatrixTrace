using System;

public  class CreateMatrixClass
{
    public int[,] CreateMatrix(int length, int width)
    {
        int[] size = new int[] { length, width };
        int[,] matrix = new int[size[0], size[1]];
        
        for (int i = 0; i < size[0]; i++)
        {
            for (int j = 0; j < size[1]; j++)
            {
                Random elementOfMatrix = new Random();
                int el = elementOfMatrix.Next(1, 100);
                matrix[i, j] = el;
            }
        }

        return matrix;
    }
}
