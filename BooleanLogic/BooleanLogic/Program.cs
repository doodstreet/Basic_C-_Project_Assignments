using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do You Qualify For Car Insurance?\nAnswer Me These Questions Three:\n");
            Console.WriteLine("WHAT..is you age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("WHAT..is your DUI count?");
            int duis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQualify?");

            bool qualify = (age >= 15 && duis == 0 && tickets <= 3);
            Console.WriteLine(qualify);


            int num1 = 7;
            int num2 = 12;
            string result = num1 > num2 ? "num1 is greater than num2" : "num 2 is greater than num1";
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
