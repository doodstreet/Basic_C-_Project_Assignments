using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAgeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            int now = (DateTime.Today.Year);
            int birthYear;

            try
            {
                do
                {
                    Console.WriteLine("What's your age?");
                    userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge <= 0)
                        Console.WriteLine("Zero or negative numbers are not valid ages.");
                } while (userAge <= 0);
                birthYear = (now - userAge);
                Console.WriteLine(birthYear + " " +  "Is the year you were born");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
