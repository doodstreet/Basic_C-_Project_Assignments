using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {

            string fullName = firstName + " " + lastName;
            Console.WriteLine("Name: " + fullName);
            return;
        }
        public void Quit(Employee person)
        {
            Console.WriteLine("I Quit");
            //throw new NotImplementedException();
        }

    }
}
