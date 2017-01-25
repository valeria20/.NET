using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Choose__a_number_condition_6 : Fibonacci
    {
        public void searching_Number_Condition_6()
        {
            List<string> two_last_numerals = new List<string>();

            int n = 200;
            Fibonacci f = new Fibonacci();
            ulong[] numbers = new ulong[n + 1];
            numbers = f.getFibonacciNumbers(n);

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    /*trueIndex - index of number divided by 3*/
                    int trueIndex = i;
                    int dividedByFiveHigher = 0;
                    int dividedByFiveLower = 0;
                    /*higher way*/
                    for (int h = trueIndex; h <= trueIndex - 5; h++)
                    {
                        if (numbers[h] % 5 == 0)
                        {
                            dividedByFiveHigher++;
                        }
                    }

                    /*lower way*/
                    for (int l = trueIndex; l >= trueIndex + 5; l++)
                    {
                        if (numbers[l] % 5 == 0)
                        {
                            dividedByFiveLower++;
                        }
                    }

                    /* string strTypeNumber = Convert.ToString(numbers[trueIndex]);

                     string twoLastNumerals = strTypeNumber.Substring(0, strTypeNumber.Length - 2);
                     */
                    if (dividedByFiveHigher > 0 && dividedByFiveLower > 0)
                    {
                        string strTypeNumber = Convert.ToString(numbers[trueIndex]);
                        /*getting two last numerals*/
                        string twoLastNumerals = strTypeNumber.Substring(0, strTypeNumber.Length - 2);
                        two_last_numerals.Add(twoLastNumerals);
                    }
                }
            }

            Console.WriteLine("---List of two last numbers---");
            Console.WriteLine(two_last_numerals);
        }
    }
}
