using System;
using System.Collections.Generic;
using System.Text;

namespace Logical__Programs
{
    class Reverse
    {
        public void check()
        {
            int Reverse = 0, Number, Remainder;
            Console.WriteLine("Enter the number ");
            Number = Convert.ToInt32(Console.ReadLine());
            while (Number != 0)
            {
                Remainder = Number % 10;
                Reverse = Reverse * 10 + Remainder;
                Number /= 10;
            }
            Console.Write("Reversed Number: " + Reverse);
        }
    }

}
