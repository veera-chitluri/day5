using System;
using System.Collections.Generic;

using System.Linq;


namespace uniqueNumbers
{
    class Program
    {
        public static void Run()
        {

            Console.WriteLine("Enter whatever number you like or 'quit' to exit out and view the results");

            var numbers = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input != null && input.ToLower() == "quit")
                {
                    var uniqueNumbers = (numbers);
                    uniqueNumbers.Sort();
                    uniqueNumbers.ForEach(Console.WriteLine);
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
            }
        }

        private static List<int> GetUniqueNumbersList(IEnumerable<int> numbers)
        {
            return (List<int>)numbers.GroupBy(number => number);








         }
    }
}