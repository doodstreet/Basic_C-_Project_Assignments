using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            IQuittable quittable = new Employee();

            person.firstName = "Sample ";
            person.lastName = "Student ";

            person.SayName();
            quittable.Quit(person);
            Console.ReadLine();
        }
    }
}
