using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.firstName = "Sample";
            obj.lastName = "Student";
            obj.SayName();
            Console.Read();
        }
    }
}
