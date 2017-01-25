using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Divide_By_Sum_Of_Numerals : Fibonacci
    {
        public void getSumOfNumerals()
        {
            int n = 200;

            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);
            int countOfNumbers = 0;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 10)
                {
                    double sumOfNumerals = 0;

                    string strNumType = Convert.ToString(numbers[i]);
                    //int size_strNumType = 0;
                   int  size_strNumType = strNumType.Length;

                   // char[] charNumType = new char[size_strNumType-1];
                   // charNumType[size_strNumType - 1] = Convert.ToChar(strNumType);
                   //char charNumType= System.Convert.ToChar(strNumType);


                    /*for (int k = 0; i < size_strNumType; k++)
                    {
                        sumOfNumerals = (int)charNumType[k];
                        sumOfNumerals += sumOfNumerals;
                    }*/
                    foreach (char numeral in strNumType)
                    {
                        sumOfNumerals = (int)numeral;
                    }

                    sumOfNumerals += sumOfNumerals;

                    if (numbers[i] % sumOfNumerals == 0)
                    {
                        countOfNumbers++;
                    }

                }
            }

            Console.WriteLine("---Count of numbers divided by sum of numerals---");
            Console.WriteLine(countOfNumbers);
        }
    }
}
