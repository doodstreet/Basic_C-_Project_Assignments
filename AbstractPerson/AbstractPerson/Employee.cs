using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPerson
{
    public class Employee : Person
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public override void SayName()
        {

            string fullName = firstName + " " +  lastName;
            Console.WriteLine("Name: " + fullName);
            return;
        }
    }
}
