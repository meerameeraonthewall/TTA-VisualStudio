using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current datetime: " + DateTime.Now);
            Console.WriteLine("Please enter an integer.");
            int hrs = Convert.ToInt16(Console.ReadLine());
            TimeSpan time = new TimeSpan(hrs, 0, 0);

            DateTime newtime = DateTime.Now.Add(time);
            Console.WriteLine("In {0} hours it will be {1}", hrs, newtime);
            Console.Read();
        }
    }
}
