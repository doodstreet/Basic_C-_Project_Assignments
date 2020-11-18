using System;


namespace OptionAssingmentPg227
{
    class Program
    {
        static void Main(string[] args)
        {
            Options option = new Options();

            Console.WriteLine("Enter a number and lets do some math");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number, if you like");
            int userNum2;
            int result;
            if (int.TryParse(Console.ReadLine(), out userNum2))
            {
                result = option.myMethod(userNum1, userNum2);
            }
            else
            {
                result = option.myMethod(userNum1);
            }


            Console.WriteLine("result: " + result);
            Console.ReadLine();
        }
    }
}
