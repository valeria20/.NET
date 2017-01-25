using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1
{
    class Fibonacci
    {
        /* count of numbers in the seria*/

        public ulong[] getFibonacciNumbers(int n)
        {
            ulong[] fib_numbers = new ulong[n + 1];
            /*0st and 1st numbers of this seria is 0 and 1 always*/
            fib_numbers[0] = 0;
            fib_numbers[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib_numbers[i] = fib_numbers[i - 1] + fib_numbers[i - 2];
            }

            Console.WriteLine("---Fibonacci serial---");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fib_numbers[i]);
            }

            return fib_numbers;
        }
    }
}
