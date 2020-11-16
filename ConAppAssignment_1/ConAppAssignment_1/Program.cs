using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_1
{
    class Program
    {
        static void Main(string[] args)
        {   // -----part 1---------
            string[] greeting = new string[] { "Hello ", "Hi ", "Hello zhere ", "Wassup " }; // --- set up a one dimantional array of strings

            Console.WriteLine("Add a word or phrase to my greetings: "); // ask user to input a word or phrase to add to each value in array
            string addWord = Console.ReadLine(); // get value inputted

            for (int g = 0; g < greeting.Length; g++)  //---declare index var as int and create index counter
            { 
                greeting[g] += addWord;  // concatinate addWord and greeting for each iteration and update the array
            }
            foreach (string newGreeting in greeting) // after count is done, iterate thru new strings in array 
            {
                Console.WriteLine(newGreeting); // and writes the newGreeting in the array to the console
            }
            //Console.WriteLine(greeting[2]);  //checking my index concatination
            Console.ReadLine();

            //------part 2 ---------------

            int count = 0; // declare a int counter at 0 outside while loop

            while (true)
            {
                Console.WriteLine("Count = {0}", count); //-- while int conditons are true as declared, write 'Count = value of the count is so far'
                count++; //--------heres the fix to my infinte loop-- counter counts up by 1 each iteration, without atays at 0 and infinte loop--------

                if (count > 11) // while count is less than 11 continue loop
                {
                    break; // if count is not less than 11 stop loop
                }
            }
            Console.ReadLine();

            //------part 3--------------
            int[] nums = { 2, 4, 6, 8, 10 ,16, 21, 67 }; // ---create array of numbers
            for (int n = 0; n < nums.Length; n++) // --- iterate thru array while counter n < array length
            {
                Console.WriteLine(nums[n]);// ---write each number in array
            }
            Console.WriteLine();// skip a line in output for readability
            for (int m = 0; m < nums.Length; m++)//--- iterate thru array 
            {
                if ( nums[m] <= 10) //--- if array number is greater than or equal to 10, stop for loop
                Console.WriteLine(nums[m]); // -- write numbers less than ten 
            }
            Console.WriteLine();
            for (int p = 1; p <= nums.Length - 1; p++) // --- iterate thru array while counter p is less than or equal to array length 
                                                       // -- minus 1 so its within the array length -- better for base 1 apis 
            {
                Console.WriteLine(nums[p]);
            }

            Console.ReadLine();
            //------not the assignment part 3 --- redo before its turned in
            //int num3 = 10;
            //while (num3 <= 13)
            //{
            //    int num4 = 0;  // --------nested while loop ---------
            //    while (num4 <= 3)
            //    {
            //        Console.WriteLine("({0}, {1}) ", num3, num4);
            //        num4++;
            //    }
            //    num3++;
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //------part 4 ----------------
            List<string> names = new List<string>() { "Ben", "Sue", "Bob", "Kim", "Joe", "Ron", "Jim", "Pat" };

            Console.WriteLine("Try to guess a name from my list of three lettered names: Enter guess");
            string guessName = Console.ReadLine();// get input from user

            int index; // --- declare int var
            for (int i = 0; i < names.Count; i++)// for loop with counter int
            {
                if (names[i] == guessName)// apply count to list value index and compare to input from user and if the same do next line
                {
                    index = names.IndexOf(names[i]);// -- returns the first index at which the given element can be found in the array
                    Console.WriteLine("Matches index " + index);// write statement with value of 'index' 
                }
            }
            if (names.Contains(guessName) == false)// outside th for loop,check if name guessed is contained in the array and if false, do next line
            {
                Console.WriteLine("Not on list");
            }                         
            Console.ReadLine();


            //------part 5 ------------------

            List<string> fruit = new List<string>();
            fruit.Add("apple");
            fruit.Add("cherry");
            fruit.Add("peach");
            fruit.Add("cherry");
            fruit.Add("blueberry");
            fruit.Add("banana");

            Console.WriteLine("Enter a friut--try fruits that start with a \"c\"");
            string fruitPick = Console.ReadLine();// user entry

            for (int i = 0; i < fruit.Count; i++) // for loop to iterate thru list length(count) with counter int set
            {
                if (fruit[i] == fruitPick)// -- compare user entry with list items and if the same do next line
                {
                    Console.WriteLine("Found match for " + fruit[i] + " at index " + i);//-- write message with value and index
                }
            }
            if (fruit.Contains(fruitPick) == false) // after for loop finishes, check if list contains user input and if false, do next line
            {
                Console.WriteLine("Not on the list");
            }
            Console.ReadLine();


            //-----part 6 ------------------

            List<string> langsDuplicate = new List<string>() { "java", "python", "css", "html", "java", "c#", "ruby", "java" };
            List<string> langsUnique = new List<string>(); // --list to be added to unique entries only ---
            bool found = false;      // ---declare bool variable---
            foreach (string lang in langsDuplicate)
            {
                found = false; //---  re-intialize bool or flag at top of outer loop so will start again as default false
                // use lang to interate thur langsUnique and add if not there
                foreach (string unique in langsUnique)
                {
                    if (lang == unique)// check if base list iteration is in new list
                    {
                        found = true; // --- duplicate means found changes to true----
                        Console.WriteLine(lang + " --has already been seen");// --- this is a dulicate
                    }
                }
                if (!found)// -- if NOT(!) found, do this
                {
                    langsUnique.Add(lang); // adds lang in langsDuplcate to langsUnique list
                    Console.WriteLine(lang + " --has not already been seen"); // --- this list will end up with only unique values from the base list
                }

            }
            
            Console.ReadLine();
                       
        }
    }
}

        