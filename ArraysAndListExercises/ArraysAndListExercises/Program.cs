using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //write a program that displays different texts depending on the count
            //in the array/list
            var friends = new List<string>();
            Console.WriteLine("Enter a list of your friends: ");
            var input = Console.ReadLine();
            var entries = input.Split(' ');
            if (entries.Length == 1)
            {
                Console.WriteLine(input + " is your friend");
            }
            else
            {
                foreach (var entry in entries)
                    friends.Add(entry);
                if (friends.Count > 2)
                {
                    Console.WriteLine(string.Format("{0}, {1}, and others are your friends", friends[0], friends[1]));
                }
                else if (friends.Count == 2)
                {
                    Console.WriteLine(string.Format("{0} and {1} are your friends", friends[0], friends[1]));
                }
            }

            //Exercise 2
            //Write a program that prompts the user to enter their name then reverse
            //it and output it to the console
            Console.WriteLine("Enter your Name: ");
            var name = Console.ReadLine();
            var reversedName = new char[name.Length];
            for(var i = 0; i < name.Length; i++)
            {
                reversedName[i] = name[(name.Length-1) - i];
            }
            var reversed = new string(reversedName);
            Console.WriteLine(reversed);

            //Exercise 3
            //Write a program that prompts the user to enter 5 numbers, if the number
            //has been entered previously, prompt them to enter another number. Do this
            //until 5 unique numbers have been entered
            Console.WriteLine("Enter 5 unique numbers: ");
            var uniqueNumbers = new List<int>();
            var numToTest = 0;
            do
            {
                numToTest = Convert.ToInt32(Console.ReadLine());
                if (uniqueNumbers.Contains(numToTest))
                {
                    Console.WriteLine("Enter a unique number: ");
                }
                else
                {
                    uniqueNumbers.Add(numToTest);
                }
            } while (uniqueNumbers.Count < 5);
            Console.Write("You entered: ");
            foreach(var number in uniqueNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //Exercise 4
            //Write a program that prompts the user to enter any amount of numbers, then
            //'quit' to exit. Then the program outputs all of the unique numbers.
            Console.WriteLine("Enter any amount of numbers, or 'quit' to exit: ");
            var numbersList = new List<int>();
            var num = "";
            do
            {
                num = Console.ReadLine();
                //if the entered string is 'quit' then break out of the do-while loop
                if(num.ToLower() == "quit")
                {
                    break;
                }
                //test if the list already contains the value, if it doesn't then add it to the 
                //list of unique numbers
                if(!numbersList.Contains(Convert.ToInt32(num)))
                {
                    numbersList.Add(Convert.ToInt32(num));
                }
            } while (num.ToLower() != "quit");
            Console.Write("The unique numbers are: ");
            foreach(var number in numbersList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //Exercise 5
            //Write a program that prompts the user for a comma separated list
            //then outputs invalid list if the count is less than 5 or if the list 
            //is empty; otherwise, the smallest 3 numbers are outputted.
            Console.WriteLine("Enter 5 or more numbers separated by commas: ");
            var count = 5;
            var exercise5List = new List<int>();
            do
            {
                //Read in the values
                var ex5nums = Console.ReadLine();

                //Split the values into a string[]
                var ex5NumList = ex5nums.Split(',');

                //add each value into the list
                foreach (var exnum in ex5NumList)
                {
                    exercise5List.Add(Convert.ToInt32(exnum));
                }
                if(exercise5List.Count < count)
                {
                    Console.WriteLine("Invalid List! Try again!");
                }
            } while (exercise5List.Count < count);

            //start searching for the smallest 3 numbers
            var smallestNums = new List<int>();
            
            for (int i = 0; i < 3; i++)
            {
                //assume the first element is the minimum
                int min = exercise5List[0];
                foreach (var possibleNum in exercise5List)
                {
                    //test if the minimum is the next possible num
                    min = (possibleNum <= min) ? possibleNum : min;
                }
                //add the min to the list of smallest numbers
                smallestNums.Add(min);
                //remove the smallest number from the list so that it is not chosen again.
                exercise5List.Remove(min);
            }
            Console.Write("The smallest numbers are: ");
            foreach(var smallnums in smallestNums)
            {
                Console.Write(smallnums + " ");
            }
            Console.WriteLine();
        }
    }
}
