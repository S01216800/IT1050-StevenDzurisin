using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dog
{
    public string Name { get; set; }

    // Add bark() method

    public void Bark()
    {

        Console.WriteLine("{0} is barking...", Name);
    }

    // Add doTrick() method

    public void DoTrick(string trickName)
    {
        Console.WriteLine("{0} is so smart! {0} is doing a {1}!", Name, trickName);
    }
}


