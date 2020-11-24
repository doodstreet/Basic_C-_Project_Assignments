using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Employees
    {
        private string firstName;
        private string lastName;
        private int Id;

        public Employees(string firstName, string lastName, int Id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Id = Id;
        }
        // utility functions for the class
        public string getFName
        {
            get { return firstName; }
        }
        public string getLName
        {
            get { return lastName; }
        }
        public int getID
        {
            get { return Id; }
        }

    }
}
