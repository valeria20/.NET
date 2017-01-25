using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Sqrt_Of_Numbers_Contain_2 : Fibonacci
    {
        public List<int> get_sqrt_of_numbers_contain_2()
        {
            List<int> sqrt_values = new List<int>();
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);
            for (int i = 0; i < n; i++)
            {
                string strNumType = Convert.ToString(numbers[i]);
                if (strNumType.Contains("2"))
                {
                    int sqrt_value = (int)Math.Sqrt(numbers[i]);
                    sqrt_values.Add(sqrt_value);
                }
            }

            Console.WriteLine("---Sqrt values of numbers contain numeral 2---");
            Console.WriteLine(Convert.ToString(sqrt_values));
            return sqrt_values;
        }
    }

}
