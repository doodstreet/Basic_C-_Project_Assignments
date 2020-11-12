using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number and it will be multipied by 50");
            long inputMultiply = Convert.ToInt64(Console.ReadLine());
            long inputProduct = inputMultiply * 50;
            Console.WriteLine(inputProduct);


            Console.WriteLine("Pick a number and it will have 25 added to it");
            long inputAdd = Convert.ToInt64(Console.ReadLine());
            long inputSum = inputAdd + 25;
            Console.WriteLine(inputSum);
            

            Console.WriteLine("Pick a number and it will be divided by 12.5");
            long inputDivide = Convert.ToInt64(Console.ReadLine());
            double Quotient = inputDivide / 12.5;
            Console.WriteLine(Quotient.ToString());


            int ourNum = 50;
            Console.WriteLine("Pick a number and see if its greater than our number");
            int yourNum = Convert.ToInt32(Console.ReadLine());
            bool isGreater = ourNum < yourNum;
            Console.WriteLine(isGreater);

            Console.WriteLine("Pick a number and see the remainder of a division by 7");
            int inputModulus = Convert.ToInt32(Console.ReadLine());
            int modulus = inputModulus % 7;
            Console.WriteLine(modulus);

            Console.WriteLine("Thank you for playing...hahaha");
            Console.ReadLine();

      
        }
    }
}
