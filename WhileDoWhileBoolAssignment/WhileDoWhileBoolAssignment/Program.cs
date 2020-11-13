using System;


namespace WhileDoWhileBoolAssignment
{
    class Program
    {
        static void Main()
        {
            int num = 10;
            while (num > 0)
            {      
                Console.WriteLine(num);
                num--;
            }

            Console.WriteLine("Pick a number between 1 and 10");
            int numPick = Convert.ToInt32(Console.ReadLine());
            bool correctNum = numPick == 3;

            do
            {
                switch (numPick)
                {
                    case 1:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("That Is Correct!");
                        correctNum = true;
                        break;
                    case 4:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("Pick between 1 and 10");
                        numPick = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (!correctNum);

            Console.ReadLine();
        }
    }
}
