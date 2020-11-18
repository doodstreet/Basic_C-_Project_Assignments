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
            Vmath math = new Vmath();

            Console.WriteLine("Enter a number please");
            int userInput = Convert.ToInt32(Console.ReadLine());

            math.DoStuff(userInput);
            int results = math.Math(20, 30);
            decimal results1 = math.Math(20.5m, 30.6m);
            int results2 = Vmath.DoMath(13, 11);

            Console.WriteLine("20 + 30 = " + results);
            Console.WriteLine("20.5 + 30.6 = " + results1);
            Console.WriteLine("13 * 11 = " + results2);

            Console.ReadLine();
        }
    }
}
