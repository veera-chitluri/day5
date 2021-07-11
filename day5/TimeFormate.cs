using System;

namespace TimeFormate
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Type in a time value between 00:00 and 23:59");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                var hour = Convert.ToInt32(input?.Split(':')[0]);
                var minute = Convert.ToInt32(input?.Split(':')[1]);

                if (IsValidHour(hour) && IsValidMinute(minute))
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
        }

        private static bool IsValidMinute(int minute)
        {
            throw new NotImplementedException();
        }

        private static bool IsValidHour(int hour)
        {
            throw new NotImplementedException();
        }
    }
   

    
}




