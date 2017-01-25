using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Descending_Sort_By_Second_Numeral : Fibonacci
    {
        public void descending_sort_by_second_numeral()
        {
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);
            ulong temp;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (numbers[i] > 9)
                    {
                        string strNumTypeLeft = Convert.ToString(numbers[i]);
                        int second_numeralLeft = Convert.ToInt32(strNumTypeLeft.Substring(1, 1));

                        string strNumTypeRight = Convert.ToString(numbers[j]);
                        int second_numeralRight = Convert.ToInt32(strNumTypeLeft.Substring(1, 1));
                        if (second_numeralLeft > second_numeralRight)
                        {
                            temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("---Sorted serial---");

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
