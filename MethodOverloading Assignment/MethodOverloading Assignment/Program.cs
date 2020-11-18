using System;


namespace MethodOverloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DoMath math = new DoMath();

            int num1 = math.Math(13);
            decimal num2 = math.Math(4.60m);
            int num3 = math.Math("1234");
            
            Console.WriteLine("Int: 13 x 11 = " + num1);
            Console.WriteLine("Decimal: 4.60 + 3.14 = " + num2);
            Console.WriteLine("String to Int: \"1234\" / 10 = " + num3);

            Console.ReadLine();
        }

    }
}
