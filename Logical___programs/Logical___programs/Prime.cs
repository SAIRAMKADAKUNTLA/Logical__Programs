using System;
using System.Collections.Generic;
using System.Text;

namespace Logical__Programs
{
    class Prime
    {
        public void Check()
        {
            int Number, i, m;
            Console.WriteLine("Enter the number ");
            Number = Convert.ToInt32(Console.ReadLine());
            m = Number / 2;
            for (i = 2; i <= m; i++)
            {
                if (Number % i == 0)

                    Console.WriteLine("Number is not a Prime");
                else
                    Console.WriteLine("Number is Prime");
            }
        }
    }
}
