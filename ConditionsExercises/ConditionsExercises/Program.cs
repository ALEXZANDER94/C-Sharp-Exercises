using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Write a program that checks if the entered value is between 1 and 10
            Console.Write("Enter a value between 1 and 10: ");
            int input = int.Parse(Console.ReadLine());
            
            if(input <= 10 && input > 0)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }

            //Exercise 2
            //Write a program that accepts to numbers and displays the maximum
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            if(num1 > num2)
            {
                Console.WriteLine("the first number is greater than the second number");
            } else
            {
                Console.WriteLine("the second number is greater than the first number");
            }

            //Exercise 3
            //Write a program that accepts the width and height of an image, then tell
            //if the image is a portrait or landscape
            Console.Write("Enter the width of the picture: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter the height of the picture: ");
            int height = int.Parse(Console.ReadLine());
            if(width > height)
            {
                Console.WriteLine("The picture is a landscape");
            } else
            {
                Console.WriteLine("The picture is a portrait");
            }

            //Exercise 4
            //Prompt the user for the speed limit, then prompt the user of the
            //speed of the vehicle. For every 5km over the speed limit, 1 mark
            //is added to the license. If there are more than 12 marks on a license
            //then the license is suspended
            Console.Write("What is the speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.Write("What is the speed of the car: ");
            int carSpeed = int.Parse(Console.ReadLine());
            int points = 0;
            if(carSpeed > speedLimit)
            {
                int speedOver = carSpeed - speedLimit;
                points = speedOver / 5;
                if(points > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
