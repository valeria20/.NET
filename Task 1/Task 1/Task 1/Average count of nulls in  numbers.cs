using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Average_count_of_nulls_in__numbers : Fibonacci
    {
        public void average_Count_Of_Nulls_in_Numbers()
        {
            double averageCountOfNulls = 0;
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);
            int sumOfNulls = 0;
            int counterOfNulls = 0;
            for (int i = 0; i < n; i++)
            {
                string strTypeOfNumber = Convert.ToString(numbers[i]);

                foreach (var nulls in strTypeOfNumber)
                {
                    if (nulls == '0')
                    {
                        counterOfNulls++;
                    }
                }
              
                sumOfNulls += counterOfNulls;
            }

            averageCountOfNulls = sumOfNulls/n ;
            Console.WriteLine("---Average count of nulls in numbers---");
            Console.WriteLine(averageCountOfNulls); 
        }
    }
}
