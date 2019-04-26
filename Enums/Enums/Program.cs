using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week");
            bool flag = false;


            while(flag != true){

                string today = Console.ReadLine();

                try
                {
                    Days day = (Days)Enum.Parse(typeof(Days), today);
                    Console.WriteLine("Today is " + day + "!");
                    flag = true;
                    Console.Read();
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week. (try capitalizing the word)");
        
                }

            }
        }

        public enum Days{
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
