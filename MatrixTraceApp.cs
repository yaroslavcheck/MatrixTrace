using System;

public class MatrixTraceApp
{
    public static void Main()
    {
        Console.WriteLine("FoxMinded C# course. Task 02 - MatrixTrace. Student: Yaroslav Korneyko\nPlease input matrix dimensions by spaces:");

        bool inputChecker = true;

        while (inputChecker)
        {
            string inputWord = Console.ReadLine() ?? "";
            string[] dimensions = inputWord.Split(" ");

            try
            {
                CreateMatrixClass createMatrix = new CreateMatrixClass();
                int[,] matrix =
                    createMatrix.CreateMatrix(Convert.ToInt32(dimensions[0]), Convert.ToInt32(dimensions[1]));

                MatrixConsoleUtils matrixConsoleUtils = new MatrixConsoleUtils();
                MatrixTraceClass matrixTrace = new MatrixTraceClass();
        
        
        
                Console.WriteLine($"\nMatrix:");
                matrixConsoleUtils.PrintMatrix(matrix);
        
                Console.WriteLine($"Matrix Trace: {matrixTrace.MatrixTrace(matrix)}");
                inputChecker = false;
            }
            
            catch
            {
                Console.WriteLine("Please input matrix dimensions by spaces:");
            }
        }
    }
}