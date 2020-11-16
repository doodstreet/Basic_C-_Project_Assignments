using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 5, 6, 8, 22, 13 };
            Console.WriteLine("Enter a number to dived each number in the list by");
            
            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    int quotient = numbers[i] / userNum;
                    Console.WriteLine(quotient);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("And, our try/catch is 'finally' done and continuing on");
                //Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
