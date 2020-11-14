using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Dave";
            //string quote = "The man said \"Hello\". \n Hello, on a new line. \n\t Hello on a tabbed new line.";
            //string fileName = "c:\\users\\iamdo";
            //string fiName = @"c:\users\iamdo";

            //bool tOrF = name.Contains("v");
            //tOrF = name.EndsWith("e");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(tOrF);
            //Console.ReadLine();


            //string name = "Dave";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Dave");



            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
