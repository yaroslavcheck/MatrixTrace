using System;

public class MatrixTraceApp
{
    public static void Main()
    {
        Console.WriteLine("FoxMinded C# course. Task 02 - MatrixTrace. Student: Yaroslav Korneyko\nPlease input matrix dimensions by spaces:");

        string inputWord = Console.ReadLine() ?? "";
        string[] dimensions = inputWord.Split(" ");
        var matrixTrace = new MatrixTraceServise();

        string[,] matrix = matrixTrace.CreateMatrix(Convert.ToInt32(dimensions[0]), Convert.ToInt32(dimensions[1]));
        Console.WriteLine($"\nMatrix:");
        matrixTrace.PrintMatrix(matrix);
        
        Console.WriteLine($"Matrix Trace: {matrixTrace.MatrixTrace(matrix)}");
    }
}