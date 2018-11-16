using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Stack stack = new Stack();
            object item;
            do
            {
                //Clear the Console for each menu print
                Console.Clear();

                //show Menu
                Console.Write("Make a Selection:\n" +
                    "'s' -> Show Stack\n" +
                    "'a' -> Push to Stack\n" +
                    "'p' -> Pop from Stack\n" +
                    "'c' -> Clear Stack\n" +
                    "'q' -> Quit\n");

                //get the User's choice
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "s":
                        stack.Show();
                        break;
                    case "a":
                        Console.Write("What would you like to push to the stack: ");
                        item = Console.ReadLine();
                        stack.Add(item);
                        break;
                    case "p":
                        stack.Pop();
                        break;
                    case "c":
                        stack.Clear();
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
                
                
            } while (choice.ToLower() != "q");
        }
    }
}
