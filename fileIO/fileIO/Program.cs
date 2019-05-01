using System;
using System.IO;

namespace fileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an number.");
            string num = Console.ReadLine();
            //File.WriteAllText(@"log.txt", num);

            using (StreamWriter file = new StreamWriter(@"log.txt", true))
            {
                file.WriteLine(num);
                file.WriteLine("\n");
            }

            string text = File.ReadAllText(@"log.txt");
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
