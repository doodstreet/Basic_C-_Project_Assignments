using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string title = "Constructors and const";
            Console.WriteLine("the name of this asssignment is {0}", title);

            var newPerson = new Person("Dave");
 
            newPerson.NameAge();
            Console.ReadLine();
        }
    }
}
