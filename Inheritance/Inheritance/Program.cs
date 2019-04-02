using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.FirstName = "Sample";
            obj.LastName = "Student";
            obj.Id = 1;
            obj.SayName();
            Console.Read();
        
            
        }
    }
}
