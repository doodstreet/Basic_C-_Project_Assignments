using System;


namespace ClassObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to do some math operations on. ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            mathOp mathClass = new mathOp(); // create an object of type mathOp (class)
            
            //mathClass.Multiply(userNum); // get the number from user input

            int result = mathClass.Multiply(userNum);
            int result1 = mathClass.Divide(userNum);
            int result2 = mathClass.Add(userNum);
            Console.WriteLine("Your number times four is " + result);
            Console.WriteLine("Your number divided by two is " + result1);
            Console.WriteLine("Your number plus ten is " + result2);

            Console.ReadLine();
        }
    }
}
