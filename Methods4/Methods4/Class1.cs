using System;
using System.Collections.Generic;
using System.Text;

namespace Methods4
{
    class Class1
    {

        public static int Func1(int num1, int num2 = 1)
        {
            int newVal = num1 * num1 * num1 * num2;
            return newVal;
        }
    }
}
