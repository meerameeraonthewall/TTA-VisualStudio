using System;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            int tryMethod1 = Class1.Function(12);
            Console.WriteLine(tryMethod1);

            int tryMethod2 = Class1.Function(5.5);
            Console.WriteLine(tryMethod2);

            int tryMethod3 = Class1.Function("4");
            Console.WriteLine(tryMethod3);

            Console.Read();

        }
    }
}