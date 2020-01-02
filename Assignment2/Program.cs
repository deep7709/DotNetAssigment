using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            String userName, countryName;
            Boolean flag;
            Console.WriteLine("Please enter your name :");
            userName = Console.ReadLine();
            Console.WriteLine("Where are you from? :");
            countryName = Console.ReadLine();

            if (Regex.IsMatch(userName, @"^[a-zA-Z]+$") && Regex.IsMatch(countryName, @"^[a-zA-Z]+$"))
                flag = true;
            else
                flag = false;
            if (flag)
                Console.WriteLine("Hello " + userName + " form " + countryName);
            else
                Console.WriteLine("Plese enter only characters");
            Console.Read();
        }
    }
}
