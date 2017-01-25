using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Sqrt_Of_Numbers_Contain_2 : Fibonacci
    {
        public void get_sqrt_of_numbers_contain_2()
        {
            Console.WriteLine("---Sqrt of elements contain numeral 2---");
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);
            double[] sqrt_values = new double[n];

            for (int i = 0; i < n; i++)
            {
                int index = 0;
                char[] charTypeOfNumber = numbers[i].ToString().ToCharArray();
                foreach (char numeral in charTypeOfNumber)
                {
                    if (numeral == '2')
                    {
                        index = i;
                    }
                }

                double sqrt_value = Math.Sqrt(numbers[index]);
                sqrt_values[i] = sqrt_value;
            }
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine((int)sqrt_values[k]);
            }
        }
    }
}
