using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I QUIT!!!");
        }
    }
}
