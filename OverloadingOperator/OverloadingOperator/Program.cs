using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, Name = "Dave" };
            Employee emp2 = new Employee { Id = 2, Name = "Gumby" };
            bool equalEmployee = emp1 == emp2;

            Employee emp3 = new Employee { Id = 1, Name = "Dave" };
            equalEmployee = emp1 == emp3;
            Console.WriteLine(equalEmployee);
       

            Console.ReadLine();
        }
    }
}
