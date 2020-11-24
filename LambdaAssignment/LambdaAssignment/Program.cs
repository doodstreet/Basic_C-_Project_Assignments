using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of "type" Employees
            List<Employees> employeeList = new List<Employees>
            {
            new Employees("Joe", "Cuppa", 1),
            new Employees("Dave", "Street", 2),
            new Employees("Sue", "Mehoff", 3),
            new Employees("Fred", "Flit", 4),
            new Employees("Ned", "Pucka", 5),
            //new Employees("Bubba", "Stuart", 6),
            //new Employees("Joe", "Dirt", 7),
            //new Employees("Hank", "Williams", 8),
            //new Employees("Joe", "Joseph", 9),
            //new Employees("Eva", "Street", 10),
            };
            employeeList.Add(new Employees("Bubba", "Stuart", 6));
            employeeList.Add(new Employees("Joe", "Dirt", 7));
            employeeList.Add(new Employees("Hank", "Williams", 8));
            employeeList.Add(new Employees("Joe", "Joseph", 9));
            employeeList.Add(new Employees("Eva", "Street", 10));

            //foreach (var employee in employeeList)
            //    Console.WriteLine("{0}, {1}  Id no:{2}", employee.getLName, employee.getFName, employee.getID);
            //Console.ReadLine();

            List<Employees> joesHere = new List<Employees>();
            foreach (var emp in employeeList)
            {
                if (emp.getFName == "Joe")
                {
                    joesHere.Add(emp);
                }
                
            }
            foreach (var joes in joesHere)
            {
                //Console.WriteLine(joes.getLName + ",  " + joes.getFName);
                Console.WriteLine("{0}, {1} - Id no:{2}", joes.getLName, joes.getFName, joes.getID);
                
            }
            Console.WriteLine("Using foreach loops to make the new list and write new list: hit enter");
            Console.ReadLine();

            //List<Employees> joesHere1 = (from emp1 in employeeList
            //                             where emp1.getFName == "Joe"
            //                             select emp1).ToList();
            //foreach (var joes1 in joesHere1)
            //{
            //    Console.WriteLine("{0}, {1} - Id no:{2}", joes1.getLName, joes1.getFName, joes1.getID);
                
            //};
            //Console.WriteLine("Using LINQ to find and add to new list and foreach loops to write new list: hit enter");
            //Console.ReadLine();

            List<Employees> joesHere2 = (employeeList.Where(emp2 => emp2.getFName == "Joe")).ToList();
            foreach (var joes2 in joesHere2)
            {
                Console.WriteLine("{0}, {1} - Id no:{2}", joes2.getLName, joes2.getFName, joes2.getID);

            };
            Console.WriteLine("Using lambda expression: hit enter for next ");
            Console.ReadLine();

            List<Employees> id = (employeeList.Where(emp3 => emp3.getID > 5)).ToList();
            foreach (var I in id)
            {
                Console.WriteLine("{0} {1} - Id no: {2}", I.getFName, I.getLName, I.getID);
            }
            Console.ReadLine();
        }

    }
}
