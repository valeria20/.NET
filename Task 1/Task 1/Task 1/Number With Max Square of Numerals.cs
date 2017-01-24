using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Number_With_Max_Square_of_Numerals : Fibonacci
    {
        public void get_Number_With_Max_Square_Of_Numbers()
        {
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);
            for (int i = 0; i < n-1; i++)

            {
                for (int j = i+1; j < n-1; j++)
                {
                    double sumOfSquareRight = 0;
                    double sumOfSquareLeft = 0;
                    ulong temp;

                    string strTypeOfNumberLeft = Convert.ToString(numbers[i]);
                    int size = strTypeOfNumberLeft.Length;
                    char[] charTypeOfNumberLeft = new char[size];
                    charTypeOfNumberLeft[size] = Convert.ToChar(numbers[i]);
                    for (int k = 0; k < size; k++)
                    {
                        
                        sumOfSquareLeft += Math.Pow(Convert.ToDouble(charTypeOfNumberLeft[k]),
                                                    Convert.ToDouble(charTypeOfNumberLeft[k]));

                    }

                    string strTypeOfNumberRight = Convert.ToString(numbers[j]);
                    int _size = strTypeOfNumberRight.Length;
                    char[] charTypeOfNumberRight = new char[size];
                    charTypeOfNumberRight[_size] = Convert.ToChar(numbers[j]);

                    for (int c = 0; c < _size; c++)
                    {
                        
                        sumOfSquareRight += Math.Pow(Convert.ToDouble(charTypeOfNumberRight[c]),
                                                     Convert.ToDouble(charTypeOfNumberRight[c]));
                    }
                    if (sumOfSquareLeft > sumOfSquareRight)
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;

                    }
                                       
                }
            }
            Console.Write("---Number with max sum of square numerals---");
            Console.Write(numbers[0]);
        }
    }
}