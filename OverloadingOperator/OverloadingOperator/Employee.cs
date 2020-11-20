using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperator
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            Employee emp2 = obj as Employee;
            if (object.ReferenceEquals(null, emp2)) return false;
            return Id == emp2.Id;
        }

        public static bool operator == (Employee emp1, Employee emp2)
        {
            if (object.ReferenceEquals(null, emp1))
                return object.ReferenceEquals(null, emp2);
            else if (object.ReferenceEquals(null, emp2))
                return false;
            return emp1.Equals(emp2);
        }

        public static bool operator!= (Employee emp1, Employee emp2)
        {
            if (object.ReferenceEquals(null, emp1))
                return !object.ReferenceEquals(null, emp2);
            else if (object.ReferenceEquals(null, emp2))
                return true;
            return !emp1.Equals(emp2);
        }

        public override int GetHashCode()
        {
            return Id;
        }

    }
}
