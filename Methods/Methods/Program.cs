using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your number squared is " + Square(number));
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("The factorial of your number is " + Factorial(number));
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("Your number cubed and added to 8 is " + Formula(number));
            Console.Read();
        }

        public static int Square(int number)
        {
            int newVal = number * number;
            return newVal;
        }

        public static int Factorial(int number)
        {
            int newVal = 1;

            while(number >0)
            {
                newVal = newVal * number;
                number--;
            }
            return newVal;
        }

        public static int Formula(int number)
        {
            int newVal = number * number * number + 8;
            return newVal;
        }
    }
}
