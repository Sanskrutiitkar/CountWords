using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int wordCount = 0;
        bool wordContd = false;

        //iterate through each letter 
        for (int i = 0; i < sentence.Length; i++)
        {
            //logic to check double spacing 
            if (sentence[i] != ' ')
            {
                if (!wordContd)
                {
                    wordCount++;
                    wordContd = true;
                }
            }
            else
            {
                wordContd = false;
            }
        }
        Console.WriteLine($"Number of words: {wordCount}");
    }
}