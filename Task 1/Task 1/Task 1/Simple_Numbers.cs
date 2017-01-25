using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Simple_Numbers : Fibonacci
    {
        public void countOfSimpleNumbers()
        {
            int count = 0;
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);

            for (int i = 0; i < n; i++)
            {
                for (float k = 2; k < Math.Sqrt((float)numbers[i]); k++)
                {
                    if (numbers[i] % k == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("---Number of simple elements---");
            Console.WriteLine(count);
        }
    }
}
