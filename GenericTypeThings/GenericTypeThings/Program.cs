using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Hello", "Hi there", "Hello Zhere" };

            foreach (string items in employee.Things)
                Console.WriteLine(items);

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 012, 123, 234 };

            foreach (int items in employee1.Things)
                Console.WriteLine(items);


            Console.ReadLine();
        }
    }
}
