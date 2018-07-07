using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();
            var nameArray = name.ToCharArray().Reverse();
            var finalString = string.Join("", nameArray);

            Console.WriteLine("Your name reversed is: " + finalString);

        }
    }
}
