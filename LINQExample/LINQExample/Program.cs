using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            string[] students = new string[] { "Lacey", "Trish", "Gavin", "Josh", "Jon", "Landon", "Kyndreshia" };

            //Define the query expression
            IEnumerable<string> studentQuery =
                from student in students
                where student.Length >= 5
                select student;

            //Execute the query
            foreach (string s in studentQuery)
            {
                Console.Write(s + " ");
            }
            Console.ReadLine();
        }
    }
}
