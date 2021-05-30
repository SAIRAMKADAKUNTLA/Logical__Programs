using System;
using System.Collections.Generic;
using System.Text;

namespace Logical__Programs
{
    class Perfect
    {
        
            public void Check()
            {
                int Number, i, Sum = 0;
                Console.WriteLine("Enter the number ");
                Number = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= Number; i++)
                {
                    if (Number % i == 0)
                        Sum += i;
                }
                if (Sum == Number)
                    Console.Write(" It is a perfect number");
                else
                    Console.Write(" It is not a perfect number");
            }
        }
    }


