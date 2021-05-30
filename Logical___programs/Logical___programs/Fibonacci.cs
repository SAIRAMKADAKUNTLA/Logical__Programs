using System;
using System.Collections.Generic;
using System.Text;

namespace Logical__Programs
{
    class Fibonacci
    {
        public void Check()
        {
            int FirstN = 0, SecondN = 1, ThirdN, i, Number;
            Console.WriteLine("Enter the number of Elements");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstN + " " + " " + SecondN);
            for (i = 2; i <= Number; i++)
            {
                ThirdN = FirstN + SecondN;
                Console.WriteLine(ThirdN + " ");
                FirstN = SecondN;
                SecondN = ThirdN;
            }
        }
    }
}
