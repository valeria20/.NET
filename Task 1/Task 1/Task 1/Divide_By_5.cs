﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Divide_by_5 : Fibonacci
    {
        public int divideByFive()
        {
            int count = 0;
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 5 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
