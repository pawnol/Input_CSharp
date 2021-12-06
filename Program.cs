/* 
 * Input
 * Pawelski
 * 12/5/2021
 * This program shows how to get input from the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double money;
            // This is the prompt for the user.
            Console.Write("Please enter your name >> ");
            // This line gets the name typed in by the user and stores
            // it in name.
            name = Console.ReadLine();
            Console.Write("Please enter your age >> ");
            // Since Console.ReadLine() returns a string, we have to
            // convert it into a number for age.
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter how much money you have >> ");
            // This converts the entered value into a double.
            money = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hello, " + name + "!");
            // The following line is broken up over two to make it fit!
            Console.WriteLine("You are " + (age * 7) + " years " +
                "old in dog years.");
            Console.WriteLine("One day, I hope you will have " +
                "more than $" + money + ".");
        }
    }
}
