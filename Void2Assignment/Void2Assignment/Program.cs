using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Vmath math = new Vmath();// instantiate the class

            Console.WriteLine("Enter a number please");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            math.DoStuff(userInput); // call void method, pass userInput

            string y;
            math.Name(out y); // method with output instead of passing input to

            int results = math.Math(20, 30); //method to be overloaded

            decimal results1 = math.Math(20.5m, 30.6m);// overload method

            int results2 = Vmath.DoMath(13, 11); // static method, since its here
            
            Console.WriteLine("Void Name method outputs string: " + y); // out method
            Console.WriteLine("20 + 30 = " + results); /// preoverload method
            Console.WriteLine("20.5 + 30.6 = " + results1); // overload method
            Console.WriteLine("13 * 11 = " + results2); // static method
            Console.WriteLine("My name is {0}", MyName.fullName);// static class 

            Console.ReadLine();
        }
    }
}
