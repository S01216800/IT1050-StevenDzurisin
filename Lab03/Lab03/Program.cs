using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. One important similarity between "if-" and "while-" statements is the fact that they
             * both behave in accordance with certain conditions. They make decisions based on a set
             * of pre-defined criteria, and are thus crucial components of algorithms. Distinctions
             * between the two include the "if-" statement's one-time execution, as opposed to the 
             * "while-" statement's iterative nature (it loops until the condition in its header becomes
             * false). However, an "if-" statement may repeat if it is nested within a "while-" statement.
             * */

            //3.

            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW.");
            }

            //4.

            bool isTrue = true;

            if (isTrue == true)
            {
                Console.WriteLine("\nIt is true!");
            }
            else
            {
                Console.WriteLine("\nIt is false!");
            }

            //5. 

            double fahrenheit;
            double celsius;

            Console.Write("\nEnter the temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32d) * (5d / 9d);

            Console.WriteLine($"\nThe temperature in Celsius is {celsius}.");

            if (fahrenheit < 40)
            {
                Console.WriteLine("\nIt is cold.\n");
            }
            if (fahrenheit > 90)
            {
                Console.WriteLine("\nIt is hot.\n");
            }

            //6.

            int x = 0;

            while (x < 10)
            {
                x++;
                Console.WriteLine($"{x}");
            }

            Console.WriteLine(" "); /*This statement, and the one between 7 and 8, is here to
                                      insert a space between the parts so that the executed program
                                      is more legible and organized in the command prompt.*/

            //7.

            int y = 60;

            Console.WriteLine($"{y}");

            while (y > 20)
            {
                y -= 5;
                Console.WriteLine($"{y}");
            }

            Console.WriteLine(" "); //For the sake of organization.

            //8.

            int z = 10;

            Console.WriteLine($"{z}");

            z += 2;

            Console.WriteLine($"{z}");

            while (z < 20)
            {
                z += 2;
                Console.WriteLine($"{z}");
            }




        }
    }
}

