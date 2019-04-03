using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Employee : Person, IQuittable
    {

        public int Id;

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I QUIT!!!");
        }

        public static bool operator == (Employee e1, Employee e2)
        {
            return e1.Id == e2.Id;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1.Id == e2.Id);
        }


    }

}
