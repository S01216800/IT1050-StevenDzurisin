//Midterm

using System;

class Midterm
{
    static void Main()
    {
        /*1. (Created Midterm)
        * 
        *2. One of the three types of control structures used in C# programming is known as "sequence."
        *This simply refers to the order in which statements of a sequence execute. Statements are
        *written into the app in proper execution order. The second type of C# control statement is
        *"selection." Selection can manifest in "if", "if...else" and "switch" statements. Although "if"
        *statements can technically handle all "selection" needs in C#, the other two help to make things
        *more concise and efficient. The third and final type of control structure in this language is
        *known as "iteration." This comes in four flavors: "while", "do...while", "for", and "foreach"
        *statements. Just like with "if" selection statements, "while" iteration statements are capable of
        *accomplishing any iterative task in C#. However, for the sake of a more streamlined program, its
        *fellow iteration statements are often used to tackle more intricate or complex tasks.*/

        //3.

        bool keepLooping = true;

        int p = 0;
        p++;

        Console.WriteLine(p);

        while (keepLooping == true)
        {
            p++;

            Console.WriteLine(p);
        }

        //4. 

        int output = 2;

        Console.WriteLine($"[{output}]");

        while (output < 128)
        {
            output *= 2;
            Console.WriteLine($"[{output}]");
        }

        Console.WriteLine();

        //5.

        for (int n = 49; n >= 1; n--)
        {
            if (n >= 2)
            {
                Console.Write($"{n}, ");
            }
            else
            {
                Console.Write("1\n");
            }
        }

        Console.WriteLine();

        //6.

        for (int k = 1; k <= 21; k += 2)
        {
            Console.Write($"{k} ");            
        }

        Console.WriteLine();

        /*7. The given code sample will output only an asterisk. A "do...while" loop will always execute
        *at least once; the line detailing an asterisk to be printed, therefore, will execute even though
        *the condition after it is, and always will be, false. Specifically, the condition in question, 
        *which is "while (i < n)", will never be true. This is due to "i" being initialized to 10, "n" 
        *being initialized to 8, and "i" being incremented by one during each iteration. These details 
        *guarantee that "i" will never be less than 8, and therefore once the loop has executed and printed
        *an asterisk once, it won't happen again.
        * 
        *Were the same loop written in the form of a mere "while" statement instead of a "do...while", there
        *would be nothing printed to the command prompt. Unlike a "do...while", which will always execute at
        *least once because the condition is located at the end of the block, a "while" statement's condition
        *is evaluated in its first line, which means that whatever is located in the body of the statement will
        *potentially never execute at all, depending on the nature of the initial condition. This is precisely
        *the case with the given example. If it were a "while" statement, the untrue condition would cause the
        *loop to terminate before it had a chance to print an asterisk.*/

        //8.

        bool icyRain = false;
        bool tornadoWarning = false;

        //The two boolean values can be combined in an "if" statement header such that they are evaluated
        //with a boolean logical and ("&") operator between them. Both booleans are initialized as "false",
        //and the "if" statement will only print "Let's go outside!" if both of the booleans remain as such.

        if (icyRain == false & tornadoWarning == false)
        {
            Console.WriteLine("\nLet's go outside!");
        }
    }        
}
