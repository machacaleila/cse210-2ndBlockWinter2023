using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int numb = randomGenerator.Next(1,101);
        int guess = -1;

        //Console.Write("Please, guess a number: ");
        //string chooseNumber = Console.ReadLine();
        //int guess = int.Parse(chooseNumber);
        
        while (guess != numb){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
             if ( guess < numb ) {
 
             Console.WriteLine("Higher");            
            }
            else if (guess > numb) {
            Console.WriteLine("Lower");
            }
            else {
            Console.WriteLine("You guessed it");
            }
        }

       

    }
} 