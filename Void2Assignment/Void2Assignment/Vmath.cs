using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void2Assignment
{
    public class Vmath
    {
        public void DoStuff(int num)
        {
            int x = num / 2;
            Console.WriteLine("Your number divided by two = " + x);
            return;
        }
        public int Math(int num1, int num2)
        {
            return num1 + num2;
        }
        public decimal Math(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static int DoMath( int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
