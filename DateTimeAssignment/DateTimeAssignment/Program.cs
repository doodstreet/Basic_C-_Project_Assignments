using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("I am asking user for number of choice.");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime xhoursLater = currentTime.AddHours(inputNum);
            Console.WriteLine(xhoursLater);
            Console.ReadLine();
        }
    }
}
