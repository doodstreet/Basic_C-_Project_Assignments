using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Pick a greating index number between 0 and 4: ");
        int choice = Convert.ToInt32(Console.ReadLine());
       // bool numPick = (choice < 0 && 4 < choice);

        string[] stringArray = new string[] { "Hi", "Hello", "Hello Zhere", "Bonjour", "What, you talkin to me?" }; 
        if (choice >= 0 && 4 >= choice)
        {
            Console.WriteLine(stringArray[choice]);
            //Console.WriteLine("That index does not exist.");
        }
        else
        {
            //Console.WriteLine(stringArray[choice]);
            Console.WriteLine("That index does not exist.");
        }
        
     
        Console.WriteLine("\nPick an index number of the list of numbers between 0 and 5");
        int choice1 = Convert.ToInt32(Console.ReadLine());
        int[] intArray = new int[] { 3, 5, 7, 9, 11, 13 };
        if (choice1 >= 0 && 5 >= choice1)
        {
            Console.WriteLine(intArray[choice1]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        Console.WriteLine("\nPick an index number of the list of strings between 0 and 4");
        int choice2 = Convert.ToInt32(Console.ReadLine());
        List<string> strList = new List<string>();
        strList.Add("Hello there");
        strList.Add("Hello Zhere");
        strList.Add("How you do");
        strList.Add("Hi yous guys");
        strList.Add("I don't know");
        if (choice2 >= 0 && 4 >= choice2)
        {
            Console.WriteLine(strList[choice2]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        Console.ReadLine();
    }
}

