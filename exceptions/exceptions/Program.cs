using System;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            int age = Convert.ToInt16(Console.ReadLine());

            try
            {
                int year = 2019 - age;
                if (year > 2019)
                {
                    throw new ArgumentException();
                }
                else if(year ==2019)
                {
                    throw new IndexOutOfRangeException();
                }

                Console.WriteLine("Your birth year is {0}", year);

            }
            catch(ArgumentException)
            {
                Console.WriteLine("Age must be a positive number.");
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You are a baby! You can't be using this program if you are 0 years old. Try again later.");
            }

            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
            }
            Console.Read();
        }
    }
}
