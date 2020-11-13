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
            Console.WriteLine("Enter your package weight (to the closest pound):");
            int packLbs = Convert.ToInt32(Console.ReadLine());
            string checkLbs = packLbs >= 50 ? "Package too heavy to be shipped via Package Express. Have a good day." :
                                              "\nEnter package width in inches:";
            Console.WriteLine(checkLbs);
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter package height in inches :");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter package length in inches :");
            int packLength = Convert.ToInt32(Console.ReadLine());

            decimal shipPrice = ((packWidth * packLength * packHeight * packLbs) / 100);
            string checkSize = (packWidth + packWidth + packHeight) >= 50 ? "\nPackage too big to ship via Package Express." :
                                                                            "\nYour estimate for shipping this package is: $" + shipPrice;
            Console.WriteLine(checkSize);


            Console.WriteLine("Thank you");
            Console.ReadLine();
        }
    }
}
