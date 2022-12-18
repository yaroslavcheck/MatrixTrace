using System;

public class InputChecker
{
    public int[] CorrectInput()
    {
        bool inputChecker = true;
        int[] correctDimensions = new int[2];
        
        while (inputChecker)
        {
            string inputWord = Console.ReadLine() ?? "";
            string[] dimensions = inputWord.Split(" ");
            

            try
            {
                correctDimensions[0] = Convert.ToInt32(dimensions[0]);
                correctDimensions[1] = Convert.ToInt32(dimensions[1]);
                inputChecker = false;
                
            }
            
            catch
            {
                Console.WriteLine("Please input matrix dimensions by spaces:");
            }
        }
        return correctDimensions;
    }
}