using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");
            // person one and details
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate");
            decimal payRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Hours Worked Per Week");
            int weeklyHours1 = Convert.ToInt32(Console.ReadLine());

            // person two and details
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Enter Hourly Rate");
            decimal payRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Hours Worked Per Week");
            int weeklyHours2 = Convert.ToInt32(Console.ReadLine());

            //annual salary person 1
            Console.WriteLine("\nAnnual salary of Person 1:");
            decimal salary1 = payRate1 * weeklyHours1 * 52;
            Console.WriteLine(salary1);

            //annual salary person 
            Console.WriteLine("\nAnnual salary of Person 2:");
            decimal salary2 = payRate2 * weeklyHours2 * 52;
            Console.WriteLine(salary2);

            // comparison of salaries
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool isGreater = salary1 > salary2;
            Console.WriteLine(isGreater);


            Console.ReadLine();


        }
    }
}
