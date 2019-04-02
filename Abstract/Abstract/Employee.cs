using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
