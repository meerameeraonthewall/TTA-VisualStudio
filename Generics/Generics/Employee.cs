using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee<T> : Person, IQuittable
    {

        public int Id;
        public List<T> things = new List<T>();

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
