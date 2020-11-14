using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.\n");
            Console.WriteLine("Enter your package weight:");
            int packLbs = Convert.ToInt32(Console.ReadLine());
            //string checkLbs = packLbs >= 50 ? "Package too heavy to be shipped via Package Express. Have a good day." :
            //                                  "\nEnter package width in inches:";
            if (packLbs >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("\nEnter package width in inches :");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter package height in inches :");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter package length in inches :");
                int packLength = Convert.ToInt32(Console.ReadLine());

                if (packWidth + packLength + packHeight >= 50)
                {
                    Console.WriteLine("\nPackage too big to ship via Package Express.");
                }
                else
                {
                    decimal shipPrice = (packWidth * packLength * packHeight);
                    decimal totalPrice = (shipPrice * packLbs) / 100;


                    Console.WriteLine("Your estimated total for shipping this package is: $" + totalPrice);
                }
            }


            Console.WriteLine("Thank you");
            Console.ReadLine();
        }
    }
}
