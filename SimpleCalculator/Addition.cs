using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SimpleCalculator
{
    internal class Addition
    {
        public void AddNumbers(int num1, int num2)
        {
            Console.WriteLine($"Addition of {num1} and {num2} = {num1 + num2} ");
        }

        public void AddNumbers(float num1, float num2)
        { 
            Console.WriteLine($"Addition of {num1.ToString("F2",CultureInfo.InvariantCulture)} and {num2.ToString("F2", CultureInfo.InvariantCulture)} = {(num1 + num2).ToString("F2", CultureInfo.InvariantCulture)} ");
        }
    }
}
