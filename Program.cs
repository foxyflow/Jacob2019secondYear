using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListsArrays
{
    // Create an application that uses a stack to store 10 values input by the user.
    //Your application needs to check if the stack contains a specific value and if it does remove all of the elements above it
    //but leave the value searched for and all other values below in the stack.
    class Program
    { //contains 
        static void Main(string[] args)
        {
            StackExecises();
            Console.WriteLine("\n***********************************************************************************");

            Stack s2 = new Stack();
            
            
            s2.Push("any datatype");
            s2.Push(true);
            s2.Push(30.00);
            s2.Push("hero");
            s2.Push("stringy");
            s2.Push(false);
            s2.Push('@');
            s2.Push("mrString");
            s2.Push(false);
            s2.Push(50);
            s2.Push("push is just add to the top of the stack");

            Console.WriteLine(s2.Peek()); //note the top is 50 (which is the bottom, I know right -- confusing)

           Console.WriteLine($" number of items:  {s2.Count}");

            for (int i = 0; i < s2.Count; i++)
            {
                if (s2.Peek().ToString() != "stringy")
                {
                    s2.Pop();
                }
                else
                {
                    
                    break;
                    //return s1.Peek().ToString() == "stringy"
                }
            }
            foreach (object item in s2)
            {
                Console.WriteLine(item);
                
            }
            
            Console.WriteLine("**************************************************************************");
            

            // foreach(object x in s1)
            //   Console.WriteLine($"current element: {x}");
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////notes:
            //don't use a loop for a pop becasue there would be nothing left.
            Console.WriteLine("task1 :pop in assignment. copy if you don't want the top one deleted.");
            Console.WriteLine("task 3 is 2/3 assignment");
            Console.WriteLine("loop with an if statment");
            Console.WriteLine("top of the stack is the first element");
            Console.WriteLine("querce just starts at the other end? TAsk1 loop");

            Console.WriteLine("*****************************");
            Console.WriteLine("********** Stack's **********");
            Console.WriteLine("*****************************");

            /*Stack created using the default constructor*/
            Stack s1 = new Stack();

            /*Using Push to add items to the stack, note that it can take any data type*/
            s1.Push("Hello");
            s1.Push("World");
            s1.Push('@');
            s1.Push(10);
            s1.Push(false);

            /*Using the Count property to veiw the number of elements in the stack*/
            Console.WriteLine("\n... Count ...");
            Console.WriteLine("Count: " + s1.Count);

            /*Using Peek to view the stacks contents*/
            Console.WriteLine("\n ... Peek ...");
            Console.WriteLine("Top item: " + s1.Peek() + "\nCount: " + s1.Count);

            /*Using Pop to use and remove the top object*/
            Console.WriteLine("\n ... Pop ...");
            Console.WriteLine("Top item: " + s1.Pop() + "\nCount: " + s1.Count);
            Console.WriteLine("Top item: " + s1.Pop() + "\nCount: " + s1.Count);
            Console.WriteLine("Top item: " + s1.Pop() + "\nCount: " + s1.Count);
            Console.ReadLine();
        }

        private static void StackExecises()
        {
            Stack stack1 = new Stack();
            Console.WriteLine("(boot console here)");


            //first arrray practice
            string phrase = "Hellohello";
            Console.WriteLine(phrase[4]); //4th letter of Hellohello -- no need to do Array phrase = new phrase Array

            // Array phrase2 = new Array[0]; not working
            //phrase2 = { 1,2,3,4}
            int[] numbers = { 123, 456, 789 };
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            string[] names = //new string[4] no need for this?
                { "luke ", "puke  ", "Smoke ", "Scorpion"};
            foreach(string item in names)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Please enter name {i + 1}");
                names[i] = Console.ReadLine();
            }
            foreach(string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"the first name entered is {names[0]} and the last name entered is {names[3]}");//have to have variable and array index not just index.





            Console.ReadLine();//for the rest of main
        }

    }
    
}
