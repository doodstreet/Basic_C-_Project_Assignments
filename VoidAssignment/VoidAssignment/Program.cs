using System;

namespace VoidAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Math math = new Math();

            Math.doMath(3, 5);
            Math.doMath(num1: 3, num2: 5);

            Console.ReadLine();
            
        }

    }
}
