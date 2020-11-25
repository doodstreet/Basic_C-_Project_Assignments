using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAssignment
{
    public class Person
    { 
        public Person (string name) : this(name, 53)
        {
        }
        public Person(string name, int age)
        {
            PersonAge = age;
            Name = name;
        }
        public int PersonAge { get; set; }
        public string Name { get; set; }

        public void NameAge()
        {
            Console.WriteLine(Name + " " + PersonAge);
            return;
        }
    }
}
