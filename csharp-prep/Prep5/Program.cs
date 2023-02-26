using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string name = Console.RedLine();

            return name;
    }
    static int PromptUserNumber() {
            Console.Write("Please enter your fav number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
    }
    static int SquareNumber(int number){
            int square = number * number;
            return square;
    }
    static void Display( string name, int square){
            Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}