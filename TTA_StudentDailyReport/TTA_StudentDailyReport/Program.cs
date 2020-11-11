using System;

namespace TTA_StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\n\nStudent Daily Report\n");


            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            int yourPageNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with andything? Please answer \"true\" or \"false\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were ther any positive experiences you'd like to share? Please give specifics.");
            string yourExps = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int yourStudyHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

    

        }
    }
}
