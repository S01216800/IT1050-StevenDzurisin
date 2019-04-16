//Lab 04

using System;

class Lab4
{
    static void Main()
    {
        /* 1. (Lab 4 created)
         * 
         * 2. Counter-controlled iteration consists of four main components: The control variable,
         * the initial value of the control variable, the loop-continuation condition, and the increment
         * of the control variable. The control variable serves as a counter during the loop's operation.
         * Its starting value is the value from which the segment of code will begin operation. The
         * loop-continuation condition is checked, and if it is true then the program increments by the 
         * value specified in the control variable's increment. Once the loop-continuation condition is tested
         * and a value of "false" is found, the iteration stops and the program proceeds execution from immediately
         * after the counter-controlled iteration statement.
         * 
         * 3. "While" statements and "for" statements both handle counter-controlled iteration. The main difference
         * between the two is how concise each of them is. For example, a "while" statement might need to define its
         * control variable (and its initial value), loop continuation condition, and control variable increment over
         * the span of a few lines of code. A "for" statement can do all of this in just one line, inside what is known
         * as the "for" statement header. Furthermore, "for" statements are typically used for counter-controlled iteration,
         * whereas "while" loops tend to appear when sentinel-controlled iteration is present.
         * 
         * 4.In the "Microsoft Virtual Academy" video lessons, the "while" loop lesson demonstrates an example in which a
         * command console-based guessing game is presented. The game prompts the user to guess a random number chosen by
         * the system between 1 and 10. A "do...while" loop is used for this so that the code block can run at leaset one time
         * in its entirety, as opposed to being evaluated only at the top and potentially jumping to the next segment of code
         * before the user has had a chance to guess the number correctly.
         */
         
        //5.

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 ==0)
            {
                Console.WriteLine($"{i}. Variable is even.");
            }
            else
            {
                Console.WriteLine($"{i}. Variable is odd.");
            }
        }

        //6.

        Console.Write("\nPlease enter a temperature: ");
        int temp = int.Parse(Console.ReadLine());

        if (temp < 10)
        {
            Console.WriteLine("\nPolar Bear.");
        }
        else if (temp < 20)
        {
            Console.WriteLine("\nPenguin.");
        }
        else if (temp < 40)
        {
            Console.WriteLine("\nMoose.");
        }
        else if (temp < 50)
        {
            Console.WriteLine("\nReindeer.");
        }
        else if (temp < 60)
        {
            Console.WriteLine("\nDeer.");
        }
        else if (temp < 70)
        {
            Console.WriteLine("\nTurtle.");
        }
        else if (temp < 80)
        {
            Console.WriteLine("\nLion.");
        }
        else if (temp < 90)
        {
            Console.WriteLine("\nFish.");
        }



        Console.WriteLine("\nEnter any number between 1 and 8 to read about a certain type of animal.");
        Console.WriteLine("\nEnter any other number to read about bugs.");

        Console.Write("\nEnter an exhibit number: ");

        int exhibit = Convert.ToInt32(Console.ReadLine());

        switch (exhibit)
        {
            case 1:
                Console.WriteLine("\nYou have chosen the polar bear exhibit.");
                Console.WriteLine("Polar bears are large, carnivorous mammals " +
                    "who live in the world's coldest regions.\n");
                break;

            case 2:
                Console.WriteLine("\nYou have chosen the penguin exhibit.");
                Console.WriteLine("Penguins are flightless birds who live in Antarctica.\n");
                break;

            case 3:
                Console.WriteLine("\nYou have chosen the moose exhibit.");
                Console.WriteLine("\nMoose are the largest animals in the Deer family. They" +
                    " live in northern regions.\n");
                break;

            case 4:
                Console.WriteLine("\nYou have chosen the reindeer exhibit.");
                Console.WriteLine("\nReindeer are herbivorous members of the Deer family, " +
                    "and live in colder regions.\n");
                break;

            case 5:
                Console.WriteLine("\nYou have chosen the deer exhibit.");
                Console.WriteLine("\nDeer come in several varieties. They can be found all " +
                    "throught the U.S.\n");
                break;

            case 6:
                Console.WriteLine("\nYou have chosen the turtle exhibit.");
                Console.WriteLine("\nTurtles come in many different forms - snapping, sea, " +
                    "and box, to name a few. They live in many regions throughout the world.\n");
                break;

            case 7:
                Console.WriteLine("\nYou have chosen the lion exhibit.");
                Console.WriteLine("\nLions are the apex predators of their ecosystems. They are the most" +
                    "social of the big cats.\n");
                break;

            case 8:
                Console.WriteLine("\nYou have chosen the fish exhibit.");
                Console.WriteLine("\nFish come in many different shapes and sizes, and live in oceans and " +
                    "bodies of water all over the Earth.\n");
                break;

            default:
                Console.WriteLine("\nYou have chosen the bug exhibit.");
                Console.WriteLine("\nThere is a staggering variety of insects on the planet. They have existed for" +
                    " hundreds of millions of years.\n");
                    break;
        }

        //7.

        /*The following code...
         * 
         * int j = 10;
        while (j < 21)
        {
            Console.WriteLine(j);
        }
        *
        *appears to be intended to output 10 - 20, with each integer receiving its own line. The problem,
        *however, is that there is no increment applied to the control variable, and so the latter never changes
        *in value. The number "10" is printed to the console unimpeded. Therefore, the code segment results in an
        *infinite loop. To fix the issue, we add an increment to the code which increases the control variable by
        *1 during each iteration.
        */

        int j = 10;
        
        while (j < 21)
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine(); //Adds a space between number 7's output and number 8's output. Just for the
                             //sake of organization.

        //8.

        /*The following segment of code...
         * 
         * for (int i = 0; i < 101; i++)
         *      Console.WriteLine(i);
         *      Console.WriteLine("********");
         *
         *is meant to print out all integers between 0 and 100 (inclusive), each being separated with a line
         *of asterisks. The code, however, actually prints out all of these integers with no asterisk lines
         *separating them, with only one line of asterisks being printed after 100. The reason why is simple,
         *but very important: There are no curly braces denoting the body of the "for" statement. Once the
         *braces are added, the issue is fixed and the code produces the desired output.
         */

        for (int i = 0; i < 101; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine("********");
        }
    }
}
