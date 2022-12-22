using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            long i, j, n1, n2, sum;


            Console.WriteLine("Enter a number : ");
            n1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter a greater number : ");
            n2 = long.Parse(Console.ReadLine());

            Console.WriteLine("Perfect numbers between " + n1 + " to " + n2);

            for (i = n1; i <= n2; i++)
            {
                sum = 0;

                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
