using System;


class Program
{
    static void Main(string[] args)
    {
        Function(5, 9);
        Function(num1: 3, num2: 7);
        Console.Read();
    }

    public static void Function(int num1, int num2)
    {
        int result = num1 * 7 + 4;

        Console.WriteLine(num2);
    }
}
