using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int a = -1;
        while ( a != 0 ){
            Console.Write("Enter a number: ");
            string userResponse= Console.ReadLine();
            a = int.Parse(userResponse);
            
            if (a != 0 ){
                numbers.Add(a);
            }
        }
        int sum = 0;
        foreach (int number in numbers){
            sum +=number;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        //Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        //max
        int max = numbers[0];
        foreach (int number in numbers){
              if (number > max){
                max = number;
              }
        }
        Console.WriteLine($"The max is: {max}");


    }
}