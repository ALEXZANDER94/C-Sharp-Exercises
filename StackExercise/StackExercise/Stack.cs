using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Stack
    {
        //create a list of objects for any data type entered by the User
        public List<object> data { get; set; }

        public Stack()
        {
            //create the list of objects in the constructor
            data = new List<object>();
        }
        public void Show()
        {
            //if the list is empty, tell the user
            if (data.Count == 0)
            {
                Console.WriteLine("The Stack is empty!\nPress 'enter' to continue");
                Console.ReadLine();
            }
            //otherwise show each object in the list
            else
            {
                foreach (var item in data)
                {
                    Console.Write(item + " ");
                    
                }
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
            }
        }
        public void Add(object item)
        {
            Console.WriteLine(item + " is being pushed to the stack");
            data.Add(item);
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();
        }
        public void Pop()
        {
            if (data.Count == 0)
            {
                Console.WriteLine("The Stack is empty. Nothing to Pop");
            }
            else
            {
                Console.WriteLine(data.Last<object>() + " is being removed");
                data.Remove(data.Last<object>());
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
            }
        }
        public void Clear()
        {
            if (data.Count == 0)
            {
                Console.WriteLine("The stack is empty. Nothing to Clear");
            }
            else
            {
                Console.WriteLine("Clearing the stack");
                data.Clear();
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
            }
        }
    }
}
