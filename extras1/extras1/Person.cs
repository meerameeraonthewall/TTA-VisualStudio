using System;
using System.Collections.Generic;
using System.Text;

namespace extras1
{
    public class Person
    {
        public Person(string name) : this(name, 0)
        {
        }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
}
