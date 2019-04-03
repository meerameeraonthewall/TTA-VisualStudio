using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> abc = new Employee<string>() { things= {"apple", "ball", "cowboy", "door", "elephant"} };
            Employee<int> onetwothree = new Employee<int>() { things = { 1, 2, 3, 4, 5 } };

            foreach (object obj in abc.things)
            {
                Console.WriteLine(obj);
                System.Threading.Thread.Sleep(300);
            }
            
            foreach(object obj in onetwothree.things)
            {
                Console.WriteLine(obj);
                System.Threading.Thread.Sleep(300);
            }

            Console.Read();
        }
    }
}
