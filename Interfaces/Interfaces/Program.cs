using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable obj = new Employee() {firstName = "Sample", lastName = "Student"};
            obj.Quit();

            Console.Read();
        }
    }
}
