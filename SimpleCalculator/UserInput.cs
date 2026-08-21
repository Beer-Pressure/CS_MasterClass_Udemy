using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SimpleCalculator
{
    internal class UserInput
    {
        public int GetNumber()
        {
            Console.WriteLine("Enter a whole number:");
            return int.Parse(Console.ReadLine());
        }

        public float GetFloatNumber()
        {
            Console.WriteLine("Enter a number:");
            return float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }
    }
}
