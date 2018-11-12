using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //write a program to count how many numbers between 1 and 100 are divisible by 3
            var i = 0;
            int count = 0;
            while(i <= 100)
            {
                if(i%3 == 0)
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine("There are " + count + " numbers between 1 and 100 that are divisible by 3");

            //Exercise 2
            //write a program that continuously prompts the user for a number until
            //they enter 'ok' then adds all the entered numbers together.
            int total = 0;
            while(true)
            {
                Console.WriteLine("Enter a number to be added or enter 'ok' to exit: ");
                var input = Console.ReadLine();
                if(input == "ok")
                {
                    break;
                }
                else
                {
                    total += int.Parse(input);
                }
            }
            Console.WriteLine("The total is " + total);

            //Exercise 3
            //Write a program that calculate the factorial of an entered number
            Console.WriteLine("Enter a number: ");
            int fact = 1;
            int num = int.Parse(Console.ReadLine());
            for(int j = num; j >= 1; j--)
            {
                fact *= j;
            }
            Console.WriteLine(num + "! = " + fact);

            //Exercise 4
            //Write a program that generates a random number between 1 and 10. 
            //If the user guesses the number correctly, display 'you won!'
            var random = new Random();
            bool isguessed = false;
            int numberToBeGuessed = random.Next(1, 10);
            Console.WriteLine(numberToBeGuessed);
            Console.WriteLine("Try to guess the generated number between 1 and 10: ");
            while (!isguessed)
            {
                int guess = int.Parse(Console.ReadLine());
                if(guess == numberToBeGuessed)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again");
                }

            }

            //Exercise 5
            //Write a program that prompts the user for a series of numbers
            //separated by a comma, then displays the maximum of those numbers
            Console.WriteLine("Enter a series of number separated by a comma: ");
            var series = Console.ReadLine();
            int max = 0;
            for(int number = 0; number < series.Length; number++)
            {
                if(Convert.ToInt32(series[number]) != 44 && Convert.ToInt32(series[number]) != 32)
                {
                    max = (int.Parse(char.ToString(series[number])) > max) ? int.Parse(char.ToString(series[number])) : max;
                }
            }
            Console.WriteLine("The maximum number is " + max);
        }
    }
}
