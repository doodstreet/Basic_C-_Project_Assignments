using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();// instantiate class person 
            //person.FirstName = "Dave"; //add values
            //person.LastName = "Street";

            Employee person = new Employee(); // inheriting from class Person
            person.FirstName = "Sample";
            person.LastName = "Student";




            person.SayName();
            Console.ReadLine();
        }
    }
}
