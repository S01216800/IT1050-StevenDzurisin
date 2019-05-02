using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. (Created Lab 6)

            /*2. A one-dimensional array p contains four elements. The array access expressions to access
             *each of the elements in p are p[0], p[1], p[2], and p[3]. */

            //3.

            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
            "October", "November", "December"};

            Console.WriteLine($"{"Number"}{"Month",14}");

            for (int counter = 0; counter < months.Length; ++counter)
            {
                int monthNumber = counter + 1;

                Console.WriteLine($"{monthNumber,6}{months[counter],14}");
            }

            //4.

            string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };

            Console.WriteLine($"\nSeasons\n");

            foreach (string season in seasons)
            {
                Console.WriteLine($"{season}");
            }

            //5.            

            int[] chaos = new int[1000];

            Random random = new Random();
            int randomNumber;

            Console.WriteLine("\nOne thousand random numbers...\n");

            foreach (int number in chaos)
            {
                randomNumber = random.Next(0, 100);

                Console.WriteLine($"{randomNumber}");                
            }            

            //6.

            //This is the code for problem 6 before the "while" loop was converted into a "foreach"
            //loop for problem 8. I kept it here in comment form for reference.

            /*string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            Console.WriteLine(); //Just to separate this problem's output from 5's.

            Console.WriteLine(names[0]);

            int i = 0;
            while (i < names.Length)
            {
                i = i + 1;

                if (i <= 4)
                {
                    Console.WriteLine(names[0 + i]);
                }                
            }*/

            //7.

            

            //8.

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            Console.WriteLine(); //Just to separate this problem's output from 5's.

            Console.WriteLine(names[0]);

            int i = 0;
            foreach (string person in names)
            {
                i = i + 1;

                if (i <= 4)
                {
                    Console.WriteLine(names[0 + i]);
                }
            }                        
        }
    }
}
