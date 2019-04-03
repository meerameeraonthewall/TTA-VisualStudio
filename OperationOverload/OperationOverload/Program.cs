using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee() { firstName = "Sample", lastName = "Subject",  Id = 1};
            Employee obj2 = new Employee() { firstName = "Sample", lastName = "Subject", Id = 2};
            Employee obj3 = new Employee() { firstName = "Sample", lastName = "Subject", Id = 1 };

            Console.WriteLine(obj == obj2);

            Console.WriteLine(obj != obj2);

            Console.WriteLine(obj == obj3);

            Console.WriteLine(obj != obj3);

            Console.Read();
        }
    }
}
