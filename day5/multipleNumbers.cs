using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleNumbers
{
    class Program
    {


        static void Main(string[] args)
        {

            var myList = new List<string>();

            Console.WriteLine("Enter multiple names");
            var names = Console.ReadLine();
            myList = names.Split(" ").ToList();

            if (myList.Count() > 2)
            {
                Console.WriteLine($"{myList[0]},{myList[1]} and others liked your post");
            }
            else if (myList.Count == 2)
            {
                Console.WriteLine($"{myList[0]},{myList[1]} liked your post!");
            }
            else if (myList.Count == 1)
            {
                Console.WriteLine($"{myList[0]} likes your post!");
            }
            else
            {
                Console.WriteLine("No one likes");
            }


        }
    }
}

