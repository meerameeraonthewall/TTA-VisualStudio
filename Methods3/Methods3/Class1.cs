using System;
using System.Collections.Generic;
using System.Text;

namespace Methods3
{
    public class Class1
    {

        public Class1() {

            Value = true;
        }

        public bool Value { get; set; }


        public static int Function(int num1)
        {
            int newVal = num1 * num1 * num1;
            return newVal;
        }

        public static int Function(double num2)
        {
            int newVal = Convert.ToInt16((num2 * num2 * num2) / 3);
            return newVal;
        }

        public static int Function(string num3)
        {
            int number = Convert.ToInt16(num3);

            number = number * number * number * number;

            return number;
        }
    }
}
