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
            double sumOfSquare = 0;
            double[] arrayOfSquares = new double[n];
            for (int i = 0; i < n; i++)
            {
                char[] charTypeOfNumber = numbers[i].ToString().ToCharArray();
                
                foreach (char numeral in charTypeOfNumber)
                {
                    double Dnumeral = (double)numeral;
                    sumOfSquare += Math.Pow(Dnumeral, Dnumeral);      
                }
                arrayOfSquares[i] = sumOfSquare;
            }

            double maxElement = arrayOfSquares[0];
            int indexOfMaxElement = 0;
            for (int k = 0; k < n; k++)
            {
                if (arrayOfSquares[k] > maxElement)
                {
                    maxElement = arrayOfSquares[k];
                    indexOfMaxElement = k;
                }
            }

            ulong numberWithMaxSquareOfNum = numbers[indexOfMaxElement];
            Console.WriteLine("---Number with max square of numerals---");
            Console.WriteLine(numberWithMaxSquareOfNum);      
        }
    }
}

