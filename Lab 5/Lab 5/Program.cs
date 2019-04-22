//Lab 5

using System;

class Lab5
{
    static void Main()
    {
        /*1. (Created Lab 5)
         * 
         *2. The scope of the method is "public." It is specified at the beginning of the method
         *header. Other possible types of scope include "private" and "static." The scope of the
         *method is the portion of the application that can refer to the declared entity by its
         *unqualified name (accessing library classes from the .NET Framework Class Library without
         *specifying their namespace names). "Static" methods performs tasks which do not depend on
         *the data of any object besides the method's arguments. An example of a non-static method is
         *one declared as "public," as in the given example. This allows other programmers to use the 
         *method in their own classes. The return type in the method header is "double." It details the
         *type of value returned by the method - in the case of the example, the method will return a 
         *double value. The method name is "getArea." Method names should be, in and of themselves, good
         *descriptors of the method. The parameters are indicated in the parentheses section of the method
         *header. The name and type of the parameters are included. In the example, the parameters are called
         *"height" and "width", and they are both of type "double." Other types such as "int" or "string"
         *could be used. The method's body is delimited by braces, and contains (in the example) a statement 
         *"return height * width". 
         * 
         *3. A user-defined method is one that is written by the programmer, as opposed to a pre-defined
         *method included with a framework such as .NET. Instead of "reinventing the wheel," it is often
         *best to make use of pre-packaged methods that are part of the Class Library for the sake of 
         *efficiency. When writing a custom method, it is important to think about the parameters involved,
         *as well as the types included in the parameters. The name of the method should also be indicative
         *of its purpose within the program.
         * 
         *4. Methods declared as "static" operate in such a way that they are not dependent on the data of
         *any entities besides its own arguments. This differs from the functioning of most methods. Static
         *methods apply to the entirety of the classes in which they're declared. The operations of non-static
         *methods, on the other hand, involve the data of other objects in the application.
         * 
         *5. (I copied and pasted the code for numbers 5 and 6 from the downloaded zip file specified in the
         *instructions and inserted them into this solution. I assumed that this is what we were to do.) */

         Dog myDog = new Dog();
         myDog.Name = "Fido";

         // To do: uncomment the following lines of code to call the methods
         myDog.Bark();
         myDog.DoTrick("Fetch");
    }
}