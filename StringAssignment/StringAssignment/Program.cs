using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main()
        {
            string part1 = "String ";
            string part2 = "and StringBuilder ";
            string part3 = "Assignment\n";
            string title = part1 + part2 + part3;
            Console.WriteLine(title);

            title = title.ToUpper();
            Console.WriteLine(title);

            StringBuilder sb = new StringBuilder();
            sb.Append("  I found the html course somewhat challenging. ");
            sb.Append("I fond the css course challenging as well. ");
            sb.Append("The Javascript course,\n for me, was very challenging. ");
            sb.Append("GitHub confused me for so long, but I am getting the hang of it I think.");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
