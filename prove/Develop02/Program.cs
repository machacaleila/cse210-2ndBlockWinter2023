using System;
//what does the program do?: Record user's answers by prompts and the questions in a file
//What user inputs does it have?:A list of questions that radomly prompt.
// What output does it produce?: Questions and data recorded
using RadomSentence;
class Program
{
    static void Main(string[] args)
    {
        var xxx = PromptGenerator.WholeSentence();
        Console.WriteLine(xxx);

    }
}