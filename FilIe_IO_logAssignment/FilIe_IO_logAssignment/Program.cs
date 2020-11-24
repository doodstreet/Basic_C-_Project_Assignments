using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilIe_IO_logAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some more text.";
            //File.WriteAllText(@"C:\Users\Iamdo\Logs\logs.txt", text);
            
            //string text1 = File.ReadAllText(@"C:\Users\Iamdo\Logs\logs.txt");
            //Console.WriteLine(text1);
            //Console.ReadLine();

            Console.WriteLine("Enter a number to be logged to a text file, then read and written back to the console, please.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            string n = String.Format("Your number is: {0}", userNum);
            File.WriteAllText(@"C:\Users\Iamdo\Logs\logs.txt", n);
            string nReturn = File.ReadAllText(@"C:\Users\Iamdo\Logs\logs.txt");
            Console.WriteLine(nReturn);
            Console.ReadLine();       
        }
    }
}
