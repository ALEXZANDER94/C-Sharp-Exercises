using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Write a program that prompts the user for a sequence of number separated by a hyphen
            //then display if the sequence is consecutive or not consecutive
            Console.WriteLine("Enter a sequence of numbers separated with hyphens: ");
            var numbers = Console.ReadLine();
            var nums = numbers.Split('-');
            bool consecutiveInc = false;
            var index = 0;
            //for loop for incrementing series
            for (var i = Convert.ToInt32(nums[index]); i < nums.Length; i++)
            {
                if (Convert.ToInt32(nums[index]) == i)
                    consecutiveInc = true;
                else
                {
                    consecutiveInc = false;
                    break;
                }
                index++;
            }
            index = 0;
            bool consecutiveDec = false;
            //for loop for decrementing series
            for (var j = Convert.ToInt32(nums[index]); j > 0; j--)
            {
                if (Convert.ToInt32(nums[index]) == j)
                    consecutiveDec = true;
                else
                {
                    consecutiveDec = false;
                    break;
                }
                index++;
            }


            if (consecutiveInc || consecutiveDec)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");

            //Exercise 2
            //write a program that prompts the user for a series of numbers separated by a hyphen, then check to see
            //if there are any duplicates
            Console.WriteLine("Enter a series of numbers separated by a hyphen: ");
            numbers = Console.ReadLine();
            bool duplicate = false;
            if (String.IsNullOrEmpty(numbers))
            {
                //exit if the entered string is null or empty
                Environment.Exit(0);
            }
            else
            {
                //split the string by hyphens
                nums = numbers.Split('-');
                for (var i = 0; i < nums.Length; i++)
                {
                    //check for duplicates
                    var tmp = Convert.ToInt32(nums[i]);
                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        if (Convert.ToInt32(nums[j]) == Convert.ToInt32(nums[i]))
                        {
                            duplicate = true;
                        }
                    }
                }
                if (duplicate)
                    Console.WriteLine("There is a duplicate");
                else
                    Console.WriteLine("There is no duplicates");
            }

            //Exercise 3
            //Write a program that prompts the user to enter a time in the 24-hour time
            //format (i.e. 14:54). A valid time is between 00:00 and 23:59. Then display
            //if the time is valid or invalid
            Console.WriteLine("Enter a time in the 24-hour format (HH:mm):");
            var timeInput = Console.ReadLine();
            var time = timeInput.Split(':');
            //test if invalid (HH > 23 || HH < 0 || mm > 59 || mm < 0)
            if(Convert.ToInt32(time[0]) > 23 
                || Convert.ToInt32(time[0]) < 0
                || Convert.ToInt32(time[1]) > 59 
                || Convert.ToInt32(time[1]) < 0)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }

            //Exercise 4
            //Write a program that prompts the user for a series of words separated by a space
            //and outputs the words in a Pascal Case variable name (i.e. number of students -> NumberOfStudents)
            Console.WriteLine("Enter a series of words separated by a space: ");
            var spacedWords = Console.ReadLine();
            var words = spacedWords.Split(' ');
            var pascalword = "";
            foreach(var word in words)
            {
                //convert the word to all lower case
                var lowerWord = word.ToLower();
                for(int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        //if the character is the first letter in the word, upper case it
                        pascalword += word[i].ToString().ToUpper();
                    }
                    else
                    {
                        //otherwise just append it to the string
                        pascalword += word[i];
                    }
                }
            }
            Console.WriteLine("The pascale variable name is: " + pascalword);

            //Exercise 5
            //Write a program that asks the user for an english word then counts all of the 
            //vowels in the word and outputs the number of vowels
            Console.WriteLine("Enter an english word: ");
            var englishWord = Console.ReadLine();
            int vowels = 0;
            for(int i = 0; i < englishWord.Length; i++)
            {
                //if the character is a vowel, increment the running total
                if(englishWord[i] == 'a' ||
                    englishWord[i] == 'e' ||
                    englishWord[i] == 'i' ||
                    englishWord[i] == 'o' ||
                    englishWord[i] == 'u')
                {
                    vowels++;
                }
            }
            Console.WriteLine("There are " + vowels + " vowels in the word " + englishWord);
        }
    }
}
