//Addition.cs
//Displaying the sum of two numbers input from the keyboard.
using System;

public class Addition
{
    //The Main method begins the execution of the application
    public static void Main ( string[] args)
    {
        int number1; //declaration of first number to be multiplied
        int number2; //declaration of second number to be multiplied
        int product; //output of number1 and number2 being multiplied together

        Console.Write("Enter the first integer: "); //prompts the user to input the first number
        number1 = Convert.ToInt32(Console.ReadLine()); //reads the number the user entered

        Console.Write("Enter the second integer: "); //asks the user to enter the second number
        number2 = Convert.ToInt32(Console.ReadLine()); //reads the second number the user entered

        product = number1 * number2; //multiplies the first and second numbers entered

        Console.WriteLine("The product of these two numbers is {0} \n", product); //displays product

        //***************************************************************************************
        //***************************************************************************************

        Console.WriteLine("{0}\n{1}", "Hello, World!", "From Steven \n"); /*Prints the quoted text
        over two separate lines*/

        //***************************************************************************************
        //***************************************************************************************

        Console.WriteLine("Hello, World!    From Steven");

        //***************************************************************************************
        //***************************************************************************************

        /*5.
         *  a. The start of the program's execution lies in line 8, which contains the Main
         *  method of the app.
         *  
         *  b. An integer type variable will store whole-number values. A variable of this type may
         *  range between 2,147,483,647 and -2,147,483,648 (the maximum absolute values that 32 bits
         *  can represent. Double and floating-point variables don't store whole numbers, but
         *  approximations of them - in other words, numbers with decimal points.
         *  
         *  c. In chapter 4, a class was created for the AccountTest program called "Account." This
         *  class was written as follows:
         *  
         *  
         *  
         *  class Account
         *  {
         *      private string name;
         *      
         *      public void SetName(string accountName)
         *      {
         *          name = accountName;
         *      }
         *      
         *      public string GetName()
         *      {
         *          return name;
         *      }
         *  }
         *  
         *  
         *  
         *  This class contains a few different methods, one of which is the "SetName" method. The 
         *  method's header details the access modifier, return type, and name. The access modifier 
         *  determines which methods in the program can access the instance variable ("SetName").
         *  Since it is public in this case, it is not restricted to only certain methods. The return
         *  type indicates the data type returned to the method's caller after the given task has
         *  been completed. The return type for "SetName" is "void," which means the method will not
         *  give any information to the method calling upon it.
         *  
         *  d. Like we have types double and int, we can create our own custom types using Classes. Each
         *  class has variables called instance variables or class members. To read the value of an instance
         *  variable, we create a method called a "get" accessor. To assign a value to an instance variable,
         *  we use a method called a "set" accessor.
         *  
         *  e. A class is essentially the blueprints for an object or objects. An object is a reusable
         *  software component which is derived from a class. For this reason, an object can be called 
         *  an "instance" of a class. Each object is created from only a single class, but many objects 
         *  can be born of a single class. This is why object-oriented programming is considered to be
         *  much more efficient than older modes of software engineering. Reusing classes when developing
         *  new software saves time and energy, and systems also become more stable and reliable because
         *  the classes being recycled have had plenty of time to be tested, debugged, and fine-tuned in
         *  their performance.
    }
}

